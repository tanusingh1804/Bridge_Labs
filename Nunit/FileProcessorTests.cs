using NUnit.Framework;
using System;
using System.IO;

[TestFixture] 
public class FileProcessorTests
{
    private FileProcessor fileProcessor;
    private string testFilePath;

    [SetUp] 
    public void Setup()
    {
        fileProcessor = new FileProcessor();
        testFilePath = "testfile.txt"; 
    }

    [TearDown] 
    public void Cleanup()
    {
        if (File.Exists(testFilePath))
            File.Delete(testFilePath);
    }

   
    [Test]
    public void WriteToFile_And_ReadFromFile_ShouldReturnSameContent()
    {
        string content = "Hello, NUnit!";
        fileProcessor.WriteToFile(testFilePath, content);

        string result = fileProcessor.ReadFromFile(testFilePath);

        Assert.AreEqual(content, result); 
    }

    
    [Test]
    public void WriteToFile_ShouldCreateFile()
    {
        fileProcessor.WriteToFile(testFilePath, "Testing file writing.");

        Assert.IsTrue(File.Exists(testFilePath)); 
    }

    
    [Test]
    public void ReadFromFile_ShouldThrowIOException_WhenFileDoesNotExist()
    {
        Assert.Throws<IOException>(() => fileProcessor.ReadFromFile("nonexistent.txt"));
    }
}
