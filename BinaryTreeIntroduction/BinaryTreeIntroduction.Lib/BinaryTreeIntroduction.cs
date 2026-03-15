using System.Runtime.ExceptionServices;

namespace BinaryTreeIntroduction.Lib;

public class BinaryTree
{
    IntegerNode? _root;
    public BinaryTree(){ _root = null;}
    public BinaryTree(int v) {_root = new IntegerNode(v);}

    public int Count => _root == null ? 0 : _root.Count();
    public int Sum => _root == null ? 0 : _root.Sum();

    public void Insert(int v)
    {
        if (_root == null)
            _root = new IntegerNode(v);
        else
            _root.Add(v);
    }

    
    public bool Delete(int v)
    {
        if (_root == null) return false;
        else return _root.Delete(v);
    }
    public bool Contains(int v)
    {
        if (_root == null) return false;
        else return _root.Contains(v);
    }

    public override string ToString()
    {
        return _root == null ? "{}" : $"{_root}";
    }
}

public class IntegerNode
{
    int _value;
    IntegerNode? _left;
    IntegerNode? _right;
    int _count = 1;

    //internal int Count => _right == null ? 1 : 1 + _right.Count;
    internal int Sum()//Sum of values in tree
    {
        if (_left == null){
            if (_right == null) return _count*_value;
            return _count*_value + _right.Sum();
        }
        if (_right == null) return _left.Sum() + _count*_value;
        return _left.Sum() + _count*_value + _right.Sum();}
    
    internal int Count()//number of items in tree
    {
        if (_left == null){
            if (_right == null) return _count;
            return _count + _right.Count();
        }
        if (_right == null) return _left.Count() + _count;
        return _left.Count() + _count + _right.Count();
    }
    

    internal IntegerNode(int v)
    {
        _value = v;
    }

    internal void Traverse()
    {
        if (_left != null) _left.Traverse();
        if (_right != null) _right.Traverse();
    }

    internal bool Contains(int v)
    {
        if (_value == v) return true;
        if (_value < v){
            if (_left == null) return false;
            return _left.Contains(v);}
        if (_right == null) return false;
        return _right.Contains(v);
    }

    public override string ToString()
    {
        if (_right == null) {
            if (_left == null) return _value.ToString();
            return $"{_left}, {_value}";}
        if (_left == null) return $"{_left}, {_value}";
        return $"{_left}, {_value}, {_right}";
    }
    internal void Insert(int v)
    {
        IntegerNode _use;
        if (_value == v) _count ++;
        if (_value < v)  _use =_left;
        else _use = _right;
        if (_use == null) _use = new IntegerNode(v); // doesn't update original pointer?
        else _use.Insert(v);
        
    }
    internal bool Delete(int v)
    {
        IntegerNode _use;
        if (_value == v) {
            if (_count > 0) {
                _count --; 
                return true; }
            else return false; }
        if (_value < v)  _use =_left;
        else _use = _right;
        if (_use == null) return false;
        else return _use.Delete(v);
    }
}
