namespace Kolokwium1
{
    partial class Form1
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
            txtName = new TextBox();
            txtGift = new TextBox();
            txtPrice = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            lblCount = new Label();
            lblTotal = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(91, 57);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Imie";
            txtName.Size = new Size(240, 23);
            txtName.TabIndex = 0;
            // 
            // txtGift
            // 
            txtGift.Location = new Point(91, 86);
            txtGift.Name = "txtGift";
            txtGift.PlaceholderText = "Nazwa Prezentu";
            txtGift.Size = new Size(240, 23);
            txtGift.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(91, 115);
            txtPrice.Name = "txtPrice";
            txtPrice.PlaceholderText = "Cena";
            txtPrice.Size = new Size(240, 23);
            txtPrice.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(256, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 4;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(195, 375);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(38, 15);
            lblCount.TabIndex = 5;
            lblCount.Text = "label1";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(195, 407);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 375);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 7;
            label1.Text = "Ilość: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 407);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 7;
            label2.Text = "cena całości: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Controls.Add(lblCount);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Controls.Add(txtPrice);
            Controls.Add(txtGift);
            Controls.Add(txtName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtGift;
        private TextBox txtPrice;
        private Button btnAdd;
        private DataGridView dataGridView1;
        private Label lblCount;
        private Label lblTotal;
        private Label label1;
        private Label label2;
    }
}
