namespace prk_25
{
    partial class Manager
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
            orders_tab = new TabPage();
            materials_tab = new TabPage();
            lb_lname = new Label();
            lb_sname = new Label();
            lb_name = new Label();
            btn_Add = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            label1 = new Label();
            dtg_1 = new DataGridView();
            id_personal = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            sname = new DataGridViewTextBoxColumn();
            lname = new DataGridViewTextBoxColumn();
            dtg_2 = new DataGridView();
            id_tab = new DataGridViewTextBoxColumn();
            otdel_tab = new DataGridViewTextBoxColumn();
            procces_tab = new DataGridViewTextBoxColumn();
            idPartner_tab = new DataGridViewTextBoxColumn();
            date_tab = new DataGridViewTextBoxColumn();
            dtg_3 = new DataGridView();
            idMat_tab = new DataGridViewTextBoxColumn();
            name_tab = new DataGridViewTextBoxColumn();
            typemat_tab = new DataGridViewTextBoxColumn();
            dencity_tab = new DataGridViewTextBoxColumn();
            price_tab = new DataGridViewTextBoxColumn();
            tbc_1.SuspendLayout();
            personal_tab.SuspendLayout();
            orders_tab.SuspendLayout();
            materials_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtg_3).BeginInit();
            SuspendLayout();
            // 
            // tbc_1
            // 
            tbc_1.Controls.Add(personal_tab);
            tbc_1.Controls.Add(orders_tab);
            tbc_1.Controls.Add(materials_tab);
            tbc_1.Location = new Point(12, 12);
            tbc_1.Name = "tbc_1";
            tbc_1.SelectedIndex = 0;
            tbc_1.Size = new Size(541, 426);
            tbc_1.TabIndex = 0;
            // 
            // personal_tab
            // 
            personal_tab.Controls.Add(dtg_1);
            personal_tab.Location = new Point(4, 24);
            personal_tab.Name = "personal_tab";
            personal_tab.Padding = new Padding(3);
            personal_tab.Size = new Size(533, 398);
            personal_tab.TabIndex = 0;
            personal_tab.Text = "Personal";
            personal_tab.UseVisualStyleBackColor = true;
            // 
            // orders_tab
            // 
            orders_tab.Controls.Add(dtg_2);
            orders_tab.Location = new Point(4, 24);
            orders_tab.Name = "orders_tab";
            orders_tab.Padding = new Padding(3);
            orders_tab.Size = new Size(533, 398);
            orders_tab.TabIndex = 1;
            orders_tab.Text = "Orders";
            orders_tab.UseVisualStyleBackColor = true;
            // 
            // materials_tab
            // 
            materials_tab.Controls.Add(dtg_3);
            materials_tab.Location = new Point(4, 24);
            materials_tab.Name = "materials_tab";
            materials_tab.Padding = new Padding(3);
            materials_tab.Size = new Size(533, 398);
            materials_tab.TabIndex = 2;
            materials_tab.Text = "Materials";
            materials_tab.UseVisualStyleBackColor = true;
            // 
            // lb_lname
            // 
            lb_lname.AutoSize = true;
            lb_lname.BackColor = SystemColors.ActiveCaptionText;
            lb_lname.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_lname.ForeColor = SystemColors.ButtonFace;
            lb_lname.Location = new Point(559, 167);
            lb_lname.Name = "lb_lname";
            lb_lname.Size = new Size(68, 27);
            lb_lname.TabIndex = 11;
            lb_lname.Text = "Login";
            // 
            // lb_sname
            // 
            lb_sname.AutoSize = true;
            lb_sname.BackColor = SystemColors.ActiveCaptionText;
            lb_sname.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sname.ForeColor = SystemColors.ButtonFace;
            lb_sname.Location = new Point(559, 126);
            lb_sname.Name = "lb_sname";
            lb_sname.Size = new Size(68, 27);
            lb_sname.TabIndex = 10;
            lb_sname.Text = "Login";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.BackColor = SystemColors.ActiveCaptionText;
            lb_name.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_name.ForeColor = SystemColors.ButtonFace;
            lb_name.Location = new Point(559, 84);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(68, 27);
            lb_name.TabIndex = 9;
            lb_name.Text = "Login";
            // 
            // btn_Add
            // 
            btn_Add.BackColor = SystemColors.ActiveCaptionText;
            btn_Add.ForeColor = SystemColors.ButtonHighlight;
            btn_Add.Location = new Point(559, 298);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(107, 36);
            btn_Add.TabIndex = 12;
            btn_Add.Text = "Add";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.BackColor = SystemColors.ActiveCaptionText;
            btn_Edit.ForeColor = SystemColors.ButtonHighlight;
            btn_Edit.Location = new Point(559, 344);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(107, 36);
            btn_Edit.TabIndex = 13;
            btn_Edit.Text = "Edit";
            btn_Edit.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = SystemColors.ActiveCaptionText;
            btn_Delete.ForeColor = SystemColors.ButtonHighlight;
            btn_Delete.Location = new Point(558, 391);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(107, 36);
            btn_Delete.TabIndex = 14;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Add_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(559, 3);
            label1.Name = "label1";
            label1.Size = new Size(208, 27);
            label1.TabIndex = 15;
            label1.Text = "Основные таблицы";
            // 
            // dtg_1
            // 
            dtg_1.AllowUserToAddRows = false;
            dtg_1.AllowUserToDeleteRows = false;
            dtg_1.AllowUserToResizeColumns = false;
            dtg_1.AllowUserToResizeRows = false;
            dtg_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_1.Columns.AddRange(new DataGridViewColumn[] { id_personal, role, name, sname, lname });
            dtg_1.Location = new Point(0, 0);
            dtg_1.MultiSelect = false;
            dtg_1.Name = "dtg_1";
            dtg_1.ReadOnly = true;
            dtg_1.RowTemplate.Height = 25;
            dtg_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_1.Size = new Size(533, 398);
            dtg_1.TabIndex = 1;
            // 
            // id_personal
            // 
            id_personal.FillWeight = 10F;
            id_personal.HeaderText = "Id";
            id_personal.Name = "id_personal";
            id_personal.ReadOnly = true;
            // 
            // role
            // 
            role.FillWeight = 15F;
            role.HeaderText = "Role";
            role.Name = "role";
            role.ReadOnly = true;
            // 
            // name
            // 
            name.FillWeight = 25F;
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // sname
            // 
            sname.FillWeight = 25F;
            sname.HeaderText = "Sname";
            sname.Name = "sname";
            sname.ReadOnly = true;
            // 
            // lname
            // 
            lname.FillWeight = 25F;
            lname.HeaderText = "Lname";
            lname.Name = "lname";
            lname.ReadOnly = true;
            // 
            // dtg_2
            // 
            dtg_2.AllowUserToAddRows = false;
            dtg_2.AllowUserToDeleteRows = false;
            dtg_2.AllowUserToResizeColumns = false;
            dtg_2.AllowUserToResizeRows = false;
            dtg_2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_2.Columns.AddRange(new DataGridViewColumn[] { id_tab, otdel_tab, procces_tab, idPartner_tab, date_tab });
            dtg_2.Location = new Point(0, 0);
            dtg_2.MultiSelect = false;
            dtg_2.Name = "dtg_2";
            dtg_2.ReadOnly = true;
            dtg_2.RowTemplate.Height = 25;
            dtg_2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_2.Size = new Size(533, 398);
            dtg_2.TabIndex = 2;
            // 
            // id_tab
            // 
            id_tab.FillWeight = 10F;
            id_tab.HeaderText = "Id";
            id_tab.Name = "id_tab";
            id_tab.ReadOnly = true;
            // 
            // otdel_tab
            // 
            otdel_tab.FillWeight = 25F;
            otdel_tab.HeaderText = "Otdel";
            otdel_tab.Name = "otdel_tab";
            otdel_tab.ReadOnly = true;
            // 
            // procces_tab
            // 
            procces_tab.FillWeight = 25F;
            procces_tab.HeaderText = "Procces";
            procces_tab.Name = "procces_tab";
            procces_tab.ReadOnly = true;
            // 
            // idPartner_tab
            // 
            idPartner_tab.FillWeight = 10F;
            idPartner_tab.HeaderText = "Partner_id";
            idPartner_tab.Name = "idPartner_tab";
            idPartner_tab.ReadOnly = true;
            // 
            // date_tab
            // 
            date_tab.FillWeight = 25F;
            date_tab.HeaderText = "Date";
            date_tab.Name = "date_tab";
            date_tab.ReadOnly = true;
            // 
            // dtg_3
            // 
            dtg_3.AllowUserToAddRows = false;
            dtg_3.AllowUserToDeleteRows = false;
            dtg_3.AllowUserToResizeColumns = false;
            dtg_3.AllowUserToResizeRows = false;
            dtg_3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_3.Columns.AddRange(new DataGridViewColumn[] { idMat_tab, name_tab, typemat_tab, dencity_tab, price_tab });
            dtg_3.Location = new Point(0, 0);
            dtg_3.MultiSelect = false;
            dtg_3.Name = "dtg_3";
            dtg_3.ReadOnly = true;
            dtg_3.RowTemplate.Height = 25;
            dtg_3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_3.Size = new Size(533, 398);
            dtg_3.TabIndex = 3;
            // 
            // idMat_tab
            // 
            idMat_tab.FillWeight = 10F;
            idMat_tab.HeaderText = "Id";
            idMat_tab.Name = "idMat_tab";
            idMat_tab.ReadOnly = true;
            // 
            // name_tab
            // 
            name_tab.FillWeight = 25F;
            name_tab.HeaderText = "Name";
            name_tab.Name = "name_tab";
            name_tab.ReadOnly = true;
            // 
            // typemat_tab
            // 
            typemat_tab.FillWeight = 25F;
            typemat_tab.HeaderText = "TypeMat";
            typemat_tab.Name = "typemat_tab";
            typemat_tab.ReadOnly = true;
            // 
            // dencity_tab
            // 
            dencity_tab.FillWeight = 25F;
            dencity_tab.HeaderText = "Dencity";
            dencity_tab.Name = "dencity_tab";
            dencity_tab.ReadOnly = true;
            // 
            // price_tab
            // 
            price_tab.FillWeight = 25F;
            price_tab.HeaderText = "Price";
            price_tab.Name = "price_tab";
            price_tab.ReadOnly = true;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Add);
            Controls.Add(lb_lname);
            Controls.Add(lb_sname);
            Controls.Add(lb_name);
            Controls.Add(tbc_1);
            Name = "Manager";
            Text = "Manager";
            tbc_1.ResumeLayout(false);
            personal_tab.ResumeLayout(false);
            orders_tab.ResumeLayout(false);
            materials_tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtg_3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tbc_1;
        private TabPage personal_tab;
        private TabPage orders_tab;
        private TabPage materials_tab;
        private Label lb_lname;
        private Label lb_sname;
        private Label lb_name;
        private Button btn_Add;
        private Button btn_Edit;
        private Button btn_Delete;
        private Label label1;
        private DataGridView dtg_1;
        private DataGridViewTextBoxColumn id_personal;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn sname;
        private DataGridViewTextBoxColumn lname;
        private DataGridView dtg_2;
        private DataGridViewTextBoxColumn id_tab;
        private DataGridViewTextBoxColumn otdel_tab;
        private DataGridViewTextBoxColumn procces_tab;
        private DataGridViewTextBoxColumn idPartner_tab;
        private DataGridViewTextBoxColumn date_tab;
        private DataGridView dtg_3;
        private DataGridViewTextBoxColumn idMat_tab;
        private DataGridViewTextBoxColumn name_tab;
        private DataGridViewTextBoxColumn typemat_tab;
        private DataGridViewTextBoxColumn dencity_tab;
        private DataGridViewTextBoxColumn price_tab;
    }
}