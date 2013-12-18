using System.Collections.Generic;
using System.ServiceModel;
using NorthwindDAL;
using NorthwindWcfService.Infrastructure;

namespace NorthwindWcfService.Services.Abstract
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IRegionService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IRegionService
    {
        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<Region> GetRegions();
    }
}
