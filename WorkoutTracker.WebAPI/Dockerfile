FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 45101
EXPOSE 44341

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WorkoutTracker.WebAPI/WorkoutTracker.WebAPI.csproj WorkoutTracker.WebAPI/
COPY WorkoutTracker.Services/WorkoutTracker.Core.csproj WorkoutTracker.Services/
RUN dotnet restore WorkoutTracker.WebAPI/WorkoutTracker.WebAPI.csproj
COPY . .
WORKDIR /src/WorkoutTracker.WebAPI
RUN dotnet build WorkoutTracker.WebAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WorkoutTracker.WebAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WorkoutTracker.WebAPI.dll"]
