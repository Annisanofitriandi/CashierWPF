#pragma checksum "..\..\ForgotPsw.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "8E922CD71B06DDC6C577EBBAB2A58857"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CRUDBC;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CRUDBC
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    {

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CRUDBC;component/forgotpsw.xaml", System.UriKind.Relative);

#line 1 "..\..\ForgotPsw.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.lblUsname = ((System.Windows.Controls.Label)(target));
                    return;
                case 2:
                    this.lblEmail = ((System.Windows.Controls.Label)(target));
                    return;
                case 3:
                    this.lblRole = ((System.Windows.Controls.Label)(target));
                    return;
                case 4:
                    this.TxtUsName = ((System.Windows.Controls.TextBox)(target));

#line 22 "..\..\ForgotPsw.xaml"
                    this.TxtUsName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtUsName_PreviewTextInput);

#line default
#line hidden
                    return;
                case 5:
                    this.TxtUsEmail = ((System.Windows.Controls.TextBox)(target));

#line 23 "..\..\ForgotPsw.xaml"
                    this.TxtUsEmail.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtUsEmail_PreviewTextInput);

#line default
#line hidden
                    return;
                case 6:
                    this.ComboUser = ((System.Windows.Controls.ComboBox)(target));

#line 24 "..\..\ForgotPsw.xaml"
                    this.ComboUser.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboUser_SelectionChanged);

#line default
#line hidden
                    return;
                case 7:
                    this.BtnRegister = ((System.Windows.Controls.Button)(target));

#line 25 "..\..\ForgotPsw.xaml"
                    this.BtnRegister.Click += new System.Windows.RoutedEventHandler(this.BtnRegister_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.BtnCancel = ((System.Windows.Controls.Button)(target));

#line 26 "..\..\ForgotPsw.xaml"
                    this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.GridUser = ((System.Windows.Controls.DataGrid)(target));
                    return;
                case 10:
                    this.lblId = ((System.Windows.Controls.Label)(target));
                    return;
                case 11:
                    this.lblRoleName = ((System.Windows.Controls.Label)(target));
                    return;
                case 12:
                    this.lblHeader = ((System.Windows.Controls.Label)(target));
                    return;
                case 13:
                    this.TxtIdRole = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 14:
                    this.TxtRoleName = ((System.Windows.Controls.TextBox)(target));

#line 44 "..\..\ForgotPsw.xaml"
                    this.TxtRoleName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtRoleName_PreviewTextInput);

#line default
#line hidden

#line 44 "..\..\ForgotPsw.xaml"
                    this.TxtRoleName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtRoleName_TextChanged);

#line default
#line hidden
                    return;
                case 15:
                    this.BtnSvRole = ((System.Windows.Controls.Button)(target));

#line 45 "..\..\ForgotPsw.xaml"
                    this.BtnSvRole.Click += new System.Windows.RoutedEventHandler(this.BtnSvRole_Click);

#line default
#line hidden
                    return;
                case 16:
                    this.GridRole = ((System.Windows.Controls.DataGrid)(target));

#line 46 "..\..\ForgotPsw.xaml"
                    this.GridRole.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridRole_SelectionChanged);

#line default
#line hidden
                    return;
                case 17:
                    this.label = ((System.Windows.Controls.Label)(target));
                    return;
                case 18:
                    this.TxtId = ((System.Windows.Controls.TextBox)(target));

#line 57 "..\..\ForgotPsw.xaml"
                    this.TxtId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtId_TextChanged);

#line default
#line hidden
                    return;
                case 19:
                    this.label1 = ((System.Windows.Controls.Label)(target));
                    return;
                case 20:
                    this.TxtName = ((System.Windows.Controls.TextBox)(target));

#line 59 "..\..\ForgotPsw.xaml"
                    this.TxtName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtName_TextChanged);

#line default
#line hidden
                    return;
                case 21:
                    this.label2 = ((System.Windows.Controls.Label)(target));
                    return;
                case 22:
                    this.TxtEmail = ((System.Windows.Controls.TextBox)(target));

#line 61 "..\..\ForgotPsw.xaml"
                    this.TxtEmail.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtEmail_PreviewTextInput);

#line default
#line hidden

#line 61 "..\..\ForgotPsw.xaml"
                    this.TxtEmail.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtEmail_TextChanged);

#line default
#line hidden
                    return;
                case 23:
                    this.GridSupplier = ((System.Windows.Controls.DataGrid)(target));

#line 62 "..\..\ForgotPsw.xaml"
                    this.GridSupplier.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridSupplier_SelectionChanged);

#line default
#line hidden
                    return;
                case 24:
                    this.BtnSubmit = ((System.Windows.Controls.Button)(target));

#line 70 "..\..\ForgotPsw.xaml"
                    this.BtnSubmit.Click += new System.Windows.RoutedEventHandler(this.BtnSubmit_Click);

#line default
#line hidden
                    return;
                case 25:
                    this.BtnUpdate = ((System.Windows.Controls.Button)(target));

#line 71 "..\..\ForgotPsw.xaml"
                    this.BtnUpdate.Click += new System.Windows.RoutedEventHandler(this.BtnUpdate_Click);

