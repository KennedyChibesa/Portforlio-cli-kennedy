using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {

        int Choice;
        do
        {
            Console.WriteLine("======================================");
            Console.WriteLine("MY PROTFORLI APP");
            Console.WriteLine($"====================================== \n1. About Me \n2. Skills I Want  to Learn \n3. My Projects \n4. My Future Plans \n5. Exit");
            Console.Write("Enter Choice : ");

            while (!int.TryParse(Console.ReadLine(), out Choice))
            {
                Console.Write("Invalid Input. Enter a number : ");
            }
            switch (Choice)
            {
                case 1:
                    Show_About();
                    break;
                case 2:
                    Show_Skills();
                    break;
                case 3:
                    Show_Projects();
                    break;
                case 4:
                    Show_FuturePlans();
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Enter choice within the given range .......");
                    Console.WriteLine("Press any key to return to menu...");
                    Console.ReadKey();
                    break;
            }
        } while (Choice != 5);
    }
    static void Show_About()
    {
        Console.WriteLine("Hi,I'm Kennecy chibesa, a pasionate and driven computer science student . i have a strong foundation in programming and i enjoy creating efficient and scalable software solutions");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
    static void Show_Projects()
    {
        Console.WriteLine("Project list : ");
        System.Console.WriteLine("1.Library Management system\n2.Personal Portforlio website\n3.Console Calculator\n4.Quiz Application\n5.Task/To-Do Manger");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
    static void Show_Skills()
    {
        System.Console.WriteLine("Skill  Set : ");
        System.Console.WriteLine("1.Programming and Development\n2.Database and data Management\n3.web and frontedn dev");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
    static void Show_FuturePlans()
    {
        System.Console.WriteLine("future Plans : ");
        System.Console.WriteLine("1.Master Advanced Programming\n2.Build Real-World Projects\n3.Strengthen Database and system Knowledge");
        Console.WriteLine("Press any key to return to menu...");
        Console.ReadKey();
    }
}
