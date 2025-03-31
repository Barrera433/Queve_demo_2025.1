namespace QueueAray;

public class QueueUsingArray<T>
{
    private T[] _element;
    private int _front;
    private int _rear;
    private int _count;

    public QueueUsingArray(int capacity)
    {
        _element = new T[capacity];
        _front = 0;
        _rear = -1;
        _count = 0;
    }

    public void Enqueue(T item)
    {
        if (_count == _element.Length )
    
        {
            throw new InvalidOperationException("queue is full ");
        }
        _rear = (_rear + 1) % _element.Length;
        _element[_rear] = item;
        _count++;
    }

    public T Dequeue() 
    {
        if (_count== 0)
        {
            throw new InvalidOperationException("queue is empty ");
        }
        var item = _element[_front];
        _front = (_front + 1) % _element.Length;
        _count--;
        return item;

    }

    public T Peek()
    {
        if (_count == 0)
        {
            throw new InvalidOperationException("queue is empty");
        }
        return _element[_front];
    }



}

