using ConsoleApp;
using Xunit;

public class SearchAlgorithmsTests
{
    [Fact]
    public void BinarySearch_TargetExists()
    {
        var algo = new SearchAlgorithms();
        int[] nums = { 1, 3, 5, 7, 9 };

        int result = algo.BinarySearch(nums, 5);

        Assert.Equal(2, result);
    }

    [Fact]
    public void BinarySearch_TargetNotFound()
    {
        var algo = new SearchAlgorithms();
        int[] nums = { 1, 3, 5, 7, 9 };

        int result = algo.BinarySearch(nums, 6);

        Assert.Equal(-1, result);
    }

    [Fact]
    public void BinarySearch_FirstElement()
    {
        var algo = new SearchAlgorithms();
        int[] nums = { 1, 3, 5, 7, 9 };

        int result = algo.BinarySearch(nums, 1);

        Assert.Equal(0, result);
    }

    [Fact]
    public void BinarySearch_LastElement()
    {
        var algo = new SearchAlgorithms();
        int[] nums = { 1, 3, 5, 7, 9 };

        int result = algo.BinarySearch(nums, 9);

        Assert.Equal(4, result);
    }

    [Fact]
    public void BinarySearch_EmptyArray()
    {
        var algo = new SearchAlgorithms();
        int[] nums = { };

        int result = algo.BinarySearch(nums, 3);

        Assert.Equal(-1, result);
    }
}