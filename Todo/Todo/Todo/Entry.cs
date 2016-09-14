using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo
{
    public class Entry
    {
        private string _des;
    
        private bool _toggle;

        public string Des
        {
            get
            {
                return _des;
            }
            set
            {
                _des = value;
            }
        }


        public bool Toggle
        {
            get
            {
                return _toggle;
            }
            set
            {
                _toggle = value;
            }
        }

   /*     public void Edit(string des)
        {
            if(des != "")
            {
                _des = des;
            }
            
        }*/
    }
}
