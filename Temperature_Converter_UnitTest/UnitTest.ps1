# UnitTest.ps1
# Your build commands go here
Set-Location -Path $PSScriptRoot
dotnet test "Temperature_Converter_UnitTest.csproj" --logger "junit;LogFilePath=TestResults/junit-unit-test-results.xml"
