# ReadyToRun Benchmark
Sample solution for evaluating lambda cold-start time reduction that comes from using ReadyToRun images in .NET core 3.1.

## Requirements
* docker
* dotnet sdk 3.1
* aws cli

## Content
* `Functions` + `Dependencies` - sample lambda function and some external depenencies to make the deplyment package larger 
* `Deploy` - Dockerfile for building the lambda with ReadyToRun enabled and a PowerShell script that performs actual packaging and deployment
* `BenchmarkApp` - Console app for measuring cold-start time of a lambda function

## Usage
Adjust `Deploy/deploy.ps1` script and provide s3 bucket name for the deployments.
Run the script to build the project and run it twice to deploy two versions of the lambda function to AWS:
```
./deploy.ps1 lambda-stack-r2r $True # R2R enabled
./deploy.ps1 lambda-stack-std $False # R2R disabled
```
Build `BenchmarkApp` application and run it for both lambda functions to measure the cold-starts:
```
.\BenchmarkApp.exe lambda-stack-r2r-DoWork-1H059DI1YXHW
.\BenchmarkApp.exe lambda-stack-std-DoWork-YHYKZG9H9ETX
```
Sample output:
```
128 MB: 11,4732 s
256 MB: 5,3842 s
512 MB: 2,7544 s
1024 MB: 1,451 s
2048 MB: 0,9834 s
3008 MB: 0,1958 s
```
