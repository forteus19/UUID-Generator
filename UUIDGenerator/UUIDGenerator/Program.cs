Console.WriteLine("Enter the amount of UUIDs you want to generate: ");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------------------");

if (File.Exists("./output.txt"))
    File.Delete("./output.txt");
using StreamWriter file = new("output.txt", append: true);

for (int i = 0; i < amount; i++)
{
    Guid guid = Guid.NewGuid();
    Console.WriteLine(guid.ToString());
    await file.WriteLineAsync(guid.ToString());
}

Console.WriteLine("--------------------");
Console.WriteLine("UUIDs mirrored to output.txt");
Console.WriteLine("Press any key to exit...");
Console.ReadKey();