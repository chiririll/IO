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
            this.cpuMemoryLabel = new System.Windows.Forms.Label();
            this.externalMemoryLabel = new System.Windows.Forms.Label();
            this.cpuMemory = new System.Windows.Forms.PictureBox();
            this.externalMemory = new System.Windows.Forms.PictureBox();
            this.transferAmount = new System.Windows.Forms.Label();
            this.transferBlocksCount = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.transferDirectionBtn = new System.Windows.Forms.Button();
            this.transferDirectionLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.transferProgressBar = new System.Windows.Forms.ProgressBar();
            this.stateText = new System.Windows.Forms.Label();
            this.rootTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.controllsPanel = new System.Windows.Forms.Panel();
            this.processStateFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.cpuMemoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cpuMemoryScrollView = new System.Windows.Forms.Panel();
            this.externalMemoryTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.externalMemoryScrollView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBlocksCount)).BeginInit();
            this.rootTableLayout.SuspendLayout();
            this.controllsPanel.SuspendLayout();
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
            this.cpuMemoryLabel.Size = new System.Drawing.Size(472, 30);
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
            this.externalMemoryLabel.Size = new System.Drawing.Size(472, 30);
            this.externalMemoryLabel.TabIndex = 2;
            this.externalMemoryLabel.Text = "Внешнее устройство";
            this.externalMemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpuMemory
            // 
            this.cpuMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.cpuMemory.Location = new System.Drawing.Point(0, 0);
            this.cpuMemory.Name = "cpuMemory";
            this.cpuMemory.Size = new System.Drawing.Size(472, 275);
            this.cpuMemory.TabIndex = 3;
            this.cpuMemory.TabStop = false;
            this.cpuMemory.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCpuMemory);
            // 
            // externalMemory
            // 
            this.externalMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.externalMemory.Location = new System.Drawing.Point(0, 0);
            this.externalMemory.Name = "externalMemory";
            this.externalMemory.Size = new System.Drawing.Size(472, 275);
            this.externalMemory.TabIndex = 4;
            this.externalMemory.TabStop = false;
            this.externalMemory.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawExternalMemory);
            // 
            // transferAmount
            // 
            this.transferAmount.AutoSize = true;
            this.transferAmount.Location = new System.Drawing.Point(3, 6);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(183, 13);
            this.transferAmount.TabIndex = 5;
            this.transferAmount.Text = "Количество передаваемых блоков";
            // 
            // transferBlocksCount
            // 
            this.transferBlocksCount.Location = new System.Drawing.Point(6, 22);
            this.transferBlocksCount.Name = "transferBlocksCount";
            this.transferBlocksCount.Size = new System.Drawing.Size(230, 20);
            this.transferBlocksCount.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(6, 90);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(136, 90);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(100, 23);
            this.transferBtn.TabIndex = 8;
            this.transferBtn.Text = "Передать";
            this.transferBtn.UseVisualStyleBackColor = true;
            // 
            // transferDirectionBtn
            // 
            this.transferDirectionBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transferDirectionBtn.Location = new System.Drawing.Point(6, 61);
            this.transferDirectionBtn.Name = "transferDirectionBtn";
            this.transferDirectionBtn.Size = new System.Drawing.Size(230, 23);
            this.transferDirectionBtn.TabIndex = 9;
            this.transferDirectionBtn.Text = "--->";
            this.transferDirectionBtn.UseVisualStyleBackColor = true;
            this.transferDirectionBtn.Click += new System.EventHandler(this.ChangeTransferDirection);
            // 
            // transferDirectionLabel
            // 
            this.transferDirectionLabel.AutoSize = true;
            this.transferDirectionLabel.Location = new System.Drawing.Point(3, 45);
            this.transferDirectionLabel.Name = "transferDirectionLabel";
            this.transferDirectionLabel.Size = new System.Drawing.Size(125, 13);
            this.transferDirectionLabel.TabIndex = 10;
            this.transferDirectionLabel.Text = "Направление передачи";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(3, 0);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(115, 13);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "Состояние процесса:";
            // 
            // transferProgressBar
            // 
            this.transferProgressBar.Location = new System.Drawing.Point(6, 159);
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
            this.rootTableLayout.Controls.Add(this.controllsPanel, 1, 0);
            this.rootTableLayout.Controls.Add(this.cpuMemoryTableLayout, 0, 0);
            this.rootTableLayout.Controls.Add(this.externalMemoryTableLayout, 2, 0);
            this.rootTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rootTableLayout.Location = new System.Drawing.Point(0, 0);
            this.rootTableLayout.Name = "rootTableLayout";
            this.rootTableLayout.RowCount = 1;
            this.rootTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rootTableLayout.Size = new System.Drawing.Size(1216, 618);
            this.rootTableLayout.TabIndex = 15;
            // 
            // controllsPanel
            // 
            this.controllsPanel.Controls.Add(this.processStateFlowLayout);
            this.controllsPanel.Controls.Add(this.transferAmount);
            this.controllsPanel.Controls.Add(this.transferDirectionLabel);
            this.controllsPanel.Controls.Add(this.transferDirectionBtn);
            this.controllsPanel.Controls.Add(this.clearBtn);
            this.controllsPanel.Controls.Add(this.transferProgressBar);
            this.controllsPanel.Controls.Add(this.transferBtn);
            this.controllsPanel.Controls.Add(this.transferBlocksCount);
            this.controllsPanel.Location = new System.Drawing.Point(487, 3);
            this.controllsPanel.Name = "controllsPanel";
            this.controllsPanel.Size = new System.Drawing.Size(242, 190);
            this.controllsPanel.TabIndex = 16;
            // 
            // processStateFlowLayout
            // 
            this.processStateFlowLayout.Controls.Add(this.stateLabel);
            this.processStateFlowLayout.Controls.Add(this.stateText);
            this.processStateFlowLayout.Location = new System.Drawing.Point(6, 119);
            this.processStateFlowLayout.Name = "processStateFlowLayout";
            this.processStateFlowLayout.Size = new System.Drawing.Size(230, 34);
            this.processStateFlowLayout.TabIndex = 14;
            // 
            // cpuMemoryTableLayout
            // 
            this.cpuMemoryTableLayout.AutoSize = true;
            this.cpuMemoryTableLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cpuMemoryTableLayout.ColumnCount = 1;
            this.cpuMemoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.cpuMemoryTableLayout.Controls.Add(this.cpuMemoryLabel, 0, 0);
            this.cpuMemoryTableLayout.Controls.Add(this.cpuMemoryScrollView, 0, 1);
            this.cpuMemoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuMemoryTableLayout.Location = new System.Drawing.Point(3, 3);
            this.cpuMemoryTableLayout.Name = "cpuMemoryTableLayout";
            this.cpuMemoryTableLayout.RowCount = 2;
            this.cpuMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cpuMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cpuMemoryTableLayout.Size = new System.Drawing.Size(478, 612);
            this.cpuMemoryTableLayout.TabIndex = 18;
            // 
            // cpuMemoryScrollView
            // 
            this.cpuMemoryScrollView.AutoScroll = true;
            this.cpuMemoryScrollView.Controls.Add(this.cpuMemory);
            this.cpuMemoryScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpuMemoryScrollView.Location = new System.Drawing.Point(3, 33);
            this.cpuMemoryScrollView.Name = "cpuMemoryScrollView";
            this.cpuMemoryScrollView.Size = new System.Drawing.Size(472, 576);
            this.cpuMemoryScrollView.TabIndex = 2;
            // 
            // externalMemoryTableLayout
            // 
            this.externalMemoryTableLayout.ColumnCount = 1;
            this.externalMemoryTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.externalMemoryTableLayout.Controls.Add(this.externalMemoryScrollView, 0, 1);
            this.externalMemoryTableLayout.Controls.Add(this.externalMemoryLabel, 0, 0);
            this.externalMemoryTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalMemoryTableLayout.Location = new System.Drawing.Point(735, 3);
            this.externalMemoryTableLayout.Name = "externalMemoryTableLayout";
            this.externalMemoryTableLayout.RowCount = 2;
            this.externalMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.externalMemoryTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.externalMemoryTableLayout.Size = new System.Drawing.Size(478, 612);
            this.externalMemoryTableLayout.TabIndex = 19;
            // 
            // externalMemoryScrollView
            // 
            this.externalMemoryScrollView.AutoScroll = true;
            this.externalMemoryScrollView.Controls.Add(this.externalMemory);
            this.externalMemoryScrollView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.externalMemoryScrollView.Location = new System.Drawing.Point(3, 33);
            this.externalMemoryScrollView.Name = "externalMemoryScrollView";
            this.externalMemoryScrollView.Size = new System.Drawing.Size(472, 576);
            this.externalMemoryScrollView.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 618);
            this.Controls.Add(this.rootTableLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Модель канала ввода/вывода данных";
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBlocksCount)).EndInit();
            this.rootTableLayout.ResumeLayout(false);
            this.rootTableLayout.PerformLayout();
            this.controllsPanel.ResumeLayout(false);
            this.controllsPanel.PerformLayout();
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
        private System.Windows.Forms.PictureBox cpuMemory;
        private System.Windows.Forms.PictureBox externalMemory;
        private System.Windows.Forms.Label transferAmount;
        private System.Windows.Forms.NumericUpDown transferBlocksCount;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button transferDirectionBtn;
        private System.Windows.Forms.Label transferDirectionLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ProgressBar transferProgressBar;
        private System.Windows.Forms.Label stateText;
        private System.Windows.Forms.TableLayoutPanel rootTableLayout;
        private System.Windows.Forms.Panel controllsPanel;
        private System.Windows.Forms.TableLayoutPanel cpuMemoryTableLayout;
        private System.Windows.Forms.TableLayoutPanel externalMemoryTableLayout;
        private System.Windows.Forms.Panel cpuMemoryScrollView;
        private System.Windows.Forms.FlowLayoutPanel processStateFlowLayout;
        private System.Windows.Forms.Panel externalMemoryScrollView;
    }
}

