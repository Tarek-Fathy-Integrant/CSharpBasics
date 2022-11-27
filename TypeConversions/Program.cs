ProcessBytes();

static int Add(int x, int y)
{
    return x + y;
}

static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;

    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum = {0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
}