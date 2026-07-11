using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public List<Product> Products { get; set; }
    }
}


//int x;  // burdaki x field oluyor
//public int y { get; set; } // burdaki y property oluyor

//void test()
//{
//    int z; // metot içinde tanımlanırsa değişken oluyor
//}