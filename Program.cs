using AsyncAwaitTasksSample;

Console.WriteLine("Created by : Bahareh.Smi");
Console.WriteLine("Date : 1402/04/02");
Console.WriteLine();
Console.WriteLine("-----------------------------------------------------------------------------");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Without using a Async :");
Console.WriteLine();

SampleLongProcess.LongProcess();
Console.WriteLine();

SampleShortProcess.ShortProcess();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Using a Async :");
Console.WriteLine();

SampleLongProcess.LongAsyncProcess();
Console.WriteLine();

SampleShortProcess.ShortProcess();
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("More examples to use a async  :");
Console.WriteLine();

testAsync();

static async Task testAsync()
{
    Task<int> result = SampleLongProcess.LongAsyncTaskProcess();
    SampleShortProcess.ShortProcess();
    var val = await result;
    Console.WriteLine("Result = {0}", val);
    Console.ReadKey();
}
