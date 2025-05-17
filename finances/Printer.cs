namespace finances
{
    public static class Printer
    {
        public static void PrintAllExpenses(Context context)
        {
            var expenses = context.Expenses.ToList();

            var table = Tabler.CreateTable();

            foreach (Expense e in expenses)
            {
                table.AddRow(e.Id, e.Amount, e.Category, e.Date, e.Description);
            }

            Console.WriteLine(table);
        }

        public static void PrintFirstExpense(Context context)
        {
            var table = Tabler.CreateTable();

            var expense = context.Expenses.First();

            table.AddRow(expense.Id, expense.Amount, expense.Category, expense.Date, expense.Description);

            Console.WriteLine(table);
        }
    }
}