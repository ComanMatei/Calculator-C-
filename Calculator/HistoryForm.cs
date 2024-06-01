using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class HistoryForm : Form
    {
        List<string> historyCalculations = new List<string>();
        public HistoryForm(List<string> calculationHistory)
        {
            InitializeComponent();
            historyCalculations = calculationHistory;
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            foreach (string calculation in historyCalculations)
            {
                historyBox.Text += calculation + Environment.NewLine;
            }
            historyBox.SelectionStart = 0;
            historyBox.SelectionLength = 0;
            historyBox.HideSelection = true;
            historyBox.ReadOnly = true;
        }

    }
}
