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
    public class Order
    {
        public string category;
        public string itemName;
        public string material;
        public string description;
        public int quantity;
        public int unitCost;
        public int cost;
        public string notes;
    }

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
            dataGridView1.Columns["Description"].Width = columnWidth * 2;
            dataGridView1.Columns["Quantity"].Width = columnWidth / 2;
            dataGridView1.Columns["UnitCost"].Width = columnWidth / 2;
            dataGridView1.Columns["Cost"].Width = columnWidth / 2;
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
            int quantity;
            double unitCost, cost;
            // checks if the proper text fields have only integers in them
            if (int.TryParse(textQuantity.Text, out quantity) && double.TryParse(textUnitCost.Text, out unitCost) && double.TryParse(textCost.Text, out cost))
            {
                table.Rows.Add(listCategory.Text,
                                textItem.Text,
                                textMaterial.Text,
                                textDescription.Text,
                                quantity,
                                unitCost,
                                cost,
                                textNotes.Text);
                clearTextFields();
            }
            else
            {
                // this is called when the user presses submit and there are non-numeric values in quantity, unitCost, cost fields
                // have a label pop up on the design that tells the user they messed up or smth
            }

            System.Diagnostics.Debug.WriteLine("Button clicked!");
        }

        private void saveBttn_Click_1(object sender, EventArgs e)
        {
            
            
        }

    }

}
