using BinaryTreeIntroduction.Lib; 

namespace BinaryTreeIntroduction.Tests;

[TestClass]
public sealed class BasicLinkedListTests
{

    [TestMethod]
    public void TestEmpty()
    {
        BinaryTree ill = new BinaryTree();
        Assert.AreEqual(0, ill.Count);
    }

    [TestMethod]
    public void TestCount()
    {
        var ill = new BinaryTree(5);
        ill.Add(7);
        ill.Add(9);
        Assert.AreEqual(3, ill.Count);
    }

    [TestMethod]
    public void TestSum()
    {
        var ill = new BinaryTree(5);
        ill.Add(7);
        ill.Add(9);
        Assert.AreEqual(21, ill.Sum);
    }

    [TestMethod]
    public void TestToStringExplicit()
    {
        var ill = new BinaryTree(5);
        ill.Add(7);
        ill.Add(9);
        Assert.AreEqual("{5, 7, 9}", ill.ToString());
    }
    
    [TestMethod]
    public void TestOrder()
    {
        var ill = new BinaryTree(5);
        ill.Add(7);
        ill.Prepend(3);
        Assert.AreEqual("{3, 5, 7}", ill.ToString());
    }


}
