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
    Console.WriteLine("\tf - Print First Expense");
    Console.WriteLine("\ta - Print All Expenses");
    Console.WriteLine("\td - Delete an Expense");
    Console.Write("Your option? ");

    switch (Console.ReadLine())
    {
        case "f":
            Printer.PrintFirstExpense(context);
            break;
        case "a":
            Printer.PrintAllExpenses(context);
            break;
        case "d":
            Console.Write("Id? ");
            var userInputtedId = Int32.Parse(Console.ReadLine());
            var expenseToDelete = context.Expenses.SingleOrDefault(o => o.Id == userInputtedId);
            Deletor.DeleteById(context, expenseToDelete);
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


// TODO use all oop principles
// TODO separate bank accounts
// TODO addition possibility