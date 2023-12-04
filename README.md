# School Management System

This repository contains the source code for a School Management System developed using .NET Core 6, Clean Architecture, and CQRS with Event Sourcing.

## Project Overview

The School Management System is designed to efficiently handle various aspects of school management, including student enrollment, course management, teacher assignments, and more. The project is structured using Clean Architecture principles to ensure separation of concerns and maintainability.

## Technologies Used

- **.NET Core 6:** The cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications.

- **Clean Architecture:** A software design philosophy that separates concerns into distinct layers (Entities, Use Cases, and Infrastructure) to enhance maintainability and testability.

- **CQRS (Command Query Responsibility Segregation):** A pattern that separates the responsibilities of reading and writing data. Commands perform changes, and queries retrieve data, optimizing for specific use cases.

## Project Structure

The project follows a modular structure based on Clean Architecture:

- **`src/`**: Contains the source code for the application.
  - **`School.Application`**: Application layer containing use cases and application services.
  - **`School.Domain`**: Domain layer containing entities, aggregates, and domain services.
  - **`School.Infrastructure`**: Infrastructure layer containing implementation details, such as database access and external services.
  - **`School.WebApi`**: Web API layer for handling HTTP requests and serving responses.

- **`tests/`**: Contains unit tests for the application.

## Getting Started

### Prerequisites

- .NET Core 6 SDK: [Download .NET](https://dotnet.microsoft.com/download)

### Build and Run

1. Clone the repository:

   ```bash
   git clone https://github.com/YourUsername/school-management-system.git
