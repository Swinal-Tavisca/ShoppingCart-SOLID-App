using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_SOLID
{
    class Online:IOnline
    {
        public void usersOnlineDetails()
        {
            //take users online details like payment card number
            displayOnline();
        }
        public void displayOnline()
        {
            
            Console.WriteLine("ONLINE PAYMENT");
            
        }
    }
}
