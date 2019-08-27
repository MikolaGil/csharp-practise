using Shape.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    public class MainShape:IDefaultShape
    {
        public string ShapeType { get; set; }

        public double Square { get; set; }

        Triangle triangle = new Triangle("Triangle");
        Circle circle = new Circle("Circle");
        ShapeSquare square = new ShapeSquare("Square");
        public void GetLength()
        {
            triangle.CountSquare();
            circle.CountSquare();
            square.CountSquare();
        }
        public MainShape[] MakeArray()
        {
            MainShape[] shapeArr = new MainShape[]{ triangle, circle, square };
            return shapeArr;
        }

        public void DisplayShape()
        {
            MainShape mainShape = new MainShape();
            MainShape[] arr = mainShape.MakeArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"This is {arr[i].ShapeType}. CLR Type is {arr[i].GetType()}. Square is {arr[i].Square}\n");
                Console.Read();
            }
        }
    }
}
