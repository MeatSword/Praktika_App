namespace prk_25
{
    partial class EditOrder
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
            txt_OrdersProccesID = new ComboBox();
            txt_OrdersOtdelID = new ComboBox();
            ch_OrdersStatus = new CheckBox();
            btn_Edit = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txt_OrdersPartnerID = new TextBox();
            SuspendLayout();
            // 
            // txt_OrdersProccesID
            // 
            txt_OrdersProccesID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersProccesID.FormattingEnabled = true;
            txt_OrdersProccesID.Location = new Point(158, 70);
            txt_OrdersProccesID.Name = "txt_OrdersProccesID";
            txt_OrdersProccesID.Size = new Size(292, 29);
            txt_OrdersProccesID.TabIndex = 49;
            // 
            // txt_OrdersOtdelID
            // 
            txt_OrdersOtdelID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersOtdelID.FormattingEnabled = true;
            txt_OrdersOtdelID.Location = new Point(158, 12);
            txt_OrdersOtdelID.Name = "txt_OrdersOtdelID";
            txt_OrdersOtdelID.Size = new Size(292, 29);
            txt_OrdersOtdelID.TabIndex = 48;
            // 
            // ch_OrdersStatus
            // 
            ch_OrdersStatus.AutoSize = true;
            ch_OrdersStatus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ch_OrdersStatus.Location = new Point(158, 193);
            ch_OrdersStatus.Name = "ch_OrdersStatus";
            ch_OrdersStatus.Size = new Size(15, 14);
            ch_OrdersStatus.TabIndex = 47;
            ch_OrdersStatus.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = SystemColors.ActiveCaptionText;
            btn_Edit.ForeColor = SystemColors.ButtonHighlight;
            btn_Edit.Location = new Point(226, 232);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(107, 36);
            btn_Edit.TabIndex = 46;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(16, 182);
            label9.Name = "label9";
            label9.Size = new Size(70, 27);
            label9.TabIndex = 45;
            label9.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(16, 127);
            label11.Name = "label11";
            label11.Size = new Size(108, 27);
            label11.TabIndex = 44;
            label11.Text = "PartnerID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(16, 70);
            label12.Name = "label12";
            label12.Size = new Size(108, 27);
            label12.TabIndex = 43;
            label12.Text = "ProccesId";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(16, 12);
            label13.Name = "label13";
            label13.Size = new Size(90, 27);
            label13.TabIndex = 42;
            label13.Text = "OtdelID";
            // 
            // txt_OrdersPartnerID
            // 
            txt_OrdersPartnerID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersPartnerID.Location = new Point(158, 123);
            txt_OrdersPartnerID.Name = "txt_OrdersPartnerID";
            txt_OrdersPartnerID.Size = new Size(292, 29);
            txt_OrdersPartnerID.TabIndex = 41;
            // 
            // EditOrder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 297);
            Controls.Add(txt_OrdersProccesID);
            Controls.Add(txt_OrdersOtdelID);
            Controls.Add(ch_OrdersStatus);
            Controls.Add(btn_Edit);
            Controls.Add(label9);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(txt_OrdersPartnerID);
            Name = "EditOrder";
            Text = "EditOrder";
            FormClosing += EditOrder_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_OrdersProccesID;
        private ComboBox txt_OrdersOtdelID;
        private CheckBox ch_OrdersStatus;
        private Button btn_Edit;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txt_OrdersPartnerID;
    }
}