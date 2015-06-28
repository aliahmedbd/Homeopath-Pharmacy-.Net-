using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeoPathPhamacy.Entity
{
    public class TotalInfo
    {
        private int _tatalPaid;
        public int TotalPaid { 
            get
            {
                return _tatalPaid;
            } 
            set
            {
                _tatalPaid=value;
            }
        }
    }
}
