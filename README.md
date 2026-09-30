# Template Document API

A learning project for building a C# and ASP.NET Core API that fills text templates with a customer name and an annual interest rate, stores generated documents, and retrieves previous results.

## Current status

The C# console application validates a sample principal and annual interest rate, calculates one year of simple interest through reusable methods, and prints the amount with two decimal places. The API, database integration, and automated test suite have not been implemented yet.

A separate input practice application reads console text, attempts to parse a decimal, and distinguishes invalid numeric input, non-positive principal, and valid principal.

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

The console exercises target .NET 9. The framework and database provider for the later API will be recorded when that application is created.

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

## Run the input practice exercise

From the repository root, run:

```sh
dotnet run --project src/TemplateDocument.InputPractice/TemplateDocument.InputPractice.csproj
```

Enter one value when prompted. These cases were checked against the saved implementation on 2026-10-01:

| Input | Result after the prompt |
| --- | --- |
| `2000` | `Parsed principal: 2000.00` |
| `1` | `Parsed principal: 1.00` |
| `0` | `Principal must be greater than zero.` |
| `-10` | `Principal must be greater than zero.` |
| `abc` | `Please enter a valid number.` |

`decimal.TryParse` returns a Boolean indicating whether conversion succeeded and supplies the decimal through its `out` parameter. The `parsed` variable stores that Boolean. The branch chain checks conversion first, then requires principal to be greater than zero. Parsing success alone does not establish a valid principal. The output examples assume a culture that uses a decimal point.

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
