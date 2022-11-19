using System.Globalization;
using TabelaProdutos.Entities;

List<Produto> list = new List<Produto>();

Console.Write("Enter the number of products: ");
int quantProd = int.Parse(Console.ReadLine());

for (int i = 1; i <= quantProd; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char category = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (category == 'i')
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(customsFee, name, price));
    }
    else if (category == 'u')
    {
        Console.Write("Manufature date (DD/MM/YYYY): ");
        DateTime manufatureDate = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(manufatureDate, name, price));
    }
    else
    {
        list.Add(new Produto(name, price));
    }

}
    Console.WriteLine();
    Console.WriteLine("PRICE TAGS:");
    foreach(Produto prod in list)
    {
        Console.WriteLine(prod.PriceTag());
    }