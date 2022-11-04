#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Modesto.Presentation.WebAPI/Modesto.Presentation.WebAPI.csproj", "src/Modesto.Presentation.WebAPI/"]
RUN dotnet restore "src/Modesto.Presentation.WebAPI/Modesto.Presentation.WebAPI.csproj"
COPY . .
WORKDIR "/src/src/Modesto.Presentation.WebAPI"
RUN dotnet build "Modesto.Presentation.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Modesto.Presentation.WebAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Modesto.Presentation.WebAPI.dll"]