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
        private int iva;









        // STATI
        //private bool onSale;


        // COSTRUTTORE
        public Prodotto( string name, string description, int price, int iva)
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


        public int Barcode
        {
            get { return this.barcode; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Description
        { get { return this.description; }
        set { this.description = value; } }

        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public int Iva
        {
            get { return this.iva; }
            set { this.iva = value; }


        }

        public int priceIva()
        {
            return this.price + ( this.price * iva / 100);
        }




    }
}







