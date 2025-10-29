namespace Gruppövning_Dataspel_251029
{
    internal class User
    {
        public string Username { get; set; } = string.Empty;

        public int PIN { get; set; }

        //skapa log in
        public static void LogIn()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\nSkriv in ditt användarnamn:");
                string writtenUsername = Console.ReadLine();

                Console.Write("Skriv in din PIN-kod");
                string writtenPIN = Console.ReadLine();

                CheckPassword(writtenUsername, writtenPIN);
            }

        }

        public static bool CheckPassword(string username, string password)
        {
            
        }
    }
}
