using System;
using System.Collections.Generic;
using System.Text;

namespace Tienda.Model
{
    public class UserType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public List<User> Users { get; set; }
    }
}
