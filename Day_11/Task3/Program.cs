using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        ShoppingCart myCart = new ShoppingCart();
        CartController controller = new CartController();

        ICommand addApple = new AddToCartCommand(myCart, "Apple iPhone 15");
        controller.SetCommand(addApple);
        controller.PressButton();

        ICommand removeApple = new RemoveFromCartCommand(myCart, "Apple iPhone 15");
        controller.SetCommand(removeApple);
        controller.PressButton();
    }
}
