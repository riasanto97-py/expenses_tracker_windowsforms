namespace WindowsForms_expenses_tracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.btnAddFunds = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveBudget = new System.Windows.Forms.Button();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.cardExpenses = new System.Windows.Forms.Panel();
            this.lblTotalExpenses = new System.Windows.Forms.Label();
            this.lblExpensesCardTitle = new System.Windows.Forms.Label();
            this.cardIncome = new System.Windows.Forms.Panel();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.lblIncomeCardTitle = new System.Windows.Forms.Label();
            this.cardBalance = new System.Windows.Forms.Panel();
            this.lblCurrentBalance = new System.Windows.Forms.Label();
            this.lblBalanceCardTitle = new System.Windows.Forms.Label();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.addExpensePanel = new System.Windows.Forms.Panel();
            this.btnUpdateExpense = new System.Windows.Forms.Button();
            this.btnEditExpense = new System.Windows.Forms.Button();
            this.btnDeleteExpense = new System.Windows.Forms.Button();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveExpense = new System.Windows.Forms.Button();
            this.dtpExpenseDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateText = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategoryText = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmountText = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleText = new System.Windows.Forms.Label();
            this.lblAddExpenseTitle = new System.Windows.Forms.Label();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.cmbTheme = new System.Windows.Forms.ComboBox();
            this.lblTheme = new System.Windows.Forms.Label();
            this.cmbCurrency = new System.Windows.Forms.ComboBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.lblSettingsTitle = new System.Windows.Forms.Label();
            this.categoriesPanel = new System.Windows.Forms.Panel();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.lblCategoriesTitle = new System.Windows.Forms.Label();
            this.statisticsPanel = new System.Windows.Forms.Panel();
            this.panelChartPlaceholder = new System.Windows.Forms.Panel();
            this.chartExpenses = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblChartTitle = new System.Windows.Forms.Label();
            this.lblChartPlaceholder = new System.Windows.Forms.Label();
            this.cardTopCategory = new System.Windows.Forms.Panel();
            this.lblTopCategory = new System.Windows.Forms.Label();
            this.lblTopCategoryTitle = new System.Windows.Forms.Label();
            this.cardMonthlySpending = new System.Windows.Forms.Panel();
            this.lblMonthlySpending = new System.Windows.Forms.Label();
            this.lblMonthlySpendingTitle = new System.Windows.Forms.Label();
            this.lblStatisticsTitle = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.dashboardPanel.SuspendLayout();
            this.cardExpenses.SuspendLayout();
            this.cardIncome.SuspendLayout();
            this.cardBalance.SuspendLayout();
            this.addExpensePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.categoriesPanel.SuspendLayout();
            this.statisticsPanel.SuspendLayout();
            this.panelChartPlaceholder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).BeginInit();
            this.cardTopCategory.SuspendLayout();
            this.cardMonthlySpending.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnCategories);
            this.sidebarPanel.Controls.Add(this.btnStatistics);
            this.sidebarPanel.Controls.Add(this.btnAddExpense);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(150, 894);
            this.sidebarPanel.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Gray;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Location = new System.Drawing.Point(0, 200);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(150, 50);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Gray;
            this.btnCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Location = new System.Drawing.Point(0, 150);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(150, 50);
            this.btnCategories.TabIndex = 3;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Gray;
            this.btnStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Location = new System.Drawing.Point(0, 100);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(150, 50);
            this.btnStatistics.TabIndex = 2;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.BackColor = System.Drawing.Color.Gray;
            this.btnAddExpense.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddExpense.FlatAppearance.BorderSize = 0;
            this.btnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExpense.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddExpense.ForeColor = System.Drawing.Color.White;
            this.btnAddExpense.Location = new System.Drawing.Point(0, 50);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(150, 50);
            this.btnAddExpense.TabIndex = 1;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = false;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Gray;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(150, 50);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(150, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1372, 83);
            this.topPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(21, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(238, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Expenses Tracker";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.dashboardPanel);
            this.contentPanel.Controls.Add(this.addExpensePanel);
            this.contentPanel.Controls.Add(this.settingsPanel);
            this.contentPanel.Controls.Add(this.categoriesPanel);
            this.contentPanel.Controls.Add(this.statisticsPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(150, 83);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1372, 811);
            this.contentPanel.TabIndex = 2;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.Controls.Add(this.btnAddFunds);
            this.dashboardPanel.Controls.Add(this.label1);
            this.dashboardPanel.Controls.Add(this.btnSaveBudget);
            this.dashboardPanel.Controls.Add(this.txtBudget);
            this.dashboardPanel.Controls.Add(this.cardExpenses);
            this.dashboardPanel.Controls.Add(this.cardIncome);
            this.dashboardPanel.Controls.Add(this.cardBalance);
            this.dashboardPanel.Controls.Add(this.lblDashboardTitle);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(1372, 811);
            this.dashboardPanel.TabIndex = 0;
            // 
            // btnAddFunds
            // 
            this.btnAddFunds.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnAddFunds.FlatAppearance.BorderSize = 0;
            this.btnAddFunds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFunds.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddFunds.ForeColor = System.Drawing.Color.White;
            this.btnAddFunds.Location = new System.Drawing.Point(528, 486);
            this.btnAddFunds.Name = "btnAddFunds";
            this.btnAddFunds.Size = new System.Drawing.Size(200, 45);
            this.btnAddFunds.TabIndex = 16;
            this.btnAddFunds.Text = "Add Funds";
            this.btnAddFunds.UseVisualStyleBackColor = false;
            this.btnAddFunds.Click += new System.EventHandler(this.btnAddFunds_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(566, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Add Budget";
            // 
            // btnSaveBudget
            // 
            this.btnSaveBudget.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSaveBudget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveBudget.FlatAppearance.BorderSize = 0;
            this.btnSaveBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveBudget.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSaveBudget.ForeColor = System.Drawing.Color.White;
            this.btnSaveBudget.Location = new System.Drawing.Point(528, 417);
            this.btnSaveBudget.Name = "btnSaveBudget";
            this.btnSaveBudget.Size = new System.Drawing.Size(200, 45);
            this.btnSaveBudget.TabIndex = 14;
            this.btnSaveBudget.Text = "Set Budget";
            this.btnSaveBudget.UseVisualStyleBackColor = false;
            this.btnSaveBudget.Click += new System.EventHandler(this.btnSaveBudget_Click);
            // 
            // txtBudget
            // 
            this.txtBudget.BackColor = System.Drawing.Color.DimGray;
            this.txtBudget.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtBudget.ForeColor = System.Drawing.Color.White;
            this.txtBudget.Location = new System.Drawing.Point(528, 337);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.Size = new System.Drawing.Size(200, 30);
            this.txtBudget.TabIndex = 13;
            this.txtBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBudget.TextChanged += new System.EventHandler(this.txtBudget_TextChanged);
            // 
            // cardExpenses
            // 
            this.cardExpenses.AutoSize = true;
            this.cardExpenses.BackColor = System.Drawing.Color.DimGray;
            this.cardExpenses.Controls.Add(this.lblTotalExpenses);
            this.cardExpenses.Controls.Add(this.lblExpensesCardTitle);
            this.cardExpenses.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cardExpenses.Location = new System.Drawing.Point(254, 136);
            this.cardExpenses.Name = "cardExpenses";
            this.cardExpenses.Size = new System.Drawing.Size(150, 120);
            this.cardExpenses.TabIndex = 10;
            // 
            // lblTotalExpenses
            // 
            this.lblTotalExpenses.AutoSize = true;
            this.lblTotalExpenses.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalExpenses.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalExpenses.Location = new System.Drawing.Point(10, 50);
            this.lblTotalExpenses.Name = "lblTotalExpenses";
            this.lblTotalExpenses.Size = new System.Drawing.Size(64, 50);
            this.lblTotalExpenses.TabIndex = 1;
            this.lblTotalExpenses.Text = "$0";
            // 
            // lblExpensesCardTitle
            // 
            this.lblExpensesCardTitle.AutoSize = true;
            this.lblExpensesCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblExpensesCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblExpensesCardTitle.Name = "lblExpensesCardTitle";
            this.lblExpensesCardTitle.Size = new System.Drawing.Size(120, 23);
            this.lblExpensesCardTitle.TabIndex = 0;
            this.lblExpensesCardTitle.Text = "Total Expenses";
            // 
            // cardIncome
            // 
            this.cardIncome.AutoSize = true;
            this.cardIncome.BackColor = System.Drawing.Color.DimGray;
            this.cardIncome.Controls.Add(this.lblTotalIncome);
            this.cardIncome.Controls.Add(this.lblIncomeCardTitle);
            this.cardIncome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cardIncome.Location = new System.Drawing.Point(552, 136);
            this.cardIncome.Name = "cardIncome";
            this.cardIncome.Size = new System.Drawing.Size(150, 120);
            this.cardIncome.TabIndex = 11;
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTotalIncome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTotalIncome.Location = new System.Drawing.Point(10, 50);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(64, 50);
            this.lblTotalIncome.TabIndex = 1;
            this.lblTotalIncome.Text = "$0";
            // 
            // lblIncomeCardTitle
            // 
            this.lblIncomeCardTitle.AutoSize = true;
            this.lblIncomeCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblIncomeCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblIncomeCardTitle.Name = "lblIncomeCardTitle";
            this.lblIncomeCardTitle.Size = new System.Drawing.Size(65, 23);
            this.lblIncomeCardTitle.TabIndex = 0;
            this.lblIncomeCardTitle.Text = "Budget";
            this.lblIncomeCardTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cardBalance
            // 
            this.cardBalance.AutoSize = true;
            this.cardBalance.BackColor = System.Drawing.Color.DimGray;
            this.cardBalance.Controls.Add(this.lblCurrentBalance);
            this.cardBalance.Controls.Add(this.lblBalanceCardTitle);
            this.cardBalance.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cardBalance.Location = new System.Drawing.Point(850, 136);
            this.cardBalance.Name = "cardBalance";
            this.cardBalance.Size = new System.Drawing.Size(150, 120);
            this.cardBalance.TabIndex = 12;
            // 
            // lblCurrentBalance
            // 
            this.lblCurrentBalance.AutoSize = true;
            this.lblCurrentBalance.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrentBalance.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblCurrentBalance.Location = new System.Drawing.Point(14, 50);
            this.lblCurrentBalance.Name = "lblCurrentBalance";
            this.lblCurrentBalance.Size = new System.Drawing.Size(64, 50);
            this.lblCurrentBalance.TabIndex = 1;
            this.lblCurrentBalance.Text = "$0";
            // 
            // lblBalanceCardTitle
            // 
            this.lblBalanceCardTitle.AutoSize = true;
            this.lblBalanceCardTitle.ForeColor = System.Drawing.Color.White;
            this.lblBalanceCardTitle.Location = new System.Drawing.Point(15, 15);
            this.lblBalanceCardTitle.Name = "lblBalanceCardTitle";
            this.lblBalanceCardTitle.Size = new System.Drawing.Size(132, 23);
            this.lblBalanceCardTitle.TabIndex = 0;
            this.lblBalanceCardTitle.Text = "Current Balance\n";
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.White;
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 20);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(171, 41);
            this.lblDashboardTitle.TabIndex = 0;
            this.lblDashboardTitle.Text = "Dashboard";
            // 
            // addExpensePanel
            // 
            this.addExpensePanel.Controls.Add(this.btnUpdateExpense);
            this.addExpensePanel.Controls.Add(this.btnEditExpense);
            this.addExpensePanel.Controls.Add(this.btnDeleteExpense);
            this.addExpensePanel.Controls.Add(this.dgvExpenses);
            this.addExpensePanel.Controls.Add(this.btnSaveExpense);
            this.addExpensePanel.Controls.Add(this.dtpExpenseDate);
            this.addExpensePanel.Controls.Add(this.lblDateText);
            this.addExpensePanel.Controls.Add(this.cmbCategory);
            this.addExpensePanel.Controls.Add(this.lblCategoryText);
            this.addExpensePanel.Controls.Add(this.txtAmount);
            this.addExpensePanel.Controls.Add(this.lblAmountText);
            this.addExpensePanel.Controls.Add(this.txtTitle);
            this.addExpensePanel.Controls.Add(this.lblTitleText);
            this.addExpensePanel.Controls.Add(this.lblAddExpenseTitle);
            this.addExpensePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpensePanel.Location = new System.Drawing.Point(0, 0);
            this.addExpensePanel.Name = "addExpensePanel";
            this.addExpensePanel.Size = new System.Drawing.Size(1372, 811);
            this.addExpensePanel.TabIndex = 1;
            // 
            // btnUpdateExpense
            // 
            this.btnUpdateExpense.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnUpdateExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateExpense.FlatAppearance.BorderSize = 0;
            this.btnUpdateExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnUpdateExpense.ForeColor = System.Drawing.Color.White;
            this.btnUpdateExpense.Location = new System.Drawing.Point(185, 533);
            this.btnUpdateExpense.Name = "btnUpdateExpense";
            this.btnUpdateExpense.Size = new System.Drawing.Size(250, 45);
            this.btnUpdateExpense.TabIndex = 13;
            this.btnUpdateExpense.Text = "Update Expense";
            this.btnUpdateExpense.UseVisualStyleBackColor = false;
            this.btnUpdateExpense.Click += new System.EventHandler(this.btnUpdateExpense_Click);
            // 
            // btnEditExpense
            // 
            this.btnEditExpense.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEditExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditExpense.FlatAppearance.BorderSize = 0;
            this.btnEditExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnEditExpense.ForeColor = System.Drawing.Color.White;
            this.btnEditExpense.Location = new System.Drawing.Point(797, 533);
            this.btnEditExpense.Name = "btnEditExpense";
            this.btnEditExpense.Size = new System.Drawing.Size(250, 45);
            this.btnEditExpense.TabIndex = 12;
            this.btnEditExpense.Text = "Edit Expense";
            this.btnEditExpense.UseVisualStyleBackColor = false;
            this.btnEditExpense.Click += new System.EventHandler(this.btnEditExpense_Click);
            // 
            // btnDeleteExpense
            // 
            this.btnDeleteExpense.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnDeleteExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteExpense.FlatAppearance.BorderSize = 0;
            this.btnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnDeleteExpense.ForeColor = System.Drawing.Color.White;
            this.btnDeleteExpense.Location = new System.Drawing.Point(1086, 533);
            this.btnDeleteExpense.Name = "btnDeleteExpense";
            this.btnDeleteExpense.Size = new System.Drawing.Size(250, 45);
            this.btnDeleteExpense.TabIndex = 11;
            this.btnDeleteExpense.Text = "Delete Expense";
            this.btnDeleteExpense.UseVisualStyleBackColor = false;
            this.btnDeleteExpense.Click += new System.EventHandler(this.btnDeleteExpense_Click);
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Amount,
            this.Category,
            this.Date});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8.16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpenses.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpenses.Location = new System.Drawing.Point(782, 0);
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dgvExpenses.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpenses.RowTemplate.Height = 24;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Size = new System.Drawing.Size(554, 512);
            this.dgvExpenses.TabIndex = 10;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 125;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.MinimumWidth = 6;
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // btnSaveExpense
            // 
            this.btnSaveExpense.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSaveExpense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveExpense.FlatAppearance.BorderSize = 0;
            this.btnSaveExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExpense.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSaveExpense.ForeColor = System.Drawing.Color.White;
            this.btnSaveExpense.Location = new System.Drawing.Point(185, 419);
            this.btnSaveExpense.Name = "btnSaveExpense";
            this.btnSaveExpense.Size = new System.Drawing.Size(250, 45);
            this.btnSaveExpense.TabIndex = 9;
            this.btnSaveExpense.Text = " Add Expense";
            this.btnSaveExpense.UseVisualStyleBackColor = false;
            this.btnSaveExpense.Click += new System.EventHandler(this.btnSaveExpense_Click);
            // 
            // dtpExpenseDate
            // 
            this.dtpExpenseDate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.dtpExpenseDate.Location = new System.Drawing.Point(74, 323);
            this.dtpExpenseDate.Name = "dtpExpenseDate";
            this.dtpExpenseDate.Size = new System.Drawing.Size(250, 30);
            this.dtpExpenseDate.TabIndex = 8;
            // 
            // lblDateText
            // 
            this.lblDateText.AutoSize = true;
            this.lblDateText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblDateText.ForeColor = System.Drawing.Color.White;
            this.lblDateText.Location = new System.Drawing.Point(90, 292);
            this.lblDateText.Name = "lblDateText";
            this.lblDateText.Size = new System.Drawing.Size(51, 23);
            this.lblDateText.TabIndex = 7;
            this.lblDateText.Text = " Date";
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.DimGray;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Food",
            "",
            "Transport",
            "",
            "Bills",
            "",
            "Entertainment",
            "",
            "Shopping",
            "",
            "Health"});
            this.cmbCategory.Location = new System.Drawing.Point(397, 322);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(250, 31);
            this.cmbCategory.TabIndex = 6;
            // 
            // lblCategoryText
            // 
            this.lblCategoryText.AutoSize = true;
            this.lblCategoryText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCategoryText.ForeColor = System.Drawing.Color.White;
            this.lblCategoryText.Location = new System.Drawing.Point(410, 292);
            this.lblCategoryText.Name = "lblCategoryText";
            this.lblCategoryText.Size = new System.Drawing.Size(79, 23);
            this.lblCategoryText.TabIndex = 5;
            this.lblCategoryText.Text = "Category";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.DimGray;
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtAmount.Location = new System.Drawing.Point(397, 175);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 30);
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmountText
            // 
            this.lblAmountText.AutoSize = true;
            this.lblAmountText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAmountText.ForeColor = System.Drawing.Color.White;
            this.lblAmountText.Location = new System.Drawing.Point(410, 140);
            this.lblAmountText.Name = "lblAmountText";
            this.lblAmountText.Size = new System.Drawing.Size(72, 23);
            this.lblAmountText.TabIndex = 3;
            this.lblAmountText.Text = "Amount";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DimGray;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtTitle.Location = new System.Drawing.Point(74, 175);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 30);
            this.txtTitle.TabIndex = 2;
            // 
            // lblTitleText
            // 
            this.lblTitleText.AutoSize = true;
            this.lblTitleText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTitleText.ForeColor = System.Drawing.Color.White;
            this.lblTitleText.Location = new System.Drawing.Point(90, 136);
            this.lblTitleText.Name = "lblTitleText";
            this.lblTitleText.Size = new System.Drawing.Size(42, 23);
            this.lblTitleText.TabIndex = 1;
            this.lblTitleText.Text = "Title";
            // 
            // lblAddExpenseTitle
            // 
            this.lblAddExpenseTitle.AutoSize = true;
            this.lblAddExpenseTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAddExpenseTitle.ForeColor = System.Drawing.Color.White;
            this.lblAddExpenseTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAddExpenseTitle.Name = "lblAddExpenseTitle";
            this.lblAddExpenseTitle.Size = new System.Drawing.Size(200, 41);
            this.lblAddExpenseTitle.TabIndex = 0;
            this.lblAddExpenseTitle.Text = "Add Expense";
            // 
            // settingsPanel
            // 
            this.settingsPanel.AutoSize = true;
            this.settingsPanel.Controls.Add(this.btnSaveSettings);
            this.settingsPanel.Controls.Add(this.cmbTheme);
            this.settingsPanel.Controls.Add(this.lblTheme);
            this.settingsPanel.Controls.Add(this.cmbCurrency);
            this.settingsPanel.Controls.Add(this.lblCurrency);
            this.settingsPanel.Controls.Add(this.lblSettingsTitle);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(1372, 811);
            this.settingsPanel.TabIndex = 1;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSaveSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSettings.FlatAppearance.BorderSize = 0;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
            this.btnSaveSettings.Location = new System.Drawing.Point(164, 407);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(150, 40);
            this.btnSaveSettings.TabIndex = 5;
            this.btnSaveSettings.Text = "Save Settings";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // cmbTheme
            // 
            this.cmbTheme.BackColor = System.Drawing.Color.Gray;
            this.cmbTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbTheme.ForeColor = System.Drawing.Color.White;
            this.cmbTheme.FormattingEnabled = true;
            this.cmbTheme.Location = new System.Drawing.Point(147, 298);
            this.cmbTheme.Name = "cmbTheme";
            this.cmbTheme.Size = new System.Drawing.Size(200, 36);
            this.cmbTheme.TabIndex = 4;
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.BackColor = System.Drawing.Color.Transparent;
            this.lblTheme.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTheme.ForeColor = System.Drawing.Color.White;
            this.lblTheme.Location = new System.Drawing.Point(150, 241);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(70, 28);
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Theme";
            // 
            // cmbCurrency
            // 
            this.cmbCurrency.BackColor = System.Drawing.Color.Gray;
            this.cmbCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmbCurrency.ForeColor = System.Drawing.Color.White;
            this.cmbCurrency.FormattingEnabled = true;
            this.cmbCurrency.Location = new System.Drawing.Point(147, 151);
            this.cmbCurrency.Name = "cmbCurrency";
            this.cmbCurrency.Size = new System.Drawing.Size(200, 36);
            this.cmbCurrency.TabIndex = 2;
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrency.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCurrency.ForeColor = System.Drawing.Color.White;
            this.lblCurrency.Location = new System.Drawing.Point(142, 100);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(89, 28);
            this.lblCurrency.TabIndex = 1;
            this.lblCurrency.Text = "Currency";
            // 
            // lblSettingsTitle
            // 
            this.lblSettingsTitle.AutoSize = true;
            this.lblSettingsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblSettingsTitle.ForeColor = System.Drawing.Color.White;
            this.lblSettingsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblSettingsTitle.Name = "lblSettingsTitle";
            this.lblSettingsTitle.Size = new System.Drawing.Size(134, 41);
            this.lblSettingsTitle.TabIndex = 0;
            this.lblSettingsTitle.Text = "Settings";
            // 
            // categoriesPanel
            // 
            this.categoriesPanel.Controls.Add(this.lstCategories);
            this.categoriesPanel.Controls.Add(this.btnAddCategory);
            this.categoriesPanel.Controls.Add(this.txtCategoryName);
            this.categoriesPanel.Controls.Add(this.lblCategoryName);
            this.categoriesPanel.Controls.Add(this.lblCategoriesTitle);
            this.categoriesPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesPanel.Location = new System.Drawing.Point(0, 0);
            this.categoriesPanel.Name = "categoriesPanel";
            this.categoriesPanel.Size = new System.Drawing.Size(1372, 811);
            this.categoriesPanel.TabIndex = 1;
            // 
            // lstCategories
            // 
            this.lstCategories.BackColor = System.Drawing.Color.DarkGray;
            this.lstCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCategories.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lstCategories.ForeColor = System.Drawing.Color.White;
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 25;
            this.lstCategories.Items.AddRange(new object[] {
            "Food",
            "Transport",
            "Bills",
            "Entertainment",
            "Shopping",
            "Health"});
            this.lstCategories.Location = new System.Drawing.Point(215, 237);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(420, 227);
            this.lstCategories.TabIndex = 4;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(563, 136);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(150, 40);
            this.btnAddCategory.TabIndex = 3;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.BackColor = System.Drawing.Color.DarkGray;
            this.txtCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.txtCategoryName.ForeColor = System.Drawing.Color.White;
            this.txtCategoryName.Location = new System.Drawing.Point(185, 145);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(250, 31);
            this.txtCategoryName.TabIndex = 2;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.White;
            this.lblCategoryName.Location = new System.Drawing.Point(237, 95);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(149, 28);
            this.lblCategoryName.TabIndex = 1;
            this.lblCategoryName.Text = "Category Name";
            // 
            // lblCategoriesTitle
            // 
            this.lblCategoriesTitle.AutoSize = true;
            this.lblCategoriesTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblCategoriesTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblCategoriesTitle.ForeColor = System.Drawing.Color.White;
            this.lblCategoriesTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCategoriesTitle.Name = "lblCategoriesTitle";
            this.lblCategoriesTitle.Size = new System.Drawing.Size(168, 41);
            this.lblCategoriesTitle.TabIndex = 0;
            this.lblCategoriesTitle.Text = "Categories";
            // 
            // statisticsPanel
            // 
            this.statisticsPanel.Controls.Add(this.panelChartPlaceholder);
            this.statisticsPanel.Controls.Add(this.cardTopCategory);
            this.statisticsPanel.Controls.Add(this.cardMonthlySpending);
            this.statisticsPanel.Controls.Add(this.lblStatisticsTitle);
            this.statisticsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statisticsPanel.Location = new System.Drawing.Point(0, 0);
            this.statisticsPanel.Name = "statisticsPanel";
            this.statisticsPanel.Size = new System.Drawing.Size(1372, 811);
            this.statisticsPanel.TabIndex = 13;
            // 
            // panelChartPlaceholder
            // 
            this.panelChartPlaceholder.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelChartPlaceholder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChartPlaceholder.Controls.Add(this.chartExpenses);
            this.panelChartPlaceholder.Controls.Add(this.lblChartTitle);
            this.panelChartPlaceholder.Controls.Add(this.lblChartPlaceholder);
            this.panelChartPlaceholder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelChartPlaceholder.Location = new System.Drawing.Point(0, 337);
            this.panelChartPlaceholder.Name = "panelChartPlaceholder";
            this.panelChartPlaceholder.Size = new System.Drawing.Size(1372, 474);
            this.panelChartPlaceholder.TabIndex = 3;
            // 
            // chartExpenses
            // 
            chartArea1.Name = "ChartArea1";
            this.chartExpenses.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartExpenses.Legends.Add(legend1);
            this.chartExpenses.Location = new System.Drawing.Point(319, 36);
            this.chartExpenses.Name = "chartExpenses";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartExpenses.Series.Add(series1);
            this.chartExpenses.Size = new System.Drawing.Size(976, 317);
            this.chartExpenses.TabIndex = 2;
            this.chartExpenses.Text = "chart1";
            // 
            // lblChartTitle
            // 
            this.lblChartTitle.AutoSize = true;
            this.lblChartTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblChartTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblChartTitle.ForeColor = System.Drawing.Color.White;
            this.lblChartTitle.Location = new System.Drawing.Point(15, 15);
            this.lblChartTitle.Name = "lblChartTitle";
            this.lblChartTitle.Size = new System.Drawing.Size(182, 28);
            this.lblChartTitle.TabIndex = 0;
            this.lblChartTitle.Text = "Expense Analytics";
            // 
            // lblChartPlaceholder
            // 
            this.lblChartPlaceholder.AutoSize = true;
            this.lblChartPlaceholder.BackColor = System.Drawing.Color.Transparent;
            this.lblChartPlaceholder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblChartPlaceholder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblChartPlaceholder.Location = new System.Drawing.Point(55, 93);
            this.lblChartPlaceholder.Name = "lblChartPlaceholder";
            this.lblChartPlaceholder.Size = new System.Drawing.Size(249, 31);
            this.lblChartPlaceholder.TabIndex = 1;
            this.lblChartPlaceholder.Text = "Charts will appear here";
            // 
            // cardTopCategory
            // 
            this.cardTopCategory.BackColor = System.Drawing.Color.DimGray;
            this.cardTopCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTopCategory.Controls.Add(this.lblTopCategory);
            this.cardTopCategory.Controls.Add(this.lblTopCategoryTitle);
            this.cardTopCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cardTopCategory.ForeColor = System.Drawing.Color.White;
            this.cardTopCategory.Location = new System.Drawing.Point(797, 117);
            this.cardTopCategory.Name = "cardTopCategory";
            this.cardTopCategory.Size = new System.Drawing.Size(250, 120);
            this.cardTopCategory.TabIndex = 2;
            this.cardTopCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.cardTopCategory_Paint);
            // 
            // lblTopCategory
            // 
            this.lblTopCategory.AutoSize = true;
            this.lblTopCategory.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTopCategory.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblTopCategory.Location = new System.Drawing.Point(94, 65);
            this.lblTopCategory.Name = "lblTopCategory";
            this.lblTopCategory.Size = new System.Drawing.Size(0, 23);
            this.lblTopCategory.TabIndex = 1;
            this.lblTopCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopCategoryTitle
            // 
            this.lblTopCategoryTitle.AutoSize = true;
            this.lblTopCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTopCategoryTitle.Location = new System.Drawing.Point(64, 20);
            this.lblTopCategoryTitle.Name = "lblTopCategoryTitle";
            this.lblTopCategoryTitle.Size = new System.Drawing.Size(118, 23);
            this.lblTopCategoryTitle.TabIndex = 0;
            this.lblTopCategoryTitle.Text = "Top Category";
            this.lblTopCategoryTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTopCategoryTitle.Click += new System.EventHandler(this.lblTopCategoryTitle_Click);
            // 
            // cardMonthlySpending
            // 
            this.cardMonthlySpending.BackColor = System.Drawing.Color.DimGray;
            this.cardMonthlySpending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMonthlySpending.Controls.Add(this.lblMonthlySpending);
            this.cardMonthlySpending.Controls.Add(this.lblMonthlySpendingTitle);
            this.cardMonthlySpending.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cardMonthlySpending.ForeColor = System.Drawing.Color.White;
            this.cardMonthlySpending.Location = new System.Drawing.Point(385, 117);
            this.cardMonthlySpending.Name = "cardMonthlySpending";
            this.cardMonthlySpending.Size = new System.Drawing.Size(250, 120);
            this.cardMonthlySpending.TabIndex = 1;
            // 
            // lblMonthlySpending
            // 
            this.lblMonthlySpending.AutoSize = true;
            this.lblMonthlySpending.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMonthlySpending.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlySpending.Location = new System.Drawing.Point(94, 65);
            this.lblMonthlySpending.Name = "lblMonthlySpending";
            this.lblMonthlySpending.Size = new System.Drawing.Size(36, 28);
            this.lblMonthlySpending.TabIndex = 1;
            this.lblMonthlySpending.Text = "0$";
            this.lblMonthlySpending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthlySpendingTitle
            // 
            this.lblMonthlySpendingTitle.AutoSize = true;
            this.lblMonthlySpendingTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblMonthlySpendingTitle.Location = new System.Drawing.Point(44, 21);
            this.lblMonthlySpendingTitle.Name = "lblMonthlySpendingTitle";
            this.lblMonthlySpendingTitle.Size = new System.Drawing.Size(159, 23);
            this.lblMonthlySpendingTitle.TabIndex = 0;
            this.lblMonthlySpendingTitle.Text = "Monthly Spending";
            this.lblMonthlySpendingTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblStatisticsTitle
            // 
            this.lblStatisticsTitle.AutoSize = true;
            this.lblStatisticsTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatisticsTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblStatisticsTitle.ForeColor = System.Drawing.Color.White;
            this.lblStatisticsTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStatisticsTitle.Name = "lblStatisticsTitle";
            this.lblStatisticsTitle.Size = new System.Drawing.Size(144, 41);
            this.lblStatisticsTitle.TabIndex = 0;
            this.lblStatisticsTitle.Text = "Statistics";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1522, 894);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.16F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1200, 822);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Expenses Tracker";
            
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.dashboardPanel.ResumeLayout(false);
            this.dashboardPanel.PerformLayout();
            this.cardExpenses.ResumeLayout(false);
            this.cardExpenses.PerformLayout();
            this.cardIncome.ResumeLayout(false);
            this.cardIncome.PerformLayout();
            this.cardBalance.ResumeLayout(false);
            this.cardBalance.PerformLayout();
            this.addExpensePanel.ResumeLayout(false);
            this.addExpensePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.categoriesPanel.ResumeLayout(false);
            this.categoriesPanel.PerformLayout();
            this.statisticsPanel.ResumeLayout(false);
            this.statisticsPanel.PerformLayout();
            this.panelChartPlaceholder.ResumeLayout(false);
            this.panelChartPlaceholder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartExpenses)).EndInit();
            this.cardTopCategory.ResumeLayout(false);
            this.cardTopCategory.PerformLayout();
            this.cardMonthlySpending.ResumeLayout(false);
            this.cardMonthlySpending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Panel addExpensePanel;
        private System.Windows.Forms.Label lblAddExpenseTitle;
        private System.Windows.Forms.Label lblTitleText;
        private System.Windows.Forms.Label lblAmountText;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategoryText;
        private System.Windows.Forms.Label lblDateText;
        private System.Windows.Forms.Button btnSaveExpense;
        private System.Windows.Forms.DateTimePicker dtpExpenseDate;
        private System.Windows.Forms.Panel cardExpenses;
        private System.Windows.Forms.Label lblExpensesCardTitle;
        private System.Windows.Forms.Label lblTotalExpenses;
        private System.Windows.Forms.Panel cardBalance;
        private System.Windows.Forms.Label lblCurrentBalance;
        private System.Windows.Forms.Label lblBalanceCardTitle;
        private System.Windows.Forms.Panel cardIncome;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblIncomeCardTitle;
        private System.Windows.Forms.Panel statisticsPanel;
        private System.Windows.Forms.Label lblStatisticsTitle;
        private System.Windows.Forms.Panel categoriesPanel;
        private System.Windows.Forms.Label lblCategoriesTitle;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label lblSettingsTitle;
        private System.Windows.Forms.Panel cardMonthlySpending;
        private System.Windows.Forms.Label lblMonthlySpending;
        private System.Windows.Forms.Label lblMonthlySpendingTitle;
        private System.Windows.Forms.Panel cardTopCategory;
        private System.Windows.Forms.Label lblTopCategory;
        private System.Windows.Forms.Label lblTopCategoryTitle;
        private System.Windows.Forms.Panel panelChartPlaceholder;
        private System.Windows.Forms.Label lblChartTitle;
        private System.Windows.Forms.Label lblChartPlaceholder;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.ComboBox cmbCurrency;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.ComboBox cmbTheme;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button btnDeleteExpense;
        private System.Windows.Forms.Button btnEditExpense;
        private System.Windows.Forms.Button btnUpdateExpense;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartExpenses;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Button btnSaveBudget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFunds;
    }
}

