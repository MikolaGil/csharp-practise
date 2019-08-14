using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Interfaces
{
    interface IDefaultShape
    {
        string ShapeType { get; set; }
        double CountSquare();
    }
}
