using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homeworks
{
    class HomeworksUni
    {
        // Properties all as private.
        private const int TAM = 10;
        public int _index { get; set; }

        public University[] _homeWorks;

        // Metod int for to know how many homeworks we have.
        public int HomeWorksCount
        {
            get
            {
                return _index;
            }
        }

        //Initializing index and array
        public HomeworksUni()
        {
            _index = 0;
            _homeWorks = new University[TAM]; /*Variable const TAM for long to the array*/
        }

        //Adding a homeworks to the university
        public void AddingHomework(University homeworks)
        {
            if (_index < TAM)
            {
                _homeWorks[_index] = homeworks;
                _index++;
            }
            else
            {
                Console.WriteLine("Sorry, full homeworks");
            }
        }

        //Delete lates value
        public void RemoveHomeworks()
        {
            if (_index > 0)
            {
                _homeWorks[_index] = null; /*This remove latest value*/
                _index--;
            }
            else
            {
                Console.WriteLine("The agenda is empty.");
            }
        }

        public void ADelete()
        {
            if (_index > 0)
            {
                // Here delete a element select 
                Console.Write("Element to remove: "); int ind = int.Parse(Console.ReadLine());
                _homeWorks = _homeWorks.Where((source, index) => index != ind).ToArray();
                _index--;
            }
            else
            {
                Console.WriteLine("The agenda is empty.");
            }
        }

        // For know when there is homeworks
        public bool NotHomeworks()
        {
            if (_index == 0)
            {
                Console.WriteLine("There are homeworks");
                return true;
            }
            else
            {
                return false;
            }
        }

        //Getting a array sort
        public void sortData()
        {
            if(NotHomeworks()) { return; } /*Call to the function for know if there data in the arra*/

            //Created an array copy with data sort
            University[] arraySortHome = new University[_index];
            Array.Copy(_homeWorks, arraySortHome, _index);
            Array.Sort(arraySortHome);

            Console.WriteLine(StringHomeworks(arraySortHome));
        }

        //Show array of form reverse of an orderly way.
        public void sortDataRever()
        {
            if(NotHomeworks()) { return; }

            University[] sortData = new University[_index];
            Array.Copy(_homeWorks, sortData, _index);
            Array.Sort(sortData);
            Array.Reverse(sortData);

            Console.WriteLine(StringHomeworks(sortData));
        }

        //Search homeworks with name of the subject
        public University searchForSubject(string subject)
        {
            foreach (University subj in _homeWorks)
            {
                if (subj != null && subj.Subject == subject)
                {
                    return subj;
                }
            }
            return null;
        }

        public string StringHomeworks(University[] homeworks)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _index; i++)
            {
                if(_homeWorks[i] == null) { continue; }

                string data = string.Format("{0}. {1}", i + 1, _homeWorks[i]);
                sb.AppendLine(data);
            }
            return sb.ToString();
        }

        #region Form of use metod toString.
        public override string ToString()
        {
            return StringHomeworks(_homeWorks);
        }

        public void showHomewors()
        {
            Console.WriteLine(this);
        }
        #endregion
    }
}