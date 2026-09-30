# Template Document API

A learning project for building a C# and ASP.NET Core API that fills text templates with a customer name and an annual interest rate, stores generated documents, and retrieves previous results.

## Current status

The C# console application validates a sample principal and annual interest rate, calculates one year of simple interest through reusable methods, and prints the amount with two decimal places. The API, database integration, and automated test suite have not been implemented yet.

The project starts with a small console application. API endpoints and persistence will be added after the underlying C# concepts have been practised.

## Planned capabilities

- Create and retrieve text templates.
- Validate a customer name and annual interest rate.
- Generate a document from a template and save its final text.
- Retrieve a generated document without changing it when its template is later edited.
- Return useful responses for invalid input and missing resources.
- Test key business rules and database-backed request flows.

## Planned technology

- C# and ASP.NET Core
- Entity Framework Core and a relational database
- xUnit for automated tests
- GitHub Actions for build and test checks once an application exists

The console exercise targets .NET 9. The framework and database provider for the later API will be recorded when that application is created.

## Run the console exercise

Install a .NET 9 SDK. From the repository root, run:

```sh
dotnet run --project src/TemplateDocument.Console/TemplateDocument.Console.csproj
```

Expected output:

```text
Hello Jamie, your annual interest rate at Sample Bank is 5.75%
Annual interest: 115.00
```

The sample principal is `2000m` and the annual interest rate is `5.75m`, representing 5.75 percent. The exercise uses `principal * annualInterestRate / 100` for one year of simple interest. Principal must be greater than zero; a zero interest rate is allowed. Invalid inputs print a validation message and skip the calculation.

This is a learning example with fixed inputs. It does not model compounding, tax, fees, or a real banking product. `F2` rounds for display to two decimal places without changing the stored amount. The example output assumes a culture that uses a decimal point.

## Learning milestones

See [LEARNING_PLAN.md](LEARNING_PLAN.md) for the staged plan and completion criteria. [Day 1](lessons/day-01.md) covers variables and console output; [Day 2](lessons/day-02.md) adds conditions, validation, and reusable methods.

Milestones are completed when their behaviour can be demonstrated and the implementation explained. Planned functionality is not treated as implemented functionality.

## Development workflow

1. Describe one small change and its expected behaviour.
2. Implement it and run the relevant checks.
3. Review the changes before committing.
4. Commit with a short description of the actual change.
5. Push the commit to GitHub after a remote repository is connected.

Early exercises may use the main branch. Once the core workflow is comfortable, use feature branches and pull requests to practise reviewing changes.

## Data and configuration

Use fictional names and sample rates. Do not commit credentials, personal customer data, or employer-owned code. Add reproducible setup and configuration instructions when database integration is implemented.

## Learning and assistance

Documentation, search, and AI assistance may support learning and debugging. Changes should be reviewed, exercised, and understood before they are presented as completed work. This is an independent educational project.

## Portfolio preparation

Before sharing a release with an application, replace this planning status with an accurate feature summary and add verified setup steps, example requests and responses, test instructions, a short architecture explanation, and known limitations.
