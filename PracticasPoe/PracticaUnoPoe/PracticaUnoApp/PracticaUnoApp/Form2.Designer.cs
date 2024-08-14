namespace PracticaUnoApp
{
    partial class Form2
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
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            EjeYLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            EjeXLlabel = new Label();
            nameClickLabel = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 149);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "MouseDown y MouseUp";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(30, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 93);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nameClickLabel);
            groupBox2.Location = new Point(43, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "MouseWheel";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(EjeYLabel);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(EjeXLlabel);
            groupBox3.Location = new Point(348, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "MouseMove";
            // 
            // EjeYLabel
            // 
            EjeYLabel.AutoSize = true;
            EjeYLabel.Location = new Point(6, 62);
            EjeYLabel.Name = "EjeYLabel";
            EjeYLabel.Size = new Size(35, 15);
            EjeYLabel.TabIndex = 3;
            EjeYLabel.Text = "Eje Y:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(119, 62);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 19);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // EjeXLlabel
            // 
            EjeXLlabel.AutoSize = true;
            EjeXLlabel.Location = new Point(3, 19);
            EjeXLlabel.Name = "EjeXLlabel";
            EjeXLlabel.Size = new Size(35, 15);
            EjeXLlabel.TabIndex = 0;
            EjeXLlabel.Text = "Eje X:";
            // 
            // nameClickLabel
            // 
            nameClickLabel.AutoSize = true;
            nameClickLabel.Location = new Point(67, 43);
            nameClickLabel.Name = "nameClickLabel";
            nameClickLabel.Size = new Size(35, 15);
            nameClickLabel.TabIndex = 0;
            nameClickLabel.Text = "Nada";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label EjeYLabel;
        private Label label4;
        private Label label3;
        private Label EjeXLlabel;
        private PictureBox pictureBox1;
        private Label nameClickLabel;
    }
}