using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    class MainShape:IShape
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
        public void DisplayShape()
        {
            Console.WriteLine();
            Console.Read();
        }
    }
}
