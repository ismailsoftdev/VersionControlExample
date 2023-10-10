namespace VersionControlExample
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFullName = new TextBox();
            txtBoxAddress = new TextBox();
            SaveBtn = new Button();
            LblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 28);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 0;
            label1.Text = "Version Control Example";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(126, 98);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 1;
            label2.Text = "Enter your name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(126, 158);
            label3.Name = "label3";
            label3.Size = new Size(140, 21);
            label3.TabIndex = 2;
            label3.Text = "Enter your address";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(303, 96);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(343, 23);
            txtFullName.TabIndex = 3;
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.Location = new Point(303, 160);
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(343, 23);
            txtBoxAddress.TabIndex = 4;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(349, 224);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(135, 45);
            SaveBtn.TabIndex = 5;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            LblResult.Location = new Point(235, 325);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(0, 25);
            LblResult.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LblResult);
            Controls.Add(SaveBtn);
            Controls.Add(txtBoxAddress);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private TextBox txtBoxAddress;
        private Button SaveBtn;
        private Label LblResult;
    }
}