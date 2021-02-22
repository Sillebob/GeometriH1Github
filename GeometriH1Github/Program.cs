using System;

namespace GeometriH1Github
{
    class Program
    {
        static void Main(string[] args)
        {
            //omkreds
            Square kvadrat1 = new Square(2.54); //instantierer et nyt objekt af klassen Square
            Console.WriteLine(Math.Round(kvadrat1.Getperimeter(), 2));//Udskriver og kalder metoden til at beregne omkreds og afrunder til 2 decimaler;

            Square kvadrat2 = new Square(5.25);//instatierer et nyt objekt af klasssen Square med en anden side værdi
            Console.WriteLine(Math.Round(kvadrat2.Getperimeter(), 2)); /*Udskriver og kalder metoden til at beregne omkreds af det nye objekt
                                                                          * og afrunder til 2 decimaler*/

            Square kvadrat3 = new Square(15.00);//instatierer et nyt objekt af klasssen Square med en anden side værdi
            Console.WriteLine(Math.Round(kvadrat3.Getperimeter(), 2)); /*Udskriver og kalder metoden til at beregne omkreds af det tredje objekt
                                                                          * og afrunder til 2 decimaler*/

            //Areal
            Console.WriteLine(Math.Round(kvadrat1.Getareal(), 2));/*Udskriver og kalder metoden til at beregne areal af det første objekt
                                                                    * og afrunder til 2 decimaler*/

            Console.WriteLine(Math.Round(kvadrat2.Getareal(), 2)); /* Udskriver og kalder metoden til at beregne areal af det andet objekt
                                                                      * og afrunder til 2 decimaler*/
            Console.WriteLine(Math.Round(kvadrat3.Getareal(), 2)); /* Udskriver og kalder metoden til at beregne areal af det tredje objekt
                                                                      * og afrunder til 2 decimaler*/

            // Opgave B
            Square setnewvalue = new Square(25); //instantierer et nyt objekt af klassen Square med værdien af variablen side = 5

            Console.WriteLine(setnewvalue.Getperimeter());

            setnewvalue.Side = 12; //Ændrer nu værdien til 12

            Console.WriteLine(setnewvalue.Getperimeter()); //som det ses af udskriften er der nu brugt den nye værdi til udregning af omkredsen

            Square setnewvalue2 = new Square(5); //instantierer et nyt objekt af klassen Square med værdien af variablen side = 5

            Console.WriteLine(setnewvalue2.Getareal());

            setnewvalue2.Side = 7; //Ændrer nu værdien til 7

            Console.WriteLine(setnewvalue2.Getareal()); //som det ses af udskriften er der nu brugt den nye værdi til udregning af arealet

            Console.ReadKey();
        }

    }
}