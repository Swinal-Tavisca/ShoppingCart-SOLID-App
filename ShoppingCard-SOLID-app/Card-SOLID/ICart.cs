using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    public interface ICart
    {
        void addItems(Items product,int id);
        void removeItems(Items product,int id);
        void totalItemsCost(Items product);
        void retriveItem(Items product,int id);
        void displayCart();
    }
}
