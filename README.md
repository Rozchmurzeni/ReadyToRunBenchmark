# ReadyToRun Benchmark
Sample solution for evaluating lambda cold-start time reduction that comes from using ReadyToRun images in .NET core 3.1.

## Requirements
* docker
* dotnet sdk 3.1
* aws cli

## Content
* `Functions` + `Dependencies` - sample lambda function and some external depenencies to make the deplyment package larger 
* `Deploy` - Dockerfile for building the lambda with ReadyToRun enabled and a PowerShell script that performs actual packaging and deployment

## Usage
Adjust `Deploy/deploy.ps1` script and provide s3 bucket name for the deployments.
Run the script to build the project and run it twice to deploy two versions of the lambda function to AWS:
```
./deploy.ps1 lambda-stack-r2r $True # R2R enabled
./deploy.ps1 lambda-stack-std $False # R2R disabled
```
Use our [cold-start measure app](https://github.com/Rozchmurzeni/cold-start-measure) to measure the cold-starts:
```
.\Rozchmurzeni.ColdStartMeasure.exe lambda-stack-r2r-DoWork-1H059DI1YXHW
.\Rozchmurzeni.ColdStartMeasure.exe lambda-stack-std-DoWork-YHYKZG9H9ETX
```
