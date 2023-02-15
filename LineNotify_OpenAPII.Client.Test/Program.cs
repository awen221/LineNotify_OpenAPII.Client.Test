namespace LineNotify_OpenAPI.Client.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Msg = "Test OK";
            try
            {
                {
                    Console.Write("input api_url：");
                    var api_url = Console.ReadLine();
                    if (api_url is null) throw new Exception("api_url is null");

                    Console.Write("input token：");
                    var token = Console.ReadLine();
                    if (token is null) throw new Exception("token is null");

                    Console.Write("message：");
                    var message = Console.ReadLine();
                    if (message is null) throw new Exception("message is null");

                    var Result = new api().notify(api_url, token, message);

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