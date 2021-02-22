using System;
using System.Collections.Generic;
using System.Text;

namespace GeometriH1Github
{
    class Square
    { 
   private double side; //Erklærer en variabel

    public Square(double side) //opretter en konstruktør der har en egenskab defineret som side
    {
        this.side = side; //definerer at side i classen skal være det samme som siden konstruktøren tager med fra Main

    }

    //Opgave b

    public Square() //Opretter en tom konstruktør
    {
    }
    public double Side //Implementerer get & set properties til at bestemme hvad der må gøres ved variablen side
    {
        get
        {
            return this.side; // Alle kan se variablen side
        }
        set
        {
            this.side = value; //Alle kan sætte værdien for variablen
        }

    }
    //Metoder

    //omkreds
    public double Getperimeter()
    {
        double resultat = side * 4; /*da det er et kvadrat har siderne alle den samme værdi 
                                               * og man behøver derfor ikke lægge alle siderne sammen.*/
        return resultat;

    }
    //areal
    public double Getareal()
    {
        double resultat = side * side;
        return resultat;
    }

}

}