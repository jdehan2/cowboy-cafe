using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private uint lastOrderNumber;


        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        public double Subtotal { get; set; }


        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;


        public void Add(IOrderItem item)
        {
            items.Add(item);
            Subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            Subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
