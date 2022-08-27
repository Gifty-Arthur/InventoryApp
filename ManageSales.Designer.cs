namespace InventoryApp
{
    partial class ManageSales
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.OrdIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdDate = new System.Windows.Forms.DateTimePicker();
            this.QtyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.OrderGv = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.InsBtn = new System.Windows.Forms.Button();
            this.ViewBtn = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.ForestGreen;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 96);
            this.panel4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(808, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(156, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(293, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Manage Sales";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SearchCombo
            // 
            this.SearchCombo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchCombo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(487, 102);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(148, 25);
            this.SearchCombo.TabIndex = 25;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            this.ProductsGV.AllowUserToAddRows = false;
            this.ProductsGV.AllowUserToDeleteRows = false;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ProductsGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.ColumnHeadersVisible = false;
            this.ProductsGV.Location = new System.Drawing.Point(247, 133);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.ReadOnly = true;
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowTemplate.Height = 25;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(568, 203);
            this.ProductsGV.TabIndex = 24;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // OrdIdTxt
            // 
            this.OrdIdTxt.Location = new System.Drawing.Point(12, 200);
            this.OrdIdTxt.Name = "OrdIdTxt";
            this.OrdIdTxt.PlaceholderText = "Order ID";
            this.OrdIdTxt.Size = new System.Drawing.Size(158, 23);
            this.OrdIdTxt.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Order Date";
            // 
            // OrdDate
            // 
            this.OrdDate.CustomFormat = "YYYYMMDD";
            this.OrdDate.Location = new System.Drawing.Point(12, 275);
            this.OrdDate.Name = "OrdDate";
            this.OrdDate.Size = new System.Drawing.Size(200, 23);
            this.OrdDate.TabIndex = 29;
            this.OrdDate.Value = new System.DateTime(2022, 8, 27, 16, 11, 20, 0);
            // 
            // QtyTxt
            // 
            this.QtyTxt.Location = new System.Drawing.Point(331, 345);
            this.QtyTxt.Name = "QtyTxt";
            this.QtyTxt.PlaceholderText = "Order Quantity";
            this.QtyTxt.Size = new System.Drawing.Size(158, 23);
            this.QtyTxt.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(245, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quantity";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(495, 342);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 32);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add To Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderGv
            // 
            this.OrderGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderGv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrderGv.BackgroundColor = System.Drawing.Color.LightGray;
            this.OrderGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OrderGv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGv.Location = new System.Drawing.Point(245, 385);
            this.OrderGv.Name = "OrderGv";
            this.OrderGv.RowHeadersVisible = false;
            this.OrderGv.RowTemplate.Height = 25;
            this.OrderGv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGv.Size = new System.Drawing.Size(568, 203);
            this.OrderGv.TabIndex = 33;
            this.OrderGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGv_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(364, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 27);
            this.label6.TabIndex = 34;
            this.label6.Text = "Total Amount";
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotAmount.Location = new System.Drawing.Point(534, 607);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(59, 27);
            this.TotAmount.TabIndex = 35;
            this.TotAmount.Text = "GHS";
            this.TotAmount.Click += new System.EventHandler(this.label7_Click);
            // 
            // InsBtn
            // 
            this.InsBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.InsBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.InsBtn.Location = new System.Drawing.Point(12, 606);
            this.InsBtn.Name = "InsBtn";
            this.InsBtn.Size = new System.Drawing.Size(104, 32);
            this.InsBtn.TabIndex = 36;
            this.InsBtn.Text = "Insert Order";
            this.InsBtn.UseVisualStyleBackColor = false;
            this.InsBtn.Click += new System.EventHandler(this.InsBtn_Click);
            // 
            // ViewBtn
            // 
            this.ViewBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.ViewBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewBtn.Location = new System.Drawing.Point(122, 606);
            this.ViewBtn.Name = "ViewBtn";
            this.ViewBtn.Size = new System.Drawing.Size(104, 32);
            this.ViewBtn.TabIndex = 37;
            this.ViewBtn.Text = "View Orders";
            this.ViewBtn.UseVisualStyleBackColor = false;
            // 
            // ManageSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 670);
            this.Controls.Add(this.ViewBtn);
            this.Controls.Add(this.InsBtn);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.OrderGv);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.QtyTxt);
            this.Controls.Add(this.OrdDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdIdTxt);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageSales";
            this.Text = "ManageSales";
            this.Load += new System.EventHandler(this.ManageSales_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel4;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox SearchCombo;
        private DataGridView ProductsGV;
        private TextBox OrdIdTxt;
        private Label label1;
        private DateTimePicker OrdDate;
        private TextBox QtyTxt;
        private Label label2;
        private Button btnAdd;
        private DataGridView OrderGv;
        private Label label6;
        private Label TotAmount;
        private Button InsBtn;
        private Button ViewBtn;
    }
}