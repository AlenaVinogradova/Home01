int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 10;
int c1 = 41;
int a2 = 23;
int b2 = 25;
int c2 = 13;
int a3 = 55;
int b3 = 88;
int c3 = 23;

int max1 = Max(a1, a2, a3);
int max2 = Max(a1, a2, a3);
int max3 = Max(a1, a2, a3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);