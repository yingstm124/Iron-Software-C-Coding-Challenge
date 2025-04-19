using System.ComponentModel;
using challenge;

namespace challenge.Tests;

public class UnitTest
{
    [Fact]
    [Description("Input 222 2 22# should be show CAB")]
    public void Input_ShouldShowCAB()
    {
        var result = new Phone().OldPhonePad("222 2 22#");
        Assert.Equal("CAB", result);
    }

    [Fact]
    [Description("Input 2222 2 22# should be show AAB")]
    public void Input_ShouldShowAAB()
    {
        var result = new Phone().OldPhonePad("2222 2 22#");
        Assert.Equal("AAB", result);
    }

    [Fact]
    [Description("Input 4433555 555666# should be show HELLO")]
    public void Input_ShouldShowHello()
    {
        var result = new Phone().OldPhonePad("4433555 555666#");
        Assert.Equal("HELLO", result);
    }

    [Fact]
    [Description("Input 227*# should be show B")]
    public void Input_ShouldShowB()
    {
        var result = new Phone().OldPhonePad("227*#");
        Assert.Equal("B", result);
    }

    [Fact]
    [Description("Input 8 88777444666*664# should be show TURING")]
    public void Input_ShouldShowTuring()
    {
        var result = new Phone().OldPhonePad("8 88777444666*664#");
        Assert.Equal("TURING", result);
    }
}
