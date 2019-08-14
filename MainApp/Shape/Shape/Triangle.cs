using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Triangle : IDefaultShape
    {
        string _shapeType;
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
            return triangleSquare;
        }
    }
}
