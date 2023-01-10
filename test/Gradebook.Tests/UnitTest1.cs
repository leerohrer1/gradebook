using System;
using Xunit;

namespace Gradebook.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Book book = new Book(); 
        book.Add(89.1);
        book.Add(90.5);
        book.Add(77.3);

        Book result = book.GetStats();

        Assert.Equal(85.6, result.Average, 1);
        Assert.Equal(90.5, result.High, 1);
        Assert.Equal(77.3, result.Low, 1);

    }
}