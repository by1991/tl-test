﻿namespace TL.Question2.Tests;

public class TestAddData
{
    [Fact]
    public void TestRightRightCase()
    {
        var tree = new AVL();

        var data1 = 5;
        var root1 = tree.AddData(5);
        Assert.Equal(data1, root1.Data);

        var data2 = 3;
        var root2 = tree.AddData(data2);
        Assert.Equal(data1, root2.Data);

        var data3 = 6;
        var root3 = tree.AddData(data3);
        Assert.Equal(data1, root3.Data);

        var data4 = 7;
        var root4 = tree.AddData(data4);
        Assert.Equal(data1, root4.Data);

        var data5 = 9;
        var root5 = tree.AddData(data5);
        Assert.Equal(data1, root5.Data);

        var data6 = 8;
        var root6 = tree.AddData(data6);
        Assert.Equal(data4, root6.Data);
    }

    [Fact]
    public void TestLeftLeftCase()
    {
        var tree = new AVL();

        var data1 = 9;
        var root1 = tree.AddData(data1);
        Assert.Equal(data1, root1.Data);

        var data2 = 8;
        var root2 = tree.AddData(data2);
        Assert.Equal(data1, root2.Data);

        var data3 = 7;
        var root3 = tree.AddData(data3);
        Assert.Equal(data2, root3.Data);
    }

    [Fact]
    public void TestLeftRightCase()
    {
        var tree = new AVL();

        var data1 = 9;
        var root1 = tree.AddData(data1);
        Assert.Equal(data1, root1.Data);

        var data2 = 5;
        var root2 = tree.AddData(data2);
        Assert.Equal(data1, root2.Data);

        var data3 = 10;
        var root3 = tree.AddData(data3);
        Assert.Equal(data1, root3.Data);

        var data4 = 4;
        var root4 = tree.AddData(data4);
        Assert.Equal(data1, root4.Data);

        var data5 = 7;
        var root5 = tree.AddData(data5);
        Assert.Equal(data1, root5.Data);

        var data6 = 6;
        var root6 = tree.AddData(data6);
        Assert.Equal(data5, root6.Data);
    }

    [Fact]
    public void TestRightLeftCase()
    {
        var tree = new AVL();

        var data1 = 5;
        var root1 = tree.AddData(data1);
        Assert.Equal(data1, root1.Data);

        var data2 = 4;
        var root2 = tree.AddData(data2);
        Assert.Equal(data1, root2.Data);

        var data3 = 10;
        var root3 = tree.AddData(data3);
        Assert.Equal(data1, root3.Data);

        var data4 = 7;
        var root4 = tree.AddData(data4);
        Assert.Equal(data1, root4.Data);

        var data5 = 11;
        var root5 = tree.AddData(data5);
        Assert.Equal(data1, root5.Data);

        var data6 = 6;
        var root6 = tree.AddData(data6);
        Assert.Equal(data4, root6.Data);
    }
}
