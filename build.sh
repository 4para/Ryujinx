dotnet build -c Release
dotnet publish -c Release  -r linux-x64 /p:Version=1.1.1 /p:PublishProfile=PublishSingleFile
