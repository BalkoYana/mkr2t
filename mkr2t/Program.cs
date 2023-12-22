using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

////У системі потрібно виведення інформації 
/////про різні типи учасників (викладачі, студенти, технічні працівники),
///але класи не містять методів виведення. 
// дозволяє вам додати нові віртуальні операції до класу без зміни самого класу. 
namespace mkr2t
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            DistanceLearningSystem system = new DistanceLearningSystem();

            Teacher teacher = new Teacher
            {
                Name = "Андрашко Ю.В.",
                Title = "доцент",
                Degree = "к.т.н.,",
                Department = "Кафедра САТО"
            };
            system.AddParticipant(teacher);
            Teacher teacher1 = new Teacher
            {
                Name = "Маринець В.В.",
                Title = "професор",
                Degree = "д.ф.-м.н.",
                Department = "Кафедра диференціальних рівнянь"
            };
            system.AddParticipant(teacher1);

            Student student = new Student
            {
                Name = "Іваненеко І.І.,",
                Course = 3,
                Specialty = "113 – прикладна математика"
            };
            system.AddParticipant(student);

            TechnicalWorker worker = new TechnicalWorker
            {
                Name = "Роля М.Ю.,",
                Position = "лаборант"
            };
            system.AddParticipant(worker);

            system.DisplayParticipantsInfo();
        }

    }
}
