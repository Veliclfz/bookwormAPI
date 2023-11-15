using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookwormAPI.Application.ViewModels
{
    public class VM_User_Update
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public int PhoneNumber { get; set; }

    }
}
