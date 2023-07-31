using System.Collections.Generic;

namespace PierreVendor.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static List<Vendor> _instances = new List <Vendor> { };
        public List <Order> Orders = new List<Order>() { };
        public Vendor (string vendorName, string vendorDescription)
        {
            Name = vendorName;
            Description = vendorDescription;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
            }
            public static void ClearAll()
            {
                _instances.Clear();
            }
            public static List <Vendor> GetAll()
            {
                return _instances;
            }
        
            public static Vendor Find (int vendorId)
            {
                return _instances[vendorId - 1];
            }
            public void AddOrder (Order order)
            {
                Orders.Add(order);
            }      
    }
}