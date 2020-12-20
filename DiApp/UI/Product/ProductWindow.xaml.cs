using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DiApp.UI.Product
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly IProductViewModel _productViewModel;
        
        public ProductWindow(IProductViewModel productViewModel)
        {
            InitializeComponent();
            this._productViewModel = productViewModel;
            DataContext = productViewModel;
        }
    }
}
