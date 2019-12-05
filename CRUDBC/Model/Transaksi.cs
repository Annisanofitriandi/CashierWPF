using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBC.Model
{
  
        [Table("tb_m_transaksi")]
        public class Transaksi
        {
            [Key]
            public int IdTransaksi { get; set; }
            public int Total { get; set; }
            public DateTimeOffset CreateDate { get; set; }

        public Transaksi() {
            this.CreateDate = DateTimeOffset.Now.LocalDateTime;
        }

            public Transaksi(int total)
            {
                this.Total = total;
            }
        }
    }

