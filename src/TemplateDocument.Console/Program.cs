string customerName = "Jamie";
string bankName = "Sample Bank";
decimal principal = 2000m;
decimal annualInterestRate = 5.75m;

if (IsValidPrincipal(principal) && IsValidAnnualInterestRate(annualInterestRate))
{
    decimal annualInterest = CalculateAnnualInterest(principal, annualInterestRate);
    Console.WriteLine($"Hello {customerName}, your annual interest rate at {bankName} is {annualInterestRate}%");
    Console.WriteLine($"Annual interest: {annualInterest:F2}");
}
else
{
    Console.WriteLine("Principal must be greater than zero and annual interest rate must not be negative.");
}

bool IsValidPrincipal(decimal principal)
{
    return principal > 0m;
}

bool IsValidAnnualInterestRate(decimal annualInterestRate)
{
    return annualInterestRate >= 0m;
}

decimal CalculateAnnualInterest(decimal principal, decimal annualInterestRate)
{
    return principal * annualInterestRate / 100;
}
