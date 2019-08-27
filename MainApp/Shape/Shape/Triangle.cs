using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Triangle : MainShape
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
                _shapeType = value;
            }
        }
        
        public double Square { get; set; }

        public Triangle(string type)
        {
            ShapeType = type;
        }

        public double CountSquare()
        {
            Console.WriteLine("Enter triangle side length");
            double size = Convert.ToDouble(Console.ReadLine());

            double triangleSquare;
            triangleSquare = (Math.Pow(size, 2) * Math.Sqrt(3)) / 4;
            Square = triangleSquare;

            return triangleSquare;
        }
    }
}
