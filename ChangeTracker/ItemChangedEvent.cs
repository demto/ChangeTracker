using System;

namespace ChangeTracker {
    public class ItemChangedEventArgs : EventArgs{

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }

        public ItemChangedEventArgs(double price) {
            this.ItemPrice = price;
        }
    }
}