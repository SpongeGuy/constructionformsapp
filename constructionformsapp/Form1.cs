using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* todo
 * finish editing functionality
 * calculate grand total at bottom or smth
 * automatically sort by category name on every entry into datagridview
 * add deletion functionality (add connection between the row in datagridview and its respective Order object)
 */

namespace constructionformsapp
{
    public partial class Form1 : Form
    {
        DataTable table;
        List<Order> orders = new List<Order>();
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Category", typeof(String));
            table.Columns.Add("Item", typeof(String));
            table.Columns.Add("Material", typeof(String));
            table.Columns.Add("Description", typeof(String));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitCost", typeof(float));
            table.Columns.Add("Cost", typeof(float));
            table.Columns.Add("Notes", typeof(String));

            dataGridView1.DataSource = table;

            

            dataGridView1.Columns["ID"].Visible = false;

            int columnWidth = dataGridView1.Width / 8;
            dataGridView1.Columns["Category"].Width = columnWidth;
            dataGridView1.Columns["Item"].Width = columnWidth;
            dataGridView1.Columns["Material"].Width = columnWidth;
            dataGridView1.Columns["Description"].Width = columnWidth * 2;
            dataGridView1.Columns["Quantity"].Width = columnWidth / 2;
            dataGridView1.Columns["UnitCost"].Width = columnWidth / 2;
            dataGridView1.Columns["Cost"].Width = columnWidth / 2;
            dataGridView1.Columns["Notes"].Width = columnWidth + columnWidth / 2;

            dataGridView1.Columns["UnitCost"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["Cost"].DefaultCellStyle.Format = "C";

            dataGridView1.Refresh();
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
            textNotes.Clear();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool success = false;
            int quantity = 0;
            float unitCost = 0;
            try
            {
                quantity = int.Parse(textQuantity.Text);
                unitCost = float.Parse(textUnitCost.Text);
                if (listCategory.Text.Length == 0 || textItem.Text.Length == 0 || textDescription.Text.Length == 0) throw new FormatException("No text in field.");
                success = true;
                
            }
            catch (FormatException exception)
            {
                DebugHandler.Write("Invalid text in numeric-only field: " + exception.Message);
            }
            finally
            {
                if (success)
                {
                    Order order = new(listCategory.Text, textItem.Text, textMaterial.Text, textDescription.Text, quantity, unitCost, textNotes.Text);
                    addToForm(order);
                    clearTextFields();
                }
            }
        }

        public void addToForm(Order order)
        {
            table.Rows.Add(
                order.id,
                order.category,
                order.itemName,
                order.material,
                order.description,
                order.quantity,
                order.unitCost,
                order.cost,
                order.notes);
            DebugHandler.Write("Order added successfully!");
            orders.Add(order);
            
        }

        public void removeFromForm(Order order)
        {

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int rowID = int.Parse(row.Cells[0].Value.ToString()); // idk how to do this any other way

            for (int index = 0; index < orders.Count; index++)
            {
                if (orders[index].id == rowID)
                {
                    // i dont know how to do this and im tired and i had to redo all of this bc i accidentally deleted everything
                }
            }
            
        }
    }



    public class Order
    {
        public static int key = 0;

        public int id;
        public string category;
        public string itemName;
        public string material;
        public string description;
        public int quantity;
        public float unitCost;
        public float cost;
        public string notes;

        public Order(string category, string itemName, string material, string description, int quantity, float unitCost, string notes)
        {
            this.id = key;
            this.category = category;
            this.itemName = itemName;
            this.material = material;
            this.description = description;
            this.quantity = quantity;
            this.unitCost = unitCost;
            this.notes = notes;
            recalculateCost();

            key++;
        }

        public void recalculateCost()
        {
            this.cost = quantity * unitCost;
        }
    }

    public class DebugHandler
    {
        public static void Write(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}
