using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWork.EntityLayer.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerFullName { get; set; }
        public decimal Balance { get; set; }
    }
}
