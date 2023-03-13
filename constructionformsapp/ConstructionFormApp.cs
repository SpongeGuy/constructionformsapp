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
    public partial class ConstructionFormApp : Form
    {
        DataTable table;
        List<Order> orders = new List<Order>();
        public ConstructionFormApp()
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
            dataGridView1.Columns["Category"].ReadOnly = true;

            dataGridView1.Refresh();
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float totalCost = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float cost = float.Parse(row.Cells["Cost"].Value.ToString());
                totalCost += cost;
            }

            MessageBox.Show("Total cost: " + totalCost.ToString("C"));
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
                order.Cost,
                order.notes);
            
            orders.Add(order);
            DebugHandler.DisplayOrders(orders);

        }

        private void calculateTotal_Click(object sender, EventArgs e)
        {
            float totalCost = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                float cost = float.Parse(row.Cells["Cost"].Value.ToString());
                totalCost += cost;
            }

            MessageBox.Show("Total cost: " + totalCost.ToString("C"));
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            int rowID = int.Parse(row.Cells[0].Value.ToString());

            foreach (Order order in orders)
            {
                if (order.id == rowID)
                {
                    DebugHandler.DisplayOrders(orders);
                    switch (cell.OwningColumn.Name)
                    {
                        case "Item":
                            order.itemName = cell.Value.ToString();
                            break;
                        case "Material":
                            order.material = cell.Value.ToString();
                            break;
                        case "Description":
                            order.description = cell.Value.ToString();
                            break;
                        case "Quantity":
                            order.quantity = int.Parse(cell.Value.ToString());
                            break;
                        case "UnitCost":
                            order.unitCost = float.Parse(cell.Value.ToString());
                            break;
                        case "Notes":
                            order.notes = cell.Value.ToString();
                            break;
                    }
                    DebugHandler.DisplayOrders(orders);
                }
            }
            
        }

        private void delete_row(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Delete) throw new Exception("Not del key");
                List<DataGridViewRow> rows = new List<DataGridViewRow>();
                foreach(DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    int rowIndex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    rows.Add(row);
                }

                // get list of selected order ids
                List<int> selectedIDs = new List<int>();
                foreach (DataGridViewRow row in rows)
                {
                    if (row != null)
                    {
                        int orderID = (int)row.Cells["ID"].Value;
                        selectedIDs.Add(orderID);
                    }
                    
                }

                // remove selected orders from data source
                foreach (int id in selectedIDs)
                {
                    Order orderToRemove = orders.FirstOrDefault(o => o.id == id);
                    if (orderToRemove != null)
                    {
                        orders.Remove(orderToRemove);
                    }
                }

                // remove selected rows from datagridview
                foreach (DataGridViewRow row in rows)
                {
                    dataGridView1.Rows.Remove(row);
                }

                dataGridView1.Refresh();
                e.Handled = true;
            }
            catch (Exception exception)
            {
                DebugHandler.Write(exception.Message);
            }
            finally
            {
                DebugHandler.DisplayOrders(orders);
            }
        }

        private void query_quantity(object sender, EventArgs e)
        {
            var subForm = new SubTotalForm(this.orders);
            subForm.Show();
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
        private float cost;
        public float Cost
        {
            get
            {
                recalculateCost();
                return cost;
            }
        }
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
        public static void Write(params string[] messages)
        {
            foreach (string message in messages)
            {
                System.Diagnostics.Debug.WriteLine(message);
            }
        }

        public static void DisplayOrders(List<Order> orders)
        {
            Write("--------");
            foreach (Order order in orders)
            {
                Write("", order.category, order.itemName, order.material, order.description, order.quantity.ToString(), order.unitCost.ToString(), order.Cost.ToString(), order.notes);
            }
            Write("--------");
        }

        
    }

    
}
