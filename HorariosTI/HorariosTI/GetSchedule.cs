using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosTI
{
    public class GetSchedule
    {
        public void ShowSchedule(List<Subject> subjectsFiltered,List<string> subjectsNames)
        {
            List<List<string>> Groups = new List<List<string>>();
            foreach (string subject in subjectsNames)
            {
                List<string> groupsList = new List<string>();
                var Filter = (from s in subjectsFiltered
                              where s.NameSubject.Equals(subject)
                              select s.Group);
                foreach (string anySubjects in Filter)
                {
                    if(!groupsList.Contains(anySubjects))
                    {
                        groupsList.Add(anySubjects);
                    }
                }
                Groups.Add(groupsList);
            }
            Console.WriteLine(Groups.Count());
            //List<Subject> subjectsSingleGroup = new List<Subject>();
            List<Subject> subjectsLUday = new List<Subject>();
            List<Subject> subjectsMAday = new List<Subject>();
            List<Subject> subjectsMIday = new List<Subject>();
            List<Subject> subjectsJUday = new List<Subject>();
            List<Subject> subjectsVIday = new List<Subject>();
            List<Subject> subjectsSAday = new List<Subject>();
            var FilterDays = (from s in subjectsFiltered
                              where s.Group.Equals(Groups[0][0]) && s.NameSubject.Equals(subjectsNames[0])
                              select s);
            foreach (Subject item in FilterDays)
            {
                switch (item.Day)
                {
                    case "LU":
                        subjectsLUday.Add(item);
                        break;
                    case "MA":
                        subjectsMAday.Add(item);
                        break;
                    case "MI":
                        subjectsMIday.Add(item);
                        break;
                    case "JU":
                        subjectsJUday.Add(item);
                        break;
                    case "VI":
                        subjectsVIday.Add(item);
                        break;
                    case "SA":
                        subjectsSAday.Add(item);
                        break;
                    default:
                        break;
                }
            }
            subjectsLUday.PrintDataSubject();
            subjectsMAday.PrintDataSubject();
            subjectsMIday.PrintDataSubject();
            subjectsJUday.PrintDataSubject();
            subjectsVIday.PrintDataSubject();
            subjectsSAday.PrintDataSubject();
        }
    }
}
