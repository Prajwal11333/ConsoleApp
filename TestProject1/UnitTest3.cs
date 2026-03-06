using Xunit;

public class QueueAlgorithmsTests
{
    [Fact]
    public void FirstNonRepeatingCharacter_NormalCase()
    {
        var algo = new QueueAlgorithms();

        char result = algo.FirstNonRepeatingCharacter("aabbcd");

        Assert.Equal('c', result);
    }

    [Fact]
    public void FirstNonRepeatingCharacter_AllRepeating()
    {
        var algo = new QueueAlgorithms();

        char result = algo.FirstNonRepeatingCharacter("aabb");

        Assert.Equal('#', result);
    }

    [Fact]
    public void FirstNonRepeatingCharacter_FirstCharacterUnique()
    {
        var algo = new QueueAlgorithms();

        char result = algo.FirstNonRepeatingCharacter("abcd");

        Assert.Equal('a', result);
    }

    // Edge case: single character
    [Fact]
    public void FirstNonRepeatingCharacter_SingleCharacter()
    {
        var algo = new QueueAlgorithms();

        char result = algo.FirstNonRepeatingCharacter("x");

        Assert.Equal('x', result);
    }

    // Edge case: empty string
    [Fact]
    public void FirstNonRepeatingCharacter_EmptyString()
    {
        var algo = new QueueAlgorithms();

        char result = algo.FirstNonRepeatingCharacter("");

        Assert.Equal('#', result);
    }
}