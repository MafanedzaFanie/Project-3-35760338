# CMPG-323-Project-3 - 35760338
The Development of MVC Web App

## About the project
The main purpose of this project is to enhance and improve an existing ASP.NET Core MVC web application. The main objective is to implement architectural patterns, coding principles, and design patterns that align with the project's requirements.

## Prerequisites
Here is a list of all resources used to complete this project:
+ Access the NWU Azure tenant by logging into the Azure Portal using your MS account: 12345678@mynwu.ac.za
+ Resource group on Microsoft Azure
+ Visual Studios 2022 Community edition and .NET 8
+ An existing ASP.NET Core MVC web application

## Changes made on the code:
### Created Repository folder and added Classes namely:
+ ProjectRepository
+ ClientRepository
+ GenericRepository

### Added repository classes interfaces namely:
+ IProjectRepository
+ IClientRepository
+ IGenericRepository

### Transfer data access operations
+ Transfered all data access operations from the Project controller to the Project repository.
+ Transfered all data access operations from the Client controller to the Client repository.

### Implement repository classes
+ Implemented the use of the Project repository class in the Project Controller in place of data access operations that have been transferred to the repository class.
+ Implemented the use of the Client repository class in the Client Controller in place of data access operations that have been transferred to the repository class.

## Web App User Guide
+ Run the Web App on Visual Studio, a new browser will automaticaly open.
+ Telemetry Management Portal home page will appear.
+ You must register or login.
+ Once registered you will be able to see to all the Tech Trends available at NWU.

## Web App URL

