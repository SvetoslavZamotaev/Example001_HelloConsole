int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a = 4;
int b = 6;
int c = 8;
Console.WriteLine(Max(a, b, c));
