using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locate_Assets_Package.Model
{
    public class PropertySearchRequestModel
    {
        public OwnerInfo OwnerInfo { get; set; }
        public PostAddr PropertyAddress { get; set; }
    }

    public class OwnerInfo
    {
        public PersonName PersonName { get; set; }
    }

    public class PersonName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class PostAddr
    {
        public string Addr1 { get; set; }
        public string City { get; set; }
        public string StateProv { get; set; }
        public string PostalCode { get; set; }
    }

}
