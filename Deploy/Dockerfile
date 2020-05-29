FROM amazonlinux:2

ENV PROJECT Functions

RUN yum -y update
RUN rpm -Uvh https://packages.microsoft.com/config/centos/7/packages-microsoft-prod.rpm
RUN yum -y install dotnet-sdk-3.1
RUN yum -y install zip

RUN dotnet tool install -g Amazon.Lambda.Tools
ENV PATH="/root/.dotnet/tools:${PATH}"

RUN  mkdir /work
WORKDIR /work

CMD dotnet lambda package --project-location $PROJECT --msbuild-parameters "/p:PublishReadyToRun=true --self-contained false"