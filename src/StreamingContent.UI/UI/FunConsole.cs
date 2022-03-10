using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class FunConsole : IConsole
{
    public void ChangeColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }
    public void Clear()
    {
       Console.Clear();
       Console.BackgroundColor =RndColor();
    }

    private ConsoleColor RndColor()
    {
        Thread.Sleep(10);
        Random rnd = new Random();
        int colorIndex = rnd.Next(0,16);
        return (ConsoleColor)colorIndex;
    }

    public ConsoleKeyInfo ReadKey()
    {
        return Console.ReadKey();
    }

    public string ReadLine()
    {
        //grab userInput
        string input = Console.ReadLine();
        Console.WriteLine("Umm....");
        Thread.Sleep(1000);
        System.Console.WriteLine("You sure...?");
        Thread.Sleep(1000);
        System.Console.WriteLine("....okay?");
        return input;

    }

    public void ResetConsoleColor()
    {
        Console.ResetColor();
    }
    public void Write(string o)
    {
        foreach(var letter in o)
        {
            Console.ForegroundColor= RndColor();
            Console.Write(letter);
        }
    }

    public void WriteLine(string s)
    {
        //sPoNgEbOb lettering
        Console.ForegroundColor= RndColor();
        bool capitalize = false;
        foreach(var letter in s)
        {
            if(capitalize is true)
            {
                Console.ForegroundColor = RndColor();
                Console.Write(char.ToUpper(letter));
                capitalize = false;
            }
            else
            {
                Console.ForegroundColor = RndColor();
                Console.Write(char.ToLower(letter));
                capitalize=true;
            }
        }
        Thread.Sleep(50);
        Console.WriteLine("\n");
    }

    public void WriteLine(object o)
    {
        Console.ForegroundColor= RndColor();
        Console.WriteLine(o);
    }
}
