using System;
using System.Drawing;
using System.Windows.Forms;

namespace IO.View
{
    public class Grid
    {
        private const int bottomOffset = 5;

        private PictureBox container;
        private Point offset;

        private Size cellSize;

        public Grid(PictureBox container, Size cellSize, int cellsCount)
        {
            this.CellsCount = cellsCount;

            this.container = container;
            this.offset = new Point(0, 0);
            this.cellSize = cellSize;
        }

        public int CellsCount { get; private set; }
        public int CellsInRow { get; private set; }
        public int RowsCount { get; private set; }

        public void SetCellsCount(int cellsCount)
        {
            this.CellsCount = cellsCount;

            container.Invalidate();
        }

        public void RecalculateSize()
        {
            CellsInRow = container.Size.Width / cellSize.Width;
            RowsCount = (int)Math.Floor((float)CellsCount / CellsInRow);

            var actualHeight = 2 * offset.Y + (RowsCount + 1) * cellSize.Height + bottomOffset;
            container.Height = actualHeight;
        }

        public void Draw(Graphics gfx, Pen color = default)
        {
            RecalculateSize();

            var rectSize = new Size(CellsInRow * cellSize.Width, RowsCount * cellSize.Height);
            var memRect = new Rectangle(offset, rectSize);
            
            gfx.DrawRectangle(color, memRect);

            for (int i = 1; i < RowsCount; i++)
            {
                var yPos = offset.Y + cellSize.Height * i;
                gfx.DrawLine(color, offset.X, yPos, offset.X + rectSize.Width, yPos);
            }

            for (int i = 1; i < CellsInRow; i++)
            {
                var xPos = offset.X + cellSize.Width * i;
                gfx.DrawLine(color, xPos, offset.Y, xPos, offset.Y + rectSize.Height);
            }

            var inLastRow = CellsCount - RowsCount * CellsInRow;
            if (inLastRow > 0)
            {
                var yMin = offset.Y + rectSize.Height;
                var yMax = yMin + cellSize.Height;
                gfx.DrawLine(color, offset.X, yMax, offset.X + rectSize.Width, yMax);

                for (int i = 0; i <= inLastRow; i++)
                {
                    var xPos = offset.X + cellSize.Width * i;
                    gfx.DrawLine(color, xPos, yMin, xPos, yMax);
                }

                gfx.DrawLine(color, offset.X + rectSize.Width, yMin, offset.X + rectSize.Width, yMax);
            }
        }

        public Point GetCellPosition(int index)
        {
            var y = index / CellsInRow;
            var x = index % CellsInRow;

            return new Point(offset.X + x * cellSize.Width, offset.Y + y * cellSize.Height);
        }

        public int GetCellIndex(Point pos)
        {
            var xi = (pos.X - offset.X) / cellSize.Width;
            var yi = (pos.Y - offset.Y) / cellSize.Height;
            var idx = CellsInRow * yi + xi;

            if (xi >= CellsInRow || yi >= RowsCount || idx >= CellsCount)
                return -1;

            return idx;
        }
    }
}
