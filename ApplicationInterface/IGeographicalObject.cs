using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationInterface
{
    public interface IGeographicalObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }

        string GetInformationMethod();
    }
    public class Mountain : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double HighestPoint { get; set; }

        public string GetInformationMethod()
        {
            return $"Гора: {Name} " +
                $"\nкоординати: ({X}, {Y}) " +
                $"\nнайвища точка: {HighestPoint} м.";
        }
    }
    public class River : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double FlowSpeed { get; set; }
        public double Length { get; set; }

        public string GetInformationMethod()
        {
            return $"Рiчка: {Name} " +
                $"\nкоординати: ({X}, {Y}) " +
                $"\nшвидкiсть течiї: {FlowSpeed} см/с " +
                $"\nдовжина: {Length} км.";
        }
    }
}
