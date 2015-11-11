using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace serviceConsole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int first(int count, bool hit, int[] sinkedBalls);
        [OperationContract]
        void ansage(int ansage);
        [OperationContract]
        int other(int count, int[] sinkedBalls);
    }
}
