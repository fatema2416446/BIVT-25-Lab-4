
int X = 10;
int Y = 50;
bool answer = false;
if (X >= 7)
{
    double Y1 = Y;
    double sleep_beg = 4;
    double sleep_end = 7;
    if (X % 2 == 0)
    {
        sleep_beg = sleep_beg - (X / 2) * (Y1 / 60);
        //Console.WriteLine();
        Console.WriteLine((X / 2));
        Console.WriteLine((Y / 60));
        Console.WriteLine((X / 2) * (Y1 / 60));
        Console.WriteLine(sleep_beg);
    }
    else
    {
        sleep_beg = sleep_beg - ((X + 1) / 2) * (Y / 60);
    }
    Console.WriteLine(sleep_end);
    if (7.0 <= sleep_end - sleep_beg && sleep_end - sleep_beg <= 9.0)
    {
        answer = true;
    }



}
Console.WriteLine(answer);