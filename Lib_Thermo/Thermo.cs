using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_Thermo
{
    public class Thermo
    {
        public double[,] PoslCulc(double[,] u, double time, double tau, double h) {
            int a = u.GetLength(0);
            int b = u.GetLength(1);
            double[,] unew = new double[a, b];
            double Eps = tau / (h * h);
            unew = u;
            double t0 = 0;
            for (double t = t0 + tau; t <= time; t += tau) {
                for (int i = 1; i < a - 1; i++)
                    for (int j = 1; j < b - 1; j++)
                        unew[i, j] = u[i, j] + Eps * (u[i + 1, j] + u[i - 1, j] + u[i, j + 1] + u[i, j - 1] - 4 * u[i, j]);

                for (int i = 0; i < a; i++) {
                    for (int j = 0; j < b; j++) {
                        u[i, j] = unew[i, j];
                    }
                }
            }

            return u;
        }

        public double[,] ParalCulc(double[,] u, double time, double tau, double h) {
            int a = u.GetLength(0);
            int b = u.GetLength(1);
            double[,] unew = new double[a, b];
            double Eps = tau / (h * h);
            unew = u;
            double t0 = 0;
            for (double t = t0 + tau; t <= time; t += tau) {
                for (int i = 1; i < a - 1; i++) {
                    Parallel.For(1, b - 1, j => {
                        unew[i, j] = u[i, j] + Eps * (u[i + 1, j] + u[i - 1, j] + u[i, j + 1] + u[i, j - 1] - 4 * u[i, j]);
                    });
                }



                for (int i = 0; i < a; i++) {
                    for (int j = 0; j < b; j++) {
                        u[i, j] = unew[i, j];
                    }
                }
            }

            return u;
        }
    }
}
