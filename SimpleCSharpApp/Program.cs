Console.WriteLine("Test");

foreach (var arg in args)
{
    Console.WriteLine(arg);
}

ShowEnvironmentDetails();

Console.ReadLine();

static void ShowEnvironmentDetails()
{
    // Print out the drives on this machine,
    // and other interesting details.
    foreach (string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of processors: {0}",
    Environment.ProcessorCount);
    Console.WriteLine(".NET Core Version: {0}",
    Environment.Version);
}