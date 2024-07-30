namespace BankAccountUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLabel = new Label();
            balanceGroupBox = new GroupBox();
            getBalanceButton = new Button();
            saveDepositButton = new Button();
            depositGroupBox = new GroupBox();
            depositTextBox = new TextBox();
            withDrawgroupBox = new GroupBox();
            withDrawTextBox = new TextBox();
            withDrawButton = new Button();
            balanceGroupBox.SuspendLayout();
            depositGroupBox.SuspendLayout();
            withDrawgroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(133, 43);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(278, 21);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Administración de Cuenta Bancaria";
            // 
            // balanceGroupBox
            // 
            balanceGroupBox.Controls.Add(getBalanceButton);
            balanceGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            balanceGroupBox.Location = new Point(12, 96);
            balanceGroupBox.Name = "balanceGroupBox";
            balanceGroupBox.Size = new Size(183, 290);
            balanceGroupBox.TabIndex = 1;
            balanceGroupBox.TabStop = false;
            balanceGroupBox.Text = "Ver Saldo";
            // 
            // getBalanceButton
            // 
            getBalanceButton.Location = new Point(28, 77);
            getBalanceButton.Name = "getBalanceButton";
            getBalanceButton.Size = new Size(111, 57);
            getBalanceButton.TabIndex = 0;
            getBalanceButton.Text = "Ver Saldo";
            getBalanceButton.UseVisualStyleBackColor = true;
            getBalanceButton.Click += getBalanceButton_Click;
            // 
            // saveDepositButton
            // 
            saveDepositButton.Location = new Point(28, 77);
            saveDepositButton.Name = "saveDepositButton";
            saveDepositButton.Size = new Size(111, 57);
            saveDepositButton.TabIndex = 0;
            saveDepositButton.Text = "Hacer Deposito";
            saveDepositButton.UseVisualStyleBackColor = true;
            saveDepositButton.Click += saveDepositButton_Click;
            // 
            // depositGroupBox
            // 
            depositGroupBox.Controls.Add(depositTextBox);
            depositGroupBox.Controls.Add(saveDepositButton);
            depositGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositGroupBox.Location = new Point(228, 96);
            depositGroupBox.Name = "depositGroupBox";
            depositGroupBox.Size = new Size(183, 290);
            depositGroupBox.TabIndex = 2;
            depositGroupBox.TabStop = false;
            depositGroupBox.Text = "Depositos";
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(28, 28);
            depositTextBox.Multiline = true;
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(132, 30);
            depositTextBox.TabIndex = 1;
            // 
            // withDrawgroupBox
            // 
            withDrawgroupBox.Controls.Add(withDrawTextBox);
            withDrawgroupBox.Controls.Add(withDrawButton);
            withDrawgroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withDrawgroupBox.Location = new Point(417, 96);
            withDrawgroupBox.Name = "withDrawgroupBox";
            withDrawgroupBox.Size = new Size(183, 290);
            withDrawgroupBox.TabIndex = 3;
            withDrawgroupBox.TabStop = false;
            withDrawgroupBox.Text = "Retiros";
            // 
            // withDrawTextBox
            // 
            withDrawTextBox.Location = new Point(28, 28);
            withDrawTextBox.Multiline = true;
            withDrawTextBox.Name = "withDrawTextBox";
            withDrawTextBox.Size = new Size(132, 30);
            withDrawTextBox.TabIndex = 1;
            // 
            // withDrawButton
            // 
            withDrawButton.Location = new Point(28, 77);
            withDrawButton.Name = "withDrawButton";
            withDrawButton.Size = new Size(111, 57);
            withDrawButton.TabIndex = 0;
            withDrawButton.Text = "Retirar";
            withDrawButton.UseVisualStyleBackColor = true;
            withDrawButton.Click += withDrawButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 507);
            Controls.Add(withDrawgroupBox);
            Controls.Add(depositGroupBox);
            Controls.Add(balanceGroupBox);
            Controls.Add(titleLabel);
            Name = "MainForm";
            Text = "Form1";
            balanceGroupBox.ResumeLayout(false);
            depositGroupBox.ResumeLayout(false);
            depositGroupBox.PerformLayout();
            withDrawgroupBox.ResumeLayout(false);
            withDrawgroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private GroupBox balanceGroupBox;
        private Button getBalanceButton;
        private Button saveDepositButton;
        private GroupBox depositGroupBox;
        private TextBox depositTextBox;
        private GroupBox withDrawgroupBox;
        private TextBox withDrawTextBox;
        private Button withDrawButton;
    }
}
