namespace ControldeCitas
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.appointmentLabel = new System.Windows.Forms.Label();
            this.appointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.validationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.appointmentErrrorLabel = new System.Windows.Forms.Label();
            this.ageErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(30, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(58, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nombre";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(153, 36);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(139, 22);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Control de Citas";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(93, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(325, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextBox_Validating);
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(93, 125);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(325, 20);
            this.ageTextBox.TabIndex = 5;
            this.ageTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ageTextBox_Validating);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(34, 123);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(41, 20);
            this.ageLabel.TabIndex = 4;
            this.ageLabel.Text = "Edad";
            // 
            // appointmentLabel
            // 
            this.appointmentLabel.AutoSize = true;
            this.appointmentLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentLabel.Location = new System.Drawing.Point(12, 174);
            this.appointmentLabel.Name = "appointmentLabel";
            this.appointmentLabel.Size = new System.Drawing.Size(90, 19);
            this.appointmentLabel.TabIndex = 6;
            this.appointmentLabel.Text = "Fecha Cita";
            // 
            // appointmentDatePicker
            // 
            this.appointmentDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.appointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDatePicker.Location = new System.Drawing.Point(127, 174);
            this.appointmentDatePicker.Name = "appointmentDatePicker";
            this.appointmentDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.appointmentDatePicker.Size = new System.Drawing.Size(262, 24);
            this.appointmentDatePicker.TabIndex = 7;
            this.appointmentDatePicker.Validating += new System.ComponentModel.CancelEventHandler(this.appointmentDatePicker_Validating);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(164, 227);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(128, 29);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // validationErrorProvider
            // 
            this.validationErrorProvider.ContainerControl = this;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(94, 99);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.TabIndex = 9;
            // 
            // appointmentErrrorLabel
            // 
            this.appointmentErrrorLabel.AutoSize = true;
            this.appointmentErrrorLabel.ForeColor = System.Drawing.Color.Red;
            this.appointmentErrrorLabel.Location = new System.Drawing.Point(124, 201);
            this.appointmentErrrorLabel.Name = "appointmentErrrorLabel";
            this.appointmentErrrorLabel.Size = new System.Drawing.Size(0, 13);
            this.appointmentErrrorLabel.TabIndex = 10;
            // 
            // ageErrorLabel
            // 
            this.ageErrorLabel.AutoSize = true;
            this.ageErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ageErrorLabel.Location = new System.Drawing.Point(94, 148);
            this.ageErrorLabel.Name = "ageErrorLabel";
            this.ageErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.ageErrorLabel.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.ageErrorLabel);
            this.Controls.Add(this.appointmentErrrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.appointmentDatePicker);
            this.Controls.Add(this.appointmentLabel);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label appointmentLabel;
        private System.Windows.Forms.DateTimePicker appointmentDatePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ErrorProvider validationErrorProvider;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label appointmentErrrorLabel;
        private System.Windows.Forms.Label ageErrorLabel;
    }
}

