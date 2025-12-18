using ShoppingCartSystem;

ShoppingCart myCart = new();
bool startcart = true;


Console.WriteLine("\nWelcome to Shopping Cart System");
Console.WriteLine("Available commands: [add, check, remove, clear, exit]");

while (startcart)
{

    Console.Write("\n> ");
    string input = Console.ReadLine()?.ToLower().Trim() ?? "";

    if (input == "exit" || input == "done")
    {
        startcart = false;
        Console.WriteLine("Goodbye!");
    }

    else if (input == "add")
    {
        myCart.AddProduct();
    }

    else if (input == "check")
    {
        myCart.CheckProducts();
    }

    else if (input.StartsWith("remove "))
    {
        myCart.RemoveProduct(input);
    }

    else if (input == "clear")
    {
        myCart.ClearProducts();
    }

    else
    {
        Console.WriteLine($"Unknown command: '{input}'. Please try: add, check, remove, clear, exit");
    }

}













