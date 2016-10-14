namespace BankingCIS166
{
    partial class BankingForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AmountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddTransButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PayeeTextBox = new System.Windows.Forms.TextBox();
            this.CheckTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ValidationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.TransListBox = new System.Windows.Forms.ListBox();
            this.HeadingLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FeeRadioButton = new System.Windows.Forms.RadioButton();
            this.WithdrawRadioButton = new System.Windows.Forms.RadioButton();
            this.DepositRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeSaveLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Date:";
            // 
            // AmountTextBox
            // 
            this.AmountTextBox.Location = new System.Drawing.Point(110, 487);
            this.AmountTextBox.Name = "AmountTextBox";
            this.AmountTextBox.Size = new System.Drawing.Size(70, 20);
            this.AmountTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.AmountTextBox, "Transaction amount");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 493);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "&Amount:";
            // 
            // AddTransButton
            // 
            this.AddTransButton.Location = new System.Drawing.Point(110, 527);
            this.AddTransButton.Name = "AddTransButton";
            this.AddTransButton.Size = new System.Drawing.Size(136, 32);
            this.AddTransButton.TabIndex = 9;
            this.AddTransButton.Text = "&Add Transaction";
            this.toolTip1.SetToolTip(this.AddTransButton, "Submit transaction and calculate new balance");
            this.AddTransButton.UseVisualStyleBackColor = true;
            this.AddTransButton.Click += new System.EventHandler(this.AddTransButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(249, 527);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(60, 32);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "C&lear";
            this.toolTip1.SetToolTip(this.ClearButton, "Clear date, payee, check #,  and amount");
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(199, 84);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(84, 14);
            this.BalanceLabel.TabIndex = 14;
            this.BalanceLabel.Text = "$0.00";
            this.BalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.BalanceLabel, "All Transactions Total");
            // 
            // DatePicker
            // 
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(110, 461);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(98, 20);
            this.DatePicker.TabIndex = 2;
            this.toolTip1.SetToolTip(this.DatePicker, "Select transaction date");
            this.DatePicker.Value = new System.DateTime(2014, 2, 6, 9, 11, 11, 0);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(312, 527);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(60, 32);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.ExitButton, "Close Program");
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // PayeeTextBox
            // 
            this.PayeeTextBox.Location = new System.Drawing.Point(272, 460);
            this.PayeeTextBox.Name = "PayeeTextBox";
            this.PayeeTextBox.Size = new System.Drawing.Size(100, 20);
            this.PayeeTextBox.TabIndex = 6;
            this.toolTip1.SetToolTip(this.PayeeTextBox, "Payee required during withdraw transaction");
            // 
            // CheckTextBox
            // 
            this.CheckTextBox.Location = new System.Drawing.Point(272, 490);
            this.CheckTextBox.Name = "CheckTextBox";
            this.CheckTextBox.Size = new System.Drawing.Size(100, 20);
            this.CheckTextBox.TabIndex = 8;
            this.toolTip1.SetToolTip(this.CheckTextBox, "check number");
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(24, 411);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(59, 23);
            this.RemoveButton.TabIndex = 22;
            this.RemoveButton.Text = "&Remove";
            this.toolTip1.SetToolTip(this.RemoveButton, "Remove selected transaction");
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Balance";
            // 
            // ValidationErrorProvider
            // 
            this.ValidationErrorProvider.ContainerControl = this;
            // 
            // TransListBox
            // 
            this.TransListBox.FormattingEnabled = true;
            this.TransListBox.Location = new System.Drawing.Point(24, 116);
            this.TransListBox.Name = "TransListBox";
            this.TransListBox.Size = new System.Drawing.Size(435, 290);
            this.TransListBox.TabIndex = 12;
            this.TransListBox.SelectedIndexChanged += new System.EventHandler(this.TransListBox_SelectedIndexChanged);
            // 
            // HeadingLabel
            // 
            this.HeadingLabel.Location = new System.Drawing.Point(21, 98);
            this.HeadingLabel.Name = "HeadingLabel";
            this.HeadingLabel.Size = new System.Drawing.Size(438, 15);
            this.HeadingLabel.TabIndex = 15;
            this.HeadingLabel.Text = "Heading";
            this.HeadingLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FeeRadioButton);
            this.groupBox1.Controls.Add(this.WithdrawRadioButton);
            this.groupBox1.Controls.Add(this.DepositRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(110, 412);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Type";
            // 
            // FeeRadioButton
            // 
            this.FeeRadioButton.AutoSize = true;
            this.FeeRadioButton.Location = new System.Drawing.Point(165, 20);
            this.FeeRadioButton.Name = "FeeRadioButton";
            this.FeeRadioButton.Size = new System.Drawing.Size(82, 17);
            this.FeeRadioButton.TabIndex = 2;
            this.FeeRadioButton.TabStop = true;
            this.FeeRadioButton.Text = "Service &Fee";
            this.FeeRadioButton.UseVisualStyleBackColor = true;
            this.FeeRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // WithdrawRadioButton
            // 
            this.WithdrawRadioButton.AutoSize = true;
            this.WithdrawRadioButton.Location = new System.Drawing.Point(81, 20);
            this.WithdrawRadioButton.Name = "WithdrawRadioButton";
            this.WithdrawRadioButton.Size = new System.Drawing.Size(70, 17);
            this.WithdrawRadioButton.TabIndex = 1;
            this.WithdrawRadioButton.TabStop = true;
            this.WithdrawRadioButton.Text = "Withdraw";
            this.WithdrawRadioButton.UseVisualStyleBackColor = true;
            this.WithdrawRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // DepositRadioButton
            // 
            this.DepositRadioButton.AutoSize = true;
            this.DepositRadioButton.Location = new System.Drawing.Point(6, 20);
            this.DepositRadioButton.Name = "DepositRadioButton";
            this.DepositRadioButton.Size = new System.Drawing.Size(61, 17);
            this.DepositRadioButton.TabIndex = 0;
            this.DepositRadioButton.TabStop = true;
            this.DepositRadioButton.Text = "&Deposit";
            this.DepositRadioButton.UseVisualStyleBackColor = true;
            this.DepositRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "&Payee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 493);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "&Check #";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(482, 24);
            this.menuStrip1.TabIndex = 23;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeSaveLocationToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // changeSaveLocationToolStripMenuItem
            // 
            this.changeSaveLocationToolStripMenuItem.Name = "changeSaveLocationToolStripMenuItem";
            this.changeSaveLocationToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.changeSaveLocationToolStripMenuItem.Text = "&Change Save Location";
            this.changeSaveLocationToolStripMenuItem.Click += new System.EventHandler(this.changeSaveLocationToolStripMenuItem_Click);
            // 
            // BankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 569);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckTextBox);
            this.Controls.Add(this.PayeeTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HeadingLabel);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.TransListBox);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AddTransButton);
            this.Controls.Add(this.AmountTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BankingForm";
            this.Text = "Banking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BankingForm_FormClosing);
            this.Load += new System.EventHandler(this.BankingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ValidationErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox AmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddTransButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.ErrorProvider ValidationErrorProvider;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.ListBox TransListBox;
        private System.Windows.Forms.Label HeadingLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CheckTextBox;
        private System.Windows.Forms.TextBox PayeeTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FeeRadioButton;
        private System.Windows.Forms.RadioButton WithdrawRadioButton;
        private System.Windows.Forms.RadioButton DepositRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeSaveLocationToolStripMenuItem;
    }
}

