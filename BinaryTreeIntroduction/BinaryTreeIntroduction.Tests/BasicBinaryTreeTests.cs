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
        var bt = new BinaryTree(5);
        bt.Insert(7);
        bt.Insert(9);
        bt.Insert(9);
        Assert.AreEqual(4, bt.Count);
    }

    [TestMethod]
    public void TestSum()
    {
        var bt = new BinaryTree(5);
        bt.Insert(7);
        bt.Insert(9);
        Assert.AreEqual(21, bt.Sum);
    }

    [TestMethod]
    public void TestToStringExplicit()
    {
        var bt = new BinaryTree(5);
        bt.Insert(7);
        bt.Insert(9);
        Assert.AreEqual("{5, 7, 9}", bt.ToString());
    }
    [TestMethod]
    public void TestSearch()
    {
        var bt = new BinaryTree(7);
        bt.Insert(4);
        bt.Insert(9);
        bt.Insert(3);
        bt.Insert(5);
        Assert.IsTrue(bt.Contains(5));
    }

    [TestMethod]
    public void TestDeletion()
    {
        var bt = new BinaryTree(7);
        bt.Insert(4);
        bt.Insert(9);
        bt.Insert(5);
        Assert.IsTrue(bt.Delete(5));
        Assert.IsFalse(bt.Delete(5));
        Assert.IsFalse(bt.Contains(5));
        Assert.AreEqual(3, bt.Count);
    }

    [TestMethod]
    public void TestBalance()
    {
        var bt = new BinaryTree(4);
        bt.Insert(2);
        bt.Insert(6);
        bt.Insert(1);
        bt.Insert(3);//    4
        bt.Insert(5);//  2---6
        bt.Insert(7);//1--3 5--7
        Assert.IsTrue(bt.IsBalanced);
        Assert.IsTrue(false);
    }
}
