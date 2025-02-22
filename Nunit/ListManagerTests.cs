using NUnit.Framework;
using System.Collections.Generic;

[TestFixture] 
public class ListManagerTests
{
    private ListManager listManager;
    private List<int> testList;

    [SetUp] 
    public void Setup()
    {
        listManager = new ListManager();
        testList = new List<int>(); 
    }

    [Test] 
    public void AddElement_ShouldIncreaseListSize()
    {
        listManager.AddElement(testList, 10);
        Assert.AreEqual(1, testList.Count);
    }

    [Test] 
    public void RemoveElement_ShouldDecreaseListSize()
    {
        testList.Add(10);
        listManager.RemoveElement(testList, 10);
        Assert.AreEqual(0, testList.Count);
    }

    [Test] 
    public void GetSize_ShouldReturnCorrectSize()
    {
        testList.Add(10);
        testList.Add(20);
        int size = listManager.GetSize(testList);
        Assert.AreEqual(2, size);
    }

    [Test] 
    public void RemoveElement_ShouldNotChangeSize_WhenElementNotFound()
    {
        testList.Add(10);
        listManager.RemoveElement(testList, 20); // 20 list me hai hi nahi
        Assert.AreEqual(1, testList.Count);
    }
}
