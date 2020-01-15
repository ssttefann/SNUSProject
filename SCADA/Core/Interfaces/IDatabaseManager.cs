using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Core.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDatabaseManager" in both code and config file together.
    [ServiceContract]
    public interface IDatabaseManager
    {
        [OperationContract]
        bool changeScan(string id);

        [OperationContract]
        bool addTag(Tag tag);

        [OperationContract]
        bool removeTag(string id);
    }
}
