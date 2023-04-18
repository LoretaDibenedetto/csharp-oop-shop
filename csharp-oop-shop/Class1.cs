using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI / CARATTESTICHE
        private int barcode;
        private string name;
        private string description;
        private int price;
        private float iva;









        // STATI
        //private bool onSale;


        // COSTRUTTORE
        public Prodotto( string name, string description, int price, float iva)
        {
            this.barcode = GenerateCode();
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;

            //this.onSale = false;
        }




        private int GenerateCode()
        {
            Random rnd = new Random();
            return rnd.Next(10000000, 99999999);
        }






    }
}







