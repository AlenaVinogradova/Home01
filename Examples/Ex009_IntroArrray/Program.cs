int Max(int arg1, int arg2, int arg3) // тип Имя (тип ИмяАргументф, ...)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
//              0    1   2   3   4   5   6   7   8
int [] array = {11, 21, 31, 44, 25, 61, 17, 28, 19};
array[0] = 13;                  //перезапись ячейки массива
Console.WriteLine(array[0]);    //вывод ячейки массива


