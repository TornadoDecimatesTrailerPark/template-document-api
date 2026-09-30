Console.WriteLine("Enter principal:");
string? principalText = Console.ReadLine();
bool parsed = decimal.TryParse(principalText, out decimal principal);

// Exercise: Add an if/else below that checks parsed.
// On success, print "Parsed principal: " and principal with two decimal places.
// On failure, print "Please enter a valid number."
// Explain why "0" and "abc" take different branches.

if (parsed) { Console.WriteLine($"Parsed principal: {principal:f2}"); } else { Console.WriteLine("Please enter a valid number."); }