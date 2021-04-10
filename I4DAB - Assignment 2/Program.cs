using System;

namespace I4DAB___Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Context())
			{
                System.Console.WriteLine("Should we seed data? Y/n");
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.KeyChar == 'Y')
                {
                    SeedDatabase(context);
                }

            }

        }

        private static void SeedDatabase(Context context)
        {
        


            //context.Add(PC);

            context.SaveChanges();
            System.Console.WriteLine("Data saved");
        }

    }
}
