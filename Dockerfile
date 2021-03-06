FROM ghcr.io/tjololo/webapp-base-dotnet-base:v0.0.1-preview.6 AS build
COPY . /customize
RUN /scripts/build-app.sh

FROM mcr.microsoft.com/dotnet/aspnet:6.0.5-alpine3.15 AS final
WORKDIR /app
COPY --from=build /app/publish .
RUN addgroup -g 3000 dotnet && adduser -u 1000 -G dotnet -D -s /bin/false dotnet
USER dotnet
ENTRYPOINT ["dotnet", "Tjololo.DI.Template.dll", "--urls=http://*:8080"]
