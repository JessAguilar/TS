using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosTI
{
    public class Subject
    {
        public int Id { get; set; }
        public string NameSubject { get; set; }
        public string Group { get; set; }
        public int InitialHours { get; set; }
        public int InitialMinutes { get; set; }
        public int EndHours { get; set; }
        public int EndMinutes { get; set; }
        public string Day { get; set; }
        public Subject(int id, string namesubject, string group, int initialhours, int initialminutes, int endhours, int endminutes, string day)
        {
            this.Id = id;
            this.NameSubject = namesubject;
            this.Group = group;
            this.InitialHours = initialhours;
            this.InitialMinutes = initialminutes;
            this.EndHours = endhours;
            this.EndMinutes = endminutes;
            this.Day = day;
        }
        public override string ToString()
        {
            string dataSubject = string.Format("Id:{0} Nombre:{1} Grupo:{2} Dia:{3} Hora Inicio:{4}:{5} Hora Fin: {6}:{7}",
                Id,NameSubject,Group,Day,InitialHours,InitialMinutes,EndHours,EndMinutes);
            return dataSubject;
        }
    }
}
