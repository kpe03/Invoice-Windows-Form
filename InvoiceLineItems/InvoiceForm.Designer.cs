namespace InvoiceLineItems
{
    partial class InvoiceForm
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
			this.lvInvoices = new System.Windows.Forms.ListView();
			this.InvoiceIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InvoiceDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.InvoiceTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ProductCodeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.UnitPriceColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.QuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ItemTotalColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lvInvoices
			// 
			this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceIDColumn,
            this.InvoiceDateColumn,
            this.InvoiceTotalColumn,
            this.ProductCodeColumn,
            this.UnitPriceColumn,
            this.QuantityColumn,
            this.ItemTotalColumn});
			this.lvInvoices.GridLines = true;
			this.lvInvoices.HideSelection = false;
			this.lvInvoices.Location = new System.Drawing.Point(12, 29);
			this.lvInvoices.Name = "lvInvoices";
			this.lvInvoices.Size = new System.Drawing.Size(763, 489);
			this.lvInvoices.TabIndex = 1;
			this.lvInvoices.UseCompatibleStateImageBehavior = false;
			this.lvInvoices.View = System.Windows.Forms.View.Details;
			// 
			// InvoiceIDColumn
			// 
			this.InvoiceIDColumn.Text = "InvoiceID";
			this.InvoiceIDColumn.Width = 100;
			// 
			// InvoiceDateColumn
			// 
			this.InvoiceDateColumn.Text = "InvoiceDate";
			this.InvoiceDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InvoiceDateColumn.Width = 100;
			// 
			// InvoiceTotalColumn
			// 
			this.InvoiceTotalColumn.Text = "InvoiceTotal";
			this.InvoiceTotalColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.InvoiceTotalColumn.Width = 100;
			// 
			// ProductCodeColumn
			// 
			this.ProductCodeColumn.Tag = "";
			this.ProductCodeColumn.Text = "Product Code";
			this.ProductCodeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ProductCodeColumn.Width = 100;
			// 
			// UnitPriceColumn
			// 
			this.UnitPriceColumn.Text = "Unit Price";
			this.UnitPriceColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.UnitPriceColumn.Width = 100;
			// 
			// QuantityColumn
			// 
			this.QuantityColumn.Text = "Quantity";
			this.QuantityColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.QuantityColumn.Width = 100;
			// 
			// ItemTotalColumn
			// 
			this.ItemTotalColumn.Text = "Item Total";
			this.ItemTotalColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ItemTotalColumn.Width = 100;
			// 
			// InvoiceForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(795, 537);
			this.Controls.Add(this.lvInvoices);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "InvoiceForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Invoice Line Items by Invoice Date";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader InvoiceIDColumn;
        private System.Windows.Forms.ColumnHeader InvoiceDateColumn;
        private System.Windows.Forms.ColumnHeader InvoiceTotalColumn;
        private System.Windows.Forms.ColumnHeader ProductCodeColumn;
        private System.Windows.Forms.ColumnHeader UnitPriceColumn;
        private System.Windows.Forms.ColumnHeader QuantityColumn;
        private System.Windows.Forms.ColumnHeader ItemTotalColumn;
    }
}

