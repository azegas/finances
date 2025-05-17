namespace finances
{
    public class Deletor
    {
        public static void DeleteById(Context context, Expense expense)
        {
            context.Remove(expense);
            context.SaveChanges();
        }
    }
}