namespace IO
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cpuMemoryLabel = new System.Windows.Forms.Label();
            this.externalMemoryLabel = new System.Windows.Forms.Label();
            this.cpuMemoryPicture = new System.Windows.Forms.PictureBox();
            this.externalMemoryPicture = new System.Windows.Forms.PictureBox();
            this.cpuMemorySizeLabel = new System.Windows.Forms.Label();
            this.cpuMemorySize = new System.Windows.Forms.NumericUpDown();
            this.transferBtn = new System.Windows.Forms.Button();
            this.transferDirectionBtn = new System.Windows.Forms.Button();
            this.transferDirectionLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.transferProgressBar = new System.Windows.Forms.ProgressBar();
            this.stateText = new System.Windows.Forms.Label();
            this.rootTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controlsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.bytesInBlock = new System.Windows.Forms.NumericUpDown();
            this.settingsLabel = new System.Windows.Forms.Label();
            this.bytesInBlockLabel = new System.Windows.Forms.Label();
            this.externalMemorySizeLabel = new System.Windows.Forms.Label();
            this.applySettingsButton = new System.Windows.Forms.Button();
            this.externalMemorySize = new System.Windows.Forms.NumericUpDown();
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.fillBlocksButton = new System.Windows.Forms.Button();
            this.clearBlocksButton = new System.Windows.Forms.Button();
            this.memoryActionsLabel = new System.Windows.Forms.Label();
            this.selectionClearLabel = new System.Windows.Forms.Label();
            this.selectionClearButtons = new System.Windows.Forms.TableLayoutPanel();
            this.clearCpuSelectionButton = new System.Windows.Forms.Button();
            this.clearExternalSelectionButton = new System.Windows.Forms.Button();
            this.clearSelectionButton = new System.Windows.Forms.Button();
            this.selectionLabel = new System.Windows.Forms.Label();
            this.transferPanel = new System.Windows.Forms.Panel();
            this.cancelTransferBtn = new System.Windows.Forms.Button();
            this.transferLabel = new System.Windows.Forms.Label();
            this.transferSpeed = new System.Windows.Forms.NumericUpDown();
            this.transferSpeedLabel = new System.Windows.Forms.Label();
            this.processStateFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cpuMemoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cpuMemoryScrollView = new System.Windows.Forms.Panel();
            this.externalMemoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.externalMemoryScrollView = new System.Windows.Forms.Panel();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemoryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemoryPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemorySize)).BeginInit();
            this.rootTableLayout.SuspendLayout();
            this.controlsTableLayout.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bytesInBlock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemorySize)).BeginInit();
            this.selectionPanel.SuspendLayout();
            this.selectionClearButtons.SuspendLayout();
            this.transferPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferSpeed)).BeginInit();
            this.processStateFlowLayout.SuspendLayout();
            this.cpuMemoryTableLayout.SuspendLayout();
            this.cpuMemoryScrollView.SuspendLayout();
            this.externalMemoryTableLayout.SuspendLayout();
            this.externalMemoryScrollView.SuspendLayout();
            this.SuspendLayout();
            // 
            // cpuMemoryLabel
            // 
            this.cpuMemoryLabel.AutoSize = true;
            this.cpuMemoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuMemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuMemoryLabel.Location = new System.Drawing.Point(3, 0);
            this.cpuMemoryLabel.MaximumSize = new System.Drawing.Size(0, 30);
            this.cpuMemoryLabel.MinimumSize = new System.Drawing.Size(0, 30);
            this.cpuMemoryLabel.Name = "cpuMemoryLabel";
            this.cpuMemoryLabel.Size = new System.Drawing.Size(280, 30);
            this.cpuMemoryLabel.TabIndex = 1;
            this.cpuMemoryLabel.Text = "Оперативная память процессора";
            this.cpuMemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // externalMemoryLabel
            // 
            this.externalMemoryLabel.AutoSize = true;
            this.externalMemoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalMemoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.externalMemoryLabel.Location = new System.Drawing.Point(3, 0);
            this.externalMemoryLabel.MaximumSize = new System.Drawing.Size(0, 30);
            this.externalMemoryLabel.MinimumSize = new System.Drawing.Size(0, 30);
            this.externalMemoryLabel.Name = "externalMemoryLabel";
            this.externalMemoryLabel.Size = new System.Drawing.Size(280, 30);
            this.externalMemoryLabel.TabIndex = 2;
            this.externalMemoryLabel.Text = "Внешнее устройство";
            this.externalMemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuMemoryPicture
            // 
            this.cpuMemoryPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuMemoryPicture.Location = new System.Drawing.Point(0, 0);
            this.cpuMemoryPicture.Name = "cpuMemoryPicture";
            this.cpuMemoryPicture.Size = new System.Drawing.Size(280, 275);
            this.cpuMemoryPicture.TabIndex = 3;
            this.cpuMemoryPicture.TabStop = false;
            // 
            // externalMemoryPicture
            // 
            this.externalMemoryPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.externalMemoryPicture.Location = new System.Drawing.Point(0, 0);
            this.externalMemoryPicture.Name = "externalMemoryPicture";
            this.externalMemoryPicture.Size = new System.Drawing.Size(280, 275);
            this.externalMemoryPicture.TabIndex = 4;
            this.externalMemoryPicture.TabStop = false;
            // 
            // cpuMemorySizeLabel
            // 
            this.cpuMemorySizeLabel.AutoSize = true;
            this.cpuMemorySizeLabel.Location = new System.Drawing.Point(5, 30);
            this.cpuMemorySizeLabel.Name = "cpuMemorySizeLabel";
            this.cpuMemorySizeLabel.Size = new System.Drawing.Size(217, 13);
            this.cpuMemorySizeLabel.TabIndex = 5;
            this.cpuMemorySizeLabel.Text = "Размер оперативерй памяти процессора";
            // 
            // cpuMemorySize
            // 
            this.cpuMemorySize.Location = new System.Drawing.Point(5, 46);
            this.cpuMemorySize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cpuMemorySize.Name = "cpuMemorySize";
            this.cpuMemorySize.Size = new System.Drawing.Size(230, 20);
            this.cpuMemorySize.TabIndex = 6;
            this.cpuMemorySize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(135, 114);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(100, 23);
            this.transferBtn.TabIndex = 8;
            this.transferBtn.Text = "Передать";
            this.transferBtn.UseVisualStyleBackColor = true;
            // 
            // transferDirectionBtn
            // 
            this.transferDirectionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transferDirectionBtn.Location = new System.Drawing.Point(5, 85);
            this.transferDirectionBtn.Name = "transferDirectionBtn";
            this.transferDirectionBtn.Size = new System.Drawing.Size(230, 23);
            this.transferDirectionBtn.TabIndex = 9;
            this.transferDirectionBtn.Text = "--->";
            this.transferDirectionBtn.UseVisualStyleBackColor = true;
            // 
            // transferDirectionLabel
            // 
            this.transferDirectionLabel.AutoSize = true;
            this.transferDirectionLabel.Location = new System.Drawing.Point(5, 69);
            this.transferDirectionLabel.Name = "transferDirectionLabel";
            this.transferDirectionLabel.Size = new System.Drawing.Size(125, 13);
            this.transferDirectionLabel.TabIndex = 10;
            this.transferDirectionLabel.Text = "Направление передачи";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(3, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(134, 13);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "Состояние процесса:";
            // 
            // transferProgressBar
            // 
            this.transferProgressBar.Location = new System.Drawing.Point(5, 143);
            this.transferProgressBar.Name = "transferProgressBar";
            this.transferProgressBar.Size = new System.Drawing.Size(230, 23);
            this.transferProgressBar.TabIndex = 12;
            this.transferProgressBar.Value = 30;
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.Location = new System.Drawing.Point(3, 13);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(112, 13);
            this.stateText.TabIndex = 13;
            this.stateText.Text = "Передача (300/1000)";
            // 
            // rootTableLayout
            // 
            this.rootTableLayout.ColumnCount = 3;
            this.rootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.rootTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.rootTableLayout.Controls.Add(this.controlsTableLayout, 1, 0);
            this.rootTableLayout.Controls.Add(this.cpuMemoryTableLayout, 0, 0);
            this.rootTableLayout.Controls.Add(this.externalMemoryTableLayout, 2, 0);
            this.rootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rootTableLayout.Name = "rootTableLayout";
            this.rootTableLayout.RowCount = 1;
            this.rootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTableLayout.Size = new System.Drawing.Size(834, 531);
            this.rootTableLayout.TabIndex = 15;
            // 
            // controlsTableLayout
            // 
            this.controlsTableLayout.AutoSize = true;
            this.controlsTableLayout.ColumnCount = 1;
            this.controlsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.controlsTableLayout.Controls.Add(this.settingsPanel, 0, 0);
            this.controlsTableLayout.Controls.Add(this.selectionPanel, 0, 1);
            this.controlsTableLayout.Controls.Add(this.transferPanel, 0, 2);
            this.controlsTableLayout.Location = new System.Drawing.Point(295, 3);
            this.controlsTableLayout.Name = "controlsTableLayout";
            this.controlsTableLayout.RowCount = 3;
            this.controlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.controlsTableLayout.Size = new System.Drawing.Size(244, 521);
            this.controlsTableLayout.TabIndex = 24;
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.Controls.Add(this.bytesInBlock);
            this.settingsPanel.Controls.Add(this.settingsLabel);
            this.settingsPanel.Controls.Add(this.bytesInBlockLabel);
            this.settingsPanel.Controls.Add(this.cpuMemorySizeLabel);
            this.settingsPanel.Controls.Add(this.cpuMemorySize);
            this.settingsPanel.Controls.Add(this.externalMemorySizeLabel);
            this.settingsPanel.Controls.Add(this.applySettingsButton);
            this.settingsPanel.Controls.Add(this.externalMemorySize);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel.Location = new System.Drawing.Point(3, 3);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(238, 176);
            this.settingsPanel.TabIndex = 0;
            // 
            // bytesInBlock
            // 
            this.bytesInBlock.Location = new System.Drawing.Point(5, 124);
            this.bytesInBlock.Name = "bytesInBlock";
            this.bytesInBlock.Size = new System.Drawing.Size(230, 20);
            this.bytesInBlock.TabIndex = 22;
            this.bytesInBlock.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // settingsLabel
            // 
            this.settingsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsLabel.Location = new System.Drawing.Point(0, 0);
            this.settingsLabel.Name = "settingsLabel";
            this.settingsLabel.Size = new System.Drawing.Size(238, 30);
            this.settingsLabel.TabIndex = 23;
            this.settingsLabel.Text = "Параметры";
            this.settingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bytesInBlockLabel
            // 
            this.bytesInBlockLabel.AutoSize = true;
            this.bytesInBlockLabel.Location = new System.Drawing.Point(5, 108);
            this.bytesInBlockLabel.Name = "bytesInBlockLabel";
            this.bytesInBlockLabel.Size = new System.Drawing.Size(134, 13);
            this.bytesInBlockLabel.TabIndex = 21;
            this.bytesInBlockLabel.Text = "Количество байт в блоке";
            // 
            // externalMemorySizeLabel
            // 
            this.externalMemorySizeLabel.AutoSize = true;
            this.externalMemorySizeLabel.Location = new System.Drawing.Point(5, 69);
            this.externalMemorySizeLabel.Name = "externalMemorySizeLabel";
            this.externalMemorySizeLabel.Size = new System.Drawing.Size(198, 13);
            this.externalMemorySizeLabel.TabIndex = 15;
            this.externalMemorySizeLabel.Text = "Размер памяти внешнего устройства";
            // 
            // applySettingsButton
            // 
            this.applySettingsButton.Location = new System.Drawing.Point(5, 150);
            this.applySettingsButton.Name = "applySettingsButton";
            this.applySettingsButton.Size = new System.Drawing.Size(230, 23);
            this.applySettingsButton.TabIndex = 18;
            this.applySettingsButton.Text = "Применить";
            this.applySettingsButton.UseVisualStyleBackColor = true;
            this.applySettingsButton.Click += new System.EventHandler(this.UpdateSettings);
            // 
            // externalMemorySize
            // 
            this.externalMemorySize.Location = new System.Drawing.Point(5, 85);
            this.externalMemorySize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.externalMemorySize.Name = "externalMemorySize";
            this.externalMemorySize.Size = new System.Drawing.Size(230, 20);
            this.externalMemorySize.TabIndex = 16;
            this.externalMemorySize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // selectionPanel
            // 
            this.selectionPanel.AutoSize = true;
            this.selectionPanel.Controls.Add(this.fillBlocksButton);
            this.selectionPanel.Controls.Add(this.clearBlocksButton);
            this.selectionPanel.Controls.Add(this.memoryActionsLabel);
            this.selectionPanel.Controls.Add(this.selectionClearLabel);
            this.selectionPanel.Controls.Add(this.selectionClearButtons);
            this.selectionPanel.Controls.Add(this.selectionLabel);
            this.selectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectionPanel.Location = new System.Drawing.Point(3, 185);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(238, 118);
            this.selectionPanel.TabIndex = 17;
            // 
            // fillBlocksButton
            // 
            this.fillBlocksButton.Location = new System.Drawing.Point(135, 92);
            this.fillBlocksButton.Name = "fillBlocksButton";
            this.fillBlocksButton.Size = new System.Drawing.Size(100, 23);
            this.fillBlocksButton.TabIndex = 8;
            this.fillBlocksButton.Text = "Заполнить";
            this.fillBlocksButton.UseVisualStyleBackColor = true;
            this.fillBlocksButton.Click += new System.EventHandler(this.FillMemoryClick);
            // 
            // clearBlocksButton
            // 
            this.clearBlocksButton.Location = new System.Drawing.Point(4, 92);
            this.clearBlocksButton.Name = "clearBlocksButton";
            this.clearBlocksButton.Size = new System.Drawing.Size(100, 23);
            this.clearBlocksButton.TabIndex = 7;
            this.clearBlocksButton.Text = "Очистить";
            this.clearBlocksButton.UseVisualStyleBackColor = true;
            this.clearBlocksButton.Click += new System.EventHandler(this.ClearMemoryClick);
            // 
            // memoryActionsLabel
            // 
            this.memoryActionsLabel.AutoSize = true;
            this.memoryActionsLabel.Location = new System.Drawing.Point(5, 76);
            this.memoryActionsLabel.Name = "memoryActionsLabel";
            this.memoryActionsLabel.Size = new System.Drawing.Size(113, 13);
            this.memoryActionsLabel.TabIndex = 6;
            this.memoryActionsLabel.Text = "Действия с блоками";
            // 
            // selectionClearLabel
            // 
            this.selectionClearLabel.AutoSize = true;
            this.selectionClearLabel.Location = new System.Drawing.Point(5, 29);
            this.selectionClearLabel.Name = "selectionClearLabel";
            this.selectionClearLabel.Size = new System.Drawing.Size(113, 13);
            this.selectionClearLabel.TabIndex = 5;
            this.selectionClearLabel.Text = "Очистить выделение";
            // 
            // selectionClearButtons
            // 
            this.selectionClearButtons.ColumnCount = 3;
            this.selectionClearButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionClearButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionClearButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.selectionClearButtons.Controls.Add(this.clearCpuSelectionButton, 0, 0);
            this.selectionClearButtons.Controls.Add(this.clearExternalSelectionButton, 2, 0);
            this.selectionClearButtons.Controls.Add(this.clearSelectionButton, 1, 0);
            this.selectionClearButtons.Location = new System.Drawing.Point(5, 45);
            this.selectionClearButtons.Name = "selectionClearButtons";
            this.selectionClearButtons.RowCount = 1;
            this.selectionClearButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectionClearButtons.Size = new System.Drawing.Size(230, 28);
            this.selectionClearButtons.TabIndex = 4;
            // 
            // clearCpuSelectionButton
            // 
            this.clearCpuSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearCpuSelectionButton.Location = new System.Drawing.Point(3, 3);
            this.clearCpuSelectionButton.Name = "clearCpuSelectionButton";
            this.clearCpuSelectionButton.Size = new System.Drawing.Size(70, 22);
            this.clearCpuSelectionButton.TabIndex = 1;
            this.clearCpuSelectionButton.Text = "ОПП";
            this.clearCpuSelectionButton.UseVisualStyleBackColor = true;
            this.clearCpuSelectionButton.Click += new System.EventHandler(this.ClearCpuSelection);
            // 
            // clearExternalSelectionButton
            // 
            this.clearExternalSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearExternalSelectionButton.Location = new System.Drawing.Point(155, 3);
            this.clearExternalSelectionButton.Name = "clearExternalSelectionButton";
            this.clearExternalSelectionButton.Size = new System.Drawing.Size(72, 22);
            this.clearExternalSelectionButton.TabIndex = 2;
            this.clearExternalSelectionButton.Text = "Внеш.";
            this.clearExternalSelectionButton.UseVisualStyleBackColor = true;
            this.clearExternalSelectionButton.Click += new System.EventHandler(this.ClearExternalSelection);
            // 
            // clearSelectionButton
            // 
            this.clearSelectionButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearSelectionButton.Location = new System.Drawing.Point(79, 3);
            this.clearSelectionButton.Name = "clearSelectionButton";
            this.clearSelectionButton.Size = new System.Drawing.Size(70, 22);
            this.clearSelectionButton.TabIndex = 3;
            this.clearSelectionButton.Text = "Все";
            this.clearSelectionButton.UseVisualStyleBackColor = true;
            this.clearSelectionButton.Click += new System.EventHandler(this.ClearAllSelection);
            // 
            // selectionLabel
            // 
            this.selectionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.selectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionLabel.Location = new System.Drawing.Point(0, 0);
            this.selectionLabel.Name = "selectionLabel";
            this.selectionLabel.Size = new System.Drawing.Size(238, 30);
            this.selectionLabel.TabIndex = 0;
            this.selectionLabel.Text = "Выделение";
            this.selectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferPanel
            // 
            this.transferPanel.AutoSize = true;
            this.transferPanel.Controls.Add(this.cancelTransferBtn);
            this.transferPanel.Controls.Add(this.transferLabel);
            this.transferPanel.Controls.Add(this.transferSpeed);
            this.transferPanel.Controls.Add(this.transferSpeedLabel);
            this.transferPanel.Controls.Add(this.processStateFlowLayout);
            this.transferPanel.Controls.Add(this.transferDirectionLabel);
            this.transferPanel.Controls.Add(this.transferDirectionBtn);
            this.transferPanel.Controls.Add(this.transferProgressBar);
            this.transferPanel.Controls.Add(this.transferBtn);
            this.transferPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.transferPanel.Location = new System.Drawing.Point(3, 309);
            this.transferPanel.Name = "transferPanel";
            this.transferPanel.Size = new System.Drawing.Size(238, 209);
            this.transferPanel.TabIndex = 16;
            // 
            // cancelTransferBtn
            // 
            this.cancelTransferBtn.Enabled = false;
            this.cancelTransferBtn.Location = new System.Drawing.Point(5, 114);
            this.cancelTransferBtn.Name = "cancelTransferBtn";
            this.cancelTransferBtn.Size = new System.Drawing.Size(100, 23);
            this.cancelTransferBtn.TabIndex = 22;
            this.cancelTransferBtn.Text = "Отменить";
            this.cancelTransferBtn.UseVisualStyleBackColor = true;
            // 
            // transferLabel
            // 
            this.transferLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.transferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transferLabel.Location = new System.Drawing.Point(0, 0);
            this.transferLabel.Name = "transferLabel";
            this.transferLabel.Size = new System.Drawing.Size(238, 30);
            this.transferLabel.TabIndex = 21;
            this.transferLabel.Text = "Передача";
            this.transferLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // transferSpeed
            // 
            this.transferSpeed.Location = new System.Drawing.Point(5, 46);
            this.transferSpeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.transferSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.transferSpeed.Name = "transferSpeed";
            this.transferSpeed.Size = new System.Drawing.Size(230, 20);
            this.transferSpeed.TabIndex = 20;
            this.transferSpeed.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            // 
            // transferSpeedLabel
            // 
            this.transferSpeedLabel.AutoSize = true;
            this.transferSpeedLabel.Location = new System.Drawing.Point(5, 30);
            this.transferSpeedLabel.Name = "transferSpeedLabel";
            this.transferSpeedLabel.Size = new System.Drawing.Size(142, 13);
            this.transferSpeedLabel.TabIndex = 19;
            this.transferSpeedLabel.Text = "Скорость передачи (бит/с)";
            // 
            // processStateFlowLayout
            // 
            this.processStateFlowLayout.Controls.Add(this.stateLabel);
            this.processStateFlowLayout.Controls.Add(this.stateText);
            this.processStateFlowLayout.Location = new System.Drawing.Point(5, 172);
            this.processStateFlowLayout.Name = "processStateFlowLayout";
            this.processStateFlowLayout.Size = new System.Drawing.Size(230, 34);
            this.processStateFlowLayout.TabIndex = 14;
            // 
            // cpuMemoryTableLayout
            // 
            this.cpuMemoryTableLayout.ColumnCount = 1;
            this.cpuMemoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cpuMemoryTableLayout.Controls.Add(this.cpuMemoryScrollView, 0, 1);
            this.cpuMemoryTableLayout.Controls.Add(this.cpuMemoryLabel, 0, 0);
            this.cpuMemoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuMemoryTableLayout.Location = new System.Drawing.Point(3, 3);
            this.cpuMemoryTableLayout.Name = "cpuMemoryTableLayout";
            this.cpuMemoryTableLayout.RowCount = 2;
            this.cpuMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cpuMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cpuMemoryTableLayout.Size = new System.Drawing.Size(286, 525);
            this.cpuMemoryTableLayout.TabIndex = 18;
            // 
            // cpuMemoryScrollView
            // 
            this.cpuMemoryScrollView.AutoScroll = true;
            this.cpuMemoryScrollView.Controls.Add(this.cpuMemoryPicture);
            this.cpuMemoryScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuMemoryScrollView.Location = new System.Drawing.Point(3, 33);
            this.cpuMemoryScrollView.Name = "cpuMemoryScrollView";
            this.cpuMemoryScrollView.Size = new System.Drawing.Size(280, 568);
            this.cpuMemoryScrollView.TabIndex = 2;
            // 
            // externalMemoryTableLayout
            // 
            this.externalMemoryTableLayout.ColumnCount = 1;
            this.externalMemoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.externalMemoryTableLayout.Controls.Add(this.externalMemoryScrollView, 0, 1);
            this.externalMemoryTableLayout.Controls.Add(this.externalMemoryLabel, 0, 0);
            this.externalMemoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalMemoryTableLayout.Location = new System.Drawing.Point(545, 3);
            this.externalMemoryTableLayout.Name = "externalMemoryTableLayout";
            this.externalMemoryTableLayout.RowCount = 2;
            this.externalMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.externalMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.externalMemoryTableLayout.Size = new System.Drawing.Size(286, 525);
            this.externalMemoryTableLayout.TabIndex = 19;
            // 
            // externalMemoryScrollView
            // 
            this.externalMemoryScrollView.AutoScroll = true;
            this.externalMemoryScrollView.Controls.Add(this.externalMemoryPicture);
            this.externalMemoryScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalMemoryScrollView.Location = new System.Drawing.Point(3, 33);
            this.externalMemoryScrollView.Name = "externalMemoryScrollView";
            this.externalMemoryScrollView.Size = new System.Drawing.Size(280, 568);
            this.externalMemoryScrollView.TabIndex = 15;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 20;
            this.updateTimer.Tick += new System.EventHandler(this.Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 531);
            this.Controls.Add(this.rootTableLayout);
            this.MinimumSize = new System.Drawing.Size(800, 570);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модель канала ввода/вывода данных";
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemoryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemoryPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemorySize)).EndInit();
            this.rootTableLayout.ResumeLayout(false);
            this.rootTableLayout.PerformLayout();
            this.controlsTableLayout.ResumeLayout(false);
            this.controlsTableLayout.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bytesInBlock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemorySize)).EndInit();
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.selectionClearButtons.ResumeLayout(false);
            this.transferPanel.ResumeLayout(false);
            this.transferPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transferSpeed)).EndInit();
            this.processStateFlowLayout.ResumeLayout(false);
            this.processStateFlowLayout.PerformLayout();
            this.cpuMemoryTableLayout.ResumeLayout(false);
            this.cpuMemoryTableLayout.PerformLayout();
            this.cpuMemoryScrollView.ResumeLayout(false);
            this.externalMemoryTableLayout.ResumeLayout(false);
            this.externalMemoryTableLayout.PerformLayout();
            this.externalMemoryScrollView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label cpuMemoryLabel;
        private System.Windows.Forms.Label externalMemoryLabel;
        private System.Windows.Forms.PictureBox cpuMemoryPicture;
        private System.Windows.Forms.PictureBox externalMemoryPicture;
        private System.Windows.Forms.Label cpuMemorySizeLabel;
        private System.Windows.Forms.NumericUpDown cpuMemorySize;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button transferDirectionBtn;
        private System.Windows.Forms.Label transferDirectionLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ProgressBar transferProgressBar;
        private System.Windows.Forms.Label stateText;
        private System.Windows.Forms.TableLayoutPanel rootTableLayout;
        private System.Windows.Forms.Panel transferPanel;
        private System.Windows.Forms.TableLayoutPanel cpuMemoryTableLayout;
        private System.Windows.Forms.TableLayoutPanel externalMemoryTableLayout;
        private System.Windows.Forms.Panel cpuMemoryScrollView;
        private System.Windows.Forms.FlowLayoutPanel processStateFlowLayout;
        private System.Windows.Forms.Panel externalMemoryScrollView;
        private System.Windows.Forms.NumericUpDown transferSpeed;
        private System.Windows.Forms.Label transferSpeedLabel;
        private System.Windows.Forms.Button applySettingsButton;
        private System.Windows.Forms.NumericUpDown externalMemorySize;
        private System.Windows.Forms.Label externalMemorySizeLabel;
        private System.Windows.Forms.NumericUpDown bytesInBlock;
        private System.Windows.Forms.Label bytesInBlockLabel;
        private System.Windows.Forms.TableLayoutPanel controlsTableLayout;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label settingsLabel;
        private System.Windows.Forms.Label transferLabel;
        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Label selectionLabel;
        private System.Windows.Forms.TableLayoutPanel selectionClearButtons;
        private System.Windows.Forms.Button clearCpuSelectionButton;
        private System.Windows.Forms.Button clearExternalSelectionButton;
        private System.Windows.Forms.Button clearSelectionButton;
        private System.Windows.Forms.Label selectionClearLabel;
        private System.Windows.Forms.Button fillBlocksButton;
        private System.Windows.Forms.Button clearBlocksButton;
        private System.Windows.Forms.Label memoryActionsLabel;
        private System.Windows.Forms.Button cancelTransferBtn;
        private System.Windows.Forms.Timer updateTimer;
    }
}

