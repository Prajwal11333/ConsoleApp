using Xunit;

public class ParenthesesCheckerTests
{
    private readonly ParenthesesChecker checker = new ParenthesesChecker();

    [Fact]
    public void Balanced_SimpleParentheses_ReturnsTrue()
    {
        Assert.True(checker.IsBalanced("()"));
    }

    [Fact]
    public void Balanced_ComplexNested_ReturnsTrue()
    {
        Assert.True(checker.IsBalanced("({[]})"));
    }

    [Fact]
    public void NotBalanced_WrongOrder_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced("([)]"));
    }

    [Fact]
    public void NotBalanced_OnlyOpeningBrackets_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced("((("));
    }

    [Fact]
    public void Balanced_EmptyString_ReturnsTrue()
    {
        Assert.True(checker.IsBalanced(""));
    }

    // Edge Case: Only closing brackets
    [Fact]
    public void NotBalanced_OnlyClosingBrackets_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced(")))"));
    }

    // Edge Case: Single bracket
    [Fact]
    public void NotBalanced_SingleOpeningBracket_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced("("));
    }

    // Edge Case: Long nested structure
    [Fact]
    public void Balanced_LongNestedStructure_ReturnsTrue()
    {
        Assert.True(checker.IsBalanced("{[()()[]]}"));
    }

    // Edge Case: Missing closing bracket
    [Fact]
    public void NotBalanced_MissingClosingBracket_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced("{[()]}("));
    }

    // Edge Case: Extra closing bracket
    [Fact]
    public void NotBalanced_ExtraClosingBracket_ReturnsFalse()
    {
        Assert.False(checker.IsBalanced("()]}"));
    }
}