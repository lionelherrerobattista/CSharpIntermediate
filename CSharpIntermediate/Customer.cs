using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Customer
    {
        public int Id;
        public string Name;
        // readonly field
        public readonly List<Order> Orders = new List<Order>(); // initialize in fields declaration

        //public Customer()
        //{
        //    this.Orders = new List<Order>(); // or initialize in default constructor
        //}

        public Customer(int id)
            //: this() // to call default constructor and init list
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // use of readonly:
            // Orders = new List<Order>(); // if we initialize here, we overwrite the list
            // ...
        }
    }
}
