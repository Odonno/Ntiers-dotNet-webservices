using System.Collections.Generic;
using System.ServiceModel;
using NorthwindDAL;
using NorthwindWcfService.Infrastructure;

namespace NorthwindWcfService.Services.Abstract
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICategorieService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICategorieService
    {
        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<Categories> GetCategories();
    }
}
