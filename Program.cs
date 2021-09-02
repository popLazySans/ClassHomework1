using System;
using System.Collections.Generic;

namespace appSupport
{
    class Program
    {
        static void Main(string[] args)
        {
            Address AddressOfJame = new Address("Phutthamonthon", "Nakhonpathom", "10180");
            shoppingCart cartOfJame = new shoppingCart(AddressOfJame);
            User jame = new User("jame watson","jame@gmail.com",cartOfJame);

            T_shirt shirt1 = new T_shirt("L","red",500,"muscle form");
            T_shirt shirt2 = new T_shirt("M", "black", 750, "MDT we love ourselves Image");
            T_shirt shirt3 = new T_shirt("S", "rainbow", 625,"Weed Image");
            jame.shopCart.addList(shirt1);
            jame.shopCart.addList(shirt2);
            jame.shopCart.addList(shirt3);
            jame.GetUser();
            
        }
    }
}
