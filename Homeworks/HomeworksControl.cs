using System;
using System.Collections.Generic;
using System.Text;

namespace Homeworks
{
    class HomeworksControl
    {
        // Passing the class to a single variable
        public HomeworksUni _control; /*Property private*/

        // Metod for get the class in a variable, in this case _control.
        public HomeworksControl(HomeworksUni control)
        {
            _control = control;
        }

        // Show homeworks.
        public void HomeworksSee()
        {
            ClearAll();
            menuOption();
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Homeworks ascending:");
                    _control.sortData();
                    break;
                case "2":
                    Console.WriteLine("Homeworks descending:");
                    _control.sortDataRever();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Option not valid");
                    break;
            }
            PressKey();
        }
        //Add a new homeworks
        public void AddHomeworks()
        {
            ClearAll();
            Console.WriteLine("New homeworks!!");
            University homeworkNew = new University();
            Console.Write("Subject: "); homeworkNew.Subject = Console.ReadLine();
            Console.Write("HomeWorks: "); homeworkNew.Works = Console.ReadLine();
            Console.Write("Delivery Day: "); homeworkNew.DeliveryDay = Console.ReadLine();
            Console.Write("Teacher: "); homeworkNew.Teacher = Console.ReadLine();

            _control.AddingHomework(homeworkNew);
            Console.WriteLine("Homeworks add, Congratulations!!");
            PressKey();
        }

        //Remove latestHomeworks
        public void DeleteLatestWorks()
        {
            ClearAll();
            _control.RemoveHomeworks();
            Console.WriteLine("Remove homeworks, congratulations!!");
            PressKey();
        }

        //Remove any homewrks
        public void AnyWorks()
        {
            ClearAll();
            _control.ADelete();
            Console.WriteLine("Remove homeworks, congratulations!!");
            PressKey();
        }

        // Search for name 
        public void SearchForName()
        {
            Console.WriteLine("Search for Subject");
            Console.Write("Subjects: "); string sub = Console.ReadLine();

            University homeworks = _control.searchForSubject(sub);
            //Iteration
            if (sub != null)
            {
                Console.WriteLine("Data:\n {0}", homeworks);
            }
            else
            {
                Console.WriteLine("Homeworks not found");
            }
            PressKey();
        }


        //Show menu of start
        public void menuOption()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("1.- Show ascending order");
            sb.AppendLine("2.- Show desceding order");
            sb.AppendLine("3.- Show start menu");
            sb.Append("Enter a option: ");

            Console.Write(sb.ToString());
        }
        //About me
        public static void AboutMe()
        {
            ClearAll();
            Console.WriteLine("Name: Humberto Areallano");

            PressKey();
        }

        private static void ClearAll()
        {
            Console.Clear();
        }

        private static void PressKey()
        {
            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }

    }
}
