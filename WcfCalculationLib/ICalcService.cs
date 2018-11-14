using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfCalculationLib
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface ICaclcService
    {

        [OperationContract]
        OutputMatrixes SumMatrixes(InputMatrixes inputMatrixes);

        // TODO: Добавьте здесь операции служб
    }
    [DataContract]
    public class InputMatrixes
    {
        double[] mass_a;
        double[] mass_b;
        [DataMember]
        public double[] Mass_a
        {
            get { return mass_a; }
            set { mass_a = value; }
        }
        public double[] Mass_b
        {
            get { return mass_b; }
            set { mass_b = value; }
        }
    }

    [DataContract]
    public class OutputMatrixes
    {
        double[] sum;

        [DataMember]
        public double[] Mass_summ
        {
            get { return sum; }
            set { sum = value; }
        }
    }

    
    
}
