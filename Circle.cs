using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class Circle: IDefaultShape
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

        public double CountSquare()
        {
            Console.WriteLine("Enter circle radius");
            double size = Convert.ToDouble(Console.ReadLine());

            double circleSquare;
            circleSquare = Math.Pow(size, 2) * Math.PI;
            return circleSquare;
        }
    }
}
