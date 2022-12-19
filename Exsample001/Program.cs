int Max(int arg1, int arg2, int arg3);

{
    int Result = arg1; 
     if (arg2 > Result) Result = arg2;
     if (arg3 > Result) Result = arg3;  
return Result;

}

int z1 = 56;
int z2 = 93;
int z3 = 95;
int v1 = 25;
int v2 = 64;
int v3 = 41;
int e1 = 42;
int e2 = 42;
int e3 = 43;

int max1 = Max( v1,e1,z1);
int max2 = Max( v2,e2,z2);
int max3 = Max( v3,e3,z3);

int max = Max(max1, max2, max3);

Console.WriteLine(max);
