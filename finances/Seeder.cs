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

        context.SaveChanges();
    }
}