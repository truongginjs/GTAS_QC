#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

#FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
FROM mcr.microsoft.com/windows/nanoserver:1809-amd64 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Services/QCService/QCService/QCService.csproj", "Services/QCService/QCService/"]
COPY ["BuildingBlocks/SINNIKA.EFCore.Initialize/SINNIKA.EFCore.Initialize/SINNIKA.EFCore.Initialize.csproj", "BuildingBlocks/SINNIKA.EFCore.Initialize/SINNIKA.EFCore.Initialize/"]
COPY ["BuildingBlocks/SINNIKA.Cipher/SINNIKA.Cipher/SINNIKA.Cipher.csproj", "BuildingBlocks/SINNIKA.Cipher/SINNIKA.Cipher/"]
RUN dotnet restore "Services/QCService/QCService/QCService.csproj"
COPY . .
WORKDIR "/src/Services/QCService/QCService"
RUN dotnet build "QCService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QCService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QCService.dll"]