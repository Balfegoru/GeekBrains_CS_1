using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class ToDo
    {
        private string[] _titles = {string.Empty};
        private string[] _isDone = {};
        public string[] Title
        {
            get
            {
                return _titles;
            }
            set
            {

            }
        }

        public string IsDone
        {
            get;
            set;
        }

    }
}
