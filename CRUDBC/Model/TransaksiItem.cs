using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBC.Model
{
    [Table("tb_t_transaksiitem")]
    public class TransaksiItem
    {
        [Key]
        public int IdTransaksiItem { get; set; }
        public int Quantity { get; set; }
        public int SubTotal { get; set; }

        public Item Item { get; set; } //untuk foreign key
        public Transaksi Transaksi { get; set; } // foreign key
        public TransaksiItem() { }

        public TransaksiItem(int quantity, int subtotal, Item item, Transaksi transaksi)
        {
            this.Quantity = quantity;
            this.SubTotal = subtotal;
            this.Item = item;
            this.Transaksi = transaksi;
        }
    }
}

