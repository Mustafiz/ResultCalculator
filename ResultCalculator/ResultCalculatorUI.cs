using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculator
{
    public partial class ResultCalculatorUI : Form
    {
        public ResultCalculatorUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ResultCalculator aCalculator = new ResultCalculator();
            aCalculator.PhysicsMarks = Convert.ToDouble(physicsTextBox.Text);
            aCalculator.ChemistryMarks = Convert.ToDouble(chemistryTextBox.Text);
            aCalculator.MathMarks = Convert.ToDouble(mathTextBox.Text);

            averageTextBox.Text = aCalculator.GetAverageResult().ToString();
            gradeLetterTextBox.Text = aCalculator.GetGradeLetter().ToString();
        }
    }
}
