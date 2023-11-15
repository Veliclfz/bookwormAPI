using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookwormAPI.Application.ViewModels
{
    public class VM_Writer_Update
    {
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterInfo { get; set; }
        public DateTime WriterBirthday { get; set; }
        public string WriterHomeTown { get; set; }
        public int WriterAge { get; set; }

    }
}
