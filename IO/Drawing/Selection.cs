using System;

namespace IO
{
    public class Selection : ISelection
    {
        private readonly int cellsCount;

        private int cell1;
        private int cell2;

        public Selection(int cellsCount)
        {
            this.cellsCount = cellsCount;

            Clear();
        }

        public bool Selecting { get; set; }
        public bool Valid => cell1 >= 0 && cell2 >= 0;

        public int From => Math.Min(cell1, cell2);
        public int To => Math.Max(cell1, cell2);

        public void Set(int cell1, int cell2)
        {
            this.cell1 = Clamp(cell1);
            this.cell2 = Clamp(cell2);
        }

        public void Start(int startCell)
        {
            if (startCell < 0 || startCell >= cellsCount)
            {
                return;
            }

            Selecting = true;
            cell1 = startCell;
            cell2 = startCell;
        }
        
        public void Set(int cell)
        {
            if (cell < 0 || cell >= cellsCount)
            {
                return;
            }

            cell2 = cell;
        }

        public void Clear()
        {
            Selecting = false;
            cell1 = -1;
            cell2 = -1;
        }

        private int Clamp(int cell)
        {
            if (cell < 0) return 0;
            if (cell >= cellsCount) return cellsCount - 1;
            return cell;
        }
    }
}
