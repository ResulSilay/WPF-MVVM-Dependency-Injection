using DiApp.Base;
using DiApp.Business.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DiApp.UI.Product
{
    public class ProductViewModel : ViewModelBase, IProductViewModel
    {
        private readonly IProductService _productService;

        private Product productModel;
        public ObservableCollection<Product> Products { get; set; }
        public ICommand OnProductDetailCommand { get; set; }


        public Product ProductModel
        {
            get { return productModel; }
            set { productModel = value; }
        }

        public ProductViewModel(IProductService productService)
        {
            _productService = productService;

            Products = new ObservableCollection<Product>();

            productModel = new Product();

            _productService.All().ForEach(productItem =>
            {
                Products.Add(new Product() { ProductId = productItem.ProductId, Barcode = productItem.Barcode, Name = productItem.Name, Description = productItem.Description, Price = productItem.Price, Source = productItem.Source });
            });

            OnProductDetailCommand = new RelayCommand<Product>(OnDetail);

        }

        public static void OnDetail(Product product)
        {
            if (product != null)
            {
                MessageBox.Show(String.Format("{0}\n{1}\n\n{2}", product.ProductId, product.Name, product.Description));
            }
        }
    }
}