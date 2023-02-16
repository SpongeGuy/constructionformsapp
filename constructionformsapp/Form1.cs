using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace constructionformsapp
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("Item", typeof(String));
            table.Columns.Add("Material", typeof(String));
            table.Columns.Add("Description", typeof(String));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitCost", typeof(int));
            table.Columns.Add("Cost", typeof(int));
            table.Columns.Add("Notes", typeof(String));

            dataGridView1.DataSource = table;

            int columnWidth = dataGridView1.Width / 8;

            dataGridView1.Columns["Category"].Width = columnWidth;
            dataGridView1.Columns["Item"].Width = columnWidth;
            dataGridView1.Columns["Material"].Width = columnWidth;
            dataGridView1.Columns["Description"].Width = columnWidth;
            dataGridView1.Columns["Quantity"].Width = columnWidth;
            dataGridView1.Columns["UnitCost"].Width = columnWidth;
            dataGridView1.Columns["Cost"].Width = columnWidth;
            dataGridView1.Columns["Notes"].Width = columnWidth;

            dataGridView1.Refresh();

            System.Diagnostics.Debug.WriteLine("Loaded successfully!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearTextFields()
        {
            listCategory.ResetText();
            textItem.Clear();
            textMaterial.Clear();
            textDescription.Clear();
            textQuantity.Clear();
            textUnitCost.Clear();
            textCost.Clear();
            textNotes.Clear();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            clearTextFields();
            System.Diagnostics.Debug.WriteLine("Button clicked!");
        }

        private void saveBttn_Click_1(object sender, EventArgs e)
        {
            /*
            table.Rows.Add(txtTitle.Text, txtMessage.Text);
            txtTitle.Clear();
            txtMessage.Clear();
            */
        }

    }

}
