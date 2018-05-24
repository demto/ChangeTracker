using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker {
    class Program {
        static void Main(string[] args) {

            var item = new Item("Cadbury chocolate", 10);
            var tracker = new ItemPriceChangeTracker();

            item.itemChanged += tracker.ChangeTrackker;

            item.ItemPrice = 100;
            Console.ReadKey();
            item.ItemPrice = 1010;
            Console.ReadKey();
        }
    }
}
