using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclesObj
{
    internal class Circle
    {
        //properties

        public double Radius;

        //constructors 
        public Circle(double radius)
        {
            Radius = radius;

        }
        //methods
        public double CalculateCircumference()
        {
            double circumference = 0;
            //double circumference2 = 0;
            return circumference = Math.PI * Radius * 2;
            //return circumference2 = Math.Round(circumference, 2);
        }
        public string CalculateFormattedCircumference()
        {
            //CalculateCircumference();
            string circumference = ($"circumference: {FormatNumber(CalculateCircumference())}");
            return circumference;
        }
        public double CalculateArea()
        {
            double area = 0;
            //double area2 = 0;
            return area = Math.PI * Radius * Radius;
            //return area2 = Math.Round(area, 2);
        }
        public string CalculateFormattedArea()
        {
            string area = ($"area: {FormatNumber(CalculateArea())}");
            return area;

        }
        private string FormatNumber(double x)
        {
            return Math.Round(x, 2).ToString(); //old lab bring string as a string datatype.
        }

    }
}
