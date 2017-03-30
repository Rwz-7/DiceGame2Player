using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static string player1 = "Daniel";
        static string player2 = "Fabian";
        public static int anzahlP1;
        public static int anzahlP2;
        public static int gewonnenP1;
        public static int gewonnenP2;
        public static int wuerfel0P1;
        public static int wuerfel0P2;
        //public static int wuerfel1P1;
        //public static int wuerfel1P2;
        //public static int wuerfel2P1;
        //public static int wuerfel2P2;
        //public static int wuerfel3P1;
        //public static int wuerfel3P2;
        //public static int wuerfel4P1;
        //public static int wuerfel4P2;
        public static int anzahlRunden=5;
        public static int anzahlRunde;
        //public static int wurf1;
        //public static int wurf2;
        public static Random zufallWuerfel = new Random();
        public static int i = anzahlP1;
        public static int j = anzahlP2;

        static void Main(string[] args)
          {


            //Name Player1 + 
            Console.WriteLine("Whats your name Player 1?");
            player1 = Convert.ToString(Console.ReadLine());

            //Name Player2 + Begrüßung P1 & P2
            Console.WriteLine("Whats your name Player 2?");
            player2 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Hello " + player1 + ".  Hello " + player2);

            //Abfrage wie viel runden sie würfeln wollen
            Console.WriteLine("How much Rounds you want to Play?" );
            anzahlRunden = Convert.ToUInt16(Console.ReadLine());

            //Ausgabe Player 1 beginnt jetzt
            Console.WriteLine("");
            Console.WriteLine(player1 + " You are first Good Luck");
            Console.WriteLine("-----------------------------------------------------");
            Console.Clear();





            

            while (anzahlRunde != anzahlRunden)
            {
                //Player 1 würfelt + anzahlRundeP1 +1
                Console.WriteLine(player1 + " Please press a Button");
                Console.ReadKey();
                Player1();
                anzahlP1++;

                //Player 2 würfelt + anzahlRundeP2 + 1
                Console.WriteLine(player2 + " Please press a Button");
                Console.ReadKey();
                Player2();
                anzahlP2++;


                //Stelle Sieger Fest
                RundenSieger();
                anzahlRunde++;
                Console.WriteLine();
                Console.WriteLine("You played " + anzahlRunde + " Rounds"); 
                Console.WriteLine("|| Scores Player 1: " + player1 + " " + gewonnenP1 + " Won. || Scores Player 2: " + player2 + " " + gewonnenP2 + " Won.");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }


            Console.WriteLine("You played " + anzahlRunde + " Rounds");
            Console.WriteLine("|| Scores Player 1: " + player1 + " " + gewonnenP1 + " Won. || Scores Player 2: " + player2 + " " + gewonnenP2 + " Won.");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.ReadKey();
           
        }

        public static void Player1()
        {

            i = anzahlP1;
            if (j != anzahlRunden)
            {

                wuerfel0P1 = zufallWuerfel.Next(1, 7);
                //Ausgabe des Ergebnisses
                Console.WriteLine(player1 + " Du hast die " + wuerfel0P1 + " gewürfelt");
                Console.WriteLine();
                return;

            }
            else
            {
                Console.WriteLine(player1 + " Du hast alle " + anzahlRunden + " gewürfelt");
            }
        }
        public static void Player2()
        {

            j = anzahlP2;
            if (j != anzahlRunden)
            {
                
                wuerfel0P2 = zufallWuerfel.Next(1, 7);
                //Ausgabe des Ergebnisses
                Console.WriteLine(player2 + " Du hast die " + wuerfel0P2 + " gewürfelt");
                Console.WriteLine();
                return;
            }
            else
            {
                Console.WriteLine(player2 + " Du hast alle " + anzahlRunden + " gewürfelt");
            }
        }
        public static void RundenSieger()
        {
            
            {   
                // Abfrage Wen Unentschieden Nochmal Würfeln||Else P1 win||Else P2 win
                if (wuerfel0P1 == wuerfel0P2)
                {

                    Console.WriteLine("Throwing Again ");
                    Player1();
                    Player2();
                    RundenSieger();
                    return;
                    
                }
               else if (wuerfel0P1 >= wuerfel0P2)
                {
                    gewonnenP1++;
                    Console.WriteLine("Gratulation " + player1 + " You won this Round");
                }
                else if (wuerfel0P1 <= wuerfel0P2)
                {
                    gewonnenP2++;
                    Console.WriteLine("Gratulation " + player2 + " You won this Round");
                }
                
            }
        }
    }
}
