Ntiers-dotNet-webservices
=========================

An ASP.NET MVC project with WCF webservices using the Northwind database with Entity Framework.  

MvcApplication
------------------------

An ASP.NET MVC 4 project containing some views (__UI__ : User Interface).  
It allows users to read Categories, Customers, Orders, Products and Regions from Northwind database.  
You can also use CRUD (Create, Read, Update and Delete) on Products (with Ajax method on DELETE).  
Don't forget the Dependency Injection (Ninject) !  

### References

* External references : __Ninject__  
* Internal references : None  
* Service references : all NorthwindWcfService Services (__CategorieService__, __CustomerService__, __GeneralService__, __OrderService__, __ProductService__, __RegionService__)  

NorthwindBLL
------------------------

A Class Library project (__BLL__ : Business Logic Layer) that manages intermediate datas.  
Return logic datas from DAL.  
Don't forget the Dependency Injection (Ninject) !  

### References

* External references : __Ninject__  
* Internal references : __NorthwindDAL__  
* Service references : None  

NorthwindDAL
------------------------

A Class Library project (__DAL__ : Data Access Layer) that contains datas (managed by ORM : Entity Framework) and astracted with Repository Pattern.  

### References

* External references : __Entity Framework 6__  
* Internal references : None  
* Service references : None  

NorthwindWcfService
------------------------

A webservice application (__WCF__ : Windows Communication Foundation) that contains many services.  
A general service that contains some general datas (from the entire database / tables).  
Many services that could represent individuals tables.  
1 service = 1 manager  
Don't forget the Dependency Injection (Ninject) !  

### References

* External references : __Entity Framework 6__, __Ninject__  
* Internal references : __NorthwindDAL__, __NorthwindBLL__  
* Service references :  None

Informations
------------------------

* "1 service = 1 manager" could not be the best practice ! Stay pragmatic and keep the code as easier as you can.  
* Use DI (Ninject) as much as possible !  