#line default
#line hidden
                    return;
                case 26:
                    this.BtnDeleteS = ((System.Windows.Controls.Button)(target));

#line 72 "..\..\ForgotPsw.xaml"
                    this.BtnDeleteS.Click += new System.Windows.RoutedEventHandler(this.BtnDeleteS_Click);

#line default
#line hidden
                    return;
                case 27:
                    this.BtnRefresh = ((System.Windows.Controls.Button)(target));

#line 73 "..\..\ForgotPsw.xaml"
                    this.BtnRefresh.Click += new System.Windows.RoutedEventHandler(this.BtnRefresh_Click);

#line default
#line hidden
                    return;
                case 28:
                    this.ID = ((System.Windows.Controls.Label)(target));
                    return;
                case 29:
                    this.TxtItemId = ((System.Windows.Controls.TextBox)(target));

#line 83 "..\..\ForgotPsw.xaml"
                    this.TxtItemId.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtItemId_PreviewTextInput);

#line default
#line hidden

#line 83 "..\..\ForgotPsw.xaml"
                    this.TxtItemId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtItemId_TextChanged);

#line default
#line hidden
                    return;
                case 30:
                    this.NameItem = ((System.Windows.Controls.Label)(target));
                    return;
                case 31:
                    this.TxtNameItem = ((System.Windows.Controls.TextBox)(target));

#line 85 "..\..\ForgotPsw.xaml"
                    this.TxtNameItem.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtNameItem_PreviewTextInput);

#line default
#line hidden

#line 85 "..\..\ForgotPsw.xaml"
                    this.TxtNameItem.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtNameItem_TextChanged);

#line default
#line hidden
                    return;
                case 32:
                    this.Stock = ((System.Windows.Controls.Label)(target));
                    return;
                case 33:
                    this.TxtStock = ((System.Windows.Controls.TextBox)(target));

#line 87 "..\..\ForgotPsw.xaml"
                    this.TxtStock.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtStock_PreviewTextInput);

#line default
#line hidden

#line 87 "..\..\ForgotPsw.xaml"
                    this.TxtStock.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtStock_TextChanged);

#line default
#line hidden
                    return;
                case 34:
                    this.Price = ((System.Windows.Controls.Label)(target));
                    return;
                case 35:
                    this.TxtPrice = ((System.Windows.Controls.TextBox)(target));

#line 89 "..\..\ForgotPsw.xaml"
                    this.TxtPrice.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtPrice_PreviewTextInput);

#line default
#line hidden

#line 89 "..\..\ForgotPsw.xaml"
                    this.TxtPrice.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPrice_TextChanged);

#line default
#line hidden
                    return;
                case 36:
                    this.Supplier = ((System.Windows.Controls.Label)(target));
                    return;
                case 37:
                    this.ComboSupp = ((System.Windows.Controls.ComboBox)(target));

#line 91 "..\..\ForgotPsw.xaml"
                    this.ComboSupp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboSupp_SelectionChanged);

#line default
#line hidden
                    return;
                case 38:
                    this.GridItem = ((System.Windows.Controls.DataGrid)(target));

#line 92 "..\..\ForgotPsw.xaml"
                    this.GridItem.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridItem_SelectionChanged);

#line default
#line hidden
                    return;
                case 39:
                    this.BtnSave = ((System.Windows.Controls.Button)(target));

#line 101 "..\..\ForgotPsw.xaml"
                    this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_Click);

#line default
#line hidden
                    return;
                case 40:
                    this.BtnEdit = ((System.Windows.Controls.Button)(target));

#line 102 "..\..\ForgotPsw.xaml"
                    this.BtnEdit.Click += new System.Windows.RoutedEventHandler(this.BtnEdit_Click);

#line default
#line hidden
                    return;
                case 41:
                    this.BtnDelete = ((System.Windows.Controls.Button)(target));

#line 103 "..\..\ForgotPsw.xaml"
                    this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_Click);

#line default
#line hidden
                    return;
                case 42:
                    this.BtnRefreshItem = ((System.Windows.Controls.Button)(target));

#line 104 "..\..\ForgotPsw.xaml"
                    this.BtnRefreshItem.Click += new System.Windows.RoutedEventHandler(this.BtnRefreshItem_Click);

#line default
#line hidden
                    return;
                case 43:
                    this.Transaksi = ((System.Windows.Controls.Label)(target));
                    return;
                case 44:
                    this.Id = ((System.Windows.Controls.Label)(target));
                    return;
                case 45:
                    this.TxtIdTransaksi = ((System.Windows.Controls.TextBox)(target));

#line 116 "..\..\ForgotPsw.xaml"
                    this.TxtIdTransaksi.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtIdTransaksi_PreviewTextInput);

#line default
#line hidden

#line 116 "..\..\ForgotPsw.xaml"
                    this.TxtIdTransaksi.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtIdTransaksi_TextChanged);

#line default
#line hidden
                    return;
                case 46:
                    this.Date = ((System.Windows.Controls.Label)(target));
                    return;
                case 47:
                    this.TxtDate = ((System.Windows.Controls.TextBox)(target));

