using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoVM
{
    public class WorkTaskVM : BaseVM
    {
        public bool IsSelected { get; set; }


        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
