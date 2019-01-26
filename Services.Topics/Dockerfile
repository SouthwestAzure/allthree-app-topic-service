FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Services.Topics/Services.Topics.csproj", "Services.Topics/"]
RUN dotnet restore "Services.Topics/Services.Topics.csproj"
COPY . .
WORKDIR "/src/Services.Topics"
RUN dotnet build "Services.Topics.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Services.Topics.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Services.Topics.dll"]