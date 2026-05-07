int devideCount;

for(int i=1;i<=100;i++)
{
    devideCount =0;
    for(int j=1;j<=i;j++)
    {
        if (i % j == 0)
        {
            devideCount++;            
        }
    }
    if (devideCount==2)
    {
        Console.Write(i+",");
    }
}
