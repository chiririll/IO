using IO.View;
using System.Windows.Forms;

namespace IO
{
    public partial class MainForm : Form
    {
        private MemoryView cpuMemory;
        private MemoryView externalMemory;

        public MainForm()
        {
            InitializeComponent();

            cpuMemory = new MemoryView(cpuMemoryPicture);
            externalMemory = new MemoryView(externalMemoryPicture);
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
