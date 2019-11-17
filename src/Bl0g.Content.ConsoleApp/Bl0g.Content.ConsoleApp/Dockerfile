FROM mcr.microsoft.com/dotnet/core/runtime:3.0-buster-slim AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["Bl0g.Content.ConsoleApp/Bl0g.Content.ConsoleApp.csproj", "Bl0g.Content.ConsoleApp/"]
RUN dotnet restore "Bl0g.Content.ConsoleApp/Bl0g.Content.ConsoleApp.csproj"
COPY . .
WORKDIR "/src/Bl0g.Content.ConsoleApp"
RUN dotnet build "Bl0g.Content.ConsoleApp.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bl0g.Content.ConsoleApp.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Bl0g.Content.ConsoleApp.dll"]