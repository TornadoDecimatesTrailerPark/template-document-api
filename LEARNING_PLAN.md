# C# Backend Learning Plan

This project grows from small C# exercises into a database-backed template document API. The provisional schedule is 10–12 weeks at roughly 10–15 hours per week. Progress depends on what can be implemented and explained independently.

## Stages and completion criteria

| Stage | Topics | Completion criteria |
| --- | --- | --- |
| 1: C# basics | Variables, strings, numbers, input and output, conditions, loops | Write a small program that accepts a name and rate, checks input, and prints a result. |
| 2: Organising code | Methods, classes, objects, collections, exceptions, debugging | Split template filling into steps, support multiple templates, and locate a simple bug. |
| 3: First API | HTTP, JSON, ASP.NET Core, routes, requests and responses | Accept a name and rate through an endpoint, return a result, and explain the request flow. |
| 4: Persistence | SQL, tables, keys, EF Core, migrations | Save templates and generated results, then retrieve them after restarting the program. |
| 5: Structure and reliability | Dependency injection lifetimes, layers, DTOs, status codes, logs, tests | Explain design choices and verify important success and failure cases. |
| 6: Portfolio readiness | Requirement changes, setup guide, English project walkthrough | Help another person run the project and independently implement a small change. |

## Learn Git alongside C#

- Stage 1: Inspect changes, stage files, commit, push, and read commit history.
- Stage 2: Ignore generated files and review the contents of each commit.
- Stage 3: Make a change on a feature branch and review its pull request.
- Stage 4: Record requirements and acceptance criteria in an Issue.
- Stage 5: Add GitHub Actions after a runnable project and useful tests exist.
- Stage 6: Document setup, example requests, tests, design decisions, and known limitations.

Commit when there is a real, checked change. The history should describe completed learning work accurately.

## Practice routine

1. Describe the requirement and its implementation steps in plain language.
2. Try the task independently for 10–15 minutes.
3. If stuck, consult documentation or ask for a hint and identify the specific gap.
4. After reading an example, close it and implement the solution again.
5. Change one input or requirement to check understanding.
6. Run the code, inspect the result, and commit the completed change.

## Progress log

Record the date, completed behaviour, verification, and concepts to revisit. Do not pre-fill unfinished work.

| Date | Completed behaviour | Verification | Review next |
| --- | --- | --- | --- |
| 2026-10-01 | Guided console validation and reusable methods for one year of simple interest; syntax corrected with assistance. | Console run passed; seven input cases checked against the current source, including zero and negative boundaries. No committed automated test suite yet. | English semicolon placement, consistent variable names and case, scope, and independent recreation. |
| 2026-10-01 | Added learner-written conditional branches to a provided ReadLine/TryParse scaffold in a separate input practice project. | Build passed with zero warnings and errors; saved code checked with `2000`, `0`, and `abc`. | Explain the Boolean return value and decimal output, distinguish parsing from principal validation, and recreate the flow independently. |
