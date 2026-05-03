
public class AddToCartCommand : ICommand
{
    private readonly ShoppingCart _cart;
    private readonly string _item;

    public AddToCartCommand(ShoppingCart cart, string item)
    {
        _cart = cart;
        _item = item;
    }

    public void Execute() => _cart.AddItem(_item);
}
