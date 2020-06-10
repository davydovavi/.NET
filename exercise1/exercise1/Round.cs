using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    public class Round
    {
        public double x { get; set; }
        public double y { get; set; }
        private double _radius;
        public Round()
        {
            this.x = 0;
            this.y = 0;
            this._radius = 1;
        }

        public Round(double radius)
        {
            this.x = 0;
            this.y = 0;
            this._radius = radius;
        }
        public Round (double x, double y, double radius)
        {
            this.x = x;
            this.y = y;
            this._radius = radius;
        }
        public double Radius
        {
            set
            {
                if (value > 0)
                {
                    this._radius = value;
                }
                else
                {
                    throw new Exception("Wrong value. Value must be more than 0");
                }

            }
            get
            {
                return _radius;
            }
        }
        public double GetLength()
        {
            return 2 * Math.PI * _radius;
        }
        public double GetSquare()
        {
            return Math.PI * _radius * _radius;
        }
        public override string ToString()
        {
            return $"Radius = {_radius}, X = {x}, Y = {y}, Lenght = {GetLength()}, Square = {GetSquare()}";
        }
        
    }
}
