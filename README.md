# Leave Management

## Table of Contents

- [About](#about)
- [Prerequisites](#prereq)
- [Starting the project](#start_proj)

## About <a name = "about"></a>

This is a leave management project using .Net7.

For now the UI still needs improvement.

### Prerequisites <a name = "prereq"></a>

- .Net7+ is required to run the project.
- Run this command to install the necessary SSL certificates.
```
dotnet dev-certs https --trust
```
- Before starting the project make sure to open a Package Manager Console to apply the migrations using:
```
update-database
```

### Starting the project <a name ="start_proj"> </a> 

You can run the project from the start button in Visual Studio or simply run :
```
dotnet watch
```
