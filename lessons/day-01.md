# Day 1: Variables and Console Output

Goal: Learn C# variables, strings, decimal numbers, and console output. Allow about 45–60 minutes for the exercise, plus setup time.

## Exercise

Create a console program with three variables:

- Customer name: Alex
- Bank name: Sample Bank
- Annual interest rate: 6.5

Expected output:

```text
Hello Alex, your annual interest rate at Sample Bank is 6.5%
```

For this exercise, `6.5` represents 6.5 percent. It is a fixed value rather than user input. Define one clear rate convention before building an API and keep the code, examples, and tests consistent with it.

## Variation

Change the customer name to Jamie and the annual interest rate to 5.75. The output should change without rewriting the output statement:

```text
Hello Jamie, your annual interest rate at Sample Bank is 5.75%
```

## Key concepts

- A variable stores a value. `customerName` is the variable name; `"Jamie"` is a string value assigned to it.
- In an interpolated string, `{customerName}` inserts the current value of that variable into the output.
- The `m` suffix in `5.75m` tells C# to treat the number as a `decimal` literal. It does not mean percent.
- The `%` character in the output string is what displays the percent sign.
- `Console.WriteLine` prints the completed line.

## Completion criteria

- The program runs and prints the expected values.
- Changing the two variables changes the output.
- Explain `string`, `decimal`, `m`, interpolation, and `Console.WriteLine` in your own words.
- Recreate the program without copying a complete solution. Looking up individual syntax is fine.

## Git practice

Review the changed files, commit the working program, and inspect the commit history. Keep generated build files out of the repository.
