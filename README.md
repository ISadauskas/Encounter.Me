# EntityFramework help
 - In order to add a migration `dotnet ef migrations add <Name of migration> --output-dir Persistance/Migrations`
 - In order to update database `dotnet ef database update` 
 - In `app settings.Development.json` add your own my sql connection string 
  
Connection string example: `"ConnectionStrings": { "Database": "server=localhost;port=3306;database=encounterMe;uid=root;password=yourdbpass" },`

# Encounter.Me
This is project for Software Engineering course. The point is to develop an application for likeminded people that enjoy hiking.

Vision for this program:

An interface which allow users to create paths, see how many people have walked and are currently walking said path. being able to finish a path by finding a code.
Usage of this project:

This project helps to find interesting paths around Vilnius and also to create your own and share it with others.
How to set up:

To use this project firstly you need to register and then you can start creating your own paths.

-  Prepare ER diagram and create the database (MS SQL, but not mandatory - only important to be able to integrate to your solution).
-  Select/insert/update/delete usage.
-  LINQ usage: Join, Group, Skip and Take, Agregate function.
-  Entity Framework usage.
-  Usage of middleware and at least one interceptor
-  Unit and integration tests coverage at least 50%
-  Logging to the file or server of most important logic
