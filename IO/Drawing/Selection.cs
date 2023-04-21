using System;

namespace IO
{
    public class Selection
    {
        public bool Selecting { get; set; }
        public bool Drawable => From > 0 && To > 0;

        public int From { get; private set; } = -1;
        public int To { get; private set; } = -1;

        public void Set(int cell1, int cell2)
        {
            From = Math.Min(cell1, cell2);
            To = Math.Max(cell1, cell2);
        }

        public void Start(int startCell)
        {
            From = startCell;
            To = startCell;
            Selecting = true;
        }
        
        public void Set(int cell)
        {
            if (cell < From)
            {
                To = From;
                From = cell;
            }
            else
            {
                To = cell;
            }
        }

        public void Clear()
        {
            From = -1;
            To = -1;
        }
    }
}
