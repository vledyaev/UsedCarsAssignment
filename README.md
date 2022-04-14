# UsedCarsAssignment
Prerequisites: 
1. Build Tools for Visual Studio 2022 -> Web development build tools.
2. Entity Framework Core tools
3. node.js.

Steps to run the project:
1. Go to UsedCars.DAL folder and run `dotnet ef database update`
2. Add ASP.NET developer certificate by running `dotnet dev-certs https --trust`
3. Go to UsedCars.Web folder and run `dotnet run --launch-profile UsedCars`
4. Go to UsedCards.Web/client-app folder and run `npm start`