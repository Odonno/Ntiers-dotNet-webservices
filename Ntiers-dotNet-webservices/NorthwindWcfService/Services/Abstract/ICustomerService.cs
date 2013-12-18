﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using NorthwindDAL;
using NorthwindWcfService.Infrastructure;

namespace NorthwindWcfService.Services.Abstract
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICustomerService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        [ApplyDataContractResolver]
        Customers GetCustomer(String customerID);

        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<Customers> GetCustomers();
    }
}
