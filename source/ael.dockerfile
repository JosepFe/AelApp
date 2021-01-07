FROM mcr.microsoft.com/dotnet/sdk:5.0

RUN mkdir -p /AEL
RUN mkdir -p /AEL/Services

COPY Devon4Net.Application.WebAPI /AEL/Services/Devon4Net.Application.WebAPI
COPY Devon4Net.WebAPI.Implementation /AEL/Services/Devon4Net.WebAPI.Implementation

WORKDIR /AEL/Services/Devon4Net.Application.WebAPI
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]

ENV ASPNETCORE_URLS https://0.0.0.0:8085
EXPOSE 8085/tcp
ENTRYPOINT ["dotnet", "run"]