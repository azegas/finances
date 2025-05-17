using finances;


var context = new Context();

if (!context.Expenses.Any())
{
    Seeder.Seed(context);
}

bool endApp = false;

Console.WriteLine("Console Finances in C#\r");
Console.WriteLine("------------------------\n");

while (!endApp)
{
    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("\ta - Print First Expense");
    Console.WriteLine("\ts - Print All Expenses");
    Console.Write("Your option? ");

    switch (Console.ReadLine())
    {
        case "a":
            Printer.PrintFirstExpense(context);
            break;
        case "s":
            Printer.PrintAllExpenses(context);
            break;
    }

    // Wait for the user to respond before closing.
    Console.WriteLine("------------------------\n");

    // Wait for the user to respond before closing.
    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n")
    {
        endApp = true;
    }

    Console.WriteLine("\n"); // Friendly linespacing.
}