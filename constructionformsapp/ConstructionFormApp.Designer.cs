
namespace constructionformsapp
{
    partial class ConstructionFormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCategory = new System.Windows.Forms.ComboBox();
            this.textItem = new System.Windows.Forms.TextBox();
            this.textMaterial = new System.Windows.Forms.TextBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.textUnitCost = new System.Windows.Forms.TextBox();
            this.textNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonViewQuantity = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listCategory
            // 
            this.listCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCategory.FormattingEnabled = true;
            this.listCategory.Items.AddRange(new object[] {
            "Foundation",
            "Framing",
            "Cladding",
            "Roofing",
            "Flooring",
            "Interior Walls",
            "Openings"});
            this.listCategory.Location = new System.Drawing.Point(12, 26);
            this.listCategory.Name = "listCategory";
            this.listCategory.Size = new System.Drawing.Size(118, 23);
            this.listCategory.TabIndex = 0;
            // 
            // textItem
            // 
            this.textItem.Location = new System.Drawing.Point(137, 26);
            this.textItem.Name = "textItem";
            this.textItem.Size = new System.Drawing.Size(132, 23);
            this.textItem.TabIndex = 2;
            // 
            // textMaterial
            // 
            this.textMaterial.Location = new System.Drawing.Point(275, 26);
            this.textMaterial.Name = "textMaterial";
            this.textMaterial.Size = new System.Drawing.Size(197, 23);
            this.textMaterial.TabIndex = 3;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(478, 26);
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(270, 23);
            this.textDescription.TabIndex = 4;
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(754, 26);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(73, 23);
            this.textQuantity.TabIndex = 5;
            // 
            // textUnitCost
            // 
            this.textUnitCost.Location = new System.Drawing.Point(833, 26);
            this.textUnitCost.Name = "textUnitCost";
            this.textUnitCost.Size = new System.Drawing.Size(72, 23);
            this.textUnitCost.TabIndex = 6;
            // 
            // textNotes
            // 
            this.textNotes.Location = new System.Drawing.Point(911, 26);
            this.textNotes.Name = "textNotes";
            this.textNotes.Size = new System.Drawing.Size(243, 23);
            this.textNotes.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Material";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(478, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Size/Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(754, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(833, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Unit Cost";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(911, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Notes";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(1160, 23);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(80, 26);
            this.buttonSubmit.TabIndex = 17;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 19;
            this.dataGridView1.Size = new System.Drawing.Size(1228, 482);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.delete_row);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(1160, 560);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(80, 65);
            this.buttonCalculate.TabIndex = 19;
            this.buttonCalculate.Text = "Calculate Total";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // buttonViewQuantity
            // 
            this.buttonViewQuantity.Location = new System.Drawing.Point(1074, 560);
            this.buttonViewQuantity.Name = "buttonViewQuantity";
            this.buttonViewQuantity.Size = new System.Drawing.Size(80, 65);
            this.buttonViewQuantity.TabIndex = 20;
            this.buttonViewQuantity.Text = "View Total Quantity Ordered";
            this.buttonViewQuantity.UseVisualStyleBackColor = true;
            this.buttonViewQuantity.Click += new System.EventHandler(this.query_quantity);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(514, 610);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tip: Press \'DEL\' on any cell to delete its row!";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 610);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Evan Cropper, Jackson Goodall, Erin Denning";
            // 
            // ConstructionFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 637);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonViewQuantity);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNotes);
            this.Controls.Add(this.textUnitCost);
            this.Controls.Add(this.textQuantity);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.textMaterial);
            this.Controls.Add(this.textItem);
            this.Controls.Add(this.listCategory);
            this.Name = "ConstructionFormApp";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox listCategory;
        private System.Windows.Forms.TextBox textItem;
        private System.Windows.Forms.TextBox textMaterial;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.TextBox textUnitCost;
        private System.Windows.Forms.TextBox textNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonViewQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
    }
}

