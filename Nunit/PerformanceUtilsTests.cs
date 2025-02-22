using NUnit.Framework;

[TestFixture] 
public class PerformanceUtilsTests
{
    private PerformanceUtils performanceUtils;

    [SetUp] 
    public void Setup()
    {
        performanceUtils = new PerformanceUtils();
    }

    
    [Test, Timeout(2000)]
    public void LongRunningTask_ShouldFailIfTakesMoreThan2Seconds()
    {
        performanceUtils.LongRunningTask();
    }
}
