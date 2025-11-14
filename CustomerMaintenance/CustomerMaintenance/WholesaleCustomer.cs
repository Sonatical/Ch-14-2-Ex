using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class WholesaleCustomer : Customer
    {
        public string Company { get; set; } = "";
        public WholesaleCustomer(string lastName, string firstName,
            string email, string company) : base(lastName, firstName, email) =>
            Company = company;
        // ^^ Use => instead of {} for some reason.... ^^. called base to ln, fn, and em. company is company
        public WholesaleCustomer() { }

        public override string GetDisplayText() =>
            $"{base.GetDisplayText()}; ({Company})";
        //using a different style of boiler plate for generalized and better code. (?)

        
    }
}
