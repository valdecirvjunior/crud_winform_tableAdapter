using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void alunosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alunosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.crudDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'crudDataSet.Alunos' table. You can move, or remove it, as needed.
            this.alunosTableAdapter.Fill(this.crudDataSet.Alunos);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.alunosBindingSource.EndEdit();
                this.alunosTableAdapter.Update(this.crudDataSet.Alunos);
                MessageBox.Show("Updade successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed " + ex.ToString());
            }
            finally
            {
                this.alunosTableAdapter.Fill(this.crudDataSet.Alunos);
            }
        }
    }
}
