
using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto("shampoo", "Descrizione 1", 100, 22);
Console.WriteLine("Codice: " + prodotto1.Barcode); // Codice generato casualmente
Console.WriteLine(prodotto1.Name);
Console.WriteLine(prodotto1.Description);
Console.WriteLine(prodotto1.Price);
Console.WriteLine(prodotto1.Iva + "%");
Console.WriteLine(prodotto1.priceIva() + "%");