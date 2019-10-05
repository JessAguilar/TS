using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosTI
{
    internal static class ChosedSubjects
    {
        internal static List<Subject> TakeSubjects(this List<String> subjectsName)
        {
            List<Subject> allSubjects = new List<Subject>();
            List<Subject> FilteredSubjects = new List<Subject>();
            allSubjects.GetSubjects();
            foreach (string subject in subjectsName)
            {
                var Filter = (from s in allSubjects
                              where s.NameSubject.Equals(subject)
                              select s);
                foreach(Subject anySubjects in Filter)
                {
                    FilteredSubjects.Add(anySubjects);
                }
            }
            return FilteredSubjects;
        }
        internal static void PrintDataSubject(this List<Subject> subjects)
        {
            foreach (var item in subjects)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
