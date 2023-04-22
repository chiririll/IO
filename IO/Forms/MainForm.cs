using IO.View;
using System;
using System.Windows.Forms;

namespace IO
{
    public partial class MainForm : Form
    {
        private Memory cpuMemory;
        private Memory externalMemory;

        private MemoryView cpuMemoryView;
        private MemoryView externalMemoryView;

        public MainForm()
        {
            InitializeComponent();

            cpuMemory = new Memory(Convert.ToInt32(cpuMemorySize.Value), 1);
            externalMemory = new Memory(Convert.ToInt32(externalMemorySize.Value));

            cpuMemoryView = new MemoryView(cpuMemoryPicture, cpuMemory);
            externalMemoryView = new MemoryView(externalMemoryPicture, externalMemory);
        }

        private void ChangeTransferDirection(object sender, EventArgs e)
        {
            if (transferDirectionBtn.Text == "--->")
                transferDirectionBtn.Text = "<---";
            else
                transferDirectionBtn.Text = "--->";
        }

        private void ClearClick(object sender, EventArgs e)
        {
            cpuMemoryView.ClearSelection();
            externalMemoryView.ClearSelection();
        }

        private void UpdateSettings(object sender = null, EventArgs e = null)
        {
            cpuMemory.Resize(Convert.ToInt32(cpuMemorySize.Value));
            externalMemory.Resize(Convert.ToInt32(externalMemorySize.Value));
            // TODO: Bytes in block
        }
    }
}
