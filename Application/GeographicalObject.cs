using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public abstract class GeographicalObject
    {
        // властивості
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // віртуальний метод отримання інформації
        public virtual string GetInformationMethod()
        {
            return "Метод отримання iнформації не визначено.";
        }
    }
    public class Mountain : GeographicalObject
    {
        public double HighestPoint { get; set; }  // найвища точка в метрах

        // перевизначення методу отримання інформації
        public override string GetInformationMethod()
        {
            return $"\nГора: {Name} " +
                $"\nкоординати: ({X}, {Y}) \n" +
                $"найвища точка: {HighestPoint} м.";
        }
    }
    public class River : GeographicalObject
    {
        public double FlowSpeed { get; set; }  // см/с
        public double Length { get; set; }     // км

        // перевизначення методу отримання інформації
        public override string GetInformationMethod()
        {
            return $"Рiчка: {Name} " +
                $"\nкоординати: ({X}, {Y}) " +
                $"\nшвидкiсть течiї: {FlowSpeed} см/с " +
                $"\nдовжина: {Length} км.";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            River dunai = new River
            {
                X = 45.22,
                Y = 29.74,
                Name = "Дунай",
                Description = "Одна з найдовших рiчок Європи.",
                FlowSpeed = 200,
                Length = 2961
            };

            Mountain hoverla = new Mountain
            {
                X = 48.16,
                Y = 24.50,
                Name = "Говерла",
                Description = "Найвища точка України.",
                HighestPoint = 2061
            };

            Console.WriteLine(dunai.GetInformationMethod());
            Console.WriteLine(hoverla.GetInformationMethod());
        }
    }
}
