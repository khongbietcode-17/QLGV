using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Models
{
    public class UserModel: BaseModel
    {
        public int UserId {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
