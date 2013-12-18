using System;
using System.ServiceModel;

namespace NorthwindWcfService.Services.Abstract
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IGeneralService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IGeneralService
    {
        [OperationContract]
        Int32 GetCustomerCount();

        [OperationContract]
        Int32 GetProductCount();
    }
}
