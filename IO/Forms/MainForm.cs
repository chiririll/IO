using IO.View;
using System.Drawing;
using System.Windows.Forms;

namespace IO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawCpuMemory(object sender, PaintEventArgs e)
        {
            var grid = new Grid(new Point(0, 0), new Size(15, 20), 15);

            grid.Draw(e.Graphics, 500, Pens.LightGray);
            e.Graphics.FillRectangle(Brushes.LightBlue, new Rectangle(0, 0, 15, 20));
        }

        private void DrawExternalMemory(object sender, PaintEventArgs e)
        {
            var grid = new Grid(new Point(0, 0), new Size(15, 20), 15);

            grid.Draw(e.Graphics, 500, Pens.LightGray);
        }

        private void ChangeTransferDirection(object sender, System.EventArgs e)
        {
            if (transferDirectionBtn.Text == "--->")
                transferDirectionBtn.Text = "<---";
            else
                transferDirectionBtn.Text = "--->";
        }
    }
}
