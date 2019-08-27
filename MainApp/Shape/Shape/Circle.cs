using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Circle: MainShape
    {
        private string _shapeType;
        public string ShapeType
        {
            get
            {
                return _shapeType;
            }
            set
            {
                _shapeType = "Circle";
            }
        }
        
        public double Square { get; set; }

        public Circle(string type)
        {
            ShapeType = type;
        }
        public double CountSquare()
        {
            Console.WriteLine("Enter circle radius");
            double size = Convert.ToDouble(Console.ReadLine());

            double circleSquare;
            circleSquare = Math.Pow(size, 2) * Math.PI;
            Square = circleSquare;

            return circleSquare;
        }
    }
}
