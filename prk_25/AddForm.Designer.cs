namespace prk_25
{
    partial class AddForm
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
            tbc_1 = new TabControl();
            personal_tab = new TabPage();
            txt_PersonalOtdelID = new ComboBox();
            txt_PersonalRoleID = new ComboBox();
            btn_Add1 = new Button();
            label7 = new Label();
            txt_PersonalPhone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_Pass = new TextBox();
            txt_Log = new TextBox();
            txt_PersonalName = new TextBox();
            orders_tab = new TabPage();
            txt_OrdersProccesID = new ComboBox();
            txt_OrdersOtdelID = new ComboBox();
            ch_OrdersStatus = new CheckBox();
            btn_Add2 = new Button();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txt_OrdersPartnerID = new TextBox();
            materials_tab = new TabPage();
            txt_MaterialsProviderID = new ComboBox();
            txt_MaterialsTypeMatID = new ComboBox();
            btn_Add3 = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            txt_MaterialsName = new TextBox();
            txt_MaterialsPrice = new TextBox();
            txt_MaterialsDencity = new TextBox();
            label1 = new Label();
            tbc_1.SuspendLayout();
            personal_tab.SuspendLayout();
            orders_tab.SuspendLayout();
            materials_tab.SuspendLayout();
            SuspendLayout();
            // 
            // tbc_1
            // 
            tbc_1.Controls.Add(personal_tab);
            tbc_1.Controls.Add(orders_tab);
            tbc_1.Controls.Add(materials_tab);
            tbc_1.Location = new Point(12, 31);
            tbc_1.Name = "tbc_1";
            tbc_1.SelectedIndex = 0;
            tbc_1.Size = new Size(541, 407);
            tbc_1.TabIndex = 1;
            // 
            // personal_tab
            // 
            personal_tab.Controls.Add(txt_PersonalOtdelID);
            personal_tab.Controls.Add(txt_PersonalRoleID);
            personal_tab.Controls.Add(btn_Add1);
            personal_tab.Controls.Add(label7);
            personal_tab.Controls.Add(txt_PersonalPhone);
            personal_tab.Controls.Add(label6);
            personal_tab.Controls.Add(label5);
            personal_tab.Controls.Add(label4);
            personal_tab.Controls.Add(label3);
            personal_tab.Controls.Add(label2);
            personal_tab.Controls.Add(txt_Pass);
            personal_tab.Controls.Add(txt_Log);
            personal_tab.Controls.Add(txt_PersonalName);
            personal_tab.Location = new Point(4, 24);
            personal_tab.Name = "personal_tab";
            personal_tab.Padding = new Padding(3);
            personal_tab.Size = new Size(533, 379);
            personal_tab.TabIndex = 0;
            personal_tab.Text = "Personal";
            personal_tab.UseVisualStyleBackColor = true;
            // 
            // txt_PersonalOtdelID
            // 
            txt_PersonalOtdelID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PersonalOtdelID.FormattingEnabled = true;
            txt_PersonalOtdelID.Location = new Point(159, 70);
            txt_PersonalOtdelID.Name = "txt_PersonalOtdelID";
            txt_PersonalOtdelID.Size = new Size(292, 29);
            txt_PersonalOtdelID.TabIndex = 41;
            // 
            // txt_PersonalRoleID
            // 
            txt_PersonalRoleID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PersonalRoleID.FormattingEnabled = true;
            txt_PersonalRoleID.Location = new Point(159, 14);
            txt_PersonalRoleID.Name = "txt_PersonalRoleID";
            txt_PersonalRoleID.Size = new Size(292, 29);
            txt_PersonalRoleID.TabIndex = 40;
            // 
            // btn_Add1
            // 
            btn_Add1.BackColor = SystemColors.ActiveCaptionText;
            btn_Add1.ForeColor = SystemColors.ButtonHighlight;
            btn_Add1.Location = new Point(229, 333);
            btn_Add1.Name = "btn_Add1";
            btn_Add1.Size = new Size(107, 36);
            btn_Add1.TabIndex = 24;
            btn_Add1.Text = "Add";
            btn_Add1.UseVisualStyleBackColor = false;
            btn_Add1.Click += btn_Add1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(39, 284);
            label7.Name = "label7";
            label7.Size = new Size(73, 27);
            label7.TabIndex = 23;
            label7.Text = "Phone";
            // 
            // txt_PersonalPhone
            // 
            txt_PersonalPhone.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PersonalPhone.Location = new Point(159, 286);
            txt_PersonalPhone.Name = "txt_PersonalPhone";
            txt_PersonalPhone.Size = new Size(292, 29);
            txt_PersonalPhone.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(39, 232);
            label6.Name = "label6";
            label6.Size = new Size(104, 27);
            label6.TabIndex = 21;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(39, 182);
            label5.Name = "label5";
            label5.Size = new Size(68, 27);
            label5.TabIndex = 20;
            label5.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(39, 129);
            label4.Name = "label4";
            label4.Size = new Size(106, 27);
            label4.TabIndex = 19;
            label4.Text = "FullName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(39, 72);
            label3.Name = "label3";
            label3.Size = new Size(85, 27);
            label3.TabIndex = 18;
            label3.Text = "otdelID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(39, 16);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 17;
            label2.Text = "roleId";
            // 
            // txt_Pass
            // 
            txt_Pass.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Pass.Location = new Point(159, 234);
            txt_Pass.Name = "txt_Pass";
            txt_Pass.Size = new Size(292, 29);
            txt_Pass.TabIndex = 5;
            // 
            // txt_Log
            // 
            txt_Log.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Log.Location = new Point(159, 182);
            txt_Log.Name = "txt_Log";
            txt_Log.Size = new Size(292, 29);
            txt_Log.TabIndex = 4;
            // 
            // txt_PersonalName
            // 
            txt_PersonalName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_PersonalName.Location = new Point(159, 127);
            txt_PersonalName.Name = "txt_PersonalName";
            txt_PersonalName.Size = new Size(292, 29);
            txt_PersonalName.TabIndex = 3;
            // 
            // orders_tab
            // 
            orders_tab.Controls.Add(txt_OrdersProccesID);
            orders_tab.Controls.Add(txt_OrdersOtdelID);
            orders_tab.Controls.Add(ch_OrdersStatus);
            orders_tab.Controls.Add(btn_Add2);
            orders_tab.Controls.Add(label9);
            orders_tab.Controls.Add(label11);
            orders_tab.Controls.Add(label12);
            orders_tab.Controls.Add(label13);
            orders_tab.Controls.Add(txt_OrdersPartnerID);
            orders_tab.Location = new Point(4, 24);
            orders_tab.Name = "orders_tab";
            orders_tab.Padding = new Padding(3);
            orders_tab.Size = new Size(533, 379);
            orders_tab.TabIndex = 1;
            orders_tab.Text = "Orders";
            orders_tab.UseVisualStyleBackColor = true;
            // 
            // txt_OrdersProccesID
            // 
            txt_OrdersProccesID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersProccesID.FormattingEnabled = true;
            txt_OrdersProccesID.Location = new Point(172, 71);
            txt_OrdersProccesID.Name = "txt_OrdersProccesID";
            txt_OrdersProccesID.Size = new Size(292, 29);
            txt_OrdersProccesID.TabIndex = 40;
            // 
            // txt_OrdersOtdelID
            // 
            txt_OrdersOtdelID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersOtdelID.FormattingEnabled = true;
            txt_OrdersOtdelID.Location = new Point(172, 13);
            txt_OrdersOtdelID.Name = "txt_OrdersOtdelID";
            txt_OrdersOtdelID.Size = new Size(292, 29);
            txt_OrdersOtdelID.TabIndex = 39;
            // 
            // ch_OrdersStatus
            // 
            ch_OrdersStatus.AutoSize = true;
            ch_OrdersStatus.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            ch_OrdersStatus.Location = new Point(172, 194);
            ch_OrdersStatus.Name = "ch_OrdersStatus";
            ch_OrdersStatus.Size = new Size(15, 14);
            ch_OrdersStatus.TabIndex = 38;
            ch_OrdersStatus.UseVisualStyleBackColor = true;
            // 
            // btn_Add2
            // 
            btn_Add2.BackColor = SystemColors.ActiveCaptionText;
            btn_Add2.ForeColor = SystemColors.ButtonHighlight;
            btn_Add2.Location = new Point(240, 233);
            btn_Add2.Name = "btn_Add2";
            btn_Add2.Size = new Size(107, 36);
            btn_Add2.TabIndex = 37;
            btn_Add2.Text = "Add";
            btn_Add2.UseVisualStyleBackColor = false;
            btn_Add2.Click += btn_Add2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(30, 183);
            label9.Name = "label9";
            label9.Size = new Size(70, 27);
            label9.TabIndex = 34;
            label9.Text = "Status";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.ActiveCaptionText;
            label11.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(30, 128);
            label11.Name = "label11";
            label11.Size = new Size(108, 27);
            label11.TabIndex = 32;
            label11.Text = "PartnerID";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = SystemColors.ActiveCaptionText;
            label12.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = SystemColors.ButtonFace;
            label12.Location = new Point(30, 71);
            label12.Name = "label12";
            label12.Size = new Size(108, 27);
            label12.TabIndex = 31;
            label12.Text = "ProccesId";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveCaptionText;
            label13.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(30, 13);
            label13.Name = "label13";
            label13.Size = new Size(90, 27);
            label13.TabIndex = 30;
            label13.Text = "OtdelID";
            // 
            // txt_OrdersPartnerID
            // 
            txt_OrdersPartnerID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_OrdersPartnerID.Location = new Point(172, 124);
            txt_OrdersPartnerID.Name = "txt_OrdersPartnerID";
            txt_OrdersPartnerID.Size = new Size(292, 29);
            txt_OrdersPartnerID.TabIndex = 27;
            // 
            // materials_tab
            // 
            materials_tab.Controls.Add(txt_MaterialsProviderID);
            materials_tab.Controls.Add(txt_MaterialsTypeMatID);
            materials_tab.Controls.Add(btn_Add3);
            materials_tab.Controls.Add(label14);
            materials_tab.Controls.Add(label15);
            materials_tab.Controls.Add(label16);
            materials_tab.Controls.Add(label17);
            materials_tab.Controls.Add(label18);
            materials_tab.Controls.Add(txt_MaterialsName);
            materials_tab.Controls.Add(txt_MaterialsPrice);
            materials_tab.Controls.Add(txt_MaterialsDencity);
            materials_tab.Location = new Point(4, 24);
            materials_tab.Name = "materials_tab";
            materials_tab.Padding = new Padding(3);
            materials_tab.Size = new Size(533, 379);
            materials_tab.TabIndex = 2;
            materials_tab.Text = "Materials";
            materials_tab.UseVisualStyleBackColor = true;
            // 
            // txt_MaterialsProviderID
            // 
            txt_MaterialsProviderID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsProviderID.FormattingEnabled = true;
            txt_MaterialsProviderID.Location = new Point(172, 67);
            txt_MaterialsProviderID.Name = "txt_MaterialsProviderID";
            txt_MaterialsProviderID.Size = new Size(292, 29);
            txt_MaterialsProviderID.TabIndex = 41;
            // 
            // txt_MaterialsTypeMatID
            // 
            txt_MaterialsTypeMatID.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsTypeMatID.FormattingEnabled = true;
            txt_MaterialsTypeMatID.Location = new Point(172, 15);
            txt_MaterialsTypeMatID.Name = "txt_MaterialsTypeMatID";
            txt_MaterialsTypeMatID.Size = new Size(292, 29);
            txt_MaterialsTypeMatID.TabIndex = 40;
            // 
            // btn_Add3
            // 
            btn_Add3.BackColor = SystemColors.ActiveCaptionText;
            btn_Add3.ForeColor = SystemColors.ButtonHighlight;
            btn_Add3.Location = new Point(251, 291);
            btn_Add3.Name = "btn_Add3";
            btn_Add3.Size = new Size(107, 36);
            btn_Add3.TabIndex = 37;
            btn_Add3.Text = "Add";
            btn_Add3.UseVisualStyleBackColor = false;
            btn_Add3.Click += btn_Add3_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = SystemColors.ActiveCaptionText;
            label14.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(17, 229);
            label14.Name = "label14";
            label14.Size = new Size(69, 27);
            label14.TabIndex = 34;
            label14.Text = "Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = SystemColors.ActiveCaptionText;
            label15.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(17, 179);
            label15.Name = "label15";
            label15.Size = new Size(62, 27);
            label15.TabIndex = 33;
            label15.Text = "Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.ActiveCaptionText;
            label16.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(17, 126);
            label16.Name = "label16";
            label16.Size = new Size(88, 27);
            label16.TabIndex = 32;
            label16.Text = "Dencity";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = SystemColors.ActiveCaptionText;
            label17.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(17, 69);
            label17.Name = "label17";
            label17.Size = new Size(120, 27);
            label17.TabIndex = 31;
            label17.Text = "ProviderID";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = SystemColors.ActiveCaptionText;
            label18.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ButtonFace;
            label18.Location = new Point(17, 13);
            label18.Name = "label18";
            label18.Size = new Size(118, 27);
            label18.TabIndex = 30;
            label18.Text = "typeMatID";
            // 
            // txt_MaterialsName
            // 
            txt_MaterialsName.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsName.Location = new Point(172, 231);
            txt_MaterialsName.Name = "txt_MaterialsName";
            txt_MaterialsName.Size = new Size(292, 29);
            txt_MaterialsName.TabIndex = 29;
            // 
            // txt_MaterialsPrice
            // 
            txt_MaterialsPrice.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsPrice.Location = new Point(172, 179);
            txt_MaterialsPrice.Name = "txt_MaterialsPrice";
            txt_MaterialsPrice.Size = new Size(292, 29);
            txt_MaterialsPrice.TabIndex = 28;
            // 
            // txt_MaterialsDencity
            // 
            txt_MaterialsDencity.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_MaterialsDencity.Location = new Point(172, 124);
            txt_MaterialsDencity.Name = "txt_MaterialsDencity";
            txt_MaterialsDencity.Size = new Size(292, 29);
            txt_MaterialsDencity.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(412, 9);
            label1.Name = "label1";
            label1.Size = new Size(134, 27);
            label1.TabIndex = 16;
            label1.Text = "Добавление";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(label1);
            Controls.Add(tbc_1);
            Name = "AddForm";
            Text = "AddForm";
            tbc_1.ResumeLayout(false);
            personal_tab.ResumeLayout(false);
            personal_tab.PerformLayout();
            orders_tab.ResumeLayout(false);
            orders_tab.PerformLayout();
            materials_tab.ResumeLayout(false);
            materials_tab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbc_1;
        private TabPage personal_tab;
        private TabPage orders_tab;
        private TabPage materials_tab;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox txt_Pass;
        private TextBox txt_Log;
        private TextBox txt_PersonalName;
        private Label label7;
        private TextBox txt_PersonalPhone;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_Add1;
        private CheckBox ch_OrdersStatus;
        private Button btn_Add2;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txt_OrdersPartnerID;
        private Button btn_Add3;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TextBox txt_MaterialsName;
        private TextBox txt_MaterialsPrice;
        private TextBox txt_MaterialsDencity;
        private ComboBox txt_OrdersProccesID;
        private ComboBox txt_OrdersOtdelID;
        private ComboBox txt_PersonalOtdelID;
        private ComboBox txt_PersonalRoleID;
        private ComboBox txt_MaterialsProviderID;
        private ComboBox txt_MaterialsTypeMatID;
    }
}