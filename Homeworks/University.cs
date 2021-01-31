using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Homeworks 
{
    class University : IComparable<University>
    {
        // Properties.
        public String Subject { get; set; } 
        public String Works { get; set; } 
        public String DeliveryDay { get; set; } /*Dia de entrega */
        public String Teacher { get; set; }

        //Builder void
        public University()
        {

        }

        public University(string subject, string works, string deliveryDay, string teacher)
        {
            Subject = subject;
            Works = works;
            DeliveryDay = deliveryDay;
            Teacher = teacher;
        }

        // Call metod equals for compared two objects
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                //This is for know if two objects are the same.
                return false;
            }

            University h = obj as University;
            if (h == null)
            {
                return false;
            }

            // Si no we have a only value null so, we have contact
            return string.Equals(Works, h.Works) && string.Equals(Subject, h.Subject);
        }

        // Get hash code metod 
        public override int GetHashCode()
        {
            unchecked
            {
                int hashWorks = (Works != null ? Works.GetHashCode() : 0);
                int hashSubject = (Subject != null ? Subject.GetHashCode() : 0);
                return (hashWorks * 397) ^ (hashSubject);
            }
        }

        public override string ToString()
        {
            return string.Format("Teacher: {0}\nWork: {1}\nSubject: {2}\nDelivery day {3}: \n",Teacher, Works,
                Subject, DeliveryDay);
        }

        //This is the interfaz IComparable
        public int CompareTo([AllowNull] University other)
        {
            return Works.CompareTo(other.Works);
        }
    }
}
