using Crud_Win_Forms_Pessoa.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_Crud.Entity;

namespace WindowsForms_Crud
{
    public partial class Frm_Crud_Pessoa : Form
    {
        private readonly IPersonService _service;
        private IEnumerable<Person> _persons;

        public Frm_Crud_Pessoa(IPersonService service)
        {
            _service = service;
            InitializeComponent();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            var person = new Person(0, Tb_Name.Text, Tb_Cpf.Text, Tb_Email.Text);
            _service.Insert(person);
            CleanFields();
            FullfillList();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            var person = new Person(Convert.ToInt32(Tb_Id.Text), Tb_Name.Text, Tb_Cpf.Text, Tb_Email.Text);
            _service.Update(person);
            CleanFields();
            FullfillList();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            _service.Delete(Convert.ToInt32(Tb_Id.Text));
            CleanFields();
            FullfillList();
        }

        private void CleanFields()
        {
            Tb_Id.Text = string.Empty;
            Tb_Name.Text = string.Empty;
            Tb_Cpf.Text = string.Empty;
            Tb_Email.Text = string.Empty;
        }

        private void FullfillList()
        {
            _persons = _service.FindAll();
            this.dg_persons.DataSource = _persons.ToList();
        }

        private void Frm_Crud_Pessoa_Load(object sender, EventArgs e)
        {
            FullfillList();
        }

        private void dg_persons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null) return;
            Tb_Id.Text = dgv.CurrentRow.Cells["Id"]?.Value?.ToString();
            Tb_Name.Text = dgv.CurrentRow.Cells["Name"]?.Value?.ToString();
            Tb_Cpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            Tb_Email.Text = dgv.CurrentRow.Cells["Email"]?.Value?.ToString();
        }
    }
}
