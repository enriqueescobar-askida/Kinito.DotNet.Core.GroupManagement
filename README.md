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
cd src/Web;
dotnet run;
```
### Solution Web

#### Demo

https://github.com/aspnet/MetaPackages/blob/96be626c87c3ca325b18aa6653602f5e7087497f/src/Microsoft.AspNetCore/WebHost.cs#L150

