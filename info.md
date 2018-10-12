Ajout dans *.csproj
````
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
````

````
dotnet restore
````

````
dotnet ef -migrations --help
````

````
dotnet ef migrations add init
dotnet ef migrations database update
````

````
dotnet ef migrations remove
````