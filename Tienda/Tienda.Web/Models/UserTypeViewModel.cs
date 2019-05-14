using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tienda.Web.Models
{
    public class UserTypeViewModel
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public List<UserViewModel> Users { get; set; }
    }
}
