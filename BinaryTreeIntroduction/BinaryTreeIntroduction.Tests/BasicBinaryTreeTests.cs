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
        ill.Insert(7);
        ill.Insert(9);
        ill.Insert(9);
        Assert.AreEqual(4, ill.Count);
    }

    [TestMethod]
    public void TestSum()
    {
        var ill = new BinaryTree(5);
        ill.Insert(7);
        ill.Insert(9);
        Assert.AreEqual(21, ill.Sum);
    }

    [TestMethod]
    public void TestToStringExplicit()
    {
        var ill = new BinaryTree(5);
        ill.Insert(7);
        ill.Insert(9);
        Assert.AreEqual("{5, 7, 9}", ill.ToString());
    }
    [TestMethod]
    public void TestSearch()
    {
        var ill = new BinaryTree(7);
        ill.Insert(4);
        ill.Insert(9);
        ill.Insert(3);
        ill.Insert(5);
        Assert.IsTrue(ill.Contains(5));
    }
}
