# build.ps1
# Your build commands go here
Set-Location -Path $PSScriptRoot
dotnet build "Temperature_Converter.csproj" -c Release -f net8.0-windows -o ./output