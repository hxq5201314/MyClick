namespace MyClick
{
    partial class Click
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEvery = new Label();
            numericInterval = new NumericUpDown();
            labelPerClick = new Label();
            numericCount = new NumericUpDown();
            labelTimes = new Label();
            buttonStart = new Button();
            labelBuffer = new Label();
            numericBuffer = new NumericUpDown();
            labelBufferHint = new Label();
            labelHotkey = new Label();
            labelStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)numericInterval).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericBuffer).BeginInit();
            SuspendLayout();
            //
            // labelEvery
            //
            labelEvery.AutoSize = true;
            labelEvery.BackColor = Color.Transparent;
            labelEvery.ForeColor = Color.White;
            labelEvery.Location = new Point(25, 30);
            labelEvery.Name = "labelEvery";
            labelEvery.Text = "每";
            //
            // numericInterval
            //
            numericInterval.BackColor = Color.White;
            numericInterval.ForeColor = Color.Black;
            numericInterval.Location = new Point(50, 27);
            numericInterval.Name = "numericInterval";
            numericInterval.Size = new Size(50, 23);
            numericInterval.Minimum = 1;
            numericInterval.Maximum = 3600;
            numericInterval.Value = 1;
            //
            // labelPerClick
            //
            labelPerClick.AutoSize = true;
            labelPerClick.BackColor = Color.Transparent;
            labelPerClick.ForeColor = Color.White;
            labelPerClick.Location = new Point(110, 30);
            labelPerClick.Name = "labelPerClick";
            labelPerClick.Text = "秒点击";
            //
            // numericCount
            //
            numericCount.BackColor = Color.White;
            numericCount.ForeColor = Color.Black;
            numericCount.Location = new Point(165, 27);
            numericCount.Name = "numericCount";
            numericCount.Size = new Size(50, 23);
            numericCount.Minimum = 1;
            numericCount.Maximum = 1000;
            numericCount.Value = 5;
            //
            // labelTimes
            //
            labelTimes.AutoSize = true;
            labelTimes.BackColor = Color.Transparent;
            labelTimes.ForeColor = Color.White;
            labelTimes.Location = new Point(225, 30);
            labelTimes.Name = "labelTimes";
            labelTimes.Text = "次";
            //
            // buttonStart
            //
            buttonStart.BackColor = Color.White;
            buttonStart.ForeColor = Color.Black;
            buttonStart.Location = new Point(345, 25);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(70, 30);
            buttonStart.Text = "开始";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            //
            // labelBuffer
            //
            labelBuffer.AutoSize = true;
            labelBuffer.BackColor = Color.Transparent;
            labelBuffer.ForeColor = Color.White;
            labelBuffer.Location = new Point(25, 80);
            labelBuffer.Name = "labelBuffer";
            labelBuffer.Text = "缓冲";
            //
            // numericBuffer
            //
            numericBuffer.BackColor = Color.White;
            numericBuffer.ForeColor = Color.Black;
            numericBuffer.Location = new Point(75, 77);
            numericBuffer.Name = "numericBuffer";
            numericBuffer.Size = new Size(50, 23);
            numericBuffer.Minimum = 0;
            numericBuffer.Maximum = 3600;
            numericBuffer.Value = 2;
            //
            // labelBufferHint
            //
            labelBufferHint.AutoSize = true;
            labelBufferHint.BackColor = Color.Transparent;
            labelBufferHint.ForeColor = Color.White;
            labelBufferHint.Location = new Point(135, 80);
            labelBufferHint.Name = "labelBufferHint";
            labelBufferHint.Text = "秒后启动(0 表示立即)";
            //
            // labelHotkey
            //
            labelHotkey.AutoSize = true;
            labelHotkey.BackColor = Color.Transparent;
            labelHotkey.ForeColor = Color.White;
            labelHotkey.Location = new Point(25, 130);
            labelHotkey.Name = "labelHotkey";
            labelHotkey.Text = "快捷键 F1 启停(全局)";
            //
            // labelStatus
            //
            labelStatus.AutoSize = true;
            labelStatus.BackColor = Color.Transparent;
            labelStatus.ForeColor = Color.LightGreen;
            labelStatus.Location = new Point(25, 180);
            labelStatus.Name = "labelStatus";
            labelStatus.Text = "状态: 已停止";
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(440, 235);
            Controls.Add(labelEvery);
            Controls.Add(numericInterval);
            Controls.Add(labelPerClick);
            Controls.Add(numericCount);
            Controls.Add(labelTimes);
            Controls.Add(buttonStart);
            Controls.Add(labelBuffer);
            Controls.Add(numericBuffer);
            Controls.Add(labelBufferHint);
            Controls.Add(labelHotkey);
            Controls.Add(labelStatus);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "简洁鼠标连点器";
            ((System.ComponentModel.ISupportInitialize)numericInterval).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericBuffer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEvery;
        private NumericUpDown numericInterval;
        private Label labelPerClick;
        private NumericUpDown numericCount;
        private Label labelTimes;
        private Button buttonStart;
        private Label labelBuffer;
        private NumericUpDown numericBuffer;
        private Label labelBufferHint;
        private Label labelHotkey;
        private Label labelStatus;
    }
}
