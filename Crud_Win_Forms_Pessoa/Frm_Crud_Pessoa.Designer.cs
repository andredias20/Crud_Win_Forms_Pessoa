namespace WindowsForms_Crud
{
    partial class Frm_Crud_Pessoa
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Add = new Button();
            Btn_Edit = new Button();
            Btn_Remove = new Button();
            Tb_Id = new TextBox();
            lbl_id = new Label();
            Lbl_Name = new Label();
            Tb_Name = new TextBox();
            Lbl_Email = new Label();
            Tb_Email = new TextBox();
            Lbl_Cpf = new Label();
            Tb_Cpf = new TextBox();
            dg_persons = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_persons).BeginInit();
            SuspendLayout();
            // 
            // Btn_Add
            // 
            Btn_Add.Location = new Point(643, 479);
            Btn_Add.Margin = new Padding(4, 3, 4, 3);
            Btn_Add.Name = "Btn_Add";
            Btn_Add.Size = new Size(88, 27);
            Btn_Add.TabIndex = 0;
            Btn_Add.Text = "Adicionar";
            Btn_Add.UseVisualStyleBackColor = true;
            Btn_Add.Click += Btn_Add_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.Location = new Point(737, 479);
            Btn_Edit.Margin = new Padding(4, 3, 4, 3);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(88, 27);
            Btn_Edit.TabIndex = 1;
            Btn_Edit.Text = "Editar";
            Btn_Edit.UseVisualStyleBackColor = true;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_Remove
            // 
            Btn_Remove.Location = new Point(832, 479);
            Btn_Remove.Margin = new Padding(4, 3, 4, 3);
            Btn_Remove.Name = "Btn_Remove";
            Btn_Remove.Size = new Size(88, 27);
            Btn_Remove.TabIndex = 2;
            Btn_Remove.Text = "Remover";
            Btn_Remove.UseVisualStyleBackColor = true;
            Btn_Remove.Click += Btn_Remove_Click;
            // 
            // Tb_Id
            // 
            Tb_Id.Enabled = false;
            Tb_Id.Location = new Point(14, 58);
            Tb_Id.Margin = new Padding(4, 3, 4, 3);
            Tb_Id.Name = "Tb_Id";
            Tb_Id.Size = new Size(151, 23);
            Tb_Id.TabIndex = 3;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(14, 39);
            lbl_id.Margin = new Padding(4, 0, 4, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(18, 15);
            lbl_id.TabIndex = 4;
            lbl_id.Text = "ID";
            // 
            // Lbl_Name
            // 
            Lbl_Name.AutoSize = true;
            Lbl_Name.Location = new Point(14, 84);
            Lbl_Name.Margin = new Padding(4, 0, 4, 0);
            Lbl_Name.Name = "Lbl_Name";
            Lbl_Name.Size = new Size(40, 15);
            Lbl_Name.TabIndex = 6;
            Lbl_Name.Text = "Nome";
            // 
            // Tb_Name
            // 
            Tb_Name.Location = new Point(14, 103);
            Tb_Name.Margin = new Padding(4, 3, 4, 3);
            Tb_Name.Name = "Tb_Name";
            Tb_Name.Size = new Size(151, 23);
            Tb_Name.TabIndex = 5;
            // 
            // Lbl_Email
            // 
            Lbl_Email.AutoSize = true;
            Lbl_Email.Location = new Point(14, 174);
            Lbl_Email.Margin = new Padding(4, 0, 4, 0);
            Lbl_Email.Name = "Lbl_Email";
            Lbl_Email.Size = new Size(41, 15);
            Lbl_Email.TabIndex = 10;
            Lbl_Email.Text = "E-mail";
            // 
            // Tb_Email
            // 
            Tb_Email.Location = new Point(14, 193);
            Tb_Email.Margin = new Padding(4, 3, 4, 3);
            Tb_Email.Name = "Tb_Email";
            Tb_Email.Size = new Size(151, 23);
            Tb_Email.TabIndex = 9;
            // 
            // Lbl_Cpf
            // 
            Lbl_Cpf.AutoSize = true;
            Lbl_Cpf.Location = new Point(14, 129);
            Lbl_Cpf.Margin = new Padding(4, 0, 4, 0);
            Lbl_Cpf.Name = "Lbl_Cpf";
            Lbl_Cpf.Size = new Size(28, 15);
            Lbl_Cpf.TabIndex = 8;
            Lbl_Cpf.Text = "CPF";
            // 
            // Tb_Cpf
            // 
            Tb_Cpf.Location = new Point(14, 148);
            Tb_Cpf.Margin = new Padding(4, 3, 4, 3);
            Tb_Cpf.Name = "Tb_Cpf";
            Tb_Cpf.Size = new Size(151, 23);
            Tb_Cpf.TabIndex = 7;
            // 
            // dg_persons
            // 
            dg_persons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_persons.Location = new Point(14, 269);
            dg_persons.Margin = new Padding(4, 3, 4, 3);
            dg_persons.Name = "dg_persons";
            dg_persons.Size = new Size(905, 203);
            dg_persons.TabIndex = 11;
            dg_persons.CellClick += dg_persons_CellClick;
            // 
            // Frm_Crud_Pessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(dg_persons);
            Controls.Add(Lbl_Email);
            Controls.Add(Tb_Email);
            Controls.Add(Lbl_Cpf);
            Controls.Add(Tb_Cpf);
            Controls.Add(Lbl_Name);
            Controls.Add(Tb_Name);
            Controls.Add(lbl_id);
            Controls.Add(Tb_Id);
            Controls.Add(Btn_Remove);
            Controls.Add(Btn_Edit);
            Controls.Add(Btn_Add);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Frm_Crud_Pessoa";
            Text = "Crud de Pessoas";
            Load += Frm_Crud_Pessoa_Load;
            ((System.ComponentModel.ISupportInitialize)dg_persons).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.TextBox Tb_Id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label Lbl_Name;
        private System.Windows.Forms.TextBox Tb_Name;
        private System.Windows.Forms.Label Lbl_Email;
        private System.Windows.Forms.TextBox Tb_Email;
        private System.Windows.Forms.Label Lbl_Cpf;
        private System.Windows.Forms.TextBox Tb_Cpf;
        private System.Windows.Forms.DataGridView dg_persons;
    }
}

