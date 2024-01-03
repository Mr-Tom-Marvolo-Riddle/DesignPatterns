namespace AlgorithmsAndDataStructures.LinkedLists
{
    public class LLNode
    {
        #region Public Properties.

        public int Data { get; set; }
        public LLNode Next { get; set; }

        #endregion Public Properties.

        #region Constructors.

        public LLNode(int data)
        {
            Data = data;
        }

        public LLNode()
        {
        }

        #endregion Constructors.

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}