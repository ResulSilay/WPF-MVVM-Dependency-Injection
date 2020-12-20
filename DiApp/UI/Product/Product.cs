using DiApp.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiApp.UI.Product
{
    public class Product: ObservableBase
    {
        public long productId;
        public String barcode;
        public String name;
        public String description;
        public Double price;
        public String source;

        public long ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                if (productId != value)
                {
                    productId = value;
                    RaisePropertyChanged("ProductId");
                }
            }
        }

        public String Barcode
        {
            get
            {
                return barcode;
            }
            set
            {
                if (barcode != value)
                {
                    barcode = value;
                    RaisePropertyChanged("Barcode");
                }
            }
        }


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    RaisePropertyChanged("Name");
                }
            }
        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (description != value)
                {
                    description = value;
                    RaisePropertyChanged("Description");
                }
            }
        }

        public Double Price
        {
            get
            {
                return price;
            }
            set
            {
                if (price != value)
                {
                    price = value;
                    RaisePropertyChanged("Price");
                }
            }
        }

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                if (source != value)
                {
                    source = value;
                    RaisePropertyChanged("Source");
                }
            }
        }
    }
}