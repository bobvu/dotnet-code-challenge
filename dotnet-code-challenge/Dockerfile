# build runtime image
#FROM tells Docker that we want to base our image on the existing image (microsoft/aspnetcore:1.1), that already contains all the dependencies for running
FROM microsoft/dotnet:2.0-sdk AS build
#ARG is getting from this "docker build --build-arg var=xxx" --> ARG is "xxx"
ARG source
#WORKDIR set working directory inside the container to /app, you can access to this foder using this command "docker exec -t -i 802af9400d82 /bin/bash"
WORKDIR /app
# Make port 80 available to the world outside this container
COPY ${source:-obj/Docker/publish} .
#ENTRYPOIN to specifiy where to start building
ENTRYPOINT["dotnet", "dotnet-code-challenge.dll"]
