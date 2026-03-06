using Xunit;

public class ArrayUtilsTests
{
    [Fact]
    public void TwoSum_ReturnsCorrectIndices()
    {
        // Arrange
        var utils = new ArrayUtils();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        // Act
        int[] result = utils.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_WorksForDifferentInput()
    {
        // Arrange
        var utils = new ArrayUtils();
        int[] nums = { 3, 2, 4 };
        int target = 6;

        // Act
        int[] result = utils.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 1, 2 }, result);
    }

    [Fact]
    public void TwoSum_WorksWithNegativeNumbers()
    {
        // Arrange
        var utils = new ArrayUtils();
        int[] nums = { -3, 4, 3, 90 };
        int target = 0;

        // Act
        int[] result = utils.TwoSum(nums, target);

        // Assert
        Assert.Equal(new int[] { 0, 2 }, result);
    }
}