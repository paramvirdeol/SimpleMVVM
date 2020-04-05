using MyDashboard.Services;
using MyData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MyDashboard.Customers
{
    public class CustomerEditViewModel : INotifyPropertyChanged
    {
        private Customer _customer;
        private ICustomersRepository _repository = new CustomersRepository();

        public CustomerEditViewModel()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged=delegate { };


        public Customer Customer 
        {
            get { return _customer; }
            set
            {
                if (value != _customer) 
                {
                    _customer = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("Customer"));
                }
            }
        }

        public Guid CustomerId { get; set; }
        public ICommand SaveCommand { get; set; }

        public async void LoadCustomer()
        {
            Customer = await _repository.GetCustomerAsync(CustomerId);
        }
        private async void OnSave()
        {
            Customer = await _repository.UpdateCustomerAsync(Customer);
        }

    }
}
