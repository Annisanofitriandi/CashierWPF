using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBC.Model
{
    [Table("TB_M_User")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTimeOffset RegisterDate {get; set;}

        public Role Roles { get; set; }
        public User()
        {

        }

        public User(string name, string email, string password, Role role)
        {
            this.UserName = name;
            this.Email = email;
            this.Password = password;
            this.Roles = role;
            
        }
}

}
