namespace NFS_Color_Picker
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            trackBarR = new System.Windows.Forms.TrackBar();
            trackBarG = new System.Windows.Forms.TrackBar();
            trackBarB = new System.Windows.Forms.TrackBar();
            trackBarA = new System.Windows.Forms.TrackBar();
            numR = new System.Windows.Forms.NumericUpDown();
            numG = new System.Windows.Forms.NumericUpDown();
            numB = new System.Windows.Forms.NumericUpDown();
            numA = new System.Windows.Forms.NumericUpDown();
            lblR = new System.Windows.Forms.Label();
            lblG = new System.Windows.Forms.Label();
            lblB = new System.Windows.Forms.Label();
            lblA = new System.Windows.Forms.Label();
            panelColor = new NFS_Color_Picker.DoubleBufferedPanel();
            txtHEXFormat = new System.Windows.Forms.TextBox();
            txtDecimalFormat = new System.Windows.Forms.TextBox();
            labelHEX = new System.Windows.Forms.Label();
            labelDecimal = new System.Windows.Forms.Label();
            btnCopyHEX = new System.Windows.Forms.Button();
            btnCopyDecimal = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)trackBarR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numA).BeginInit();
            SuspendLayout();

            // trackBarR
            trackBarR.Location = new System.Drawing.Point(55, 20);
            trackBarR.Maximum = 255;
            trackBarR.Name = "trackBarR";
            trackBarR.Size = new System.Drawing.Size(268, 45);
            trackBarR.TabIndex = 0;
            trackBarR.ValueChanged += trackBar_ValueChanged;

            // trackBarG
            trackBarG.Location = new System.Drawing.Point(55, 60);
            trackBarG.Maximum = 255;
            trackBarG.Name = "trackBarG";
            trackBarG.Size = new System.Drawing.Size(268, 45);
            trackBarG.TabIndex = 1;
            trackBarG.ValueChanged += trackBar_ValueChanged;

            // trackBarB
            trackBarB.Location = new System.Drawing.Point(55, 100);
            trackBarB.Maximum = 255;
            trackBarB.Name = "trackBarB";
            trackBarB.Size = new System.Drawing.Size(268, 45);
            trackBarB.TabIndex = 2;
            trackBarB.ValueChanged += trackBar_ValueChanged;

            // trackBarA
            trackBarA.Location = new System.Drawing.Point(55, 140);
            trackBarA.Maximum = 255;
            trackBarA.Name = "trackBarA";
            trackBarA.Size = new System.Drawing.Size(268, 45);
            trackBarA.TabIndex = 3;
            trackBarA.ValueChanged += trackBar_ValueChanged;

            // numR
            numR.Location = new System.Drawing.Point(357, 20);
            numR.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numR.Name = "numR";
            numR.Size = new System.Drawing.Size(130, 23);
            numR.TabIndex = 4;
            numR.ValueChanged += numeric_ValueChanged;

            // numG
            numG.Location = new System.Drawing.Point(357, 60);
            numG.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numG.Name = "numG";
            numG.Size = new System.Drawing.Size(130, 23);
            numG.TabIndex = 5;
            numG.ValueChanged += numeric_ValueChanged;

            // numB
            numB.Location = new System.Drawing.Point(357, 105);
            numB.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numB.Name = "numB";
            numB.Size = new System.Drawing.Size(130, 23);
            numB.TabIndex = 6;
            numB.ValueChanged += numeric_ValueChanged;

            // numA
            numA.Location = new System.Drawing.Point(357, 147);
            numA.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numA.Name = "numA";
            numA.Size = new System.Drawing.Size(130, 23);
            numA.TabIndex = 7;
            numA.ValueChanged += numeric_ValueChanged;

            // lblR
            lblR.AutoSize = true;
            lblR.Location = new System.Drawing.Point(20, 25);
            lblR.Name = "lblR";
            lblR.Size = new System.Drawing.Size(14, 15);
            lblR.TabIndex = 8;
            lblR.Text = "R";

            // lblG
            lblG.AutoSize = true;
            lblG.Location = new System.Drawing.Point(20, 65);
            lblG.Name = "lblG";
            lblG.Size = new System.Drawing.Size(15, 15);
            lblG.TabIndex = 9;
            lblG.Text = "G";

            // lblB
            lblB.AutoSize = true;
            lblB.Location = new System.Drawing.Point(20, 105);
            lblB.Name = "lblB";
            lblB.Size = new System.Drawing.Size(14, 15);
            lblB.TabIndex = 10;
            lblB.Text = "B";

            // lblA
            lblA.AutoSize = true;
            lblA.Location = new System.Drawing.Point(20, 145);
            lblA.Name = "lblA";
            lblA.Size = new System.Drawing.Size(15, 15);
            lblA.TabIndex = 11;
            lblA.Text = "A";

            // panelColor
            panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelColor.Location = new System.Drawing.Point(511, 20);
            panelColor.Name = "panelColor";
            panelColor.Size = new System.Drawing.Size(150, 150);
            panelColor.TabIndex = 12;

            // txtHEXFormat
            txtHEXFormat.Location = new System.Drawing.Point(20, 200);
            txtHEXFormat.Name = "txtHEXFormat";
            txtHEXFormat.ReadOnly = false;
            txtHEXFormat.Size = new System.Drawing.Size(303, 23);
            txtHEXFormat.TabIndex = 13;

            // txtDecimalFormat
            txtDecimalFormat.Location = new System.Drawing.Point(20, 250);
            txtDecimalFormat.Name = "txtDecimalFormat";
            txtDecimalFormat.ReadOnly = false;
            txtDecimalFormat.Size = new System.Drawing.Size(303, 23);
            txtDecimalFormat.TabIndex = 14;

            // labelHEX
            labelHEX.AutoSize = true;
            labelHEX.Location = new System.Drawing.Point(20, 180);
            labelHEX.Name = "labelHEX";
            labelHEX.Size = new System.Drawing.Size(29, 15);
            labelHEX.TabIndex = 15;
            labelHEX.Text = "HEX";

            // labelDecimal
            labelDecimal.AutoSize = true;
            labelDecimal.Location = new System.Drawing.Point(20, 230);
            labelDecimal.Name = "labelDecimal";
            labelDecimal.Size = new System.Drawing.Size(50, 15);
            labelDecimal.TabIndex = 16;
            labelDecimal.Text = "Decimal";

            // btnCopyHEX
            btnCopyHEX.Location = new System.Drawing.Point(357, 200);
            btnCopyHEX.Name = "btnCopyHEX";
            btnCopyHEX.Size = new System.Drawing.Size(130, 25);
            btnCopyHEX.TabIndex = 17;
            btnCopyHEX.Text = "Copy";
            btnCopyHEX.UseVisualStyleBackColor = true;
            btnCopyHEX.Click += btnCopyHEX_Click;

            // btnCopyDecimal
            btnCopyDecimal.Location = new System.Drawing.Point(357, 250);
            btnCopyDecimal.Name = "btnCopyDecimal";
            btnCopyDecimal.Size = new System.Drawing.Size(130, 25);
            btnCopyDecimal.TabIndex = 18;
            btnCopyDecimal.Text = "Copy";
            btnCopyDecimal.UseVisualStyleBackColor = true;
            btnCopyDecimal.Click += btnCopyDecimal_Click;

            // Form1
            ClientSize = new System.Drawing.Size(680, 300);
            Controls.Add(trackBarR);
            Controls.Add(trackBarG);
            Controls.Add(trackBarB);
            Controls.Add(trackBarA);
            Controls.Add(numR);
            Controls.Add(numG);
            Controls.Add(numB);
            Controls.Add(numA);
            Controls.Add(lblR);
            Controls.Add(lblG);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(panelColor);
            Controls.Add(txtHEXFormat);
            Controls.Add(txtDecimalFormat);
            Controls.Add(labelHEX);
            Controls.Add(labelDecimal);
            Controls.Add(btnCopyHEX);
            Controls.Add(btnCopyDecimal);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "NFS Color Picker v1.0 | By FiLixsi";

            ((System.ComponentModel.ISupportInitialize)trackBarR).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarG).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarB).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numR).EndInit();
            ((System.ComponentModel.ISupportInitialize)numG).EndInit();
            ((System.ComponentModel.ISupportInitialize)numB).EndInit();
            ((System.ComponentModel.ISupportInitialize)numA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private NFS_Color_Picker.DoubleBufferedPanel panelColor;
        private System.Windows.Forms.TextBox txtHEXFormat;
        private System.Windows.Forms.TextBox txtDecimalFormat;
        private System.Windows.Forms.Label labelHEX;
        private System.Windows.Forms.Label labelDecimal;
        private System.Windows.Forms.Button btnCopyHEX;
        private System.Windows.Forms.Button btnCopyDecimal;
    }
}
