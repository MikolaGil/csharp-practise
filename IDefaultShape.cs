using System;
using System.Collections.Generic;
using System.Text;

namespace Shape
{
    interface IDefaultShape
    {
        string ShapeType { get; set; }
        double CountSquare();
    }
}
