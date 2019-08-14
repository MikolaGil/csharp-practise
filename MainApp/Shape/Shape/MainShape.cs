using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class MainShape: IShape
    {
        int _shape;
        public int Shape
        {
            get
            {
                return _shape;
            }
            set
            {
                _shape = value;
            }
        }
        object[] arr;
        Triangle triangle = new Triangle("Triangle");
        Circle circle = new Circle();
        Square square = new Square();
        public void GetLength()
        {
            triangle.CountSquare();
            circle.CountSquare();
            square.CountSquare();
        }
        public void MakeArray()
        {
            object[] shapeArr = new Object[]{ triangle, circle, square };
            arr = shapeArr;
        }

        public void DisplayShape()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"This is . CLR Type is. Square is ");
                Console.Read();
            }
        }
    }
}
