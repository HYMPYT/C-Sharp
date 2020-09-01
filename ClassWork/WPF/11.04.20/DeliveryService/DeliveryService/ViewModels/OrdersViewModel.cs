using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DeliveryService.Models;

namespace DeliveryService.ViewModels
{
    public class OrdersViewModel : INotifyPropertyChanged
    {
        DeliveryServiceModel db = new DeliveryServiceModel();
        public ObservableCollection<Order> Orders { get; set; }

        public OrdersViewModel()
        {
            Orders = new ObservableCollection<Order>();
            LoadOrders();
        }

        public void LoadOrders()
        {
            Orders.Clear();
            foreach (Order order in db.Orders.ToList())
            {
                Orders.Add(order);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
