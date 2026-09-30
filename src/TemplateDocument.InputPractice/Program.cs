Console.WriteLine("Enter principal:");
string? principalText = Console.ReadLine();
bool parsed = decimal.TryParse(principalText, out decimal principal);

// Check conversion before validating the principal.
// Report numeric input errors separately from non-positive principal.
// Display valid principal with two decimal places.

if (parsed == false)
{
    Console.WriteLine("Please enter a valid number.");
}
else if (parsed && principal <= 0)
{
    Console.WriteLine("Principal must be greater than zero.");
}
else
{
    Console.WriteLine($"Parsed principal: {principal:f2}");
}
