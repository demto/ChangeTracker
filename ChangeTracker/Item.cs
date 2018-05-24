using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTracker {
    class Item {

        private string itemName;
        private double itemPrice;
        public event EventHandler<ItemChangedEventArgs> itemChanged;

        public Item(string name, double price) {
            this.itemName = name;
            this.itemPrice = price;
        }

        public int ItemId { get; set; }
        public string ItemName {
            get {
                return itemName;
            }
            set {
                if (itemName != value) {
                    itemName = value;
                };

            }
        }

        public double ItemPrice {
            get {
                return itemPrice;
            }
            set {
                if (itemPrice != value) {
                    itemPrice = value;
                };
                OnItemPriceChanged(this.ItemPrice);
            }
        }

        // Just added to test something on Git commit
        protected virtual void OnItemPriceChanged(double price){
            itemChanged?.Invoke(this, new ItemChangedEventArgs(price));
        }
    }
}
