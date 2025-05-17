using ConsoleTables;

namespace finances
{
    public static class Tabler
    {
        public static ConsoleTable CreateTable()
        {
            var table = new ConsoleTable("id", "Amount", "Date", "Category", "Description");

            return table;
        }

    }
}
