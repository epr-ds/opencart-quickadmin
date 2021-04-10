namespace WinForms.Views
{
    partial class StockView
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.lstVwProducts = new MaterialSkin.Controls.MaterialListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.addProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.editProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadStockMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.loginMenuItemStock = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btNext = new MaterialSkin.Controls.MaterialButton();
            this.btPrev = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteProduct = new MaterialSkin.Controls.MaterialButton();
            this.btEditProduct = new MaterialSkin.Controls.MaterialButton();
            this.btAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.lbl_messsage = new LollipopLabel();
            this.panel1.SuspendLayout();
            this.StockContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.lbl_messsage);
            this.panel1.Controls.Add(this.lstVwProducts);
            this.panel1.Controls.Add(this.pictureBox_iconSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btDeleteProduct);
            this.panel1.Controls.Add(this.btEditProduct);
            this.panel1.Controls.Add(this.btAddProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2038, 1217);
            this.panel1.TabIndex = 1;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearch.Depth = 0;
            this.txtBxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBxSearch.Location = new System.Drawing.Point(242, 63);
            this.txtBxSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBxSearch.MaxLength = 50;
            this.txtBxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearch.Multiline = false;
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(1560, 50);
            this.txtBxSearch.TabIndex = 14;
            this.txtBxSearch.Text = "";
            // 
            // lstVwProducts
            // 
            this.lstVwProducts.AllowColumnReorder = true;
            this.lstVwProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVwProducts.AutoSizeTable = false;
            this.lstVwProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerTitle,
            this.headerStatus,
            this.headerQuantity,
            this.headerPrice});
            this.lstVwProducts.ContextMenuStrip = this.StockContextMenuStrip;
            this.lstVwProducts.Depth = 0;
            this.lstVwProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVwProducts.FullRowSelect = true;
            this.lstVwProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwProducts.HideSelection = false;
            this.lstVwProducts.Location = new System.Drawing.Point(156, 144);
            this.lstVwProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstVwProducts.MinimumSize = new System.Drawing.Size(400, 192);
            this.lstVwProducts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwProducts.MultiSelect = false;
            this.lstVwProducts.Name = "lstVwProducts";
            this.lstVwProducts.OwnerDraw = true;
            this.lstVwProducts.Size = new System.Drawing.Size(1646, 904);
            this.lstVwProducts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwProducts.TabIndex = 11;
            this.lstVwProducts.UseCompatibleStateImageBehavior = false;
            this.lstVwProducts.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "ID";
            // 
            // headerTitle
            // 
            this.headerTitle.Text = "Producto";
            this.headerTitle.Width = 250;
            // 
            // headerStatus
            // 
            this.headerStatus.Text = "Estado";
            this.headerStatus.Width = 150;
            // 
            // headerQuantity
            // 
            this.headerQuantity.Text = "Cantidad";
            this.headerQuantity.Width = 120;
            // 
            // headerPrice
            // 
            this.headerPrice.Text = "Precio";
            this.headerPrice.Width = 120;
            // 
            // StockContextMenuStrip
            // 
            this.StockContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StockContextMenuStrip.Depth = 0;
            this.StockContextMenuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.StockContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductMenuItem,
            this.editProductMenuItem,
            this.deleteProductMenuItem,
            this.toolStripSeparator1,
            this.reloadStockMenuItem,
            this.loginMenuItemStock});
            this.StockContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.StockContextMenuStrip.Name = "StockContextMenuStrip";
            this.StockContextMenuStrip.Size = new System.Drawing.Size(244, 160);
            // 
            // addProductMenuItem
            // 
            this.addProductMenuItem.AutoSize = false;
            this.addProductMenuItem.Image = global::WinForms.Properties.Resources.NewProduct_32px;
            this.addProductMenuItem.Name = "addProductMenuItem";
            this.addProductMenuItem.Size = new System.Drawing.Size(120, 30);
            this.addProductMenuItem.Text = "Añadir";
            // 
            // editProductMenuItem
            // 
            this.editProductMenuItem.AutoSize = false;
            this.editProductMenuItem.Image = global::WinForms.Properties.Resources.Edit_32px;
            this.editProductMenuItem.Name = "editProductMenuItem";
            this.editProductMenuItem.Size = new System.Drawing.Size(120, 30);
            this.editProductMenuItem.Text = "Editar";
            // 
            // deleteProductMenuItem
            // 
            this.deleteProductMenuItem.AutoSize = false;
            this.deleteProductMenuItem.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.deleteProductMenuItem.Name = "deleteProductMenuItem";
            this.deleteProductMenuItem.Size = new System.Drawing.Size(120, 30);
            this.deleteProductMenuItem.Text = "Eliminar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // reloadStockMenuItem
            // 
            this.reloadStockMenuItem.AutoSize = false;
            this.reloadStockMenuItem.Image = global::WinForms.Properties.Resources.Refresh_32px;
            this.reloadStockMenuItem.Name = "reloadStockMenuItem";
            this.reloadStockMenuItem.Size = new System.Drawing.Size(120, 30);
            this.reloadStockMenuItem.Text = "Recargar";
            // 
            // loginMenuItemStock
            // 
            this.loginMenuItemStock.AutoSize = false;
            this.loginMenuItemStock.Image = global::WinForms.Properties.Resources.Password_32px;
            this.loginMenuItemStock.Name = "loginMenuItemStock";
            this.loginMenuItemStock.Size = new System.Drawing.Size(120, 30);
            this.loginMenuItemStock.Text = "Iniciar sesión";
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::WinForms.Properties.Resources.Search_32px;
            this.pictureBox_iconSearch.Location = new System.Drawing.Point(156, 63);
            this.pictureBox_iconSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.Size = new System.Drawing.Size(74, 69);
            this.pictureBox_iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_iconSearch.TabIndex = 10;
            this.pictureBox_iconSearch.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picLoading);
            this.panel2.Controls.Add(this.btNext);
            this.panel2.Controls.Add(this.btPrev);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 1146);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2038, 71);
            this.panel2.TabIndex = 8;
            // 
            // picLoading
            // 
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picLoading.Location = new System.Drawing.Point(1916, 0);
            this.picLoading.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(122, 71);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 9;
            this.picLoading.TabStop = false;
            // 
            // btNext
            // 
            this.btNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btNext.Depth = 0;
            this.btNext.Dock = System.Windows.Forms.DockStyle.Left;
            this.btNext.DrawShadows = true;
            this.btNext.HighEmphasis = true;
            this.btNext.Icon = global::WinForms.Properties.Resources.Forward_32px;
            this.btNext.Location = new System.Drawing.Point(44, 0);
            this.btNext.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(44, 71);
            this.btNext.TabIndex = 2;
            this.btNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btNext.UseAccentColor = false;
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // btPrev
            // 
            this.btPrev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btPrev.Depth = 0;
            this.btPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btPrev.DrawShadows = true;
            this.btPrev.HighEmphasis = true;
            this.btPrev.Icon = global::WinForms.Properties.Resources.Back_32px;
            this.btPrev.Location = new System.Drawing.Point(0, 0);
            this.btPrev.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(44, 71);
            this.btPrev.TabIndex = 3;
            this.btPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrev.UseAccentColor = false;
            this.btPrev.UseVisualStyleBackColor = true;
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteProduct.Depth = 0;
            this.btDeleteProduct.DrawShadows = true;
            this.btDeleteProduct.HighEmphasis = true;
            this.btDeleteProduct.Icon = global::WinForms.Properties.Resources.Trash_32px;
            this.btDeleteProduct.Location = new System.Drawing.Point(1860, 337);
            this.btDeleteProduct.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btDeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(44, 36);
            this.btDeleteProduct.TabIndex = 5;
            this.btDeleteProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDeleteProduct.UseAccentColor = false;
            this.btDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btEditProduct
            // 
            this.btEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEditProduct.Depth = 0;
            this.btEditProduct.DrawShadows = true;
            this.btEditProduct.HighEmphasis = true;
            this.btEditProduct.Icon = global::WinForms.Properties.Resources.Edit_32px;
            this.btEditProduct.Location = new System.Drawing.Point(1860, 240);
            this.btEditProduct.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btEditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(44, 36);
            this.btEditProduct.TabIndex = 5;
            this.btEditProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btEditProduct.UseAccentColor = false;
            this.btEditProduct.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            this.btAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddProduct.Depth = 0;
            this.btAddProduct.DrawShadows = true;
            this.btAddProduct.HighEmphasis = true;
            this.btAddProduct.Icon = global::WinForms.Properties.Resources.NewProduct_32px;
            this.btAddProduct.Location = new System.Drawing.Point(1860, 144);
            this.btAddProduct.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(44, 36);
            this.btAddProduct.TabIndex = 5;
            this.btAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddProduct.UseAccentColor = false;
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // lbl_messsage
            // 
            this.lbl_messsage.AutoSize = true;
            this.lbl_messsage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_messsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_messsage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_messsage.Location = new System.Drawing.Point(150, 1054);
            this.lbl_messsage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_messsage.Name = "lbl_messsage";
            this.lbl_messsage.Size = new System.Drawing.Size(124, 31);
            this.lbl_messsage.TabIndex = 12;
            this.lbl_messsage.Text = "Message";
            // 
            // StockView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StockView";
            this.Size = new System.Drawing.Size(2038, 1217);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StockContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLoading;
        private MaterialSkin.Controls.MaterialButton btNext;
        private MaterialSkin.Controls.MaterialButton btPrev;
        private MaterialSkin.Controls.MaterialButton btAddProduct;
        private MaterialSkin.Controls.MaterialListView lstVwProducts;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerTitle;
        private System.Windows.Forms.ColumnHeader headerStatus;
        private System.Windows.Forms.ColumnHeader headerQuantity;
        private System.Windows.Forms.ColumnHeader headerPrice;
        private MaterialSkin.Controls.MaterialButton btDeleteProduct;
        private MaterialSkin.Controls.MaterialButton btEditProduct;
        private LollipopLabel lbl_messsage;
        private MaterialSkin.Controls.MaterialContextMenuStrip StockContextMenuStrip;
        private MaterialSkin.Controls.MaterialToolStripMenuItem addProductMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem editProductMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem deleteProductMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem reloadStockMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem loginMenuItemStock;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearch;
    }
}
