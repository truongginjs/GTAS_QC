# GTAS-QC

## Create solution 
script to create
```sh
mkdir <solution>
dotnet new webapi <Project>
dotnet new xunit <Project>.Tests

dotnet new sln <solution>

dotnet sln add ./<project>/<project>.csproj
dotnet sln add ./<project>.Tests/<project>.Tests.csproj

dotnet add ./<project>.Tests/<project>.Tests.csproj reference ./<project>/<project>.csproj
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
dotnet-ef database update
# down
dotnet-ef update <previous-mrg-name>
# to turn back database
dotnet-ef database update 0 
dotnet-ef migrations remove #--force to force warning 
```

## tools
```sh
#install local tool
dotnet tool install <directory> <command> [--version <version>]
#uninstall
dotnet tool uninstall <command> 
# call
dotnet <command> [args]
```

example: 
cipher tool
```sh
#install
dotnet tool install --add-source ..\..\..\BuildingBlocks\SINNIKA.Cipher\nupkg sinnika.cipher
#uninstall
dotnet tool uninstall sinnika.cipher
#encrypt
dotnet sinnika.cipher -e -t 'hello' -p 'salt'
#decrypt
dotnet sinnika.cipher -d -t '7H7lCXt6RqSyo86nMKCIvIH2dJzG3/UV0J7uJQz0StJ+2GEL5y56u1XErgP4kzbZ' -p 'salt'

```
## envaironment

## architecture & Diagram

- QC Service Classdiagram: [QC-Class-Diagram](https://drive.google.com/file/d/1K94qTuKHKrDHDywIw9APaLpHeTHf-YAe/view?usp=sharing)
- QCApp Architecture: [QC-App-Arch](https://drive.google.com/file/d/1QwGQJ9Lrs_HuDoA6GjGdC_c4yKVjLs_P/view?usp=sharing)
- Microservice architecture: [MS-Arch](https://drive.google.com/file/d/1KTeB6w2x79cIf6x9pQRtaL6MjfCTnq68/view?usp=sharing)

## Docker
## Author
NMT, PPJ
## License
Empty
