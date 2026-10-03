using System.Collections.Generic;
using System.ServiceModel;
using UzenetkuldoWCF.Models;

namespace UzenetkuldoWCF
{
    [ServiceContract]
    public interface IUzenetService
    {
        [OperationContract]
        List<Uzenet> Read();

        [OperationContract]
        string Create(Uzenet uzenet);

        [OperationContract]
        string Update(Uzenet uzenet);

        [OperationContract]
        string Delete(int id);
    }
}