#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.


FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

ENV DOTNET_URLS=http://+/
ENV ASPNETCORE_ENVIRONMENT "Development"
ENV API_KEY schedioB.croniFi.quora.8712327261.key
ENV SQL-CONNECTION-STRING Server=dev-crn-sql-server.database.windows.net,1433;Initial\ Catalog=dev-quora;Persist\ Security\ Info=False;User\ ID= crnsqladmin;Password=crnSQL@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection\ Timeout=30;

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["quora/quora.csproj", "quora/"]
RUN dotnet restore "quora/quora.csproj"
COPY . .
WORKDIR "/src/quora"
RUN dotnet build "quora.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "quora.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "quora.dll"]