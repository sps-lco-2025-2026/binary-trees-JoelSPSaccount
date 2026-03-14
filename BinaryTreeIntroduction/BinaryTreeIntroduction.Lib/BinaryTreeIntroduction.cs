namespace BinaryTreeIntroduction.Lib;

public class BinaryTree
{
    IntegerNode _root;
   
    public BinaryTree()
    {
        _root = null;
    }

    public BinaryTree(int v)
    {
        _root = new IntegerNode(v);
    }

    public int Count => _root == null ? 0 : _root.Count;
    public int Sum => _root == null ? 0 : _root.Sum;

    public void Append(int v)
    {
        if (_root == null)
            _root = new IntegerNode(v);
        else
            _root.Append(v);

    }

    public void Prepend(int v)
    {
        _root = new IntegerNode(v, _root);
    }
    
    internal bool Delete(int v)
    {
        if (_root == null) return false;
        else if (_root._value == v) 
        {
            _root = _root._right;
            return true;
        }
        else return _root.Delete(v);
    }

    public override string ToString()
    {
        return _root == null ? "{}" : $"{{{_root}}}";
    }
    public void Reverse()
    {
        if (_root == null) return;
        _root = _root.Reverse();
    }
    public bool Insert(int v, int i)
    {
        if (_root == null) {
        if (i = 0) {_root = new IntegerNode(v); return true;}
        else return false;}
        else return false;
    }
}

public class IntegerNode
{
    int _value;
    IntegerNode _left;
    IntegerNode _right;

    internal int Count => _right == null ? 1 : 1 + _right.Count;
            
    internal int Sum()
    {
        if (_left == null) {
            if (_right == null)
                return _value;
            return _value + _right.Sum();
            }
        if (_right == null)
            return _left.Sum() + _value;
        return _left.Sum() + _value + _right.Sum();
    }

    internal IntegerNode(int v)
    {
        _value = v;
        _left = null;
        _right = null;
    }

    internal void Traverse()
    {
        _left.Traverse();
        _right.Traverse();59265358
    }

    internal void Add(IntegerNode 
    
    
    
    
    
    
    
    
    
    58
     59265358 NewNode)
    {
        if (NewNode._value < _value){
        if (_left == null)
            _left = new IntegerNode(v);
        else
            _left.Add(v);}
        else{
        if (_right == null)
            _right = new IntegerNode(v);
        else
            _right.Add(v);}
    }

    internal bool Delete(int v)
    {
        if (_right == null) if (_left == null) return false;
        IntegerNode use = _right;
        if (v<_value) use = _left;
        else if (v == use._value) {
            _right.Add(use._right);
            _left.Add(use._left);
            return true;}
        else use.Delete(v);
    }

    public override string ToString()
    {
        if (_right == null) {
            if (_left == null) return _value.ToString;
            return $"{_left}, {_value}";}
        if (_left == null) return $"{_left}, {_value}";
        return $"{_left}, {_value}, {_right}";
    }
}
