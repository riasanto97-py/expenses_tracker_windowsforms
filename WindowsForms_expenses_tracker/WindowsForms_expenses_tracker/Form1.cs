using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsForms_expenses_tracker
{
    public partial class Form1 : Form
    {
        private List<Expense> expenses = new List<Expense>();
        private int selectedIndex = -1;
        private decimal budget = 0;
        private string selectedCurrency = "€";

        
        private string currentTheme = "Gray";
        private bool lowBudgetWarningShown = false;
        private bool budgetExceededWarningShown = false;
        private void UpdateStatistics()
        {
            DateTime now = DateTime.Now;

            decimal monthlyTotal = expenses
                .Where(x => x.Date.Month == now.Month && x.Date.Year == now.Year)
                .Sum(x => x.Amount);

            lblMonthlySpending.Text = monthlyTotal.ToString("0.00") + " " + selectedCurrency;

            string topCategory = expenses
                .GroupBy(x => x.Category)
                .OrderByDescending(g => g.Sum(x => x.Amount))
                .Select(g => g.Key)
                .FirstOrDefault();

            lblTopCategory.Text = topCategory ?? "None";
        }
        private List<string> categories = new List<string>()
{
    "Food",
    "Transport",
    "Bills",
    "Entertainment",
    "Shopping",
    "Health"
};
        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCategories()
        {
            lstCategories.Items.Clear();
            cmbCategory.Items.Clear();

            foreach (string category in categories)
            {
                lstCategories.Items.Add(category);
                cmbCategory.Items.Add(category);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            dashboardPanel.BringToFront();

            // CURRENCY
            cmbCurrency.Items.Clear();
            cmbCurrency.Items.Add("€");
            cmbCurrency.Items.Add("$");
            cmbCurrency.Items.Add("£");
            cmbCurrency.SelectedIndex = 0;

            selectedCurrency = cmbCurrency.Text;

            // THEME
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add("Light");
            cmbTheme.Items.Add("Dark");
            cmbTheme.Items.Add("Gray");

            cmbTheme.SelectedItem = currentTheme;
            cmbCurrency.SelectedItem = selectedCurrency;
            ApplyTheme(currentTheme);

            

            // INIT UI
            LoadCategories();
            UpdateDashboard();
            UpdateStatistics();
            UpdateChart();
        }
        

        private void SetTextColor(Color color)
        {
            foreach (Control ctrl in this.Controls)
            {
                ChangeControlTextColor(ctrl, color);
            }
        }

        
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboardPanel.BringToFront();

        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            

            addExpensePanel.BringToFront();
           
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statisticsPanel.BringToFront();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            categoriesPanel.BringToFront();
        }
        private void UpdateGrid()
        {
            dgvExpenses.Rows.Clear();

            foreach (var expense in expenses)
            {
                dgvExpenses.Rows.Add(
                    expense.Title,
                    expense.Amount,
                    expense.Category,
                    expense.Date.ToShortDateString()
                );
            }
        }
        
        
        private void ChangeControlTextColor(Control parent, Color color)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.ForeColor = color;

                if (ctrl.HasChildren)
                {
                    ChangeControlTextColor(ctrl, color);
                }
            }
        }
        private void ApplyTheme(string theme)
        {
            if (theme == "Light")
            {
                this.BackColor = Color.White;
                contentPanel.BackColor = Color.White;

                SetTextColor(Color.Black);
            }
            else if (theme == "Dark")
            {
                this.BackColor = Color.FromArgb(45, 45, 48);
                contentPanel.BackColor = Color.FromArgb(45, 45, 48);

                SetTextColor(Color.White);
            }
            else if (theme == "Gray")
            {
                this.BackColor = Color.FromArgb(130, 130, 130);
                contentPanel.BackColor = Color.FromArgb(130, 130, 130);

                SetTextColor(Color.Gainsboro);
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsPanel.BringToFront();
        }

        private void CheckBudgetWarning()
        {
            if (budget <= 0)
                return;

            decimal totalExpenses = expenses.Sum(x => x.Amount);
            decimal balance = budget - totalExpenses;

            decimal threshold = budget * 0.10m;

            // Budget exceeded
            if (balance < 0 && !budgetExceededWarningShown)
            {
                MessageBox.Show(
                    $"🚨 Budget Exceeded!\n\n" +
                    $"You have exceeded your budget.\n\n" +
                    $"Current Balance: {balance:0.00} {selectedCurrency}",
                    "Budget Exceeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                budgetExceededWarningShown = true;
            }

            // Low budget
            else if (balance <= threshold &&
                     balance >= 0 &&
                     !lowBudgetWarningShown)
            {
                MessageBox.Show(
                    $"⚠ Warning!\n\n" +
                    $"Your remaining budget is below 10%.\n\n" +
                    $"Remaining Balance: {balance:0.00} {selectedCurrency}",
                    "Low Budget Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                lowBudgetWarningShown = true;
            }

            // Reset flags αν ξαναανέβει το balance
            if (balance > threshold)
            {
                lowBudgetWarningShown = false;
                budgetExceededWarningShown = false;
            }
        }

       
        private void UpdateDashboard()
        {
            decimal totalExpenses = expenses.Sum(x => x.Amount);

            lblTotalExpenses.Text =
                totalExpenses.ToString("0.00") + " " + selectedCurrency;

            lblTotalIncome.Text =
                budget.ToString("0.00") + " " + selectedCurrency;

            decimal balance = budget - totalExpenses;

            lblCurrentBalance.Text =
                balance.ToString("0.00") + " " + selectedCurrency;

            CheckBudgetWarning();
        }
        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            string amountInput = txtAmount.Text.Replace(",", ".");

            decimal amount;

            if (!decimal.TryParse(
                amountInput,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            Expense newExpense = new Expense
            {
                Title = title,
                Amount = amount,
                Category = cmbCategory.Text,
                Date = dtpExpenseDate.Value
            };

            expenses.Add(newExpense);

            txtTitle.Clear();
            txtAmount.Clear();
            cmbCategory.SelectedIndex = -1;
            dtpExpenseDate.Value = DateTime.Now;

            UpdateDashboard();
            UpdateGrid();
            UpdateStatistics();
            UpdateChart();

            MessageBox.Show("Expense added successfully.");
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this expense?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.Yes)
                {
                    int index = dgvExpenses.SelectedRows[0].Index;

                    expenses.RemoveAt(index);

                    UpdateGrid();
                    UpdateDashboard();
                    UpdateStatistics();
                    UpdateChart();
                }
            }
        }

        private void btnEditExpense_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count > 0)
            {
                selectedIndex = dgvExpenses.SelectedRows[0].Index;

                Expense selectedExpense = expenses[selectedIndex];

                txtTitle.Text = selectedExpense.Title;
                txtAmount.Text = selectedExpense.Amount.ToString();
                cmbCategory.Text = selectedExpense.Category;
                dtpExpenseDate.Value = selectedExpense.Date;
            }
        }

        private void btnUpdateExpense_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Please select an expense first.");
                return;
            }

            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }

            string amountInput = txtAmount.Text.Replace(",", ".");

            decimal amount;

            if (!decimal.TryParse(
                amountInput,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out amount))
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("Amount must be greater than zero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbCategory.Text))
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            expenses[selectedIndex].Title = title;
            expenses[selectedIndex].Amount = amount;
            expenses[selectedIndex].Category = cmbCategory.Text;
            expenses[selectedIndex].Date = dtpExpenseDate.Value;

            selectedIndex = -1;

            UpdateGrid();
            UpdateDashboard();
            UpdateStatistics();
            UpdateChart();

            txtTitle.Clear();
            txtAmount.Clear();
            cmbCategory.SelectedIndex = -1;

            MessageBox.Show("Expense updated successfully.");
        }
        private void UpdateChart()
        {
            chartExpenses.Series.Clear();
            chartExpenses.ChartAreas.Clear();

            chartExpenses.ChartAreas.Add("MainArea");
            chartExpenses.Series.Add("Expenses");

            chartExpenses.Series["Expenses"].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            var data = expenses
                .GroupBy(x => x.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    Total = g.Sum(x => x.Amount)
                });

            foreach (var item in data)
            {
                chartExpenses.Series["Expenses"].Points.AddXY(item.Category, item.Total);
            }
        }
        private void lblTopCategoryTitle_Click(object sender, EventArgs e)
        {

        }

        private void cardTopCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveBudget_Click(object sender, EventArgs e)
        {



            string input = txtBudget.Text.Replace(",", ".");

            decimal value;

            if (decimal.TryParse(input,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out value))
            {
                budget = value;

                UpdateDashboard();
            }
            else
            {
                MessageBox.Show("Invalid budget value");
            }
            txtBudget.Clear();
        }

        private void txtBudget_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string newCategory = txtCategoryName.Text.Trim();

            if (string.IsNullOrWhiteSpace(newCategory))
            {
                MessageBox.Show("Please enter a category name.");
                return;
            }

            newCategory =
                char.ToUpper(newCategory[0]) +
                newCategory.Substring(1).ToLower();

            if (!categories.Any(c =>
                c.Equals(newCategory, StringComparison.OrdinalIgnoreCase)))
            {
                categories.Add(newCategory);

                LoadCategories();

                txtCategoryName.Clear();

                MessageBox.Show("Category added successfully.");
            }
            else
            {
                MessageBox.Show("Category already exists.");
            }
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            currentTheme = cmbTheme.Text;

            ApplyTheme(currentTheme);

            selectedCurrency = cmbCurrency.Text;

            UpdateDashboard();

            MessageBox.Show("Settings saved");
        }

        private void btnAddFunds_Click_1(object sender, EventArgs e)
        {
            
        
            string input = txtBudget.Text.Replace(",", ".");

            decimal value;

            if (decimal.TryParse(
                input,
                NumberStyles.Any,
                CultureInfo.InvariantCulture,
                out value))
            {
                budget += value;

                UpdateDashboard();

                MessageBox.Show(
                    $"Added {value:0.00} {selectedCurrency}\n\n" +
                    $"New Budget: {budget:0.00} {selectedCurrency}",
                    "Funds Added",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtBudget.Clear();
            }
            else
            {
                MessageBox.Show("Invalid amount");
            }
        }
        
        
        
    }
    }
    

