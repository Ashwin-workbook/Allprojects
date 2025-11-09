Console.WriteLine("Starting");
string result = await GetData();
Console.WriteLine(result);
Console.WriteLine("End");

async Task<string> GetData()
{
    Console.WriteLine("Fetch data");
    await Task.Delay(30000);
    return "Data received";
}