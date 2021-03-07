using System;
using SDev.Optim;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Optimizer.Check();
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                Console.WriteLine(msg);
            }
        }
    }
}
