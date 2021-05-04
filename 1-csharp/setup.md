# Setting up a solution

## Commands

- To start up a console project for the UI run `dotnet new console --name NameOfUILayer`
- To create a class lib project for any non UI related logic run `dotnet new classlib --name NameOfLayer`
- To add a project reference, navigate to the project folder of the project you want to add a reference to and run `dotnet add reference <path to project you wanna reference>`
- To package everything in a solution, navigate to the root folder and run `dotnet new sln --name NameofSolution`
- To add projects to a solution run `dotnet sln add PathToProject`
