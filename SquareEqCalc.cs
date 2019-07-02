using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqEqCalc_v3
{
    class SquareEqCalc
    {
        public double a = 0.0;
        public double b = 0.0;
        public double c = 0.0;
        public double x1 = 0.0, x2 = 0.0;


        public int Ways()
        {
            /* a  b  c  №
               0  0  0  1
               0  0 !0  2
               0 !0  0  3
               0 !0 !0  4
              !0  0  0  5
              !0  0 !0  6
              !0 !0  0  7
              !0 !0 !0  8 */

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                        return 1;
                    else
                        return 2;
                }
                else
                {
                    if (c == 0)
                        return 3;

                    else
                        return 4;
                }
            }
            else
            {
                if (b == 0)
                {
                    if (c == 0)
                        return 5;
                    else
                        return 6;
                }
                else
                {
                    if (c == 0)
                        return 7;
                    else
                        return 8;
                }
            }

        }

        public void Solution()
        {
            double D = b * b - 4 * a * c;
            switch (Ways())
            {
                case 1:
                    {
                        break;
                    };

                case 2:
                    {
                        break;
                    };

                case 3:
                    {
                        x1 = 0;
                        break;
                    };

                case 4:
                    {
                        x1 = -c / b;
                        break;
                    };

                case 5:
                    {
                        x1 = 0;
                        break;
                    };

                case 6:
                    {
                        if (a * c < 0)
                        {
                            x1 = Math.Sqrt(-c / a);
                            x2 = -Math.Sqrt(-c / a);
                        }

                        break;
                    };

                case 7:
                    {
                        x1 = 0;
                        x2 = -b / a;
                        break;
                    };

                case 8:
                    {
                        if (D > 0)
                        {
                            x1 = (-b + Math.Sqrt(D)) / (2 * a);
                            x2 = (-b - Math.Sqrt(D)) / (2 * a);
                        }
                        else
                        {
                            if (D == 0)
                                x1 = -b / 2 * a;
                        }
                        break;

                    };
            }



        }


    }
}
