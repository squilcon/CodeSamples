﻿using SOLID._2.O.Bad.Enums;

namespace SOLID._2.O.Bad.Models
{
    internal class Shape
    {
        public ShapeType Type { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
    }
}