# Breakdown Management Application

This is a simple web application to manage breakdowns. It allows users to create, update, and list breakdowns. The application is built using the following technologies:

- **C# Web API** for the backend
- **SQL Server** for the database
- **JavaScript (with AJAX)** for the frontend

## Features

- Create a new breakdown
- Update an existing breakdown
- List all breakdowns

## Data Model

The application uses the following data structure for breakdowns:

| Field                | Type          | Description                    |
|----------------------|---------------|--------------------------------|
| Breakdown Reference   | Unique String | A unique identifier for the breakdown. |
| Company Name         | String        | The name of the company.       |
| Driver Name          | String        | The name of the driver.        |
| Registration Number   | String        | The vehicle's registration number. |
| Breakdown Date       | DateTime      | The date and time of the breakdown. |

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or later)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Node.js](https://nodejs.org/) (for any frontend dependencies)

## Installation

### 1. Clone the Repository

Clone the repository to your local machine:
https://github.com/Zethembe-tech/RnRApp.git

