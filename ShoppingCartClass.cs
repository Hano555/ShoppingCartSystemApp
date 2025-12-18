namespace ShoppingCartSystem;

public class ShoppingCart
{

    private List<Product> _items = [];

    public void AddProduct()
    {
        string newProductName = "";
        decimal newProductPrice = 0;
        int newProductQuantity = 0;

        // 1. Name Loop
        while (true)
        {
            Console.WriteLine("\nEnter product name (or type 'back' to cancel):");
            string nameInput = Console.ReadLine()?.ToUpper().Trim() ?? "";

            if (nameInput == "BACK" || nameInput == "CANCEL") return; // Jumps out of adding
            if (!string.IsNullOrWhiteSpace(nameInput))
            {
                newProductName = nameInput;
                break; // Valid name, move to next question
            }
            Console.WriteLine("Error: Name cannot be empty.");
        }

        // 2. Price Loop
        while (true)
        {
            Console.WriteLine($"\nEnter price for {newProductName}:");
            if (decimal.TryParse(Console.ReadLine(), out newProductPrice) && newProductPrice >= 0)
            {
                break; // Valid price, move to next question
            }
            Console.WriteLine("Error: Please enter a valid numerical price (e.g., 10.50).");
        }

        // 3. Quantity Loop
        while (true)
        {
            Console.WriteLine($"\nEnter quantity for {newProductName}:");
            if (int.TryParse(Console.ReadLine(), out newProductQuantity) && newProductQuantity > 0)
            {
                break; // Valid quantity, finish adding
            }
            Console.WriteLine("Error: Please enter a valid whole number greater than 0.");
        }

        // Success: Add to cart and sort
        _items.Add(new Product(newProductName, newProductPrice, newProductQuantity));
        _items.Sort((x, y) => string.Compare(x.Name, y.Name));
        Console.WriteLine($"\nSUCCESS: {newProductQuantity}x {newProductName} added to cart.");
    }


    public void CheckProducts()
    {
        if (_items.Count == 0)
        {
            Console.WriteLine("\nYour cart is currently empty.\n");
        }

        else
        {
            decimal grandTotal = 0;

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("\nProduct Name" + "Price".PadLeft(15) + "Quantity".PadLeft(15));
            Console.WriteLine("------------" + "-----".PadLeft(15) + "--------\n".PadLeft(16));



            for (int i = 0; i < _items.Count; i++)
            {
                decimal productPriceTotal = _items[i].Price * _items[i].Quantity;
                grandTotal += productPriceTotal;

                Console.WriteLine($"{i + 1}.{_items[i].Name,-15}{_items[i].Price,10:C}{_items[i].Quantity,10}");
            }

            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine($"Your Cart Total: {grandTotal,10:C}\n");
        }
    }

    public void RemoveProduct(string input)
    {
        string[] deleteinput = input.Split(' ');

        if (deleteinput.Length > 1 && int.TryParse(deleteinput[1], out int index))
        {

            int actualindex = index - 1;

            if (actualindex >= 0 && actualindex < _items.Count)
            {
                _items.RemoveAt(actualindex);
                Console.WriteLine("Product removed!");
            }
        }
    }

    public void ClearProducts()
    {
        Console.WriteLine("\nAre you sure you want to delete ALL tasks? (y/n): \n");
        string confirm = Console.ReadLine()?.ToLower() ?? "";

        if (confirm == "y")
        {
            _items.Clear();
            Console.WriteLine("Products cleared!");
        }

        else Console.WriteLine("Clear cancelled.");
    }
}

