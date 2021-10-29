using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tourist
{
    class MyTable
    {
        public MyTable(int Id, string Name, double Price, int Count, bool Status)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
            this.Status = Status;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool Status { get; set; }
    }
}
