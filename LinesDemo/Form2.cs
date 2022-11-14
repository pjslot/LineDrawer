using System;
using System.Windows.Forms;

namespace LinesDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            numericPointDiam.Value = Settings.pointDiam;
            numericLineTolsh.Value = Settings.lineTolsh;
            labelPointColor.BackColor = Settings.pointColour;
            labelLineColor.BackColor = Settings.lineColour;
        }

        private void bParamApply_Click(object sender, EventArgs e)
        {
            //передача настроек
            Settings.pointDiam = (int)numericPointDiam.Value;
            Settings.lineTolsh = (int)numericLineTolsh.Value;

            Close();
        }

        private void bChoosePointColor_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            var res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                var color = f.Color;
                Settings.pointColour = color;
                labelPointColor.BackColor = color;
            }
        }

        private void bChooseLineColor_Click(object sender, EventArgs e)
        {
            ColorDialog f = new ColorDialog();
            var res = f.ShowDialog();
            if (res == DialogResult.OK)
            {
                var color = f.Color;
                Settings.lineColour = color;
                labelLineColor.BackColor = color;
            }
        }
    }
}
