public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value < Data)
        {

            if (Left is null)
                Left = new Node(value);
            else if (Left.Data == value) { }
            else
                Left.Insert(value);
        }
        else
        {

            if (Right is null)
                Right = new Node(value);
            else if (Right.Data == value) { }
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value < Data)
        {
            if (Left is null)
                return false;

            else if (Left.Data == value)
                return true;
            else
                return Left.Contains(value);
        }
        else
        {

            if (Right is null)
                return false;

            else if (Right.Data == value)
                return true;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        if (Left is not null && Right is not null)
        {
            int left = Left.GetHeight();
            int right = Right.GetHeight();

            return Math.Max(left, right) + 1;
        }
        else if (Left is not null)
        {
            int left = Left.GetHeight(); return left + 1;
        }
        else if (Right is not null)
        {
            int right = Right.GetHeight(); return right + 1;
        }
        return 1;
    }
}