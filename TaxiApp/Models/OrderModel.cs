using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Models
{
    public class OrderModel
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string Phone { get; set; }

        public string LandingStreet { get; set; }

        public string LandingAddress { get; set; }

        public string TargetStreet { get; set; }

        public string TargetAddress { get; set; }

        public string DiscountCode { get; set; }
    }
}
