using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "MadLibs";

            Random quesGen = new Random();

            List<string> wordTypes = new List<string>();
            string[] types =
            {
                "Enter a Noun: ", "Enter a Verb: ", "Enter an Adverb: ", "Enter an Adjective: ", "Enter a Name: ", "Enter a Body Part: ",
                "Enter Someone in the room's Name: ", "Enter an Animal: "
            };
            wordTypes.AddRange(types);

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
            
            

            Console.ReadKey();
        }
    }
}