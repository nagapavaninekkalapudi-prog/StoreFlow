# StoreFlow

A simple C# console application for managing and retrieving store tasks using related JSON datasets.

## Overview

StoreFlow was created as a personal project to practise C# and .NET development, working with JSON data, relationships between datasets, and LINQ filtering.

The application allows users to find:

* High-priority tasks for a selected store
* Tasks assigned to a selected colleague
* Related colleague, department and store information

## How It Works

The application uses four JSON datasets:

* `tasks.json` – stores task information
* `colleagues.json` – stores colleague information
* `departments.json` – stores department information
* `stores.json` – stores store information

Tasks contain IDs that are used to find the related colleague, department and store.

```text
Task
 ├── AssignedToId → Colleague
 ├── DepartmentId → Department
 └── StoreId → Store
```

## Technologies

* C#
* .NET
* System.Text.Json
* LINQ
* JSON
* Visual Studio Code
* Git / GitHub

## Example

The application can ask for a store ID:

```text
Enter store ID: 1

High Priority Tasks:
Replenish milk - Pavani - Grocery - Aylesbury Store 1
```

It can also retrieve tasks assigned to a colleague:

```text
Enter colleague ID: 1

Tasks assigned to colleague:
Replenish milk - High - Open - Grocery - Aylesbury Store 1
```

## Running the Application

### Prerequisites

* .NET SDK installed
* Git (optional if cloning from GitHub)

### Run locally

Clone the repository and move into the project directory:

```bash
git clone https://github.com/nagapavaninekkalapudi-prog/StoreFlow.git
cd StoreFlow
```

Run the application:

```bash
dotnet run
```

## What I Learned

This project helped me practise:

* Working with JSON data in C#
* Deserializing JSON into C# objects
* Using IDs to connect related datasets
* Filtering collections using LINQ
* Handling cases where no matching records are found
* Building and testing a small application incrementally

## Future Improvements

Possible improvements for a future version include:

* Moving the data from JSON files to a database
* Adding automated unit tests
* Improving input validation and error handling
* Separating business logic from the console interface
* Adding a REST API
* Adding a web-based user interface

## Project Status

This is a personal learning project and represents a simple first version of the application.
