using System;
using System.Drawing;
using System.Windows.Forms;

namespace IO.View
{
    internal class MemoryView
    {
        private readonly Memory memory;

        private readonly PictureBox pictureBox;
        private readonly Grid grid;

        public bool SelectionEnabled { get; set; } = true;

        public MemoryView(PictureBox pictureBox, Memory memory)
        {
            this.memory = memory;
            this.pictureBox = pictureBox;
            this.grid = new Grid(pictureBox, new Size(15, 20), memory.Size);

            memory.MemoryUpdate += MemoryUpdated;
            
            pictureBox.Paint += Draw;
 
            pictureBox.MouseDown += StartSelecting;
            pictureBox.MouseUp += StopSelecting;
            pictureBox.MouseMove += UpdateSelection;
            pictureBox.Resize += ContainerResize;
        }

        ~MemoryView()
        {
            memory.MemoryUpdate -= MemoryUpdated;

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
            grid.Draw(e.Graphics, memory.Selection, memory.Cells);
        }
        
        private void MemoryUpdated()
        {
            grid.SetCellsCount(memory.Size);
        }

        private void StartSelecting(object sender, MouseEventArgs e)
        {
            if (!SelectionEnabled) return;

            memory.Selection.Clear();

            var startCell = grid.GetCellIndex(e.Location);
            if (startCell < 0)
            {
                return;
            }

            memory.Selection.Start(startCell);
            pictureBox.Invalidate();
        }

        private void UpdateSelection(object sender, MouseEventArgs e)
        {
            if (!memory.Selection.Selecting)
            {
                return;
            }

            var cellIndex = grid.GetCellIndex(e.Location);

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
