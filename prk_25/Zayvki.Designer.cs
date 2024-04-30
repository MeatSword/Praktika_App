namespace prk_25
{
    partial class Zayvki
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
            dtg_1 = new DataGridView();
            id_apl = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            lb_name = new Label();
            label4 = new Label();
            lb_sname = new Label();
            lb_lname = new Label();
            btn_exit = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_1).BeginInit();
            SuspendLayout();
            // 
            // dtg_1
            // 
            dtg_1.AllowUserToAddRows = false;
            dtg_1.AllowUserToDeleteRows = false;
            dtg_1.AllowUserToResizeColumns = false;
            dtg_1.AllowUserToResizeRows = false;
            dtg_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_1.Columns.AddRange(new DataGridViewColumn[] { id_apl, desc });
            dtg_1.Location = new Point(3, 71);
            dtg_1.MultiSelect = false;
            dtg_1.Name = "dtg_1";
            dtg_1.ReadOnly = true;
            dtg_1.RowTemplate.Height = 25;
            dtg_1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_1.Size = new Size(640, 239);
            dtg_1.TabIndex = 0;
            // 
            // id_apl
            // 
            id_apl.FillWeight = 10F;
            id_apl.HeaderText = "id_apl";
            id_apl.Name = "id_apl";
            id_apl.ReadOnly = true;
            // 
            // desc
            // 
            desc.HeaderText = "desc";
            desc.Name = "desc";
            desc.ReadOnly = true;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.BackColor = SystemColors.ActiveCaptionText;
            lb_name.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_name.ForeColor = SystemColors.ButtonFace;
            lb_name.Location = new Point(12, 322);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(68, 27);
            lb_name.TabIndex = 3;
            lb_name.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Times New Roman", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(248, 36);
            label4.TabIndex = 6;
            label4.Text = "Просмотр заявок";
            // 
            // lb_sname
            // 
            lb_sname.AutoSize = true;
            lb_sname.BackColor = SystemColors.ActiveCaptionText;
            lb_sname.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sname.ForeColor = SystemColors.ButtonFace;
            lb_sname.Location = new Point(12, 360);
            lb_sname.Name = "lb_sname";
            lb_sname.Size = new Size(68, 27);
            lb_sname.TabIndex = 7;
            lb_sname.Text = "Login";
            lb_sname.Click += lb_sname_Click;
            // 
            // lb_lname
            // 
            lb_lname.AutoSize = true;
            lb_lname.BackColor = SystemColors.ActiveCaptionText;
            lb_lname.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lb_lname.ForeColor = SystemColors.ButtonFace;
            lb_lname.Location = new Point(12, 402);
            lb_lname.Name = "lb_lname";
            lb_lname.Size = new Size(68, 27);
            lb_lname.TabIndex = 8;
            lb_lname.Text = "Login";
            // 
            // btn_exit
            // 
            btn_exit.BackColor = SystemColors.ActiveCaptionText;
            btn_exit.ForeColor = SystemColors.ButtonHighlight;
            btn_exit.Location = new Point(529, 12);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(107, 36);
            btn_exit.TabIndex = 9;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // Zayvki
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 441);
            Controls.Add(btn_exit);
            Controls.Add(lb_lname);
            Controls.Add(lb_sname);
            Controls.Add(label4);
            Controls.Add(lb_name);
            Controls.Add(dtg_1);
            Name = "Zayvki";
            Text = "Zayvki";
            Load += Zayvki_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtg_1;
        private DataGridViewTextBoxColumn id_apl;
        private DataGridViewTextBoxColumn desc;
        private Label lb_name;
        private Label label4;
        private Label lb_sname;
        private Label lb_lname;
        private Button btn_exit;
    }
}