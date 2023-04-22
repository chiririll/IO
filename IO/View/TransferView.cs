using System;
using System.Reflection;
using System.Windows.Forms;

namespace IO
{
    public class TransferView
    {
        private readonly string cpuToExtSwitchText = "-->";
        private readonly string extToCpuSwitchText = "<--";

        private readonly string idleStateText = "Ожидание";
        private readonly string transferStateText = "Передача ({0}/{1})...";

        private readonly string messageBoxTitle = "Что-то пошло не так";
        private readonly string blocksNotSelected = "Сначала нужно выделить блоки";
        private readonly string outOfTargetMemory = "На целевом устройстве недостаточно памяти";
        private readonly string transferCompletedMessage = "Успешно передано {0} бит!";

        private readonly TransferModel model;

        private readonly NumericUpDown transferSpeedField;
        private readonly Button switchDirectionButton;
        private readonly Button startTransferButton;
        private readonly Button cancelTransferButton;
        private readonly Label stateLabel;
        private readonly ProgressBar progressBar;

        public TransferView(
            TransferModel model,
            NumericUpDown transferSpeedField,
            Button switchDirectionButton,
            Button startTransferButton,
            Button cancelTransferButton,
            Label stateLabel,
            ProgressBar progressBar)
        {
            this.model = model;

            this.transferSpeedField = transferSpeedField;
            this.switchDirectionButton = switchDirectionButton;
            this.startTransferButton = startTransferButton;
            this.cancelTransferButton = cancelTransferButton;
            this.stateLabel = stateLabel;
            this.progressBar = progressBar;

            model.SetSpeed(Convert.ToInt32(transferSpeedField.Value));

            model.StateChanged += UpdateView;
            model.ProgressUpdate += UpdateProgress;
            model.TransferCompleted += TransferCompleted;

            switchDirectionButton.Click += SwitchDirection;
            transferSpeedField.ValueChanged += ChangeSpeed;
            startTransferButton.Click += StartTransfer;
            cancelTransferButton.Click += CancelTransfer;

            UpdateView();
        }

        ~TransferView()
        {
            model.StateChanged -= UpdateView;
            model.ProgressUpdate -= UpdateProgress;
            model.TransferCompleted -= TransferCompleted;

            switchDirectionButton.Click -= SwitchDirection;
            transferSpeedField.ValueChanged -= ChangeSpeed;
            startTransferButton.Click -= StartTransfer;
            cancelTransferButton.Click -= CancelTransfer;
        }

        private void SwitchDirection(object sender, EventArgs e) => model.SwitchDirection();
        private void StartTransfer(object sender, EventArgs e)
        {
            try
            {
                model.StartTransfer();
            }
            catch (ArgumentException)
            {
                MessageBox.Show(blocksNotSelected, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(OutOfMemoryException)
            {
                MessageBox.Show(outOfTargetMemory, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CancelTransfer(object sender, EventArgs e) => model.CancelTransfer();
        private void ChangeSpeed(object sender, EventArgs e) => model.SetSpeed(Convert.ToInt32(transferSpeedField.Value));

        private void UpdateView()
        {
            switchDirectionButton.Text = model.DirectionToCpu ? extToCpuSwitchText : cpuToExtSwitchText;
            switchDirectionButton.Enabled = !model.Transfering;

            startTransferButton.Enabled = !model.Transfering;
            cancelTransferButton.Enabled = model.Transfering;

            stateLabel.Text = model.Transfering ? string.Format(transferStateText, 0, 0) : idleStateText;

            UpdateProgress();
        }

        private void UpdateProgress()
        {
            if (!model.Transfering) 
            {
                stateLabel.Text = idleStateText;
                progressBar.Maximum = 0;
                progressBar.Value = 0;
                return;
            }

            stateLabel.Text = string.Format(transferStateText, model.TransferedBits, model.TotalBits);
            progressBar.Value = model.TransferedBits;
            progressBar.Maximum = model.TotalBits;
        }

        private void TransferCompleted()
        {
            MessageBox.Show(string.Format(transferCompletedMessage, model.TotalBits));
        }
    }
}
