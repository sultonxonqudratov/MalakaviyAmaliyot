using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Topshiriq
{
    public class Polinom
    {
        private List<SinglePart> parts = new List<SinglePart>();
        public Polinom(params SinglePart[] parts)
        {
            this.parts.AddRange(parts.Where(x => x.Ratio != 0));
        }

        public override string ToString()
        {
            return string.Join(" + ", parts.OrderByDescending(x => x.Power));
        }

        public Polinom Diff() => new(parts.Select(x => x.Diff()).ToArray());

        public double Compute(double x)
        {
            double result = 0;
            foreach (var part in parts)
            {
                result += part.Compute(x);
            }
            return result;
        }   
    }

    public struct SinglePart
    {
        public double Ratio { get; set; }

        public int Power { get; set; }

        public SinglePart(double r, int p) 
        {
            Ratio = r;
            Power = p;
        }

        public double Compute(double x)
        {
            return Ratio * Math.Pow(x, Power);
        }

        public SinglePart Diff() => new(Math.Round(Ratio * Power, 10), Power - 1);

        public override string ToString()
        {
            if(Power == 0) return Ratio.ToString();
            return $"{Ratio}x^{Power}";
        }
    }
}
