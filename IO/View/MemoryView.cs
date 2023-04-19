using System;
using System.Drawing;
using System.Windows.Forms;

namespace IO.View
{
    internal class MemoryView
    {
        private PictureBox pictureBox;
        private Grid grid;

        private bool selecting = false;

        public MemoryView(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.grid = new Grid(pictureBox, new Size(15, 20), 5000);

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
        }

        private void Draw(object sender, PaintEventArgs e)
        {
            grid.Draw(e.Graphics, Pens.LightGray);
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(0, 0, 15, 20));
        }

        private void UpdateSelection(object sender, EventArgs e)
        {
            if (!selecting) return;

            var me = e as MouseEventArgs;

            var cellIndex = grid.GetCellIndex(me.Location);
            Console.WriteLine(cellIndex);
        }

        private void StartSelecting(object sender, MouseEventArgs e) => selecting = true;
        private void StopSelecting(object sender, MouseEventArgs e) => selecting = false;
    }
}
