namespace WinForms.Views
{
    partial class OrdersView
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
            this.lblMsg = new LollipopLabel();
            this.btEditOrder = new MaterialSkin.Controls.MaterialButton();
            this.btAddOrder = new MaterialSkin.Controls.MaterialButton();
            this.btViewOrder = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteOrder = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.txtBxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btNext = new MaterialSkin.Controls.MaterialButton();
            this.btPrev = new MaterialSkin.Controls.MaterialButton();
            this.lstVwOrders = new MaterialSkin.Controls.MaterialListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAdded = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerModified = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrdersContextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.addOrderMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.editOrderMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteOrderMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.reloadOrdersMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.loginMenuItemOrder = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.OrdersContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.btEditOrder);
            this.panel1.Controls.Add(this.btAddOrder);
            this.panel1.Controls.Add(this.btViewOrder);
            this.panel1.Controls.Add(this.btDeleteOrder);
            this.panel1.Controls.Add(this.pictureBox_iconSearch);
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstVwOrders);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 400);
            this.panel1.TabIndex = 1;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblMsg.Location = new System.Drawing.Point(75, 318);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(78, 17);
            this.lblMsg.TabIndex = 15;
            this.lblMsg.Text = "Notification";
            // 
            // btEditOrder
            // 
            this.btEditOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEditOrder.Depth = 0;
            this.btEditOrder.DrawShadows = true;
            this.btEditOrder.HighEmphasis = true;
            this.btEditOrder.Icon = global::WinForms.Properties.Resources.CurrencyExchange_32px;
            this.btEditOrder.Location = new System.Drawing.Point(836, 126);
            this.btEditOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btEditOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditOrder.Name = "btEditOrder";
            this.btEditOrder.Size = new System.Drawing.Size(44, 36);
            this.btEditOrder.TabIndex = 12;
            this.btEditOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btEditOrder.UseAccentColor = false;
            this.btEditOrder.UseVisualStyleBackColor = true;
            // 
            // btAddOrder
            // 
            this.btAddOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddOrder.Depth = 0;
            this.btAddOrder.DrawShadows = true;
            this.btAddOrder.HighEmphasis = true;
            this.btAddOrder.Icon = global::WinForms.Properties.Resources.AddTag_32px;
            this.btAddOrder.Location = new System.Drawing.Point(836, 75);
            this.btAddOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Size = new System.Drawing.Size(44, 36);
            this.btAddOrder.TabIndex = 11;
            this.btAddOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddOrder.UseAccentColor = false;
            this.btAddOrder.UseVisualStyleBackColor = true;
            // 
            // btViewOrder
            // 
            this.btViewOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btViewOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btViewOrder.Depth = 0;
            this.btViewOrder.DrawShadows = true;
            this.btViewOrder.HighEmphasis = true;
            this.btViewOrder.Icon = global::WinForms.Properties.Resources.Eye_32px;
            this.btViewOrder.Location = new System.Drawing.Point(836, 176);
            this.btViewOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btViewOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btViewOrder.Name = "btViewOrder";
            this.btViewOrder.Size = new System.Drawing.Size(44, 36);
            this.btViewOrder.TabIndex = 13;
            this.btViewOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btViewOrder.UseAccentColor = false;
            this.btViewOrder.UseVisualStyleBackColor = true;
            // 
            // btDeleteOrder
            // 
            this.btDeleteOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteOrder.Depth = 0;
            this.btDeleteOrder.DrawShadows = true;
            this.btDeleteOrder.HighEmphasis = true;
            this.btDeleteOrder.Icon = global::WinForms.Properties.Resources.Trash_32px;
            this.btDeleteOrder.Location = new System.Drawing.Point(836, 226);
            this.btDeleteOrder.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDeleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Size = new System.Drawing.Size(44, 36);
            this.btDeleteOrder.TabIndex = 14;
            this.btDeleteOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDeleteOrder.UseAccentColor = false;
            this.btDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::WinForms.Properties.Resources.Search_32px;
            this.pictureBox_iconSearch.Location = new System.Drawing.Point(78, 33);
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.Size = new System.Drawing.Size(37, 36);
            this.pictureBox_iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_iconSearch.TabIndex = 10;
            this.pictureBox_iconSearch.TabStop = false;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BackColor = System.Drawing.SystemColors.Control;
            this.txtBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearch.Depth = 0;
            this.txtBxSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxSearch.Hint = "Buscar...";
            this.txtBxSearch.Location = new System.Drawing.Point(121, 33);
            this.txtBxSearch.MaxLength = 32767;
            this.txtBxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearch.Multiline = false;
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(708, 36);
            this.txtBxSearch.TabIndex = 9;
            this.txtBxSearch.TabStop = false;
            this.txtBxSearch.Text = "";
            this.txtBxSearch.UseAccent = false;
            this.txtBxSearch.UseTallSize = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picLoading);
            this.panel2.Controls.Add(this.btNext);
            this.panel2.Controls.Add(this.btPrev);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 37);
            this.panel2.TabIndex = 8;
            // 
            // picLoading
            // 
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Right;
            this.picLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picLoading.Location = new System.Drawing.Point(904, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(46, 37);
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
            this.btNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(44, 37);
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
            this.btPrev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btPrev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrev.Name = "btPrev";
            this.btPrev.Size = new System.Drawing.Size(44, 37);
            this.btPrev.TabIndex = 3;
            this.btPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrev.UseAccentColor = false;
            this.btPrev.UseVisualStyleBackColor = true;
            // 
            // lstVwOrders
            // 
            this.lstVwOrders.AllowColumnReorder = true;
            this.lstVwOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVwOrders.AutoSizeTable = false;
            this.lstVwOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerCustomer,
            this.headerStatus,
            this.headerTotal,
            this.headerAdded,
            this.headerModified});
            this.lstVwOrders.ContextMenuStrip = this.OrdersContextMenu;
            this.lstVwOrders.Depth = 0;
            this.lstVwOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVwOrders.FullRowSelect = true;
            this.lstVwOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwOrders.HideSelection = false;
            this.lstVwOrders.Location = new System.Drawing.Point(75, 75);
            this.lstVwOrders.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstVwOrders.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwOrders.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwOrders.Name = "lstVwOrders";
            this.lstVwOrders.OwnerDraw = true;
            this.lstVwOrders.ShowGroups = false;
            this.lstVwOrders.Size = new System.Drawing.Size(754, 237);
            this.lstVwOrders.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwOrders.TabIndex = 0;
            this.lstVwOrders.UseCompatibleStateImageBehavior = false;
            this.lstVwOrders.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "ID";
            // 
            // headerCustomer
            // 
            this.headerCustomer.Text = "Cliente";
            this.headerCustomer.Width = 120;
            // 
            // headerStatus
            // 
            this.headerStatus.Text = "Estado";
            this.headerStatus.Width = 120;
            // 
            // headerTotal
            // 
            this.headerTotal.Text = "Total";
            this.headerTotal.Width = 120;
            // 
            // headerAdded
            // 
            this.headerAdded.Text = "Añadido";
            this.headerAdded.Width = 120;
            // 
            // headerModified
            // 
            this.headerModified.Text = "Modificado";
            this.headerModified.Width = 120;
            // 
            // OrdersContextMenu
            // 
            this.OrdersContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.OrdersContextMenu.Depth = 0;
            this.OrdersContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOrderMenuItem,
            this.editOrderMenuItem,
            this.deleteOrderMenuItem,
            this.toolStripSeparator,
            this.reloadOrdersMenuItem,
            this.loginMenuItemOrder});
            this.OrdersContextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrdersContextMenu.Name = "OrdersContextMenu";
            this.OrdersContextMenu.Size = new System.Drawing.Size(143, 160);
            // 
            // addOrderMenuItem
            // 
            this.addOrderMenuItem.AutoSize = false;
            this.addOrderMenuItem.Image = global::WinForms.Properties.Resources.AddTag_32px;
            this.addOrderMenuItem.Name = "addOrderMenuItem";
            this.addOrderMenuItem.Size = new System.Drawing.Size(120, 30);
            this.addOrderMenuItem.Text = "Añadir";
            // 
            // editOrderMenuItem
            // 
            this.editOrderMenuItem.AutoSize = false;
            this.editOrderMenuItem.Image = global::WinForms.Properties.Resources.Edit_32px;
            this.editOrderMenuItem.Name = "editOrderMenuItem";
            this.editOrderMenuItem.Size = new System.Drawing.Size(120, 30);
            this.editOrderMenuItem.Text = "Editar";
            // 
            // deleteOrderMenuItem
            // 
            this.deleteOrderMenuItem.AutoSize = false;
            this.deleteOrderMenuItem.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.deleteOrderMenuItem.Name = "deleteOrderMenuItem";
            this.deleteOrderMenuItem.Size = new System.Drawing.Size(120, 30);
            this.deleteOrderMenuItem.Text = "Eliminar";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(139, 6);
            // 
            // reloadOrdersMenuItem
            // 
            this.reloadOrdersMenuItem.AutoSize = false;
            this.reloadOrdersMenuItem.Image = global::WinForms.Properties.Resources.Refresh_32px;
            this.reloadOrdersMenuItem.Name = "reloadOrdersMenuItem";
            this.reloadOrdersMenuItem.Size = new System.Drawing.Size(120, 30);
            this.reloadOrdersMenuItem.Text = "Recargar";
            // 
            // loginMenuItemOrder
            // 
            this.loginMenuItemOrder.AutoSize = false;
            this.loginMenuItemOrder.Image = global::WinForms.Properties.Resources.Password_32px;
            this.loginMenuItemOrder.Name = "loginMenuItemOrder";
            this.loginMenuItemOrder.Size = new System.Drawing.Size(120, 30);
            this.loginMenuItemOrder.Text = "Iniciar sesión";
            // 
            // OrdersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "OrdersView";
            this.Size = new System.Drawing.Size(950, 400);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.OrdersContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LollipopLabel lblMsg;
        private MaterialSkin.Controls.MaterialButton btEditOrder;
        private MaterialSkin.Controls.MaterialButton btAddOrder;
        private MaterialSkin.Controls.MaterialButton btViewOrder;
        private MaterialSkin.Controls.MaterialButton btDeleteOrder;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picLoading;
        private MaterialSkin.Controls.MaterialButton btNext;
        private MaterialSkin.Controls.MaterialButton btPrev;
        private MaterialSkin.Controls.MaterialListView lstVwOrders;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerCustomer;
        private System.Windows.Forms.ColumnHeader headerStatus;
        private System.Windows.Forms.ColumnHeader headerTotal;
        private System.Windows.Forms.ColumnHeader headerAdded;
        private System.Windows.Forms.ColumnHeader headerModified;
        private MaterialSkin.Controls.MaterialContextMenuStrip OrdersContextMenu;
        private MaterialSkin.Controls.MaterialToolStripMenuItem addOrderMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem editOrderMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem deleteOrderMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem reloadOrdersMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem loginMenuItemOrder;
    }
}
