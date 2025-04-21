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

    [Fact]
    [Description("Input 222 28136664# should be show CAT&DOG")]
    public void Input_ShouldShowCATANDDOG()
    {
        var result = new Phone().OldPhonePad("222 28136664#");
        Assert.Equal("CAT&DOG", result);
    }

    [Fact]
    [Description("Input ***2222220 should be show C ")]
    public void Input_ShouldShowCWithSpace()
    {
        var result = new Phone().OldPhonePad("***2222220");
        Assert.Equal("C ",result);
    }

    [Fact]
    [Description("Input 2 should be show AD")]
    public void Input_ShouldShowJustA()
    {
        var result = new Phone().OldPhonePad("23");
        Assert.Equal("AD",result);
    }

    [Fact]
    [Description("Input #2 should be show empty")]
    public void Input_IfSharp_ShouldShowEmpty()
    {
        var result = new Phone().OldPhonePad("#2");
        Assert.Equal("",result);
    }

    [Fact]
    [Description("Input 2 should be show A")]
    public void Input_ShouldShowA()
    {
        var result = new Phone().OldPhonePad("2");
        Assert.Equal("A",result);
    }

    [Fact]
    [Description("Input *** should be show empty")]
    public void Input_IfStar_ShouldShowEmpty()
    {
        var result = new Phone().OldPhonePad("***");
        Assert.Equal("",result);
    }

    [Fact]
    [Description("Input *0*0 should be show space")]
    public void Input_IfStarBetaween_ShouldShowSpace() 
    {
        var result = new Phone().OldPhonePad("*0*0");
        Assert.Equal(" ",result);
    }

    [Fact]
    [Description("Input **222*22 should be show B")]
    public void Input_IfStarBetaween_ShouldShowB() 
    {
        var result = new Phone().OldPhonePad("**222*22");
        Assert.Equal("B",result);
    }

    [Fact]
    [Description("Input 99 should be show X")]
    public void Input_ShouldShowX() 
    {
        var result = new Phone().OldPhonePad("99");
        Assert.Equal("X",result);
    }

    [Fact]
    [Description("Input 99 999 9999* should be show XY")]
    public void Input_ShouldShowXY() 
    {
        var result = new Phone().OldPhonePad("99 999 9999*");
        Assert.Equal("XY",result);
    }
}
