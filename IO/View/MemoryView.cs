using System;
using System.Drawing;
using System.Windows.Forms;

namespace IO.View
{
    internal class MemoryView
    {
        private PictureBox pictureBox;
        private Selection selection;
        private Grid grid;


        public MemoryView(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.selection = new Selection();
            this.grid = new Grid(pictureBox, new Size(15, 20), 5000, selection);

            pictureBox.Paint += Draw;
 
            pictureBox.MouseDown += StartSelecting;
            pictureBox.MouseUp += StopSelecting;
            pictureBox.MouseMove += UpdateSelection;
        }

        ~MemoryView()
        {
            pictureBox.Paint -= Draw;
            pictureBox.MouseDown -= StartSelecting;
            pictureBox.MouseUp -= StopSelecting;
            pictureBox.MouseMove -= UpdateSelection;
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            grid.Draw(e.Graphics);
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(0, 0, 15, 20));
        }

        private void StartSelecting(object sender, MouseEventArgs e)
        {
            selection.Clear();
            var me = e as MouseEventArgs;

            var startCell = grid.GetCellIndex(me.Location);
            if (startCell < 0)
            {
                return;
            }

            selection.Start(startCell);
        }

        private void UpdateSelection(object sender, EventArgs e)
        {
            if (!selection.Selecting)
            {
                return;
            }

            var me = e as MouseEventArgs;

            var cellIndex = grid.GetCellIndex(me.Location);
            Console.WriteLine(cellIndex);

            selection.Set(cellIndex);
            pictureBox.Invalidate();
        }

        private void StopSelecting(object sender, MouseEventArgs e) => selection.Selecting = false;
    }
}
