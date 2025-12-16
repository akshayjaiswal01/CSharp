namespace FactoryDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine(" 1. MySql Server \n 2. Sql Server \n 3. Oracle Server \n 4. exit");

                Console.WriteLine("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                DataBaseFactory factory = new DataBaseFactory();

                IDatabase databaseObject = factory.getSomeDatabase(choice);

                int opChoice;

                do
                {
                    Console.WriteLine(" 1. Insert \n 2. Update \n 3. Delete \n 4. Exit");
                    Console.WriteLine("Enter Database Operation: ");
                    opChoice = Convert.ToInt32(Console.ReadLine());

                    switch (opChoice)
                    {
                        case 1:
                            databaseObject.insert();
                            break;

                        case 2:
                            databaseObject.update();
                            break;

                        case 3:
                            databaseObject.delete();
                            break;

                        case 4:
                            Console.WriteLine("Closing Database Connnection");
                            break;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                while (opChoice != 4);

                

            }
            while (choice != 4);
            
        }
    }
}
