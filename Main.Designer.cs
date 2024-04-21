namespace KAMM
{
    partial class frmMain
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            label1 = new Label();
            label2 = new Label();
            nudSeconds = new NumericUpDown();
            nudPixels = new NumericUpDown();
            btnStart = new Button();
            brnStop = new Button();
            ((System.ComponentModel.ISupportInitialize)nudSeconds).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPixels).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(282, 15);
            label1.TabIndex = 2;
            label1.Text = "Number of seconds to wait before move the mouse:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 58);
            label2.Name = "label2";
            label2.Size = new Size(207, 15);
            label2.TabIndex = 3;
            label2.Text = "Number of pixels to move the mouse:";
            // 
            // nudSeconds
            // 
            nudSeconds.Location = new Point(300, 24);
            nudSeconds.Name = "nudSeconds";
            nudSeconds.Size = new Size(41, 23);
            nudSeconds.TabIndex = 4;
            nudSeconds.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // nudPixels
            // 
            nudPixels.Location = new Point(300, 56);
            nudPixels.Name = "nudPixels";
            nudPixels.Size = new Size(41, 23);
            nudPixels.TabIndex = 5;
            nudPixels.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 109);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // brnStop
            // 
            brnStop.Location = new Point(266, 109);
            brnStop.Name = "brnStop";
            brnStop.Size = new Size(75, 23);
            brnStop.TabIndex = 7;
            brnStop.Text = "Stop";
            brnStop.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 155);
            Controls.Add(brnStop);
            Controls.Add(btnStart);
            Controls.Add(nudPixels);
            Controls.Add(nudSeconds);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Kreaker's AutoMouseMover";
            ((System.ComponentModel.ISupportInitialize)nudSeconds).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPixels).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private NumericUpDown nudSeconds;
        private NumericUpDown nudPixels;
        private Button btnStart;
        private Button brnStop;
    }
}
