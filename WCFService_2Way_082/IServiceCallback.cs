using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService_2Way_082
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(CallbackContract =typeof(IClientCallback))]
    public interface IServiceCallback
    {

        [OperationContract(IsOneWay = true)]
        void gabung(string username);

        [OperationContract(IsOneWay = true)]
        void kirimPesan(string pesan);

        // TODO: Add your service operations here
    }

    
}
