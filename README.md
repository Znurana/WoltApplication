# WoltApplication

WoltApplication is a web application developed using ASP.NET Core for managing foods, restaurants, and categories. It follows a layered architecture with a Business Logic Layer (BLL) and Data Access Layer (DAL) for improved maintainability and scalability.

## Table of Contents

- [Features](#features)
- [Project Structure](#project-structure)
- [Dependencies](#dependencies)
- [Author](#license)

## Features

- **CRUD Operations**: Provides endpoints for Create, Read, Update, and Delete operations for customers.
- **DTO Converter Mapper**: Uses DTO converter mapper for seamless data exchange between layers.
- **Entity Framework Core**: Utilizes Entity Framework Core for data access to interact with the database.


## Project Structure

The project follows a typical ASP.NET Core structure:

- **Controllers**: Contains controllers responsible for handling HTTP requests and generating responses.
- **Models**: Defines the data models used in the application.
- **DTOs**: Contains Data Transfer Objects used for transferring data between layers.
- **Services**: Contains business logic services.
- **DAL**: Data Access Layer containing database context and repository classes.
- **Mappings**: Contains configuration for DTO mappings.
- **Utilities**: Contains utility classes and helper methods.

## Dependencies

- **ASP.NET Core**: Framework for building web applications.
- **Entity Framework Core**: Object-relational mapper for .NET to interact with databases.
- **Microsoft.EntityFrameworkCore.SqlServer**: SQL Server database provider for Entity Framework Core.
- **Microsoft.AspNetCore.Mvc.NewtonsoftJson**: JSON serialization support.

## Author

https://github.com/Znurana?tab=repositories



