# Kinito.DotNet.Core.GroupManagement
Kinito.DotNet.Core.GroupManagement Description

Using:

* Visual Studio 2017 or Visual Code

* dotnet core

* command prompt as administrator

## Solution & namespace

### Project Web & Adding to solution

```
mkdir src;
dotnet new sln -n Kinito.DotNet.Core.GroupManagement;
cd src;
mkdir Web;
cd Web;
dotnet new web;
cd ../..;
dotnet sln add src/Web/Web.csproj;
code .;
```
