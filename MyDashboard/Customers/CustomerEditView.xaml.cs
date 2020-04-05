using MyDashboard.Services;
using MyData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyDashboard.Customers
{
    /// <summary>
    /// Interaction logic for CustomerEditView.xaml
    /// </summary>
    public partial class CustomerEditView : UserControl
    {        
        public CustomerEditView()
        {
            InitializeComponent();
        }

        public Guid CustomerId
        {
            get { return (Guid)GetValue(CustomerIdProperty); }
            set { SetValue(CustomerIdProperty, value); }
        }

        public static readonly DependencyProperty CustomerIdProperty =
            DependencyProperty.Register("CustomerId", typeof(Guid), 
                typeof(CustomerEditView), new PropertyMetadata(Guid.Empty));
        
    }
}
