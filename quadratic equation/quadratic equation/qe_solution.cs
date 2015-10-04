using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quadratic_equation
{
    class qe_solution
    {
        private double a, b, c;

        private double desk;

        private List <double> roots = new List <double> ();

        public qe_solution(double _a, double _b, double _c)
        {
            a = _a;
            b = _b;
            c = _c;

            desk = Deskriminant();
        }

        public double GetDesk()
        {
            return desk;
        }

        private double Deskriminant()
        {
            return (Math.Pow(b, 2) - (4 * (a * c)));
        }

        private int rootisgood(double desk)
        {
            if (desk > 0)
                return (2);
            else if (desk == 0)
                return (1);
            else
                return (0);
        }

        public List <double> solve()
        {
            roots.Clear();

            if (rootisgood(desk) == 2)
            {
                roots.Add((-b + Math.Sqrt(desk)) / (2 * a));
                roots.Add((-b - Math.Sqrt(desk)) / (2 * a));
            }
            else if (rootisgood(desk) == 1)
            {
                roots.Add(-b / (2 * a));
            }
            else
            {
                roots.Clear();
            }

            return roots;
        }

    }
}
