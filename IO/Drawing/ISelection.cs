namespace IO
{
    public interface ISelection
    {
        int From { get; }
        int To { get; }

        void Clear();
    }
}