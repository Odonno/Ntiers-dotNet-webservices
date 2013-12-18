﻿using System;
using System.Collections.Generic;
using System.ServiceModel;
using NorthwindDAL;
using NorthwindWcfService.Infrastructure;

namespace NorthwindWcfService.Services.Abstract
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IProductService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IProductService
    {
        [OperationContract]
        [ApplyDataContractResolver]
        Products GetProduct(Int32 productID);

        [OperationContract]
        [ApplyDataContractResolver]
        IEnumerable<Products> GetProducts();

        [OperationContract]
        [ApplyDataContractResolver]
        void AddProduct(Products products);

        [OperationContract]
        [ApplyDataContractResolver]
        void RemoveProduct(Int32 productID);
    }
}