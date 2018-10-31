using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalculationLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class CalcService : ICaclcService
    {
        public OutputMatrixes SumMatrixes(InputMatrixes inputMatrixes)
        {
            // inputMatrixes.Mass_a
            OutputMatrixes mass_data = new OutputMatrixes();
            int n = inputMatrixes.Mass_b.Length;
            mass_data.Mass_summ = new double[n];
          //  double[] mass_sum = new double[n];
            for (int i = 0; i < n; i++)
                mass_data.Mass_summ[i] = inputMatrixes.Mass_a[i] + inputMatrixes.Mass_b[i];

            return mass_data;
        }
    }
}
