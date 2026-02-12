public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }
    public Node? Parent { get; private set;}

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data) return; // no duplicates

        if (value < Data)
        {
            if (Left is null)
            {
                Left = new Node(value);
                Left.Parent = this;
            }
            else
            {
                Left.Insert(value);
            }
        }
        else
        {
            if (Right is null)
            {
                Right = new Node(value);
                Right.Parent = this;
            }
            else
            {
                Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
    {
        if (value == Data)
        {
            return true;
        }
        else if (value < Data)
        {
            if (Left is null) return false;
            else return Left.Contains(value);
        }

        if (Right is null) return false;
        else return Right.Contains(value);
    
    }

    public int GetHeight()
    {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}