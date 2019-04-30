# Base image
FROM microsoft/dotnet
#FROM microsoft/aspnetcore:2.0-nanoserver-sac2016 AS base

#create a directory
RUN mkdir /app
#set it to working directory
WORKDIR /app

#define the dependencies of application
COPY MeteringService.csproj .
#download the required packages
RUN dotnet restore

# build the application
COPY . .
RUN dotnet publish -c Release -o out
#application starts and the ports it's running on.
EXPOSE 8080/tcp
EXPOSE 5443/tcp

RUN chown -R 10001:0 /app && chmod -R og+rwx /app
USER 10001

CMD ["dotnet","out/MeteringService.dll"]
