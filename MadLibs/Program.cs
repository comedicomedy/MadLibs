using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace MadLibs
{
    
    class Program
    {
        //Creates an array for the Questions
        static string[] types =
        {
            "Enter a Noun: ", "Enter a Verb: ", "Enter an Adverb: ", "Enter an Adjective: ", "Enter a Name: ", "Enter a Body Part: ",
            "Enter Someone in the room's Name: ", "Enter an Animal: ", "Enter a Place: "
        };
        
        static void Main(string[] args)
        {
            //Messes with the Console
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "MadLibs";
            

            //Introduction
            Console.WriteLine("Welcome to MADLIBS! \nThe Crazy Word Game \n\nDo you know how to play?");
            string yesOrNo = Console.ReadLine();
            if (yesOrNo == "y" || yesOrNo == "yes" || yesOrNo == "Yes")
            {
                Console.WriteLine("Now chose what Madlib.");
            }
            else if (yesOrNo == "n" || yesOrNo == "no" || yesOrNo == "No")
            {
                 Console.WriteLine("MadLibs is a word game where you have to answer whatever the prompt says. \nNow chose what MadLib.");
            }

            Console.WriteLine("The Injury at the Factory(1) or The Mad Shoppe(2)?");
            string whichLib = Console.ReadLine();
            switch (whichLib)
            {
                case "1":
                    Console.WriteLine("Ok here we go! \n");
                    FirstMadLib();
                    break;
                case "2":
                    Console.WriteLine("Ok here we go! \n");
                    SecondMadLib();
                    break;
                default:
                    System.Environment.Exit(1);
                    break;
            }
        

            FirstMadLib();
            
            Console.ReadKey();
        }

        //The first Madlib
        static void FirstMadLib()
        {
            Console.Write(types[4]);
            string na1 = Console.ReadLine();
            Console.Write(types[0]);
            string n1 = Console.ReadLine();
            Console.Write(types[0]);
            string n2 = Console.ReadLine();
            Console.Write(types[5]);
            string bp1 = Console.ReadLine();
            Console.Write(types[8]);
            string p1 = Console.ReadLine();
            Console.Write(types[3]);
            string a1 = Console.ReadLine();
            Console.Write(types[8]);
            string p2 = Console.ReadLine();
            Console.Write("Verb past tense: ");
            string v1 = Console.ReadLine();
            Console.Write(types[0]);
            string n3 = Console.ReadLine();
            Console.Write(types[0]);
            string n4 = Console.ReadLine();
            
            Console.WriteLine(na1 + " works at a " + n1 + " factory. While using the " + n2 + " machine he broke his " + bp1 + ". His Boss sent him to the " + 
                              p1 + ". They did a " + a1 + " job at treating " + na1 + ". After they get treated they headed to the " + p2 + ". they "
                              + v1 + " his favorite show. After he went to the " + n3 + " shop and bought a " + n4 + 
                              " then they walked out living the rest of his life.");
        
            System.Environment.Exit(1);
        }

        static void SecondMadLib()
        {
           Console.Write(types[0]);
           string n1 = Console.ReadLine();
           Console.Write(types[0]);
           string n2 = Console.ReadLine();
           Console.Write(types[0]);
           string n3 = Console.ReadLine();
           Console.Write(types[0]);
           string n4 = Console.ReadLine();
           Console.Write(types[1]);
           string v1 = Console.ReadLine();
           Console.Write(types[3]);
           string a1 = Console.ReadLine();
           Console.Write(types[0]);
           string n5 = Console.ReadLine();
           Console.Write(types[3]);
           string a2 = Console.ReadLine();
           Console.Write(types[3]);
           string a3 = Console.ReadLine();
           Console.Write(types[0]);
           string n6 = Console.ReadLine();
           Console.Write(types[5]);
           string bp1 = Console.ReadLine();
           Console.Write(types[1]);
           string v2 = Console.ReadLine();
           Console.WriteLine(types[0]);
           string n8 = Console.ReadLine();

           Console.WriteLine("Jeff works at a crazy store selling Crazy stuff like " + n1 + ", " + n2 + " and " + n3 +
                            ". All the stuff here was bought at the " + n4 + " market. When Jeff " + v1 + " in to storage. He looked for the "
                            + a1 + " " + n5 + ". He needed to put them on the " + a2 + " shelf. while looking for the " + a3 + " " + n6
                            + " he came across a magical " + bp1 + " which when he held caused him to " + v2 +
                            " which killed him and the " + n8 + " didn't see him again");
        
            System.Environment.Exit(1);
        }
    }
}
