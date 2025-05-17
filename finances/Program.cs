using finances;


var context = new Context();

if (!context.Expenses.Any())
{
    Seeder.Seed(context);
}

Printer.PrintFirstExpense(context);
Printer.PrintAllExpenses(context);