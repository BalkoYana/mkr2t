using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mkr2t
{
    public class Info : Visitor
    {
        public void Visit(Teacher teacher)
        {
            Console.WriteLine($"Ім'я: {teacher.Name}, Звання: {teacher.Title}, Ступінь: {teacher.Degree},  {teacher.Department}");
        }

        public void Visit(Student student)
        {
            Console.WriteLine($"Ім'я: {student.Name}, Курс: {student.Course}, Спеціальність: {student.Specialty}");
        }

        public void Visit(TechnicalWorker worker)
        {
            Console.WriteLine($"Ім'я: {worker.Name}, Посада: {worker.Position}");
        }
    }
}
