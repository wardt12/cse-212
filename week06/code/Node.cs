public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if(value > Data) {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        if (value == Data)
            return true;
        if (value < Data)
            return Left != null && Left.Contains(value);
        return Right != null && Right.Contains(value);

        // TODO Start Problem 2
    }

    public int GetHeight() {
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;
        // TODO Start Problem 4
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
