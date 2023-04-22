using System;
using System.Drawing;
using System.Windows.Forms;

namespace IO.View
{
    internal class MemoryView
    {
        private Memory memory;

        private PictureBox pictureBox;
        private Grid grid;

        public MemoryView(PictureBox pictureBox, Memory memory)
        {
            this.memory = memory;
            this.pictureBox = pictureBox;
            this.grid = new Grid(pictureBox, new Size(15, 20), memory.Size, memory.Selection);

            memory.SizeChanged += MemoryResize;
            
            pictureBox.Paint += Draw;
 
            pictureBox.MouseDown += StartSelecting;
            pictureBox.MouseUp += StopSelecting;
            pictureBox.MouseMove += UpdateSelection;
            pictureBox.Resize += ContainerResize;
        }


        ~MemoryView()
        {
            memory.SizeChanged -= MemoryResize;

            pictureBox.Paint -= Draw;

            pictureBox.MouseDown -= StartSelecting;
            pictureBox.MouseUp -= StopSelecting;
            pictureBox.MouseMove -= UpdateSelection;
            pictureBox.Resize -= ContainerResize;
        }

        public void ClearSelection()
        {
            memory.Selection.Clear();
            pictureBox.Invalidate();
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            grid.Draw(e.Graphics, memory.Cells);
        }
        
        private void MemoryResize()
        {
            grid.SetCellsCount(memory.Size);
        }

        private void StartSelecting(object sender, MouseEventArgs e)
        {
            memory.Selection.Clear();
            var me = e as MouseEventArgs;

            var startCell = grid.GetCellIndex(me.Location);
            if (startCell < 0)
            {
                return;
            }

            memory.Selection.Start(startCell);
            pictureBox.Invalidate();
        }

        private void UpdateSelection(object sender, EventArgs e)
        {
            if (!memory.Selection.Selecting)
            {
                return;
            }

            var me = e as MouseEventArgs;
            var cellIndex = grid.GetCellIndex(me.Location);

            memory.Selection.Set(cellIndex);
            pictureBox.Invalidate();
        }

        private void StopSelecting(object sender, MouseEventArgs e) => memory.Selection.Selecting = false;

        private void ContainerResize(object sender, EventArgs e)
        {
            grid.RecalculateSize();
            pictureBox.Invalidate();
        }
    }
}
