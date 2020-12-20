using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.UI.Product
{
    public interface IProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }
    }
}
