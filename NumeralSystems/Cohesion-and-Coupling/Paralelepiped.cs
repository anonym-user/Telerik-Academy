﻿using System;

namespace CohesionAndCoupling
{
    public class Paralelepiped
    {
        private double width;
        private double height;
        private double depth;

        public Paralelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentException("Width cannot be negative or zero");
                }
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    throw new ArgumentException("Height cannot be negative or zero");
                }
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }
            private set
            {
                if (value > 0)
                {
                    this.depth = value;
                }
                else
                {
                    throw new ArgumentException("Depth cannot be negative or zero");
                }
            }
        }

        public double CalcVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalcDiagonalXYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalcDiagonalXY()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalcDiagonalXZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalcDiagonalYZ()
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
