using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosTI
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSchedule getSchedule = new GetSchedule();
            List<Subject> subjectsList = new List<Subject>();
            subjectsList.GetSubjects();
            List<Subject> chosedSubjects = new List<Subject>();
            List<String> subjectsname = new List<String>
            {
                "INGENIERIA ECONOMICA",
                "INGLES I"
            };
            chosedSubjects = subjectsname.TakeSubjects();
            /*foreach (Subject item in chosedSubjects)
            {
                Console.WriteLine("Id:{0} Nombre:{1} Grupo:{2} Dia:{3} Hora Inicio:{4}:{5} Hora Fin: {6}:{7}",
                    item.Id, item.NameSubject, item.Group, item.Day, item.InitialHours, item.InitialMinutes, item.EndHours, item.EndMinutes);
            }*/
            getSchedule.ShowSchedule(chosedSubjects, subjectsname);
            Console.ReadKey();
        }
    }
}
