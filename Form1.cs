using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace NFS_Color_Picker
{
    public partial class Form1 : Form
    {
        private bool isUpdating = false;

        public Form1()
        {
            InitializeComponent();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            trackBarR.Value = 0;
            trackBarG.Value = 0;
            trackBarB.Value = 0;
            trackBarA.Value = 0;

            numR.Value = 0;
            numG.Value = 0;
            numB.Value = 0;
            numA.Value = 0;

            txtHEXFormat.TextChanged += TxtHEXFormat_TextChanged;
            txtDecimalFormat.TextChanged += TxtDecimalFormat_TextChanged;
            panelColor.Click += panelColor_Click;

            UpdateColor();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            isUpdating = true;
            if (sender == trackBarR) numR.Value = trackBarR.Value;
            if (sender == trackBarG) numG.Value = trackBarG.Value;
            if (sender == trackBarB) numB.Value = trackBarB.Value;
            if (sender == trackBarA) numA.Value = trackBarA.Value;
            isUpdating = false;

            UpdateColor();
        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            isUpdating = true;
            if (sender == numR) trackBarR.Value = (int)numR.Value;
            if (sender == numG) trackBarG.Value = (int)numG.Value;
            if (sender == numB) trackBarB.Value = (int)numB.Value;
            if (sender == numA) trackBarA.Value = (int)numA.Value;
            isUpdating = false;

            UpdateColor();
        }

        private void UpdateColor()
        {
            if (isUpdating) return;
            isUpdating = true;

            int r = trackBarR.Value;
            int g = trackBarG.Value;
            int b = trackBarB.Value;
            int a = trackBarA.Value;

            panelColor.BackColor = Color.FromArgb(a, r, g, b);

            string hex = $"{r:X2}{g:X2}{b:X2}{a:X2}";
            txtHEXFormat.Text = hex;

            uint decimalValue = (uint)((r << 24) | (g << 16) | (b << 8) | a);
            txtDecimalFormat.Text = decimalValue.ToString();

            isUpdating = false;
        }

        private void TxtHEXFormat_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            string hex = txtHEXFormat.Text.Trim().Replace("#", "");
            if (hex.Length != 8) return;

            try
            {
                isUpdating = true;
                int r = int.Parse(hex.Substring(0, 2), NumberStyles.HexNumber);
                int g = int.Parse(hex.Substring(2, 2), NumberStyles.HexNumber);
                int b = int.Parse(hex.Substring(4, 2), NumberStyles.HexNumber);
                int a = int.Parse(hex.Substring(6, 2), NumberStyles.HexNumber);

                trackBarR.Value = r; numR.Value = r;
                trackBarG.Value = g; numG.Value = g;
                trackBarB.Value = b; numB.Value = b;
                trackBarA.Value = a; numA.Value = a;

                uint decimalValue = (uint)((r << 24) | (g << 16) | (b << 8) | a);
                txtDecimalFormat.Text = decimalValue.ToString();

                panelColor.BackColor = Color.FromArgb(a, r, g, b);
            }
            catch { }
            finally { isUpdating = false; }
        }

        private void TxtDecimalFormat_TextChanged(object sender, EventArgs e)
        {
            if (isUpdating) return;

            try
            {
                if (!uint.TryParse(txtDecimalFormat.Text.Trim(), out uint decValue))
                    return;

                isUpdating = true;

                int r = (int)((decValue >> 24) & 0xFF);
                int g = (int)((decValue >> 16) & 0xFF);
                int b = (int)((decValue >> 8) & 0xFF);
                int a = (int)(decValue & 0xFF);

                trackBarR.Value = r; numR.Value = r;
                trackBarG.Value = g; numG.Value = g;
                trackBarB.Value = b; numB.Value = b;
                trackBarA.Value = a; numA.Value = a;

                string hex = $"{r:X2}{g:X2}{b:X2}{a:X2}";
                txtHEXFormat.Text = hex;

                panelColor.BackColor = Color.FromArgb(a, r, g, b);
            }
            catch { }
            finally { isUpdating = false; }
        }

        private void btnCopyHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHEXFormat.Text);
        }

        private void btnCopyDecimal_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtDecimalFormat.Text);
        }

        private void panelColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                dlg.Color = panelColor.BackColor;
                dlg.FullOpen = true;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    isUpdating = true;

                    Color selected = dlg.Color;

                    trackBarR.Value = selected.R;
                    trackBarG.Value = selected.G;
                    trackBarB.Value = selected.B;
                    trackBarA.Value = selected.A;

                    numR.Value = selected.R;
                    numG.Value = selected.G;
                    numB.Value = selected.B;
                    numA.Value = selected.A;

                    string hex = $"{selected.R:X2}{selected.G:X2}{selected.B:X2}{selected.A:X2}";
                    txtHEXFormat.Text = hex;

                    uint decimalValue = (uint)((selected.R << 24) | (selected.G << 16) | (selected.B << 8) | selected.A);
                    txtDecimalFormat.Text = decimalValue.ToString();

                    panelColor.BackColor = selected;

                    isUpdating = false;
                }
            }
        }
    }
}
