using product;
using shop;
using System.Reflection.Metadata.Ecma335;

bool quit = false;
bool areProductAdded = false;
int selector;
int numberOfProductsToAdd;

Console.WriteLine("Benvenuto nel programma!");
Console.WriteLine("Inserisci il nome del negozio: ");
string shopName = Console.ReadLine();
Console.WriteLine("Inserisci la città: ");
string shopCity = Console.ReadLine();
Console.WriteLine("Inserisci l'indirizzo: ");
string shopAddress = Console.ReadLine();
Console.WriteLine("Inserisci il numero civico: ");
int shopHouseNumber = int.Parse(Console.ReadLine());
Shop myShop = new Shop(shopName, shopCity, shopAddress, shopHouseNumber);

do
{
    Console.WriteLine("Che operazione vuoi eseguire?");
    Console.WriteLine("[1] Inserisci prodotti");
    Console.WriteLine("[2] Stampa il resconto del negozio");
    Console.WriteLine("[3] Esci dal programma");
    selector = int.Parse(Console.ReadLine());

    switch (selector)
    {
        case 1:
            Console.WriteLine("Quanti prodotti vuoi inserire?");
            numberOfProductsToAdd = int.Parse(Console.ReadLine());
            addProductList(numberOfProductsToAdd);
            areProductAdded = true;
            break;
        case 2:
            if (areProductAdded)
            {
                printShop();
            }   else 
            {
                Console.WriteLine("Devi prima inserire una lista di prodotti!");
            }
            break;
        case 3:
            quit = true;
            break;
        default:
            Console.WriteLine("Operazione non valida");
            break;
    }
} while (!quit);

void addProductList(int numberOfProductsToAdd)
{
    List<Product> startingList = new List<Product>();
    for (int i = 0; i < numberOfProductsToAdd; i++)
    {
        Console.WriteLine("Inserisci il nome del prodotto: ");
        string productName = Console.ReadLine();
        Console.WriteLine("Inserisci la descrizione del prodotto: ");
        string productDescription = Console.ReadLine();
        Console.WriteLine("Inserisci il nome della categoria del prodotto: ");
        string productCategory = Console.ReadLine();
        Console.WriteLine("Inserisci il prezzo del prodotto: ");
        float productPrice = float.Parse(Console.ReadLine());
        Product newProduct = new Product(productPrice, productName, productDescription, productCategory);
        startingList.Add(newProduct);
    }
    myShop.addListToProductList(startingList);
}

void printShop()
{
    Console.WriteLine(myShop.shopRappresentationString());
}