dotnet restore ./src/Fal.sln
dotnet build --no-restore ./src/Fal.sln
dotnet test --no-build ./src/Fal.sln