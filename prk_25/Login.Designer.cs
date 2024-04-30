namespace prk_25
{
    partial class Login
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
            txt_Log = new TextBox();
            txt_Pass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txt_Log
            // 
            txt_Log.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Log.Location = new Point(134, 83);
            txt_Log.Name = "txt_Log";
            txt_Log.Size = new Size(292, 29);
            txt_Log.TabIndex = 0;
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Pass.Location = new Point(136, 220);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(292, 29);
            txt_Pass.TabIndex = 1;
            txt_Pass.KeyDown += txt_Pass_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(235, 18);
            label1.Name = "label1";
            label1.Size = new Size(89, 36);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(245, 154);
            label2.Name = "label2";
            label2.Size = new Size(69, 36);
            label2.TabIndex = 3;
            label2.Text = "Pass";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 289);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_Pass);
            Controls.Add(txt_Log);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Log;
        private TextBox txt_Pass;
        private Label label1;
        private Label label2;
    }
}