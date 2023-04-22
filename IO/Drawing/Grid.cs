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

        private Selection selection;

        public Grid(PictureBox container, Size cellSize, int cellsCount, Selection selection = null)
        {
            this.CellsCount = cellsCount;

            this.container = container;
            this.offset = new Point(0, 0);
            this.cellSize = cellSize;

            this.selection = selection;
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
            CellsInRow = (container.Size.Width - offset.X) / cellSize.Width;
            RowsCount = (int)Math.Floor((float)CellsCount / CellsInRow);

            var actualHeight = 2 * offset.Y + (RowsCount + 1) * cellSize.Height + bottomOffset;
            container.Height = actualHeight;
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

        public void Draw(Graphics gfx)
        {
            RecalculateSize();
            DrawGrid(gfx, Pens.LightGray);
            DrawSelection(gfx, Pens.Red);
        }

        private void DrawGrid(Graphics gfx, Pen pen)
        {
            var rectSize = new Size(CellsInRow * cellSize.Width, RowsCount * cellSize.Height);
            var memRect = new Rectangle(offset, rectSize);

            gfx.DrawRectangle(pen, memRect);

            for (int i = 1; i < RowsCount; i++)
            {
                var yPos = offset.Y + cellSize.Height * i;
                gfx.DrawLine(pen, offset.X, yPos, offset.X + rectSize.Width, yPos);
            }

            for (int i = 1; i < CellsInRow; i++)
            {
                var xPos = offset.X + cellSize.Width * i;
                gfx.DrawLine(pen, xPos, offset.Y, xPos, offset.Y + rectSize.Height);
            }

            var inLastRow = CellsCount - RowsCount * CellsInRow;
            if (inLastRow > 0)
            {
                var yMin = offset.Y + rectSize.Height;
                var yMax = yMin + cellSize.Height;
                gfx.DrawLine(pen, offset.X, yMax, offset.X + rectSize.Width, yMax);

                for (int i = 0; i <= inLastRow; i++)
                {
                    var xPos = offset.X + cellSize.Width * i;
                    gfx.DrawLine(pen, xPos, yMin, xPos, yMax);
                }

                gfx.DrawLine(pen, offset.X + rectSize.Width, yMin, offset.X + rectSize.Width, yMax);
            }
        }

        private void DrawSelection(Graphics gfx, Pen pen)
        {
            if (selection == null || !selection.Drawable)
            {
                return;
            }

            for (int cell = selection.From; cell <= selection.To; cell++)
            {
                gfx.DrawRectangle(pen, GetCellPosition(cell), cellSize);
            }
        }
    }
}
