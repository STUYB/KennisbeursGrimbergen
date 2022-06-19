# KennisbeursGrimbergen

This web application is developped using ASP.NET Core MVC framework with EF & Identity.


## Configuration

To start the app make sure to do the following:

1. Create a "**KennisbeursGrimbergen**" database
2. Run folowwing commands:
```shell  
dotnet ef migrations add InitialCreate
dotnet ef database update
```
This will add the tables to the **KennisbeursGrimbergen** database aswell as seeding the db with users en default data
