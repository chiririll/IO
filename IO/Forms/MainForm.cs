using IO.View;
using System;
using System.Windows.Forms;

namespace IO
{
    public partial class MainForm : Form
    {
        private const int tickTime = 20;

        private readonly Memory cpuMemory;
        private readonly MemoryView cpuMemoryView;

        private readonly Memory externalMemory;
        private readonly MemoryView externalMemoryView;

        private readonly TransferModel transferModel;
        private readonly TransferView transferView;

        public MainForm()
        {
            InitializeComponent();

            cpuMemory = new Memory(Convert.ToInt32(cpuMemorySize.Value), 1);
            cpuMemoryView = new MemoryView(cpuMemoryPicture, cpuMemory);

            externalMemory = new Memory(Convert.ToInt32(externalMemorySize.Value));
            externalMemoryView = new MemoryView(externalMemoryPicture, externalMemory);

            transferModel = new TransferModel(cpuMemory, externalMemory);
            transferModel.SetBlockSize(Convert.ToInt32(bytesInBlock.Value));
            transferView = new TransferView(
                transferModel,
                transferSpeed,
                transferDirectionBtn,
                transferBtn,
                cancelTransferBtn,
                stateText,
                transferProgressBar);
            transferModel.TransferStarted += DisableControls;
            transferModel.TransferEnded += EnableControls;
        }

        ~MainForm()
        {
            transferModel.TransferStarted -= DisableControls;
            transferModel.TransferEnded -= EnableControls;
        }

        private void Tick(object sender, EventArgs e)
        {
            transferModel.Tick(tickTime);
        }

        private void UpdateSettings(object sender = null, EventArgs e = null)
        {
            cpuMemory.Resize(Convert.ToInt32(cpuMemorySize.Value));
            externalMemory.Resize(Convert.ToInt32(externalMemorySize.Value));
            transferModel.SetBlockSize(Convert.ToInt32(bytesInBlock.Value));
        }

        #region Selection
        private void ClearCpuSelection(object sender, EventArgs e) => ClearSelection(true, false);
        private void ClearAllSelection(object sender, EventArgs e) => ClearSelection(true, true);
        private void ClearExternalSelection(object sender, EventArgs e) => ClearSelection(false, true);

        private void ClearSelection(bool cpu, bool ext)
        {
            if (cpu) cpuMemoryView.ClearSelection();
            if (ext) externalMemoryView.ClearSelection();
        }

        private void ClearMemoryClick(object sender, EventArgs e)
        {
            cpuMemory.ClearCellsInSelection();
            externalMemory.ClearCellsInSelection();
            ClearSelection(true, true);
        }

        private void FillMemoryClick(object sender, EventArgs e)
        {
            cpuMemory.FillCellsInSelection();
            externalMemory.FillCellsInSelection();
            //ClearSelection(true, true);
        }
        #endregion Selection

        private void DisableControls()
        {
            applySettingsButton.Enabled = false;

            clearCpuSelectionButton.Enabled = false;
            clearSelectionButton.Enabled = false;
            clearExternalSelectionButton.Enabled = false;

            fillBlocksButton.Enabled = false;
            clearBlocksButton.Enabled = false;

            cpuMemoryView.SelectionEnabled = false;
            externalMemoryView.SelectionEnabled = false;
        }

        private void EnableControls()
        {
            applySettingsButton.Enabled = true;

            clearCpuSelectionButton.Enabled = true;
            clearSelectionButton.Enabled = true;
            clearExternalSelectionButton.Enabled = true;

            fillBlocksButton.Enabled = true;
            clearBlocksButton.Enabled = true;

            cpuMemoryView.SelectionEnabled = true;
            externalMemoryView.SelectionEnabled = true;
        }
    }
}
