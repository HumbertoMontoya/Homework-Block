using System;
using System.Text;

namespace Homeworks
{
    class Program
    {
        static HomeworksControl control = new HomeworksControl(new HomeworksUni());
        static void Main(string[] args)
        {
            Console.Title = "Rihay Homeworks";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            //Console.Clear();

            string option = "";
            do
            {
                Console.Clear();
                Console.SetCursorPosition(60, 1);
                Console.Write("Homeworks!\n");
                PrintMenu();
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        control.HomeworksSee();
                        break;
                    case "2":
                        control.AddHomeworks();
                        break;
                    case "3":
                        control.DeleteLatestWorks();
                        break;
                    case "4":
                        control.AnyWorks();
                        break;
                    case "5":
                        control.SearchForName();
                        break;
                    case "6":
                        HomeworksControl.AboutMe();
                        break;
                    case "7":
                        break;
                    default:
                        Console.WriteLine("OPTION NOT VALID!!");
                        break;
                }

            } while (option != "7");
        }

        static void PrintMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1- See Homeworks");
            sb.AppendLine("2- Add Homeworks");
            sb.AppendLine("3- Remove latest Homeworks");
            sb.AppendLine("4- Remove any Homeworks");
            sb.AppendLine("5- Search Homeworks for name");
            sb.AppendLine("6- About me");
            sb.AppendLine("7- Enter an option: ");

            Console.Write(sb.ToString());
        }
    }
}
