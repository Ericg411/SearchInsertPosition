namespace SearchInsertPosition.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 5;
        int answer = 2;
        int result = _test.SearchInsert(nums, target);
        Assert.AreEqual(answer, result);
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 2;
        int answer = 1;
        int result = _test.SearchInsert(nums, target);
        Assert.AreEqual(answer, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        int[] nums = { 1, 3, 5, 6 };
        int target = 7;
        int answer = 4;
        int result = _test.SearchInsert(nums, target);
        Assert.AreEqual(answer, result);
    }
}