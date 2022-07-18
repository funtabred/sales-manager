using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales_Management___Project.Entities
{
    public struct ImportInvoice
    {
        public string importInvoiceId;
        public DateTime createdAt;
        public List<ImportInvoiceDetail> importInvoiceDetails;
    }
}
