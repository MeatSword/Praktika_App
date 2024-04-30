namespace prk_25
{
    partial class EditMaterial
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
            txt_MaterialsProviderID = new ComboBox();
            txt_MaterialsTypeMatID = new ComboBox();
            btn_Edit = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txt_MaterialsName = new TextBox();
            txt_MaterialsPrice = new TextBox();
            txt_MaterialsDencity = new TextBox();
            SuspendLayout();
            // 
            // txt_MaterialsProviderID
            // 
            txt_MaterialsProviderID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsProviderID.FormattingEnabled = true;
            txt_MaterialsProviderID.Location = new Point(167, 63);
            txt_MaterialsProviderID.Name = "txt_MaterialsProviderID";
            txt_MaterialsProviderID.Size = new Size(292, 29);
            txt_MaterialsProviderID.TabIndex = 52;
            // 
            // txt_MaterialsTypeMatID
            // 
            txt_MaterialsTypeMatID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsTypeMatID.FormattingEnabled = true;
            txt_MaterialsTypeMatID.Location = new Point(167, 11);
            txt_MaterialsTypeMatID.Name = "txt_MaterialsTypeMatID";
            txt_MaterialsTypeMatID.Size = new Size(292, 29);
            txt_MaterialsTypeMatID.TabIndex = 51;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = SystemColors.ActiveCaptionText;
            btn_Edit.ForeColor = SystemColors.ButtonHighlight;
            btn_Edit.Location = new Point(246, 287);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(107, 36);
            btn_Edit.TabIndex = 50;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(12, 225);
            label14.Name = "label14";
            label14.Size = new Size(69, 27);
            label14.TabIndex = 49;
            label14.Text = "Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(12, 175);
            label15.Name = "label15";
            label15.Size = new Size(62, 27);
            label15.TabIndex = 48;
            label15.Text = "Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(12, 122);
            label16.Name = "label16";
            label16.Size = new Size(88, 27);
            label16.TabIndex = 47;
            label16.Text = "Dencity";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(12, 65);
            label17.Name = "label17";
            label17.Size = new Size(120, 27);
            label17.TabIndex = 46;
            label17.Text = "ProviderID";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ActiveCaptionText;
            label18.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(12, 9);
            label18.Name = "label18";
            label18.Size = new Size(118, 27);
            label18.TabIndex = 45;
            label18.Text = "typeMatID";
            // 
            // txt_MaterialsName
            // 
            txt_MaterialsName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsName.Location = new Point(167, 227);
            txt_MaterialsName.Name = "txt_MaterialsName";
            txt_MaterialsName.Size = new Size(292, 29);
            txt_MaterialsName.TabIndex = 44;
            // 
            // txt_MaterialsPrice
            // 
            txt_MaterialsPrice.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsPrice.Location = new Point(167, 175);
            txt_MaterialsPrice.Name = "txt_MaterialsPrice";
            txt_MaterialsPrice.Size = new Size(292, 29);
            txt_MaterialsPrice.TabIndex = 43;
            // 
            // txt_MaterialsDencity
            // 
            txt_MaterialsDencity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsDencity.Location = new Point(167, 120);
            txt_MaterialsDencity.Name = "txt_MaterialsDencity";
            txt_MaterialsDencity.Size = new Size(292, 29);
            txt_MaterialsDencity.TabIndex = 42;
            // 
            // EditMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 355);
            Controls.Add(txt_MaterialsProviderID);
            Controls.Add(txt_MaterialsTypeMatID);
            Controls.Add(btn_Edit);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(txt_MaterialsName);
            Controls.Add(txt_MaterialsPrice);
            Controls.Add(txt_MaterialsDencity);
            Name = "EditMaterial";
            Text = "EditMaterial";
            FormClosing += EditMaterial_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox txt_MaterialsProviderID;
        private ComboBox txt_MaterialsTypeMatID;
        private Button btn_Edit;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txt_MaterialsName;
        private TextBox txt_MaterialsPrice;
        private TextBox txt_MaterialsDencity;
    }
}