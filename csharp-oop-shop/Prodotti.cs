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
        private bool onSale;


        // COSTRUTTORE
        public Prodotto( string name, string description, int price, int iva)
        {
            this.barcode = GenerateCode();
            this.name = name;
            this.description = description;
            this.price = price;
            this.iva = iva;

            this.onSale = true;
        }



        //generare numero randomico
        private int GenerateCode()
        {
            Random rnd = new Random();
            return rnd.Next(0, 99);
            
        }

        //saldo prodotto 
        public bool GetOnSale()
        {
            return this.onSale;
        }
        public bool SetOnSale()
        {
           return onSale = false;
        }


        //get barcode
        public int Barcode
        {
         get { return this.barcode; }
        }


        //get set name product
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //get set name description
        public string Description
        { get { return this.description; }
        set { this.description = value; } }


        //get set price 
        public int Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        //get set iva
        public int Iva
        {
            get { return this.iva; }
            set { this.iva = value; }


        }

        //calculate price + iva
        public int priceIva()
        {
            return this.price + ( this.price * iva / 100);
        }

        //concat generatecode + name
        public string extendName()
        {
            return  this.GenerateCode() + this.name;     
        }

        //pad string codeee
        public string PadStringCode()
        {       
            
                string codeString = barcode.ToString();
           
                int codelength = codeString.Length;

            //  calcolo il numero di zeri da aggiungere come padding a sinistra del codice a barre sottraendo la lunghezza di "codeString" da 8
            //  e memorizzando il risultato in una variabile

                int add0 = 8 - codelength;

            //Se "add0" è maggiore di 0

            if (add0 > 0){

                // la lunghezza del codice a barre è inferiore a
                //8 caratteri e quindi  aggiunge dei padding a sinistra.


                // quindi creo una nuova stringa formata da "add0" zeri seguiti dalla stringa "codeString",
                //ottenendo così una nuova stringa con una lunghezza totale di 8 caratteri.

                codeString = new string('0', add0) + codeString;

            }
              return codeString;
        }

    }
}







