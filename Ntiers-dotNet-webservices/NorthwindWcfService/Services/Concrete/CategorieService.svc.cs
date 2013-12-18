using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using NorthwindBLL.Managers.Abstract;
using NorthwindWcfService.Services.Abstract;


namespace NorthwindWcfService.Services.Concrete
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CategorieService" à la fois dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez CategorieService.svc ou CategorieService.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class CategorieService : ICategorieService
    {
        private readonly ICategoriesManager _categoriesManager;

        public CategorieService(ICategoriesManager categoriesManager)
        {
            _categoriesManager = categoriesManager;
        }


        public IEnumerable<NorthwindDAL.Categories> GetCategories()
        {
            return _categoriesManager.Categories();
        }
    }
}
