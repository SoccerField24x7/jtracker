
# Project Setup
** NOTE THIS IS NOT COMPLETE **

These are just place-holder notes to job my memory

## Server installation instructions

* yum install git
* clone repo
* cd project dir
* dotnet restore
* dotnet build (instead of restore?)


## Setup Reverse Proxy

* remove app.UseHttpsRedirection() from Startup.cs
* 

## Install Test Framework

* Add new project for NUnit


## Install Entity Framework

* Install-Package MySql.Data.EntityFrameworkCore -Version 8.0.13
* `dotnet add package MySql.Data.EntityFrameworkCore --version 8.0.13`


## Migrations

### Initial Setup
`dotnet ef migrations add InitialMigration`

### Executing updates on Database
`dotnet ef database update`

### Adding new tables (Code First!)
1. Add new model into the `jtcontext/Models` folder
1. Add DbSet
1. `dotnet ef migrations add <migration-name>`
1. Execute update on database