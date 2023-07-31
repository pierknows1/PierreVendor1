using System.Collections.Generic;

namespace PierreVendor.Models
{
    public class Order
   {
        public string MyOrder { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };
        public Order (string orderTest, string orderDescription )
        {
            MyOrder = orderTest;
            Description = orderDescription;
            _instances.Add(this);
            Id = _instances.Count;
        }
        public static List<Order> GetAll()
        {
            return _instances;
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find (int vendorId)
        {
            return _instances[vendorId - 1];
        }
   }
}