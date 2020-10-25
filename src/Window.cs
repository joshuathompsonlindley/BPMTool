using System;
using System.Windows.Forms;

namespace BPMTool
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void InputTextChangeEvent(object sender, EventArgs e)
        {
            TextBox Context = (TextBox)sender;

            if (Context.Text != "-" && Context.TextLength > 0 && !double.TryParse(Context.Text, out _))
            {
                Context.Clear();
                MessageBox.Show("You can only enter numbers in this field!\nExample: 120 or -3.90.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PitchCalcButtonClickEvent(object sender, EventArgs e)
        {
            string Value1Text = pitchOldBPMInput.Text;
            string Value2Text = pitchNewBPMInput.Text;

            if (double.TryParse(Value1Text, out double Value1) && double.TryParse(Value2Text, out double Value2))
            {
                double Calculation = BPMTool.GetPitchFromBPMChange(Value1, Value2);
                pitchNewPitchOutput.Text = Calculation.ToString();
            }
            else
            {
                MessageBox.Show("Something went wrong trying to convert inputs to numbers.\nPlease check your inputs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BPMCalcButtonClickEvent(object sender, EventArgs e)
        {
            string Value1Text = bpmOldBPMInput.Text;
            string Value2Text = bpmPitchDiffInput.Text;

            if (double.TryParse(Value1Text, out double Value1) && double.TryParse(Value2Text, out double Value2))
            {
                double Calculation = BPMTool.GetBPMFromPitchChange(Value1, Value2);
                bpmNewBPMOutput.Text = Calculation.ToString();
            }
            else
            {
                MessageBox.Show("Something went wrong trying to convert inputs to numbers.\nPlease check your inputs!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void WindowLoadEvent(object sender, EventArgs e)
        {
            versionLabel.Text = "Version: " + ProductVersion;
            titleLabel.Text = ProductName;
        }
    }
}