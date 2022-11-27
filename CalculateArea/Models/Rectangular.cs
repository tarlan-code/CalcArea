using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateArea.Models
{
    internal class Rectangular:Figure
    {
        float _length;
        float _witdh;

        public float Length
        {
            get => _length;
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        
        public float Witdh
        {
            get => _witdh;
            set
            {
                if (value > 0)
                {
                    _witdh = value;
                }
            }
        }

        public Rectangular(float length,float witdh)
        {
            Length = length;
            Witdh = witdh;
        }
        public override float CalcArea()
        {
            
            return Witdh * Length;
        }
    }
}
