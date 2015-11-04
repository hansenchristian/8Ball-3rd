using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _8Ball_Anwendung
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int first(int count, bool hit, int[] sinkedBalls);
        void ansage(int ansage);
        int other(int count, int[] sinkedBalls);
    }
}
