param(
    [Parameter(Mandatory=$True)]
    [String]$StackName,
    [Boolean]$BuildWithR2r = $True
)

# configuration
$DeployBucket = '' # insert your bucket here
$DockerTag = 'rozchmurzeni/lambdadotnetr2r'
$Region = 'eu-central-1'

# check if docker image exists in local repository
docker image inspect $DockerTag 2>&1 | Out-Null
$imageExists = $LASTEXITCODE -eq 0

if(!$imageExists){
    # build docker image
    docker build -t rozchmurzeni/lambdadotnetr2r $PSScriptRoot
}

if($BuildWithR2r){
    # package with ReadyToRun enabled using the docker container
    docker run --rm -v $PSScriptRoot/../:/work -e PROJECT=Functions $DockerTag 
}
else{
    # package locally with ReadyToRun disabled
    dotnet lambda package --project-location $PSScriptRoot/../Functions --framework netcoreapp3.1
}

# deploy package to AWS
dotnet lambda deploy-serverless `
    --project-location $PSScriptRoot/../Functions `
    --package $PSScriptRoot/../Functions/bin/release/netcoreapp3.1/Functions.zip `
    --stack-name $StackName `
    --s3-bucket $DeployBucket `
    --template $PSScriptRoot/../Functions/application.yaml `
    --region $Region `