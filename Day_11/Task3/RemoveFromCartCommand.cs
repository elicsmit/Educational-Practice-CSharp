
public class RemoveFromCartCommand : ICommand
{
    private readonly ShoppingCart _cart;
    private readonly string _item;

    public RemoveFromCartCommand(ShoppingCart cart, string item)
    {
        _cart = cart;
        _item = item;
    }

    public void Execute() => _cart.RemoveItem(_item);
}
