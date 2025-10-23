using System.Globalization;

namespace Personal_budget_tracker
{
    public partial class Form1 : Form
    {
        private decimal totalIncome = 0m;
        private decimal totalExpenses = 0m;

        public Form1()
        {
            InitializeComponent();

            // Wire expense button (designer already wired Add Income -> button1_Click)
            btnAddExpenses.Click += BtnAddExpenses_Click;

            
            UpdateTotalsLabels();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            var input = tbxIncome.Text?.Trim();
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Enter an income amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxIncome.Focus();
                return;
            }

            if (!TryParseAmount(input, out var amount))
            {
                MessageBox.Show("Invalid income amount. Use numbers, e.g. 1000 or 1234.56.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxIncome.Focus();
                return;
            }

            totalIncome += amount;
            UpdateTotalsLabels();

            tbxIncome.Clear();
            tbxIncome.Focus();
        }

        
        private void BtnAddExpenses_Click(object? sender, EventArgs e)
        {
            var description = tbxExpenseDesc.Text?.Trim(); 
            var input = tbxExpenseAmt.Text?.Trim();       

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Enter an expense amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxExpenseDesc.Focus();
                return;
            }

            if (!TryParseAmount(input, out var amount))
            {
                MessageBox.Show("Invalid expense amount. Use numbers!", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbxExpenseDesc.Focus();
                return;
            }

            totalExpenses += amount;
            UpdateTotalsLabels();

            // Optionally clear description and amount
            tbxExpenseDesc.Clear();
            tbxExpenseAmt.Clear();
            tbxExpenseDesc.Focus();
        }

        // Helper: culture-aware amount parsing (falls back to invariant)
        private static bool TryParseAmount(string? text, out decimal amount)
        {
            amount = 0m;
            if (string.IsNullOrWhiteSpace(text)) return false;

            if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.CurrentCulture, out amount))
                return true;

            if (decimal.TryParse(text, NumberStyles.Number | NumberStyles.AllowCurrencySymbol, CultureInfo.InvariantCulture, out amount))
                return true;

            return false;
        }

        
        private void UpdateTotalsLabels()
        {
            label5.Text = $"Total Income: {totalIncome:C}";
            label6.Text = $"Total Expenses: {totalExpenses:C}";
            label7.Text = $"Balance: {(totalIncome - totalExpenses):C}";
        }
    }
}
