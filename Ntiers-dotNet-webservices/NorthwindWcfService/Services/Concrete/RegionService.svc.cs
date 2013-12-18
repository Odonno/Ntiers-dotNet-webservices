using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindBLL.Managers.Abstract;
using NorthwindDAL;
using NorthwindWcfService.Services.Abstract;

namespace NorthwindWcfService.Services.Concrete
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "RegionService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez RegionService.svc ou RegionService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class RegionService : IRegionService
    {
        private readonly IRegionManager _regionManager;

        public RegionService(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }




        public IEnumerable<Region> GetRegions()
        {
            return _regionManager.Regions();
        }
    }
}
