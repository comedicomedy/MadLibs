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
            switch (yesOrNo)
            {
                case "yes":
                    Console.WriteLine("Ok, here we go!");
                    break;
                case "y":
                    Console.WriteLine("Ok, here we go!");
                    break;
                case "no":
                    Console.WriteLine("MadLibs is a word game where you have to answer whatever the prompt says.");
                    break;
                case "n":
                    Console.WriteLine("MadLibs is a word game where you have to answer whatever the prompt says.");
                    break;
                
                default:
                    Console.WriteLine("ERROR");
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
        }

        static void SecondMadLib()
        {
            
        }
    }
}
