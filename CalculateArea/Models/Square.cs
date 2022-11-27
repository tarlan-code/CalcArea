using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Models
{
    internal class Square : Figure
    {
        
        float _side;

        public float Side{
            get => _side;
            set
            {
                if (value>0)
                {
                    _side = value;
                }
            } 
        }

        public Square(float side)
        {
            Side = side;
        }
        public override float CalcArea()
        {

            return Side * Side;
        }
    }
}
