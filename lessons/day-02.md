# Day 2: Validation and Reusable Methods

This exercise combines decimal calculations, conditional branches, and method calls in the console application. The goal is to validate fixed inputs before calculating one year of simple interest.

## Implemented behaviour

- Principal must be greater than zero.
- Annual interest rate must be greater than or equal to zero.
- When both inputs are valid, calculate `principal * annualInterestRate / 100` and print the result with two decimal places.
- When either input is invalid, print the validation message and skip the calculation.

The sample rate `5.75m` represents 5.75 percent. This exercise assumes one year of simple interest without compounding, tax, or fees.

## Methods

| Method | Inputs | Return type | Purpose |
| --- | --- | --- | --- |
| `IsValidPrincipal` | `decimal principal` | `bool` | Return whether principal is greater than zero. |
| `IsValidAnnualInterestRate` | `decimal annualInterestRate` | `bool` | Return whether the rate is non-negative. |
| `CalculateAnnualInterest` | Principal and annual interest rate, both `decimal` | `decimal` | Return the calculated interest amount. |

The main flow calls the two validation methods with `&&`. It calls the calculation method only when both validations pass. The calculation method assumes its inputs have already been validated.

See [Program.cs](../src/TemplateDocument.Console/Program.cs) for the complete runnable implementation. In this console program, the method declarations are local functions within the generated entry point. Classes and instance methods will be introduced in a later exercise.

## Syntax to practise

Place the semicolon at the end of the `return` statement, inside the method body:

```csharp
bool IsValidPrincipal(decimal principal)
{
    return principal > 0m;
}
```

- Use an English semicolon (`;`) to end each statement. A method declaration does not need a semicolon after its closing brace.
- C# identifiers are case-sensitive: `principal` and `Principal` are different names.
- Output the variable that received the result; `annualInterest` and `calculatedInterest` are different names.
- Use `F2` for two decimal places, for example `{annualInterest:F2}`. This rounds for display only; it does not change the stored number. Display separators depend on the current culture.
- `return` sends a value back to the caller. `Console.WriteLine` displays text.
- An `if / else if / else` chain executes one branch. Independent `if` statements each evaluate their own condition.

## Verification cases

Use the following cases to check the program. The amount examples assume a culture that uses a decimal point.

All seven cases were checked against the current source on 2026-10-01 using a temporary console project with varied input values.

| Principal | Annual rate (%) | Expected behaviour |
| --- | --- | --- |
| 2000 | 5.75 | Print the greeting and `Annual interest: 115.00`. |
| 3000 | 4 | Print the greeting and `Annual interest: 120.00`. |
| 2000 | 0 | Print the greeting and `Annual interest: 0.00`. |
| 0 | 5.75 | Print only the validation message. |
| -100 | 5.75 | Print only the validation message. |
| 2000 | -1 | Print only the validation message. |
| -100 | -1 | Print only the validation message. |

Validation message:

```text
Principal must be greater than zero and annual interest rate must not be negative.
```

To reproduce a case, temporarily change `principal` and `annualInterestRate` in `Program.cs` and run:

```sh
dotnet run --project src/TemplateDocument.Console/TemplateDocument.Console.csproj
```

Restore the sample values `2000m` and `5.75m` after checking the cases. These checks exercise the current console program; a committed automated test suite is a later milestone.

## Understanding to demonstrate

- Recreate a validation method and a calculation method without copying a complete solution.
- Explain parameters, arguments, return values, and variable scope.
- Predict the result for valid, zero, and negative inputs before running the program.
- Explain why the main flow validates before calling the calculation method.
- Correct missing semicolons, inconsistent variable names, and incorrect format strings.

Running successfully confirms the implementation works for the checked cases. Independent understanding still needs practice.
