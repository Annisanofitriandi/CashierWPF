using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CRUDBC.Model;
using CRUDBC.NewFolder1;
using Outlook = Microsoft.Office.Interop.Outlook;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.ComponentModel;
using System.Drawing;


namespace CRUDBC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //bool isAdd = false;
        MyContext myContext = new MyContext();
        //private BindingListCollectionView SupplierView;
        int supplierid, rolesId;
        int transid;
        int itemid;
        int lasttot;
        int totalharga;
        int pay;
        int startprice = 0;
        List<TransaksiItem> cart = new List<TransaksiItem>();
        string report = " Faktur \t " + "Name \t " + "Quantity \t " + "Price \n";
        public MainWindow()

        {
            InitializeComponent();
            //showData();
            BtnDeleteS.IsEnabled = false;
            BtnUpdate.IsEnabled = false;
            BtnDelete.IsEnabled = false;
            BtnEdit.IsEnabled = false;
            //this.SupplierView = (BindingListCollectionView)(CollectionViewSource.GetDefaultView(myContext));
            ComboItem.ItemsSource = myContext.Items.ToList();
            TxtDate.Text = DateTimeOffset.Now.DateTime.ToString();
            ComboSupp.ItemsSource = myContext.Suppliers.ToList();
            GridSupplier.ItemsSource = myContext.Suppliers.ToList();
            GridItem.ItemsSource = myContext.Items.ToList();
            GridUser.ItemsSource = myContext.Users.ToList();
            var push = new Transaksi(); // add id transaksi
            myContext.Transaksi.Add(push); // add id transaksi
            myContext.SaveChanges();  // add id transaksi
            TxtIdTransaksi.Text = Convert.ToString(push.IdTransaksi);  // add id transaksi
            ComboUser.ItemsSource = myContext.Roles.ToList();

        }

        #region Supplier
        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (TxtName.Text == "")
            {
                MessageBox.Show("Name is Required", "Caution", MessageBoxButton.OK);
                TxtName.Focus();
            }
            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("Email is Required", "Caution", MessageBoxButton.OK);
                TxtEmail.Focus();
            }
            else
            {
                var Cekemail = myContext.Suppliers.FirstOrDefault(s => s.Email == TxtEmail.Text);
                if (Cekemail == null)
                {
                    var push = new Supplier(TxtName.Text, TxtEmail.Text);
                    myContext.Suppliers.Add(push);
                    var result = myContext.SaveChanges();
                    if (result > 0)
                    {
                        MessageBox.Show(result + " row has been inserted.");

                    }
                    GridSupplier.ItemsSource = myContext.Suppliers.ToList();
                    ComboSupp.ItemsSource = myContext.Suppliers.ToList();
                    try
                    {
                        //Outlook._Application _app = new Outlook.Application();
                        //Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                        //mail.To = TxtEmail.Text;
                        //mail.Body = TxtName + " Data anda sudah masuk ke database";
                        //mail.Importance = Outlook.OlImportance.olImportanceNormal;
                        //((Outlook._MailItem)mail).Send();
                        //MessageBox.Show("Your email has been send", "Message", MessageBoxButton.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK);
                    }

                }
                else
                {
                    MessageBox.Show("This email has been used!");
                }
            }
        }
        //public void showData()
        //{
        //    GridSupplier.ItemsSource = myContext.Suppliers.ToList();
        //    GridItem.ItemsSource = myContext.Items.ToList();
        //}

        private void GridSupplier_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object data = GridSupplier.SelectedItem;
                TxtId.Text = (GridSupplier.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
                TxtName.Text = (GridSupplier.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
                TxtEmail.Text = (GridSupplier.SelectedCells[2].Column.GetCellContent(data) as TextBlock).Text;
                BtnSubmit.IsEnabled = true;
                BtnUpdate.IsEnabled = true;
                BtnDeleteS.IsEnabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Data berhasil dihapus");
            }
        }

        private void TxtEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z0-9.@]+$");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnDeleteS_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this supplier?", "Delete", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
                {
                    int num = Convert.ToInt32(TxtId.Text);
                    var dRow = myContext.Suppliers.Where(s => s.Id == num).FirstOrDefault();
                    myContext.Suppliers.Remove(dRow);
                    myContext.SaveChanges();
                    GridSupplier.ItemsSource = myContext.Suppliers.ToList();

                    MessageBox.Show("Data berhasil dihapus");


                }
            }
            catch (Exception)
            {

            }
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(TxtId.Text);
            var uRow = myContext.Suppliers.FirstOrDefault(s => s.Id == num);
            uRow.Name = TxtName.Text;
            uRow.Email = TxtEmail.Text;
            myContext.SaveChanges();
            GridSupplier.ItemsSource = myContext.Suppliers.ToList();

        }
        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            TxtId.Text = "";
            TxtName.Text = "";
            TxtEmail.Text = "";
        }

        private void TxtId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        #endregion Supplier
        #region Item
        private void TxtItemId_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtItemId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtNameItem_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z!]");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TxtNameItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void TxtPrice_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void TxtPrice_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtStock_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtStock_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GridItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object data = GridItem.SelectedItem;
                TxtItemId.Text = (GridItem.SelectedCells[0].Column.GetCellContent(data) as TextBlock).Text;
                TxtNameItem.Text = (GridItem.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
                TxtStock.Text = (GridItem.SelectedCells[2].Column.GetCellContent(data) as TextBlock).Text;
                TxtPrice.Text = (GridItem.SelectedCells[3].Column.GetCellContent(data) as TextBlock).Text;
                string supplier = (GridItem.SelectedCells[4].Column.GetCellContent(data) as TextBlock).Text;
                BtnSave.IsEnabled = true;
                BtnEdit.IsEnabled = true;
                BtnDelete.IsEnabled = true;
                ComboSupp.Text = supplier;


            }
            catch (Exception)
            {

            }
        }


        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((TxtNameItem.Text == "") || (TxtStock.Text == "") || (TxtPrice.Text == ""))
                {
                    if (TxtNameItem.Text == "")
                    {
                        MessageBox.Show("Name Item Is Required", "Caution", MessageBoxButton.OK);
                        TxtNameItem.Focus();
                    }
                    else if (TxtStock.Text == "")
                    {
                        MessageBox.Show("Stock Item Is Required", "Caution", MessageBoxButton.OK);
                        TxtStock.Focus();
                    }
                    else if (TxtPrice.Text == "")
                    {
                        MessageBox.Show("Price Item  is Required", "Caution", MessageBoxButton.OK);
                        TxtPrice.Focus();
                    }
                }
                else
                {
                    if (TxtNameItem.Text != null)
                    {
                        int Stock = Convert.ToInt32(TxtStock.Text);
                        int Price = Convert.ToInt32(TxtPrice.Text);

                        var supplier = myContext.Suppliers.Where(w => w.Id == supplierid).FirstOrDefault();
                        var itemname = myContext.Items.Where(i => i.Name == TxtNameItem.Text).FirstOrDefault();
                        //var priceitem = myContext.Items.Where(i => i.Price == TxtPriceItem.Text).FirstOrDefault();

                        if (itemname != null)
                        {
                            var stockrecent = itemname.Stock;
                            var pricerecent = itemname.Price;
                            var supplierrecent = itemname.Supplier.ToString();


                            if (TxtPrice.Text == pricerecent.ToString())
                            {
                                int updStock = Stock + stockrecent;
                                itemname.Stock = Convert.ToInt32(updStock);
                                var result2 = myContext.SaveChanges();

                                if (result2 > 0)
                                {
                                    MessageBox.Show("Stock Has Been Updated");
                                }
                                else
                                {
                                    MessageBox.Show("Stock Cant be Updated");

                                }
                                GridItem.ItemsSource = myContext.Items.ToList();

                            }

                            else
                            {
                                int Stock2 = Convert.ToInt32(TxtStock.Text);
                                int Price2 = Convert.ToInt32(TxtPrice.Text);

                                var supplier2 = myContext.Suppliers.Where(w => w.Id == supplierid).FirstOrDefault();
                                var pushStock = new Item(TxtNameItem.Text, Stock2, Price2, supplier2);
                                myContext.Items.Add(pushStock);
                                var result = myContext.SaveChanges();
                                if (result > 0)
                                {
                                    MessageBox.Show("New Item has been inserted");
                                }
                                else
                                {
                                    MessageBox.Show("New item cant be inserted");
                                }
                                GridItem.ItemsSource = myContext.Items.ToList();
                            }
                        }

                        else
                        {
                            int Stock2 = Convert.ToInt32(TxtStock.Text);
                            int Price2 = Convert.ToInt32(TxtPrice.Text);

                            var supplier2 = myContext.Suppliers.Where(w => w.Id == supplierid).FirstOrDefault();
                            var pushStock = new Item(TxtNameItem.Text, Stock2, Price2, supplier2);
                            myContext.Items.Add(pushStock);
                            var result = myContext.SaveChanges();
                            if (result > 0)
                            {
                                MessageBox.Show("New Item has been inserted");
                            }
                            else
                            {
                                MessageBox.Show("New item cant be inserted");
                            }
                            GridItem.ItemsSource = myContext.Items.ToList();
                        }
                    }


                }
                ComboItem.ItemsSource = myContext.Items.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK);
            }
        }


        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(TxtItemId.Text);
                var uRow = myContext.Items.FirstOrDefault(s => s.ItemId == num);
                uRow.Name = TxtNameItem.Text;
                uRow.Stock = Convert.ToInt32(TxtStock.Text);
                uRow.Price = Convert.ToInt32(TxtPrice.Text);
                uRow.Supplier = myContext.Suppliers.FirstOrDefault(i => i.Id == supplierid);
                myContext.SaveChanges();
                GridItem.ItemsSource = myContext.Items.ToList();
            }
            catch
            {
                MessageBox.Show("Item Has Been Updated");
            }
        }
        private void ComboSupp_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            supplierid = Convert.ToInt32(ComboSupp.SelectedValue.ToString());

        }

        private void BtnSubmit_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete this Item?", "Delete", MessageBoxButton.YesNoCancel) == MessageBoxResult.Yes)
                {
                    int num = Convert.ToInt32(TxtItemId.Text);
                    var iRow = myContext.Items.Where(i => i.ItemId == num).FirstOrDefault();
                    myContext.Items.Remove(iRow);
                    myContext.SaveChanges();
                    GridItem.ItemsSource = myContext.Items.ToList();
                    TxtItemId.Text = "";
                    TxtNameItem.Text = "";
                    TxtStock.Text = "";
                    TxtPrice.Text = "";
                    ComboSupp.Text = "";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Data Item berhasil dihapus");
            }
        }

        private void NameItem_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }


        private void TxtNameItem_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        #endregion Item

        #region Transaksi
        private void ComboItem_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            itemid = Convert.ToInt32(ComboItem.SelectedValue.ToString());
            var nameitem = myContext.Items.FirstOrDefault(i => i.ItemId == itemid);
            TxtPriceItem.Text = nameitem.Price.ToString();
            TxtStockItem.Text = nameitem.Stock.ToString();


        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void TxtIdTransaksi_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtIdTransaksi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtItem_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtItem_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtNameItem_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtNameItem_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtPriceItem_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtPriceItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }


        private void TxtQty_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void TxtQty_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void GridTransaksi_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtDate_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtDate_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnTbh_Click(object sender, RoutedEventArgs e)
        {

            string iditem = itemid.ToString();
            int prc = Convert.ToInt32(TxtPriceItem.Text);
            int qty = Convert.ToInt32(TxtQty.Text);
            int stock = Convert.ToInt32(TxtStockItem.Text);
            int tot = prc * qty;
            int updstock = stock - qty;


            lasttot += tot;
            TxtTotpay.Text = lasttot.ToString();
            transid = Convert.ToInt32(TxtIdTransaksi.Text);
            var trans = myContext.Transaksi.Where(t => t.IdTransaksi == transid).FirstOrDefault();
            var item = myContext.Items.Where(i => i.ItemId == itemid).FirstOrDefault();

            item.Stock = updstock;
            myContext.SaveChanges();
            //showData();
            cart.Add(new TransaksiItem { Transaksi = trans, Item = item, Quantity = qty, SubTotal = tot });
            GridTransaksi.Items.Add(new { ItemId = iditem, Name = ComboItem.Text, Price = TxtPriceItem.Text, Quantity = TxtQty.Text, Total = tot.ToString() });
        }

        private void TxtPayment_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                totalharga = Convert.ToInt32(TxtTotpay.Text);
                pay = Convert.ToInt32(TxtPayment.Text);
                TxtChange.Text = "Rp. " + (pay - totalharga).ToString("n0");
            }
            catch (Exception)
            {

            }
        }
        private void BtnKrg_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelItem_Click(object sender, RoutedEventArgs e)
        {
            var data = GridTransaksi.SelectedItem;
            string itemcart = (GridTransaksi.SelectedCells[1].Column.GetCellContent(data) as TextBlock).Text;
            string qtycart = (GridTransaksi.SelectedCells[3].Column.GetCellContent(data) as TextBlock).Text;
            string totalcart = (GridTransaksi.SelectedCells[4].Column.GetCellContent(data) as TextBlock).Text;
            int total = Convert.ToInt32(TxtTotpay.Text);

            if (GridTransaksi.SelectedItem != null)
            {
                int maxstock = Convert.ToInt32(TxtStockItem.Text);
                int stockcart = Convert.ToInt32(qtycart);
                int pricecart = Convert.ToInt32(totalcart);

                var item = myContext.Items.Where(i => i.Name == itemcart).FirstOrDefault();

                int stocknow = item.Stock;
                int realstock = Convert.ToInt32(qtycart) + stocknow;
                int realtotal = total - pricecart;

                item.Stock = realstock;
                myContext.SaveChanges();

                TxtStockItem.Text = realstock.ToString();
                TxtTotpay.Text = realtotal.ToString();
                GridTransaksi.Items.RemoveAt(GridTransaksi.SelectedIndex);
                GridItem.ItemsSource = myContext.Items.ToList();
            }
            else
            {
                TxtTotpay.Text = startprice.ToString();
            }
        }






        private void BtnRefreshItem_Click(object sender, RoutedEventArgs e)
        {
            TxtItemId.Text = "";
            TxtNameItem.Text = "";
            TxtStock.Text = "";
            TxtPrice.Text = "";
        }

        private void TxtStockItem_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtTotpay_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSv_Click(object sender, RoutedEventArgs e)
        {
            totalharga = Convert.ToInt32(TxtTotpay.Text);
            pay = Convert.ToInt32(TxtPayment.Text);
            if (TxtPayment.Text == "")
            {
                MessageBox.Show("Payment is Required!", "Caution");
            }
            else if (totalharga <= pay)
            {
                int transId = Convert.ToInt32(TxtIdTransaksi.Text);
                //var item = myContext.TransaksiItems.FirstOrDefault(i => i.IdTransaksiItem == transId);
                var trans = myContext.Transaksi.FirstOrDefault(t => t.IdTransaksi == transId);
                int totprice = Convert.ToInt32(TxtTotpay.Text);
                //trans.Total = totprice;
                foreach (var transitem in cart)
                {
                    myContext.TransaksiItems.Add(transitem);
                    myContext.SaveChanges();
                    report += transitem.Item.ItemId + "\t" + transitem.Item.Name + "\t" + transitem.Quantity;


                }
                TxtIdTransaksi.Text = "";
                MessageBox.Show("Your change is : Rp. " + (pay - totalharga).ToString("n0") + "\nThank You!", "Notification", MessageBoxButton.OK);
                trans.Total = totprice;
                myContext.SaveChanges();
                Clear();
                using (PdfDocument document = new PdfDocument())
                {
                    //Add a page to the document
                    PdfPage page = document.Pages.Add();

                    //Create PDF graphics for the page
                    PdfGraphics graphics = page.Graphics;

                    //Set the standard font
                    PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 20);

                    //Draw the text
                    graphics.DrawString(report, font, PdfBrushes.Black, new PointF(0, 0));

                    //Save the document
                    document.Save("Output.pdf");

                    #region View the Workbook
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the PDF?", "PDF has been created",
                        MessageBoxButton.YesNo, MessageBoxImage.Information) == MessageBoxResult.Yes)
                    {
                        try
                        {
                            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                            System.Diagnostics.Process.Start("Output.pdf");

                            //Exit
                            Close();
                        }
                        catch (Win32Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else
                        Close();
                    #endregion
                }
            }
            else
            {
                MessageBox.Show("Your payment id invalid!", "Caution", MessageBoxButton.OK);
            }
        }

        private void BtnUpd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDlt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtStockItem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void Clear()
        {
            GridTransaksi.Items.Clear();
            TxtPriceItem.Text = "";
            TxtStockItem.Text = "";
            TxtQty.Text = "";
            TxtTotpay.Text = "";
            TxtPayment.Text = "";
            TxtChange.Text = "";

        }

        private void TxtPayment_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TxtChange_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnCnl_Click(object sender, RoutedEventArgs e)
        {
            Clear();
            cart.Clear();
        }

        private void TxtPayment_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }



        private void ComboUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            rolesId = Convert.ToInt32(ComboUser.SelectedValue.ToString());
        }

        private void TxtUsName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }

        private void TxtUsEmail_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {

        }







        #endregion Transaksi

        #region Register

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {

            if (TxtUsName.Text == "")
            {
                MessageBox.Show("User Name cannot be empty!", "Caution", MessageBoxButton.OK);
                TxtUsName.Focus();
            }
            else if (TxtUsEmail.Text == "")
            {
                MessageBox.Show("Email cannot be empty!", "Caution", MessageBoxButton.OK);
                TxtUsEmail.Focus();
            }
            else if (ComboUser.Text == "")
            {
                MessageBox.Show("Select a Role!", "Caution", MessageBoxButton.OK);
                ComboUser.Focus();
            }
            else
            {
                var checkEmail = myContext.Users.Where(u => u.Email == TxtUsEmail.Text).FirstOrDefault(); // mencari email yg ada
                var pass = Guid.NewGuid().ToString();
                var role = myContext.Roles.Where(r => r.IdRole == rolesId).FirstOrDefault();
                if (checkEmail == null)
                {
                    var push = new User(TxtUsName.Text, TxtUsEmail.Text, pass, role);
                    myContext.Users.Add(push);
                    var result = myContext.SaveChanges();
                    GridUser.ItemsSource = myContext.Users.ToList();
                    if (result > 0)
                    {
                        MessageBox.Show(result + " you have been registered !");
                        try
                        {
                            Outlook._Application _app = new Outlook.Application();
                            Outlook.MailItem mail = (Outlook.MailItem)_app.CreateItem(Outlook.OlItemType.olMailItem);
                            //sesuaikan dengan content yang di xaml
                            mail.To = TxtUsEmail.Text;
                            mail.Subject = "Register from Annisa";
                            mail.Body = "email has delivered !";
                            mail.Importance = Outlook.OlImportance.olImportanceNormal;
                            ((Outlook._MailItem)mail).Send();
                            MessageBox.Show("message has been sent.", "message", MessageBoxButton.OK);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Message", MessageBoxButton.OK);
                        }
                    }
                    GridUser.ItemsSource = myContext.Users.ToList();

                }
            }
        }



        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            TxtUsName.Text = "";
            TxtUsEmail.Text = "";

        }




        #endregion Register

        #region Role

        private void TxtRoleName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^A-Za-z!]");
            e.Handled = regex.IsMatch(e.Text);
        }
#endregion
        private void GridRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TxtRoleName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnSvRole_Click(object sender, RoutedEventArgs e)
        {

           
         
        }
    }
}