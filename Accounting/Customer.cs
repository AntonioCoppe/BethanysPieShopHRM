using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    public class Customer {
        private string cutomerId;
        private string name;

        public string CustomerId {
            get { return cutomerId; }
            set {
                cutomerId = value;
            }
        }
        public string Name {
            get { return name; }
            set {
                name = value;
            }
        }
    }
}