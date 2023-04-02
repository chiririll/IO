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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.clearBtn = new System.Windows.Forms.Button();
            this.transferBtn = new System.Windows.Forms.Button();
            this.transferDirectionBtn = new System.Windows.Forms.Button();
            this.transferDirectionLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.stateText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cpuMemoryLabel
            // 
            this.cpuMemoryLabel.AutoSize = true;
            this.cpuMemoryLabel.Location = new System.Drawing.Point(8, 14);
            this.cpuMemoryLabel.Name = "cpuMemoryLabel";
            this.cpuMemoryLabel.Size = new System.Drawing.Size(177, 13);
            this.cpuMemoryLabel.TabIndex = 1;
            this.cpuMemoryLabel.Text = "Оперативная память процессора";
            // 
            // externalMemoryLabel
            // 
            this.externalMemoryLabel.AutoSize = true;
            this.externalMemoryLabel.Location = new System.Drawing.Point(466, 14);
            this.externalMemoryLabel.Name = "externalMemoryLabel";
            this.externalMemoryLabel.Size = new System.Drawing.Size(112, 13);
            this.externalMemoryLabel.TabIndex = 2;
            this.externalMemoryLabel.Text = "Внешнее устройство";
            // 
            // cpuMemory
            // 
            this.cpuMemory.Location = new System.Drawing.Point(11, 30);
            this.cpuMemory.Name = "cpuMemory";
            this.cpuMemory.Size = new System.Drawing.Size(236, 275);
            this.cpuMemory.TabIndex = 3;
            this.cpuMemory.TabStop = false;
            this.cpuMemory.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawCpuMemory);
            // 
            // externalMemory
            // 
            this.externalMemory.Location = new System.Drawing.Point(469, 30);
            this.externalMemory.Name = "externalMemory";
            this.externalMemory.Size = new System.Drawing.Size(224, 275);
            this.externalMemory.TabIndex = 4;
            this.externalMemory.TabStop = false;
            this.externalMemory.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawExternalMemory);
            // 
            // transferAmount
            // 
            this.transferAmount.AutoSize = true;
            this.transferAmount.Location = new System.Drawing.Point(253, 30);
            this.transferAmount.Name = "transferAmount";
            this.transferAmount.Size = new System.Drawing.Size(183, 13);
            this.transferAmount.TabIndex = 5;
            this.transferAmount.Text = "Количество передаваемых блоков";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(256, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(207, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(256, 119);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 7;
            this.clearBtn.Text = "Очистить";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // transferBtn
            // 
            this.transferBtn.Location = new System.Drawing.Point(388, 119);
            this.transferBtn.Name = "transferBtn";
            this.transferBtn.Size = new System.Drawing.Size(75, 23);
            this.transferBtn.TabIndex = 8;
            this.transferBtn.Text = "Передать";
            this.transferBtn.UseVisualStyleBackColor = true;
            // 
            // transferDirectionBtn
            // 
            this.transferDirectionBtn.Location = new System.Drawing.Point(256, 90);
            this.transferDirectionBtn.Name = "transferDirectionBtn";
            this.transferDirectionBtn.Size = new System.Drawing.Size(207, 23);
            this.transferDirectionBtn.TabIndex = 9;
            this.transferDirectionBtn.Text = "--->";
            this.transferDirectionBtn.UseVisualStyleBackColor = true;
            this.transferDirectionBtn.Click += new System.EventHandler(this.ChangeTransferDirection);
            // 
            // transferDirectionLabel
            // 
            this.transferDirectionLabel.AutoSize = true;
            this.transferDirectionLabel.Location = new System.Drawing.Point(256, 74);
            this.transferDirectionLabel.Name = "transferDirectionLabel";
            this.transferDirectionLabel.Size = new System.Drawing.Size(125, 13);
            this.transferDirectionLabel.TabIndex = 10;
            this.transferDirectionLabel.Text = "Направление передачи";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(253, 155);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(115, 13);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "Состояние процесса:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(253, 194);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.TabIndex = 12;
            this.progressBar1.Value = 30;
            // 
            // stateText
            // 
            this.stateText.AutoSize = true;
            this.stateText.Location = new System.Drawing.Point(258, 178);
            this.stateText.Name = "stateText";
            this.stateText.Size = new System.Drawing.Size(112, 13);
            this.stateText.TabIndex = 13;
            this.stateText.Text = "Передача (300/1000)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 312);
            this.Controls.Add(this.stateText);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.transferDirectionLabel);
            this.Controls.Add(this.transferDirectionBtn);
            this.Controls.Add(this.transferBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.transferAmount);
            this.Controls.Add(this.externalMemory);
            this.Controls.Add(this.cpuMemory);
            this.Controls.Add(this.cpuMemoryLabel);
            this.Controls.Add(this.externalMemoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Модель канала ввода/вывода данных";
            ((System.ComponentModel.ISupportInitialize)(this.cpuMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.externalMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label cpuMemoryLabel;
        private System.Windows.Forms.Label externalMemoryLabel;
        private System.Windows.Forms.PictureBox cpuMemory;
        private System.Windows.Forms.PictureBox externalMemory;
        private System.Windows.Forms.Label transferAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button transferBtn;
        private System.Windows.Forms.Button transferDirectionBtn;
        private System.Windows.Forms.Label transferDirectionLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label stateText;
    }
}

