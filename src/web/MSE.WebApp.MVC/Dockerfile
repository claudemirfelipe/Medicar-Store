#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["./web/MSE.WebApp.MVC/MSE.WebApp.MVC.csproj", "web/MSE.WebApp.MVC/"]
COPY ["./building blocks/MSE.Core/MSE.Core.csproj", "building blocks/MSE.WebAPI.Core/"]
COPY ["./building blocks/MSE.WebAPI.Core/MSE.WebAPI.Core.csproj", "building blocks/MSE.WebAPI.Core/"]

RUN dotnet restore "web/MSE.WebApp.MVC/MSE.WebApp.MVC.csproj"
COPY . .
WORKDIR "web/MSE.WebApp.MVC"
RUN dotnet build "MSE.WebApp.MVC.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MSE.WebApp.MVC.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MSE.WebApp.MVC.dll"]