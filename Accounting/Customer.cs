using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    public class Customer {
        private string? cutomerId;
        private string? name;

        public string CustomerId {
            get { 
                if (cutomerId == null)
                {
                    throw new ArgumentNullException(nameof(cutomerId));
                }
                return cutomerId; }
            set {
                cutomerId = value;
            }
        }
        public string Name {
            get { 
                if (name == null)
                {
                    throw new ArgumentNullException(nameof(name));
                }
                return name; }
            set {
                name = value;
            }
        }
    }
}