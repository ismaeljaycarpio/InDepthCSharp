using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InDepthCSharp
{
    class ProductNameComprarer : IComparer<Product>
    {

        public int Compare(Product x, Product y)
        {
            //throw new NotImplementedException();
            return x.Name.CompareTo(y.Name);
        }
    }
}
