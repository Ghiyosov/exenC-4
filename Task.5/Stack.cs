namespace Task._5;

public class Stack<T>
{
    List<T> _list = new();
    public void Push(T item)
    {
        _list.Add(item);
    }
    public T Pop()
    {
        var it = _list.Last();
        _list.Remove(it);
        return it;
    }
    public T Peak()
    {
        var it = _list.Last();
        return it;
    }

}
