using finances;

public static class Seeder
{
    public static void Seed(Context context)
    {
        context.Expenses.Add(
            new Expense
            {
                Amount = 55,
                Category = "Food",
                Date = DateTime.Now,
                Description = "Delicious food krc"
            });

        context.Expenses.Add(
            new Expense
            {
                Amount = 100,
                Category = "Telefonas",
                Date = DateTime.Now,
                Description = "Brangus"
            });

        context.Expenses.Add(
            new Expense
            {
                Amount = 20,
                Category = "Kisielius",
                Date = DateTime.Now,
                Description = "Neblogas"
            });

        context.Expenses.Add(
            new Expense
            {
                Amount = 10,
                Category = "Guma",
                Date = DateTime.Now,
                Description = "Pobrange"
            });

        context.Expenses.Add(
            new Expense
            {
                Amount = 500,
                Category = "Saldytuvas",
                Date = DateTime.Now,
                Description = "Toks visai nieko"
            });

        context.SaveChanges();
    }
}