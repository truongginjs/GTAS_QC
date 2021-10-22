# GTAS-QC
## Author
NMT, PPJ

## Create solution 
script to create
```sh
mkdir <solution>
dotnet new webapi <Project>
dotnet new xunit <Project>.Tests

dotnet new sln <solution>

dotnet sln add ./<project>/<project>.csproj
dotnet sln add ./<project>.Tests/<project>.Tests.csproj

dotnet add ./<project>.Tests/<project>.Tests.csproj reference ./<project>/<project>.Tests.csproj
```
## some library
| Package | Reference |Note|
| ------ | ------ | ------ |
| Microsoft.EntityFrameworkCore | [nuget](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore/) | ORM |
| Microsoft.EntityFrameworkCore.Design | [nuget](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Design/) | Migration |
| Microsoft.EntityFrameworkCore.Inmemory | [nuget](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Inmemory/) | DB in ram |
| Microsoft.EntityFrameworkCore.SqlServer | [nuget](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer/) | connect to sqlserver |
| AutoMapper.Extensions.Microsoft.DependencyInjection | [nuget](https://www.nuget.org/packages/AutoMapper.Extensions.Microsoft.DependencyInjection/) | mapping |
| GraphQL | [nuget](https://www.nuget.org/packages/GraphQL/) | graphql type |
| GraphQL.Server.Core | [nuget](https://www.nuget.org/packages/GraphQL.Server.Core/) | graphql server |
| GraphQL.Server.Transports.AspNetCore | [nuget](https://www.nuget.org/packages/GraphQL.Server.Transports.AspNetCore/) | auto |
| GraphQL.Server.Transports.AspNetCore.SystemTextJson | [nuget](https://www.nuget.org/packages/GraphQL.Server.Transports.AspNetCore.SystemTextJson/) | auto |
| GraphQL.Server.UI.GraphiQL | [nuget](https://www.nuget.org/packages/GraphQL.Server.UI.GraphiQL/) | graphql UI |
| Grpc.AspNetCore | [nuget](https://www.nuget.org/packages/Grpc.AspNetCore/) | grpc |
| Grpc.Tools | [nuget](https://www.nuget.org/packages/Grpc.Tools/) | grpc build proto |
|Swashbuckle.AspNetCore|[nuget](https://www.nuget.org/packages/Grpc.Tools/)|API UI|
script
```sh
dotnet add package <package>
```
## build, run, test and debug

```sh
dotnet restore
dotnet build

dotnet run
dotnet watch run

dotnet test
```

debug  press "F5" to create .vscode and debug

## migration and seeddata
```sh
dotnet-ef migrations add <Name>
dotnet-ef datate update
# down
dotnet-ef update <previous-mrg-name>
# to turn back database
dotnet-ef update 0 
dotnet-ef migrations remove #--force to force warning 
```
## envaironment

## architecture



## Docker

## License
Empty
