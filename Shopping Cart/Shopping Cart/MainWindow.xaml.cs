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

namespace Shopping_Cart
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<string> _products;
        private BindingList<string> _cart;
        private string _itemQuantity;
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        public BindingList<string> Products
        {
            get { return _products; }
            set
            {
                _products = value;
            }
        }
        public BindingList<string> Cart
        {
            get { return _cart; }
            set
            {
                _cart= value;
            }
        }

      




        public string SubTotal
        {
            get {
                return "0.00 sh";
            }
           
        }
        public string tax
        {
            get
            {
                return "0.00 sh";
            }

        }
        public string total
        {
            get
            {
                return "0.00 sh";
            }

        }


        public string item 
        { get
            {
                return _itemQuantity;
            }
            set { _itemQuantity = value; } 
        }

        public bool CanAddToCart
        {
            get
            {
                bool output = false;
                return output;
            }
           
        }

        public void AddToCart()
        {

        }

        public bool RemoveFromCart
        {
            get
            {
                bool output = false;
                return output;
            }
        }
        public bool CanCheckOut
        {
            get
            {
                bool output = false;
                return output;
            }
        }
    }
}
