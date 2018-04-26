using System;

namespace DevTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Creates a TestClient and runs the test
                TestClient testClient = new TestClient();
                testClient.ProgrammerTest();
                Console.WriteLine("All operations successful.");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Main failed.\n\n" + ex.ToString());
                Console.ReadKey();
            }
        }
    }
}
