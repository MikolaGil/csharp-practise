using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class ShapeSquare: MainShape
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
                _shapeType = "Square";
            }
        }
        
        public double Square { get; set; }
        public ShapeSquare(string type)
        {
            ShapeType = type;
        }

        public double CountSquare()
        {
            Console.WriteLine("Enter square side length");
            double size = Convert.ToDouble(Console.ReadLine());

            double squareSquare;
            squareSquare = Math.Pow(size, 2);
            Square = squareSquare;

            return squareSquare;
        }
    }
}
