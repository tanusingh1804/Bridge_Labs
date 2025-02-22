using System;
using System.Threading;

public class PerformanceUtils
{
    public void LongRunningTask()
    {
        Thread.Sleep(3000); 
    }
}
