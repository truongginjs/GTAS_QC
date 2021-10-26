FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal AS base
WORKDIR /app
EXPOSE 80

ENV ASPNETCORE_URLS=http://+:80

FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /src
COPY ["QCService.csproj", "./"]
RUN dotnet restore "QCService.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "QCService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "QCService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "QCService.dll"]
