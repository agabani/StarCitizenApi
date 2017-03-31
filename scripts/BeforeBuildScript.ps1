function UpdateVersion ($path) {
    $file = Get-Item $path
    $xml = [xml](Get-Content $file)
    $node = $xml.Project.PropertyGroup
    $node.Version = "($env:APPVEYOR_BUILD_VERSION)"
    $xml.Save($file.FullName)
}

UpdateVersion ('.\StarCitizenApi\StarCitizenApi.csproj')
UpdateVersion ('.\StarCitizenApi.FileSystem\StarCitizenApi.FileSystem.csproj')
UpdateVersion ('.\StarCitizenApi.WindowsAzure\StarCitizenApi.WindowsAzure.csproj')

dotnet restore
