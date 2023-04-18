
using csharp_oop_shop;

Prodotto prodotto1 = new Prodotto("shampoo", "fantastico shampoo", 100, 22);
Console.WriteLine("Codice a barre: " + prodotto1.Barcode); // Codice generato casualmente
Console.WriteLine("Nome prodotto: "+ prodotto1.Name);
Console.WriteLine("Descrizione prodotto: " + prodotto1.Description);
Console.WriteLine("Prezzo base: "+ prodotto1.Price + "$");
Console.WriteLine("Iva: "+ prodotto1.Iva + "%");
Console.WriteLine("Prezzo finale con iva: "+ prodotto1.priceIva() + "$");
Console.WriteLine("code piu' nome esteso: " + prodotto1.extendName());

Console.WriteLine("numero pad0: " + prodotto1.PadStringCode());
Console.WriteLine("il prodotto e' in saldo? " + prodotto1.SetOnSale());