using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker {
    class ItemPriceChangeTracker {

        private Item item;

        public void ChangeTrackker(object sender, ItemChangedEventArgs e){
            if (e.ItemPrice > 1000d) {
                Console.WriteLine($"OMG! Item Price has increased to : {e.ItemPrice}!");
            }

            Console.WriteLine($"The item's price has changed to {e.ItemPrice}");

            DirectoryInfo newDir = Directory.CreateDirectory(@"C:\MyStuff\AppLogs\Changes");
            string path = @"C:\MyStuff\AppLogs\Changes\Changes.txt";

            var log = $"Item price changed to {e.ItemPrice} at {DateTime.Now}";
            using (StreamWriter sr = new StreamWriter(path, true)){
                sr.WriteLine(log);
            }
        }
    }
}