#line 118 "..\..\ForgotPsw.xaml"
                    this.TxtDate.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtDate_PreviewTextInput);

#line default
#line hidden

#line 118 "..\..\ForgotPsw.xaml"
                    this.TxtDate.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtDate_TextChanged);

#line default
#line hidden
                    return;
                case 48:
                    this.Item = ((System.Windows.Controls.Label)(target));
                    return;
                case 49:
                    this.ComboItem = ((System.Windows.Controls.ComboBox)(target));

#line 120 "..\..\ForgotPsw.xaml"
                    this.ComboItem.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboItem_SelectionChanged);

#line default
#line hidden
                    return;
                case 50:
                    this.PriceItem = ((System.Windows.Controls.Label)(target));
                    return;
                case 51:
                    this.TxtPriceItem = ((System.Windows.Controls.TextBox)(target));

#line 122 "..\..\ForgotPsw.xaml"
                    this.TxtPriceItem.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtPriceItem_PreviewTextInput);

#line default
#line hidden

#line 122 "..\..\ForgotPsw.xaml"
                    this.TxtPriceItem.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPriceItem_TextChanged);

#line default
#line hidden
                    return;
                case 52:
                    this.Quantity = ((System.Windows.Controls.Label)(target));
                    return;
                case 53:
                    this.TxtQty = ((System.Windows.Controls.TextBox)(target));

#line 124 "..\..\ForgotPsw.xaml"
                    this.TxtQty.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtQty_PreviewTextInput);

#line default
#line hidden

#line 124 "..\..\ForgotPsw.xaml"
                    this.TxtQty.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtQty_TextChanged);

#line default
#line hidden
                    return;
                case 54:
                    this.StockItem = ((System.Windows.Controls.Label)(target));
                    return;
                case 55:
                    this.TxtStockItem = ((System.Windows.Controls.TextBox)(target));

#line 126 "..\..\ForgotPsw.xaml"
                    this.TxtStockItem.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtStockItem_PreviewTextInput);

#line default
#line hidden

#line 126 "..\..\ForgotPsw.xaml"
                    this.TxtStockItem.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtStockItem_TextChanged);

#line default
#line hidden
                    return;
                case 56:
                    this.GridTransaksi = ((System.Windows.Controls.DataGrid)(target));

#line 127 "..\..\ForgotPsw.xaml"
                    this.GridTransaksi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.GridTransaksi_SelectionChanged);

#line default
#line hidden
                    return;
                case 58:
                    this.BtnSv = ((System.Windows.Controls.Button)(target));

#line 143 "..\..\ForgotPsw.xaml"
                    this.BtnSv.Click += new System.Windows.RoutedEventHandler(this.BtnSv_Click);

#line default
#line hidden
                    return;
                case 59:
                    this.BtnUpd = ((System.Windows.Controls.Button)(target));

#line 144 "..\..\ForgotPsw.xaml"
                    this.BtnUpd.Click += new System.Windows.RoutedEventHandler(this.BtnUpd_Click);

#line default
#line hidden
                    return;
                case 60:
                    this.BtnCnl = ((System.Windows.Controls.Button)(target));

#line 145 "..\..\ForgotPsw.xaml"
                    this.BtnCnl.Click += new System.Windows.RoutedEventHandler(this.BtnCnl_Click);

#line default
#line hidden
                    return;
                case 61:
                    this.BtnTbh = ((System.Windows.Controls.Button)(target));

#line 146 "..\..\ForgotPsw.xaml"
                    this.BtnTbh.Click += new System.Windows.RoutedEventHandler(this.BtnTbh_Click);

#line default
#line hidden
                    return;
                case 62:
                    this.TotalPay = ((System.Windows.Controls.Label)(target));
                    return;
                case 63:
                    this.TxtTotpay = ((System.Windows.Controls.TextBox)(target));

#line 148 "..\..\ForgotPsw.xaml"
                    this.TxtTotpay.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtTotpay_TextChanged);

#line default
#line hidden
                    return;
                case 64:
                    this.Pay = ((System.Windows.Controls.Label)(target));
                    return;
                case 65:
                    this.TxtPayment = ((System.Windows.Controls.TextBox)(target));

#line 150 "..\..\ForgotPsw.xaml"
                    this.TxtPayment.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtPayment_KeyDown);

#line default
#line hidden

#line 150 "..\..\ForgotPsw.xaml"
                    this.TxtPayment.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TxtPayment_PreviewTextInput);

#line default
#line hidden

#line 150 "..\..\ForgotPsw.xaml"
                    this.TxtPayment.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtPayment_TextChanged);

#line default
#line hidden
                    return;
                case 66:
                    this.Change = ((System.Windows.Controls.Label)(target));
                    return;
                case 67:
                    this.TxtChange = ((System.Windows.Controls.TextBox)(target));

#line 152 "..\..\ForgotPsw.xaml"
                    this.TxtChange.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtChange_TextChanged);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 57:

#line 137 "..\..\ForgotPsw.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnDelItem_Click);

#line default
#line hidden
                    break;
            }
        }

        internal System.Windows.Controls.Button BtnSubmitForgetPwd;
    }
}

