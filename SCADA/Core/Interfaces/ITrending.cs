using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    [ServiceContract(CallbackContract =typeof(ITrendingCallback))]
    interface ITrending
    {
        [OperationContract]
        void SubscriberInitialization();
    }
}
