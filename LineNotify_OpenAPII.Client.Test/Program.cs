﻿namespace LineNotify_OpenAPI.Client.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Msg = "Test OK";
            try
            {
                {
                    Console.Write("input token：");
                    var token = Console.ReadLine();
                    Console.Write("message：");
                    var message = Console.ReadLine();

                    var Result = new api().notify(token, message);
                    if (Result is null) throw new Exception("result is null");

                    Console.WriteLine($"GetResult：status={Result.status};message={Result.message}");
                }
            }
            catch (Exception ex)
            {
                Msg = $"FAIL：{ex.Message}";
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine(Msg);
                Console.WriteLine();
                Console.WriteLine("press any key to exit......");
                Console.ReadKey();
            }
        }
    }
}