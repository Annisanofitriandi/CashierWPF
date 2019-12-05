using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBC.Model
{
    [Table ("tb_m_role")]
    public class Role
    {
        [Key]
        public int IdRole { get; set; }
        public string RoleName { get; set; }

        public Role ()
        {

        }

        public Role (string rolename)
        {
            this.RoleName = rolename;
        }
    }
}
