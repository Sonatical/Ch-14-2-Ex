using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class RetailCustomer : Customer
    {
        public RetailCustomer() { }

        public RetailCustomer(string lastName, string firstName, string email, string homePhone) :
            base(lastName, firstName, email) =>
           HomePhone = homePhone;

        public string HomePhone { get; set; } = " ";

        public override string GetDisplayText() => 
            $"{base.GetDisplayText()}; ({HomePhone})";
        //ITS STRING INTERPOLATION its composite formatting and you embed variable names directly with {} and you fit it with $ from the start
    }
}
