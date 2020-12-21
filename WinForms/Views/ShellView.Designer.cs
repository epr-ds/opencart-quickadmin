namespace WinForms.Views
{
    partial class ShellView
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellView));
            this.materialTabMenu = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.lblOrdersStatus = new MaterialSkin.Controls.MaterialLabel();
            this.btEditOrder = new MaterialSkin.Controls.MaterialButton();
            this.btAddOrder = new MaterialSkin.Controls.MaterialButton();
            this.btViewOrder = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteOrder = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.txtBxSearchOrder = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picOrdersLoading = new System.Windows.Forms.PictureBox();
            this.btNextOrders = new MaterialSkin.Controls.MaterialButton();
            this.btPrevOrders = new MaterialSkin.Controls.MaterialButton();
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
            this.tabPageStock = new System.Windows.Forms.TabPage();
            this.lblStockStatus = new MaterialSkin.Controls.MaterialLabel();
            this.lstVwProducts = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StockContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.addProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.editProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteProductMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadStockMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.loginMenuItemStock = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBxSearchProduct = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picStockLoading = new System.Windows.Forms.PictureBox();
            this.btnNextStock = new MaterialSkin.Controls.MaterialButton();
            this.btnPrevStock = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteProduct = new MaterialSkin.Controls.MaterialButton();
            this.btEditProduct = new MaterialSkin.Controls.MaterialButton();
            this.btAddProduct = new MaterialSkin.Controls.MaterialButton();
            this.tabPageCustomers = new System.Windows.Forms.TabPage();
            this.lblCustomersStatus = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBxSearchCustomers = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picBxCustomersLoading = new System.Windows.Forms.PictureBox();
            this.btNextCustomers = new MaterialSkin.Controls.MaterialButton();
            this.btPrevCustomers = new MaterialSkin.Controls.MaterialButton();
            this.btEditCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btAddCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteCustomer = new MaterialSkin.Controls.MaterialButton();
            this.lstVwCustomers = new MaterialSkin.Controls.MaterialListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerContextMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.addCustomerMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.editCustomerMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.deleteCustomerMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadCustomersMenuItem = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.loginMenuItemCustomer = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblNotification = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_msg = new MaterialSkin.Controls.MaterialLabel();
            this.btSave = new MaterialSkin.Controls.MaterialButton();
            this.tabSettings = new MaterialSkin.Controls.MaterialTabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.folderInput = new LollipopFolderInPut();
            this.fileInput = new LollipopFileInput();
            this.txtBx_printer = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btExport = new MaterialSkin.Controls.MaterialButton();
            this.btImport = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox_folder = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_file = new System.Windows.Forms.PictureBox();
            this.label_saveFile_desc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_file_desc = new System.Windows.Forms.Label();
            this.chckBx_saveFile = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel_printer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_template = new MaterialSkin.Controls.MaterialLabel();
            this.tabApi = new System.Windows.Forms.TabPage();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.chkBx_cache = new MaterialSkin.Controls.MaterialCheckbox();
            this.btSubtract = new MaterialSkin.Controls.MaterialButton();
            this.btAdd = new MaterialSkin.Controls.MaterialButton();
            this.prgrssBr_minutes = new MaterialSkin.Controls.MaterialProgressBar();
            this.picProxy = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBx_nItems = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_APIkey = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxUrl = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_APIusr = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.MailContent = new WinForms.Controls.HTMLWYSIWYG();
            this.label7 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBx_mailPort = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailHost = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailPwd = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabSelectorSettings = new MaterialSkin.Controls.MaterialTabSelector();
            this.menuIconList = new System.Windows.Forms.ImageList(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.materialTabMenu.SuspendLayout();
            this.tabPageOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdersLoading)).BeginInit();
            this.OrdersContextMenu.SuspendLayout();
            this.tabPageStock.SuspendLayout();
            this.StockContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStockLoading)).BeginInit();
            this.tabPageCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCustomersLoading)).BeginInit();
            this.CustomerContextMenuStrip.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_folder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_file)).BeginInit();
            this.tabApi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProxy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.tabMail.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabMenu
            // 
            this.materialTabMenu.Controls.Add(this.tabPageOrders);
            this.materialTabMenu.Controls.Add(this.tabPageStock);
            this.materialTabMenu.Controls.Add(this.tabPageCustomers);
            this.materialTabMenu.Controls.Add(this.tabPageSettings);
            this.materialTabMenu.Depth = 0;
            resources.ApplyResources(this.materialTabMenu, "materialTabMenu");
            this.materialTabMenu.ImageList = this.menuIconList;
            this.materialTabMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabMenu.Multiline = true;
            this.materialTabMenu.Name = "materialTabMenu";
            this.materialTabMenu.SelectedIndex = 0;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.BackColor = System.Drawing.Color.White;
            this.tabPageOrders.Controls.Add(this.lblOrdersStatus);
            this.tabPageOrders.Controls.Add(this.btEditOrder);
            this.tabPageOrders.Controls.Add(this.btAddOrder);
            this.tabPageOrders.Controls.Add(this.btViewOrder);
            this.tabPageOrders.Controls.Add(this.btDeleteOrder);
            this.tabPageOrders.Controls.Add(this.pictureBox_iconSearch);
            this.tabPageOrders.Controls.Add(this.txtBxSearchOrder);
            this.tabPageOrders.Controls.Add(this.panel2);
            this.tabPageOrders.Controls.Add(this.lstVwOrders);
            resources.ApplyResources(this.tabPageOrders, "tabPageOrders");
            this.tabPageOrders.Name = "tabPageOrders";
            // 
            // lblOrdersStatus
            // 
            resources.ApplyResources(this.lblOrdersStatus, "lblOrdersStatus");
            this.lblOrdersStatus.Depth = 0;
            this.lblOrdersStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblOrdersStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblOrdersStatus.Name = "lblOrdersStatus";
            // 
            // btEditOrder
            // 
            resources.ApplyResources(this.btEditOrder, "btEditOrder");
            this.btEditOrder.BackColor = System.Drawing.Color.Transparent;
            this.btEditOrder.Depth = 0;
            this.btEditOrder.DrawShadows = true;
            this.btEditOrder.HighEmphasis = true;
            this.btEditOrder.Icon = global::WinForms.Properties.Resources.CurrencyExchange_32px;
            this.btEditOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditOrder.Name = "btEditOrder";
            this.btEditOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btEditOrder.UseAccentColor = false;
            this.btEditOrder.UseVisualStyleBackColor = false;
            // 
            // btAddOrder
            // 
            resources.ApplyResources(this.btAddOrder, "btAddOrder");
            this.btAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.btAddOrder.Depth = 0;
            this.btAddOrder.DrawShadows = true;
            this.btAddOrder.HighEmphasis = true;
            this.btAddOrder.Icon = global::WinForms.Properties.Resources.AddTag_32px;
            this.btAddOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddOrder.Name = "btAddOrder";
            this.btAddOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddOrder.UseAccentColor = false;
            this.btAddOrder.UseVisualStyleBackColor = false;
            // 
            // btViewOrder
            // 
            resources.ApplyResources(this.btViewOrder, "btViewOrder");
            this.btViewOrder.BackColor = System.Drawing.Color.Transparent;
            this.btViewOrder.Depth = 0;
            this.btViewOrder.DrawShadows = true;
            this.btViewOrder.HighEmphasis = true;
            this.btViewOrder.Icon = global::WinForms.Properties.Resources.Eye_32px;
            this.btViewOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btViewOrder.Name = "btViewOrder";
            this.btViewOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btViewOrder.UseAccentColor = false;
            this.btViewOrder.UseVisualStyleBackColor = false;
            // 
            // btDeleteOrder
            // 
            resources.ApplyResources(this.btDeleteOrder, "btDeleteOrder");
            this.btDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btDeleteOrder.Depth = 0;
            this.btDeleteOrder.DrawShadows = true;
            this.btDeleteOrder.HighEmphasis = true;
            this.btDeleteOrder.Icon = global::WinForms.Properties.Resources.Trash_32px;
            this.btDeleteOrder.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteOrder.Name = "btDeleteOrder";
            this.btDeleteOrder.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDeleteOrder.UseAccentColor = false;
            this.btDeleteOrder.UseVisualStyleBackColor = false;
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::WinForms.Properties.Resources.Search_32px;
            resources.ApplyResources(this.pictureBox_iconSearch, "pictureBox_iconSearch");
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.TabStop = false;
            // 
            // txtBxSearchOrder
            // 
            resources.ApplyResources(this.txtBxSearchOrder, "txtBxSearchOrder");
            this.txtBxSearchOrder.BackColor = System.Drawing.Color.White;
            this.txtBxSearchOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearchOrder.Depth = 0;
            this.txtBxSearchOrder.Hint = "Buscar...";
            this.txtBxSearchOrder.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearchOrder.Name = "txtBxSearchOrder";
            this.txtBxSearchOrder.TabStop = false;
            this.txtBxSearchOrder.UseAccent = false;
            this.txtBxSearchOrder.UseTallSize = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picOrdersLoading);
            this.panel2.Controls.Add(this.btNextOrders);
            this.panel2.Controls.Add(this.btPrevOrders);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // picOrdersLoading
            // 
            resources.ApplyResources(this.picOrdersLoading, "picOrdersLoading");
            this.picOrdersLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picOrdersLoading.Name = "picOrdersLoading";
            this.picOrdersLoading.TabStop = false;
            // 
            // btNextOrders
            // 
            resources.ApplyResources(this.btNextOrders, "btNextOrders");
            this.btNextOrders.BackColor = System.Drawing.Color.Transparent;
            this.btNextOrders.Depth = 0;
            this.btNextOrders.DrawShadows = true;
            this.btNextOrders.HighEmphasis = true;
            this.btNextOrders.Icon = global::WinForms.Properties.Resources.Forward_32px;
            this.btNextOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btNextOrders.Name = "btNextOrders";
            this.btNextOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btNextOrders.UseAccentColor = false;
            this.btNextOrders.UseVisualStyleBackColor = false;
            // 
            // btPrevOrders
            // 
            resources.ApplyResources(this.btPrevOrders, "btPrevOrders");
            this.btPrevOrders.BackColor = System.Drawing.Color.Transparent;
            this.btPrevOrders.Depth = 0;
            this.btPrevOrders.DrawShadows = true;
            this.btPrevOrders.HighEmphasis = true;
            this.btPrevOrders.Icon = global::WinForms.Properties.Resources.Back_32px;
            this.btPrevOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrevOrders.Name = "btPrevOrders";
            this.btPrevOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrevOrders.UseAccentColor = false;
            this.btPrevOrders.UseVisualStyleBackColor = false;
            // 
            // lstVwOrders
            // 
            this.lstVwOrders.AllowColumnReorder = true;
            resources.ApplyResources(this.lstVwOrders, "lstVwOrders");
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
            this.lstVwOrders.FullRowSelect = true;
            this.lstVwOrders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwOrders.HideSelection = false;
            this.lstVwOrders.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwOrders.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwOrders.MultiSelect = false;
            this.lstVwOrders.Name = "lstVwOrders";
            this.lstVwOrders.OwnerDraw = true;
            this.lstVwOrders.ShowGroups = false;
            this.lstVwOrders.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwOrders.UseCompatibleStateImageBehavior = false;
            this.lstVwOrders.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            resources.ApplyResources(this.headerID, "headerID");
            // 
            // headerCustomer
            // 
            resources.ApplyResources(this.headerCustomer, "headerCustomer");
            // 
            // headerStatus
            // 
            resources.ApplyResources(this.headerStatus, "headerStatus");
            // 
            // headerTotal
            // 
            resources.ApplyResources(this.headerTotal, "headerTotal");
            // 
            // headerAdded
            // 
            resources.ApplyResources(this.headerAdded, "headerAdded");
            // 
            // headerModified
            // 
            resources.ApplyResources(this.headerModified, "headerModified");
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
            resources.ApplyResources(this.OrdersContextMenu, "OrdersContextMenu");
            // 
            // addOrderMenuItem
            // 
            resources.ApplyResources(this.addOrderMenuItem, "addOrderMenuItem");
            this.addOrderMenuItem.Image = global::WinForms.Properties.Resources.AddTag_32px;
            this.addOrderMenuItem.Name = "addOrderMenuItem";
            // 
            // editOrderMenuItem
            // 
            resources.ApplyResources(this.editOrderMenuItem, "editOrderMenuItem");
            this.editOrderMenuItem.Image = global::WinForms.Properties.Resources.Edit_32px;
            this.editOrderMenuItem.Name = "editOrderMenuItem";
            // 
            // deleteOrderMenuItem
            // 
            resources.ApplyResources(this.deleteOrderMenuItem, "deleteOrderMenuItem");
            this.deleteOrderMenuItem.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.deleteOrderMenuItem.Name = "deleteOrderMenuItem";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            resources.ApplyResources(this.toolStripSeparator, "toolStripSeparator");
            // 
            // reloadOrdersMenuItem
            // 
            resources.ApplyResources(this.reloadOrdersMenuItem, "reloadOrdersMenuItem");
            this.reloadOrdersMenuItem.Image = global::WinForms.Properties.Resources.Refresh_32px;
            this.reloadOrdersMenuItem.Name = "reloadOrdersMenuItem";
            // 
            // loginMenuItemOrder
            // 
            resources.ApplyResources(this.loginMenuItemOrder, "loginMenuItemOrder");
            this.loginMenuItemOrder.Image = global::WinForms.Properties.Resources.Password_32px;
            this.loginMenuItemOrder.Name = "loginMenuItemOrder";
            // 
            // tabPageStock
            // 
            this.tabPageStock.BackColor = System.Drawing.Color.White;
            this.tabPageStock.Controls.Add(this.lblStockStatus);
            this.tabPageStock.Controls.Add(this.lstVwProducts);
            this.tabPageStock.Controls.Add(this.pictureBox1);
            this.tabPageStock.Controls.Add(this.txtBxSearchProduct);
            this.tabPageStock.Controls.Add(this.panel1);
            this.tabPageStock.Controls.Add(this.btDeleteProduct);
            this.tabPageStock.Controls.Add(this.btEditProduct);
            this.tabPageStock.Controls.Add(this.btAddProduct);
            resources.ApplyResources(this.tabPageStock, "tabPageStock");
            this.tabPageStock.Name = "tabPageStock";
            // 
            // lblStockStatus
            // 
            resources.ApplyResources(this.lblStockStatus, "lblStockStatus");
            this.lblStockStatus.Depth = 0;
            this.lblStockStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblStockStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblStockStatus.Name = "lblStockStatus";
            // 
            // lstVwProducts
            // 
            this.lstVwProducts.AllowColumnReorder = true;
            resources.ApplyResources(this.lstVwProducts, "lstVwProducts");
            this.lstVwProducts.AutoSizeTable = false;
            this.lstVwProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.headerTitle,
            this.columnHeader2,
            this.headerQuantity,
            this.headerPrice});
            this.lstVwProducts.ContextMenuStrip = this.StockContextMenuStrip;
            this.lstVwProducts.Depth = 0;
            this.lstVwProducts.FullRowSelect = true;
            this.lstVwProducts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwProducts.HideSelection = false;
            this.lstVwProducts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwProducts.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwProducts.MultiSelect = false;
            this.lstVwProducts.Name = "lstVwProducts";
            this.lstVwProducts.OwnerDraw = true;
            this.lstVwProducts.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwProducts.UseCompatibleStateImageBehavior = false;
            this.lstVwProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // headerTitle
            // 
            resources.ApplyResources(this.headerTitle, "headerTitle");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // headerQuantity
            // 
            resources.ApplyResources(this.headerQuantity, "headerQuantity");
            // 
            // headerPrice
            // 
            resources.ApplyResources(this.headerPrice, "headerPrice");
            // 
            // StockContextMenuStrip
            // 
            this.StockContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.StockContextMenuStrip.Depth = 0;
            this.StockContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductMenuItem,
            this.editProductMenuItem,
            this.deleteProductMenuItem,
            this.toolStripSeparator1,
            this.reloadStockMenuItem,
            this.loginMenuItemStock});
            this.StockContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.StockContextMenuStrip.Name = "StockContextMenuStrip";
            resources.ApplyResources(this.StockContextMenuStrip, "StockContextMenuStrip");
            // 
            // addProductMenuItem
            // 
            resources.ApplyResources(this.addProductMenuItem, "addProductMenuItem");
            this.addProductMenuItem.Image = global::WinForms.Properties.Resources.NewProduct_32px;
            this.addProductMenuItem.Name = "addProductMenuItem";
            // 
            // editProductMenuItem
            // 
            resources.ApplyResources(this.editProductMenuItem, "editProductMenuItem");
            this.editProductMenuItem.Image = global::WinForms.Properties.Resources.Edit_32px;
            this.editProductMenuItem.Name = "editProductMenuItem";
            // 
            // deleteProductMenuItem
            // 
            resources.ApplyResources(this.deleteProductMenuItem, "deleteProductMenuItem");
            this.deleteProductMenuItem.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.deleteProductMenuItem.Name = "deleteProductMenuItem";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // reloadStockMenuItem
            // 
            resources.ApplyResources(this.reloadStockMenuItem, "reloadStockMenuItem");
            this.reloadStockMenuItem.Image = global::WinForms.Properties.Resources.Refresh_32px;
            this.reloadStockMenuItem.Name = "reloadStockMenuItem";
            // 
            // loginMenuItemStock
            // 
            resources.ApplyResources(this.loginMenuItemStock, "loginMenuItemStock");
            this.loginMenuItemStock.Image = global::WinForms.Properties.Resources.Password_32px;
            this.loginMenuItemStock.Name = "loginMenuItemStock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Properties.Resources.Search_32px;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // txtBxSearchProduct
            // 
            resources.ApplyResources(this.txtBxSearchProduct, "txtBxSearchProduct");
            this.txtBxSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearchProduct.Depth = 0;
            this.txtBxSearchProduct.Hint = "Buscar...";
            this.txtBxSearchProduct.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearchProduct.Name = "txtBxSearchProduct";
            this.txtBxSearchProduct.TabStop = false;
            this.txtBxSearchProduct.UseTallSize = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picStockLoading);
            this.panel1.Controls.Add(this.btnNextStock);
            this.panel1.Controls.Add(this.btnPrevStock);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // picStockLoading
            // 
            resources.ApplyResources(this.picStockLoading, "picStockLoading");
            this.picStockLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picStockLoading.Name = "picStockLoading";
            this.picStockLoading.TabStop = false;
            // 
            // btnNextStock
            // 
            resources.ApplyResources(this.btnNextStock, "btnNextStock");
            this.btnNextStock.Depth = 0;
            this.btnNextStock.DrawShadows = true;
            this.btnNextStock.HighEmphasis = true;
            this.btnNextStock.Icon = global::WinForms.Properties.Resources.Forward_32px;
            this.btnNextStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextStock.Name = "btnNextStock";
            this.btnNextStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnNextStock.UseAccentColor = false;
            this.btnNextStock.UseVisualStyleBackColor = true;
            // 
            // btnPrevStock
            // 
            resources.ApplyResources(this.btnPrevStock, "btnPrevStock");
            this.btnPrevStock.Depth = 0;
            this.btnPrevStock.DrawShadows = true;
            this.btnPrevStock.HighEmphasis = true;
            this.btnPrevStock.Icon = global::WinForms.Properties.Resources.Back_32px;
            this.btnPrevStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnPrevStock.Name = "btnPrevStock";
            this.btnPrevStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnPrevStock.UseAccentColor = false;
            this.btnPrevStock.UseVisualStyleBackColor = true;
            // 
            // btDeleteProduct
            // 
            resources.ApplyResources(this.btDeleteProduct, "btDeleteProduct");
            this.btDeleteProduct.Depth = 0;
            this.btDeleteProduct.DrawShadows = true;
            this.btDeleteProduct.HighEmphasis = true;
            this.btDeleteProduct.Icon = global::WinForms.Properties.Resources.Trash_32px;
            this.btDeleteProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDeleteProduct.UseAccentColor = false;
            this.btDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btEditProduct
            // 
            resources.ApplyResources(this.btEditProduct, "btEditProduct");
            this.btEditProduct.Depth = 0;
            this.btEditProduct.DrawShadows = true;
            this.btEditProduct.HighEmphasis = true;
            this.btEditProduct.Icon = global::WinForms.Properties.Resources.Edit_32px;
            this.btEditProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btEditProduct.UseAccentColor = false;
            this.btEditProduct.UseVisualStyleBackColor = true;
            // 
            // btAddProduct
            // 
            resources.ApplyResources(this.btAddProduct, "btAddProduct");
            this.btAddProduct.Depth = 0;
            this.btAddProduct.DrawShadows = true;
            this.btAddProduct.HighEmphasis = true;
            this.btAddProduct.Icon = global::WinForms.Properties.Resources.NewProduct_32px;
            this.btAddProduct.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddProduct.UseAccentColor = false;
            this.btAddProduct.UseVisualStyleBackColor = true;
            // 
            // tabPageCustomers
            // 
            this.tabPageCustomers.BackColor = System.Drawing.Color.White;
            this.tabPageCustomers.Controls.Add(this.lblCustomersStatus);
            this.tabPageCustomers.Controls.Add(this.pictureBox3);
            this.tabPageCustomers.Controls.Add(this.txtBxSearchCustomers);
            this.tabPageCustomers.Controls.Add(this.panel3);
            this.tabPageCustomers.Controls.Add(this.btEditCustomer);
            this.tabPageCustomers.Controls.Add(this.btAddCustomer);
            this.tabPageCustomers.Controls.Add(this.btDeleteCustomer);
            this.tabPageCustomers.Controls.Add(this.lstVwCustomers);
            resources.ApplyResources(this.tabPageCustomers, "tabPageCustomers");
            this.tabPageCustomers.Name = "tabPageCustomers";
            // 
            // lblCustomersStatus
            // 
            resources.ApplyResources(this.lblCustomersStatus, "lblCustomersStatus");
            this.lblCustomersStatus.Depth = 0;
            this.lblCustomersStatus.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblCustomersStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCustomersStatus.Name = "lblCustomersStatus";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WinForms.Properties.Resources.Search_32px;
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // txtBxSearchCustomers
            // 
            resources.ApplyResources(this.txtBxSearchCustomers, "txtBxSearchCustomers");
            this.txtBxSearchCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearchCustomers.Depth = 0;
            this.txtBxSearchCustomers.Hint = "Buscar...";
            this.txtBxSearchCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearchCustomers.Name = "txtBxSearchCustomers";
            this.txtBxSearchCustomers.TabStop = false;
            this.txtBxSearchCustomers.UseTallSize = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picBxCustomersLoading);
            this.panel3.Controls.Add(this.btNextCustomers);
            this.panel3.Controls.Add(this.btPrevCustomers);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // picBxCustomersLoading
            // 
            resources.ApplyResources(this.picBxCustomersLoading, "picBxCustomersLoading");
            this.picBxCustomersLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picBxCustomersLoading.Name = "picBxCustomersLoading";
            this.picBxCustomersLoading.TabStop = false;
            // 
            // btNextCustomers
            // 
            resources.ApplyResources(this.btNextCustomers, "btNextCustomers");
            this.btNextCustomers.Depth = 0;
            this.btNextCustomers.DrawShadows = true;
            this.btNextCustomers.HighEmphasis = true;
            this.btNextCustomers.Icon = global::WinForms.Properties.Resources.Forward_32px;
            this.btNextCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btNextCustomers.Name = "btNextCustomers";
            this.btNextCustomers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btNextCustomers.UseAccentColor = false;
            this.btNextCustomers.UseVisualStyleBackColor = true;
            // 
            // btPrevCustomers
            // 
            resources.ApplyResources(this.btPrevCustomers, "btPrevCustomers");
            this.btPrevCustomers.Depth = 0;
            this.btPrevCustomers.DrawShadows = true;
            this.btPrevCustomers.HighEmphasis = true;
            this.btPrevCustomers.Icon = global::WinForms.Properties.Resources.Back_32px;
            this.btPrevCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btPrevCustomers.Name = "btPrevCustomers";
            this.btPrevCustomers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btPrevCustomers.UseAccentColor = false;
            this.btPrevCustomers.UseVisualStyleBackColor = true;
            // 
            // btEditCustomer
            // 
            resources.ApplyResources(this.btEditCustomer, "btEditCustomer");
            this.btEditCustomer.Depth = 0;
            this.btEditCustomer.DrawShadows = true;
            this.btEditCustomer.HighEmphasis = true;
            this.btEditCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("btEditCustomer.Icon")));
            this.btEditCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btEditCustomer.UseAccentColor = false;
            this.btEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btAddCustomer
            // 
            resources.ApplyResources(this.btAddCustomer, "btAddCustomer");
            this.btAddCustomer.Depth = 0;
            this.btAddCustomer.DrawShadows = true;
            this.btAddCustomer.HighEmphasis = true;
            this.btAddCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("btAddCustomer.Icon")));
            this.btAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btAddCustomer.UseAccentColor = false;
            this.btAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btDeleteCustomer
            // 
            resources.ApplyResources(this.btDeleteCustomer, "btDeleteCustomer");
            this.btDeleteCustomer.Depth = 0;
            this.btDeleteCustomer.DrawShadows = true;
            this.btDeleteCustomer.HighEmphasis = true;
            this.btDeleteCustomer.Icon = global::WinForms.Properties.Resources.Denied_32px;
            this.btDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btDeleteCustomer.UseAccentColor = false;
            this.btDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // lstVwCustomers
            // 
            this.lstVwCustomers.AllowColumnReorder = true;
            resources.ApplyResources(this.lstVwCustomers, "lstVwCustomers");
            this.lstVwCustomers.AutoSizeTable = false;
            this.lstVwCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.headerFullname,
            this.headerEmail,
            this.headerPhone});
            this.lstVwCustomers.ContextMenuStrip = this.CustomerContextMenuStrip;
            this.lstVwCustomers.Depth = 0;
            this.lstVwCustomers.FullRowSelect = true;
            this.lstVwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwCustomers.HideSelection = false;
            this.lstVwCustomers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwCustomers.MultiSelect = false;
            this.lstVwCustomers.Name = "lstVwCustomers";
            this.lstVwCustomers.OwnerDraw = true;
            this.lstVwCustomers.ShowGroups = false;
            this.lstVwCustomers.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwCustomers.UseCompatibleStateImageBehavior = false;
            this.lstVwCustomers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // headerFullname
            // 
            resources.ApplyResources(this.headerFullname, "headerFullname");
            // 
            // headerEmail
            // 
            resources.ApplyResources(this.headerEmail, "headerEmail");
            // 
            // headerPhone
            // 
            resources.ApplyResources(this.headerPhone, "headerPhone");
            // 
            // CustomerContextMenuStrip
            // 
            this.CustomerContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.CustomerContextMenuStrip.Depth = 0;
            this.CustomerContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerMenuItem,
            this.editCustomerMenuItem,
            this.deleteCustomerMenuItem,
            this.toolStripSeparator2,
            this.reloadCustomersMenuItem,
            this.loginMenuItemCustomer});
            this.CustomerContextMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.CustomerContextMenuStrip.Name = "CustomerContextMenuStrip";
            resources.ApplyResources(this.CustomerContextMenuStrip, "CustomerContextMenuStrip");
            // 
            // addCustomerMenuItem
            // 
            resources.ApplyResources(this.addCustomerMenuItem, "addCustomerMenuItem");
            this.addCustomerMenuItem.Image = global::WinForms.Properties.Resources.AddUserMale_32px;
            this.addCustomerMenuItem.Name = "addCustomerMenuItem";
            // 
            // editCustomerMenuItem
            // 
            resources.ApplyResources(this.editCustomerMenuItem, "editCustomerMenuItem");
            this.editCustomerMenuItem.Image = global::WinForms.Properties.Resources.Edit_32px;
            this.editCustomerMenuItem.Name = "editCustomerMenuItem";
            // 
            // deleteCustomerMenuItem
            // 
            resources.ApplyResources(this.deleteCustomerMenuItem, "deleteCustomerMenuItem");
            this.deleteCustomerMenuItem.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.deleteCustomerMenuItem.Name = "deleteCustomerMenuItem";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // reloadCustomersMenuItem
            // 
            resources.ApplyResources(this.reloadCustomersMenuItem, "reloadCustomersMenuItem");
            this.reloadCustomersMenuItem.Image = global::WinForms.Properties.Resources.Refresh_32px;
            this.reloadCustomersMenuItem.Name = "reloadCustomersMenuItem";
            // 
            // loginMenuItemCustomer
            // 
            resources.ApplyResources(this.loginMenuItemCustomer, "loginMenuItemCustomer");
            this.loginMenuItemCustomer.Image = global::WinForms.Properties.Resources.Password_32px;
            this.loginMenuItemCustomer.Name = "loginMenuItemCustomer";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Controls.Add(this.panel4);
            this.tabPageSettings.Controls.Add(this.tabSettings);
            this.tabPageSettings.Controls.Add(this.tabSelectorSettings);
            resources.ApplyResources(this.tabPageSettings, "tabPageSettings");
            this.tabPageSettings.Name = "tabPageSettings";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblNotification);
            this.panel4.Controls.Add(this.lbl_msg);
            this.panel4.Controls.Add(this.btSave);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // lblNotification
            // 
            resources.ApplyResources(this.lblNotification, "lblNotification");
            this.lblNotification.Depth = 0;
            this.lblNotification.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotification.Name = "lblNotification";
            // 
            // lbl_msg
            // 
            resources.ApplyResources(this.lbl_msg, "lbl_msg");
            this.lbl_msg.Depth = 0;
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_msg.Name = "lbl_msg";
            // 
            // btSave
            // 
            resources.ApplyResources(this.btSave, "btSave");
            this.btSave.Depth = 0;
            this.btSave.DrawShadows = true;
            this.btSave.HighEmphasis = true;
            this.btSave.Icon = global::WinForms.Properties.Resources.Save_32px;
            this.btSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSave.Name = "btSave";
            this.btSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btSave.UseAccentColor = false;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabApi);
            this.tabSettings.Controls.Add(this.tabMail);
            this.tabSettings.Depth = 0;
            resources.ApplyResources(this.tabSettings, "tabSettings");
            this.tabSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            // 
            // tabGeneral
            // 
            resources.ApplyResources(this.tabGeneral, "tabGeneral");
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controls.Add(this.panel6);
            this.tabGeneral.Controls.Add(this.folderInput);
            this.tabGeneral.Controls.Add(this.fileInput);
            this.tabGeneral.Controls.Add(this.txtBx_printer);
            this.tabGeneral.Controls.Add(this.materialLabel2);
            this.tabGeneral.Controls.Add(this.btExport);
            this.tabGeneral.Controls.Add(this.btImport);
            this.tabGeneral.Controls.Add(this.pictureBox_folder);
            this.tabGeneral.Controls.Add(this.pictureBox4);
            this.tabGeneral.Controls.Add(this.pictureBox_file);
            this.tabGeneral.Controls.Add(this.label_saveFile_desc);
            this.tabGeneral.Controls.Add(this.label12);
            this.tabGeneral.Controls.Add(this.label_file_desc);
            this.tabGeneral.Controls.Add(this.chckBx_saveFile);
            this.tabGeneral.Controls.Add(this.materialLabel_printer);
            this.tabGeneral.Controls.Add(this.materialLabel_template);
            this.tabGeneral.Name = "tabGeneral";
            // 
            // panel6
            // 
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.Name = "panel6";
            // 
            // folderInput
            // 
            this.folderInput.FocusedColor = "#508ef5";
            this.folderInput.FontColor = "#999999";
            this.folderInput.IsEnabled = true;
            resources.ApplyResources(this.folderInput, "folderInput");
            this.folderInput.MaxLength = 32767;
            this.folderInput.Name = "folderInput";
            this.folderInput.ReadOnly = false;
            this.folderInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.folderInput.UseSystemPasswordChar = false;
            // 
            // fileInput
            // 
            this.fileInput.Filter = "HTML Files (*.html)|*.*";
            this.fileInput.FocusedColor = "#508ef5";
            this.fileInput.FontColor = "#999999";
            this.fileInput.IsEnabled = true;
            resources.ApplyResources(this.fileInput, "fileInput");
            this.fileInput.MaxLength = 32767;
            this.fileInput.Name = "fileInput";
            this.fileInput.ReadOnly = false;
            this.fileInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.fileInput.UseSystemPasswordChar = false;
            // 
            // txtBx_printer
            // 
            this.txtBx_printer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_printer.Depth = 0;
            resources.ApplyResources(this.txtBx_printer, "txtBx_printer");
            this.txtBx_printer.Hint = "Nombre de la impresora";
            this.txtBx_printer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_printer.Name = "txtBx_printer";
            this.txtBx_printer.TabStop = false;
            this.txtBx_printer.UseTallSize = false;
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // btExport
            // 
            resources.ApplyResources(this.btExport, "btExport");
            this.btExport.Depth = 0;
            this.btExport.DrawShadows = true;
            this.btExport.HighEmphasis = true;
            this.btExport.Icon = global::WinForms.Properties.Resources.Export_32px;
            this.btExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btExport.Name = "btExport";
            this.btExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btExport.UseAccentColor = false;
            this.btExport.UseVisualStyleBackColor = false;
            // 
            // btImport
            // 
            resources.ApplyResources(this.btImport, "btImport");
            this.btImport.Depth = 0;
            this.btImport.DrawShadows = true;
            this.btImport.HighEmphasis = true;
            this.btImport.Icon = global::WinForms.Properties.Resources.Import_32px;
            this.btImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btImport.Name = "btImport";
            this.btImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btImport.UseAccentColor = false;
            this.btImport.UseVisualStyleBackColor = false;
            // 
            // pictureBox_folder
            // 
            this.pictureBox_folder.Image = global::WinForms.Properties.Resources.Open_32px;
            resources.ApplyResources(this.pictureBox_folder, "pictureBox_folder");
            this.pictureBox_folder.Name = "pictureBox_folder";
            this.pictureBox_folder.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinForms.Properties.Resources.print_32px;
            resources.ApplyResources(this.pictureBox4, "pictureBox4");
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox_file
            // 
            this.pictureBox_file.Image = global::WinForms.Properties.Resources.Document_32px;
            resources.ApplyResources(this.pictureBox_file, "pictureBox_file");
            this.pictureBox_file.Name = "pictureBox_file";
            this.pictureBox_file.TabStop = false;
            // 
            // label_saveFile_desc
            // 
            resources.ApplyResources(this.label_saveFile_desc, "label_saveFile_desc");
            this.label_saveFile_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_saveFile_desc.Name = "label_saveFile_desc";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Name = "label12";
            // 
            // label_file_desc
            // 
            resources.ApplyResources(this.label_file_desc, "label_file_desc");
            this.label_file_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_file_desc.Name = "label_file_desc";
            // 
            // chckBx_saveFile
            // 
            resources.ApplyResources(this.chckBx_saveFile, "chckBx_saveFile");
            this.chckBx_saveFile.Depth = 0;
            this.chckBx_saveFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBx_saveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBx_saveFile.Name = "chckBx_saveFile";
            this.chckBx_saveFile.Ripple = true;
            this.chckBx_saveFile.UseVisualStyleBackColor = true;
            // 
            // materialLabel_printer
            // 
            resources.ApplyResources(this.materialLabel_printer, "materialLabel_printer");
            this.materialLabel_printer.Depth = 0;
            this.materialLabel_printer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_printer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_printer.Name = "materialLabel_printer";
            // 
            // materialLabel_template
            // 
            resources.ApplyResources(this.materialLabel_template, "materialLabel_template");
            this.materialLabel_template.Depth = 0;
            this.materialLabel_template.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_template.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_template.Name = "materialLabel_template";
            // 
            // tabApi
            // 
            resources.ApplyResources(this.tabApi, "tabApi");
            this.tabApi.BackColor = System.Drawing.Color.White;
            this.tabApi.Controls.Add(this.btnLogin);
            this.tabApi.Controls.Add(this.chkBx_cache);
            this.tabApi.Controls.Add(this.btSubtract);
            this.tabApi.Controls.Add(this.btAdd);
            this.tabApi.Controls.Add(this.prgrssBr_minutes);
            this.tabApi.Controls.Add(this.picProxy);
            this.tabApi.Controls.Add(this.label9);
            this.tabApi.Controls.Add(this.label8);
            this.tabApi.Controls.Add(this.materialLabel5);
            this.tabApi.Controls.Add(this.materialLabel8);
            this.tabApi.Controls.Add(this.materialLabel7);
            this.tabApi.Controls.Add(this.materialLabel6);
            this.tabApi.Controls.Add(this.txtBx_nItems);
            this.tabApi.Controls.Add(this.label1);
            this.tabApi.Controls.Add(this.txtBx_APIkey);
            this.tabApi.Controls.Add(this.txtBxUrl);
            this.tabApi.Controls.Add(this.txtBx_APIusr);
            this.tabApi.Controls.Add(this.pictureBox5);
            this.tabApi.Name = "tabApi";
            // 
            // btnLogin
            // 
            resources.ApplyResources(this.btnLogin, "btnLogin");
            this.btnLogin.Depth = 0;
            this.btnLogin.DrawShadows = true;
            this.btnLogin.HighEmphasis = false;
            this.btnLogin.Icon = null;
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // chkBx_cache
            // 
            resources.ApplyResources(this.chkBx_cache, "chkBx_cache");
            this.chkBx_cache.Depth = 0;
            this.chkBx_cache.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBx_cache.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBx_cache.Name = "chkBx_cache";
            this.chkBx_cache.Ripple = true;
            this.chkBx_cache.UseVisualStyleBackColor = true;
            // 
            // btSubtract
            // 
            resources.ApplyResources(this.btSubtract, "btSubtract");
            this.btSubtract.Depth = 0;
            this.btSubtract.DrawShadows = true;
            this.btSubtract.HighEmphasis = true;
            this.btSubtract.Icon = null;
            this.btSubtract.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSubtract.UseAccentColor = true;
            this.btSubtract.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            resources.ApplyResources(this.btAdd, "btAdd");
            this.btAdd.Depth = 0;
            this.btAdd.DrawShadows = true;
            this.btAdd.HighEmphasis = true;
            this.btAdd.Icon = null;
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdd.UseAccentColor = true;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // prgrssBr_minutes
            // 
            this.prgrssBr_minutes.Depth = 0;
            resources.ApplyResources(this.prgrssBr_minutes, "prgrssBr_minutes");
            this.prgrssBr_minutes.Maximum = 50;
            this.prgrssBr_minutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.prgrssBr_minutes.Name = "prgrssBr_minutes";
            this.prgrssBr_minutes.Step = 5;
            // 
            // picProxy
            // 
            this.picProxy.Image = global::WinForms.Properties.Resources.DownloadFromCloud_32px;
            resources.ApplyResources(this.picProxy, "picProxy");
            this.picProxy.Name = "picProxy";
            this.picProxy.TabStop = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Name = "label8";
            // 
            // materialLabel5
            // 
            resources.ApplyResources(this.materialLabel5, "materialLabel5");
            this.materialLabel5.Depth = 0;
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            // 
            // materialLabel8
            // 
            resources.ApplyResources(this.materialLabel8, "materialLabel8");
            this.materialLabel8.Depth = 0;
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            // 
            // materialLabel7
            // 
            resources.ApplyResources(this.materialLabel7, "materialLabel7");
            this.materialLabel7.Depth = 0;
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            // 
            // materialLabel6
            // 
            resources.ApplyResources(this.materialLabel6, "materialLabel6");
            this.materialLabel6.Depth = 0;
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            // 
            // txtBx_nItems
            // 
            this.txtBx_nItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_nItems.Depth = 0;
            resources.ApplyResources(this.txtBx_nItems, "txtBx_nItems");
            this.txtBx_nItems.Hint = "20";
            this.txtBx_nItems.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_nItems.Name = "txtBx_nItems";
            this.txtBx_nItems.TabStop = false;
            this.txtBx_nItems.UseTallSize = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Name = "label1";
            // 
            // txtBx_APIkey
            // 
            this.txtBx_APIkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_APIkey.Depth = 0;
            resources.ApplyResources(this.txtBx_APIkey, "txtBx_APIkey");
            this.txtBx_APIkey.Hint = "Contraseña";
            this.txtBx_APIkey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_APIkey.Name = "txtBx_APIkey";
            this.txtBx_APIkey.Password = true;
            this.txtBx_APIkey.TabStop = false;
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxUrl.Depth = 0;
            resources.ApplyResources(this.txtBxUrl, "txtBxUrl");
            this.txtBxUrl.Hint = "https://mystore.com/";
            this.txtBxUrl.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.TabStop = false;
            // 
            // txtBx_APIusr
            // 
            this.txtBx_APIusr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_APIusr.Depth = 0;
            resources.ApplyResources(this.txtBx_APIusr, "txtBx_APIusr");
            this.txtBx_APIusr.Hint = "Usuario";
            this.txtBx_APIusr.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_APIusr.Name = "txtBx_APIusr";
            this.txtBx_APIusr.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinForms.Properties.Resources.BulletedList_32px;
            resources.ApplyResources(this.pictureBox5, "pictureBox5");
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.TabStop = false;
            // 
            // tabMail
            // 
            resources.ApplyResources(this.tabMail, "tabMail");
            this.tabMail.BackColor = System.Drawing.Color.White;
            this.tabMail.Controls.Add(this.panel5);
            this.tabMail.Controls.Add(this.materialLabel4);
            this.tabMail.Controls.Add(this.materialLabel3);
            this.tabMail.Controls.Add(this.label2);
            this.tabMail.Controls.Add(this.txtBx_mailPort);
            this.tabMail.Controls.Add(this.txtBx_mailSubject);
            this.tabMail.Controls.Add(this.txtBx_mailHost);
            this.tabMail.Controls.Add(this.txtBx_mailPwd);
            this.tabMail.Controls.Add(this.txtBx_mailEmail);
            this.tabMail.Controls.Add(this.label6);
            this.tabMail.Name = "tabMail";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MailContent);
            this.panel5.Controls.Add(this.label7);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // MailContent
            // 
            resources.ApplyResources(this.MailContent, "MailContent");
            this.MailContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailContent.Changed = false;
            this.MailContent.HTML = null;
            this.MailContent.Name = "MailContent";
            this.MailContent.ShowAlignCenterButton = false;
            this.MailContent.ShowAlignLeftButton = false;
            this.MailContent.ShowAlignRightButton = false;
            this.MailContent.ShowBackColorButton = false;
            this.MailContent.ShowBolButton = false;
            this.MailContent.ShowBulletButton = false;
            this.MailContent.ShowCopyButton = false;
            this.MailContent.ShowCutButton = false;
            this.MailContent.ShowFontFamilyButton = false;
            this.MailContent.ShowFontSizeButton = false;
            this.MailContent.ShowIndentButton = false;
            this.MailContent.ShowItalicButton = false;
            this.MailContent.ShowJustifyButton = false;
            this.MailContent.ShowLinkButton = false;
            this.MailContent.ShowNewButton = false;
            this.MailContent.ShowOrderedListButton = false;
            this.MailContent.ShowOutdentButton = false;
            this.MailContent.ShowPasteButton = false;
            this.MailContent.ShowPrintButton = false;
            this.MailContent.ShowTxtBGButton = false;
            this.MailContent.ShowTxtColorButton = false;
            this.MailContent.ShowUnderlineButton = false;
            this.MailContent.ShowUnlinkButton = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Name = "label7";
            // 
            // materialLabel4
            // 
            resources.ApplyResources(this.materialLabel4, "materialLabel4");
            this.materialLabel4.Depth = 0;
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // txtBx_mailPort
            // 
            this.txtBx_mailPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailPort.Depth = 0;
            resources.ApplyResources(this.txtBx_mailPort, "txtBx_mailPort");
            this.txtBx_mailPort.Hint = "Puerto";
            this.txtBx_mailPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailPort.Name = "txtBx_mailPort";
            this.txtBx_mailPort.TabStop = false;
            // 
            // txtBx_mailSubject
            // 
            this.txtBx_mailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailSubject.Depth = 0;
            resources.ApplyResources(this.txtBx_mailSubject, "txtBx_mailSubject");
            this.txtBx_mailSubject.Hint = "Asunto";
            this.txtBx_mailSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailSubject.Name = "txtBx_mailSubject";
            this.txtBx_mailSubject.TabStop = false;
            // 
            // txtBx_mailHost
            // 
            this.txtBx_mailHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailHost.Depth = 0;
            resources.ApplyResources(this.txtBx_mailHost, "txtBx_mailHost");
            this.txtBx_mailHost.Hint = "Host/Dominio";
            this.txtBx_mailHost.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailHost.Name = "txtBx_mailHost";
            this.txtBx_mailHost.TabStop = false;
            // 
            // txtBx_mailPwd
            // 
            this.txtBx_mailPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailPwd.Depth = 0;
            resources.ApplyResources(this.txtBx_mailPwd, "txtBx_mailPwd");
            this.txtBx_mailPwd.Hint = "Contraseña";
            this.txtBx_mailPwd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailPwd.Name = "txtBx_mailPwd";
            this.txtBx_mailPwd.TabStop = false;
            // 
            // txtBx_mailEmail
            // 
            this.txtBx_mailEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailEmail.Depth = 0;
            resources.ApplyResources(this.txtBx_mailEmail, "txtBx_mailEmail");
            this.txtBx_mailEmail.Hint = "Correo electrónico";
            this.txtBx_mailEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailEmail.Name = "txtBx_mailEmail";
            this.txtBx_mailEmail.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Name = "label6";
            // 
            // tabSelectorSettings
            // 
            this.tabSelectorSettings.BaseTabControl = this.tabSettings;
            this.tabSelectorSettings.Depth = 0;
            resources.ApplyResources(this.tabSelectorSettings, "tabSelectorSettings");
            this.tabSelectorSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorSettings.Name = "tabSelectorSettings";
            // 
            // menuIconList
            // 
            this.menuIconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("menuIconList.ImageStream")));
            this.menuIconList.TransparentColor = System.Drawing.Color.Transparent;
            this.menuIconList.Images.SetKeyName(0, "Pricing_32px.png");
            this.menuIconList.Images.SetKeyName(1, "MultipleDevices_32px.png");
            this.menuIconList.Images.SetKeyName(2, "UserGroups_32px.png");
            this.menuIconList.Images.SetKeyName(3, "Services_32px.png");
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // ShellView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.materialTabMenu);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabMenu;
            this.DrawerUseColors = true;
            this.Name = "ShellView";
            this.materialTabMenu.ResumeLayout(false);
            this.tabPageOrders.ResumeLayout(false);
            this.tabPageOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOrdersLoading)).EndInit();
            this.OrdersContextMenu.ResumeLayout(false);
            this.tabPageStock.ResumeLayout(false);
            this.tabPageStock.PerformLayout();
            this.StockContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStockLoading)).EndInit();
            this.tabPageCustomers.ResumeLayout(false);
            this.tabPageCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxCustomersLoading)).EndInit();
            this.CustomerContextMenuStrip.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabSettings.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_folder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_file)).EndInit();
            this.tabApi.ResumeLayout(false);
            this.tabApi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProxy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.tabMail.ResumeLayout(false);
            this.tabMail.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabMenu;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.TabPage tabPageStock;
        private System.Windows.Forms.ImageList menuIconList;
        private System.Windows.Forms.TabPage tabPageCustomers;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label lblStatus;
        private MaterialSkin.Controls.MaterialButton btEditOrder;
        private MaterialSkin.Controls.MaterialButton btAddOrder;
        private MaterialSkin.Controls.MaterialButton btViewOrder;
        private MaterialSkin.Controls.MaterialButton btDeleteOrder;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearchOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picOrdersLoading;
        private MaterialSkin.Controls.MaterialButton btNextOrders;
        private MaterialSkin.Controls.MaterialButton btPrevOrders;
        private MaterialSkin.Controls.MaterialListView lstVwOrders;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerCustomer;
        private System.Windows.Forms.ColumnHeader headerStatus;
        private System.Windows.Forms.ColumnHeader headerTotal;
        private System.Windows.Forms.ColumnHeader headerAdded;
        private System.Windows.Forms.ColumnHeader headerModified;
        private MaterialSkin.Controls.MaterialLabel lblOrdersStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picStockLoading;
        private MaterialSkin.Controls.MaterialButton btnNextStock;
        private MaterialSkin.Controls.MaterialButton btnPrevStock;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearchCustomers;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picBxCustomersLoading;
        private MaterialSkin.Controls.MaterialButton btNextCustomers;
        private MaterialSkin.Controls.MaterialButton btPrevCustomers;
        private MaterialSkin.Controls.MaterialButton btEditCustomer;
        private MaterialSkin.Controls.MaterialButton btAddCustomer;
        private MaterialSkin.Controls.MaterialButton btDeleteCustomer;
        private MaterialSkin.Controls.MaterialListView lstVwCustomers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader headerFullname;
        private System.Windows.Forms.ColumnHeader headerEmail;
        private System.Windows.Forms.ColumnHeader headerPhone;
        private MaterialSkin.Controls.MaterialLabel lblCustomersStatus;
        private MaterialSkin.Controls.MaterialLabel lblStockStatus;
        private MaterialSkin.Controls.MaterialListView lstVwProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader headerTitle;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader headerQuantity;
        private System.Windows.Forms.ColumnHeader headerPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearchProduct;
        private MaterialSkin.Controls.MaterialButton btDeleteProduct;
        private MaterialSkin.Controls.MaterialButton btEditProduct;
        private MaterialSkin.Controls.MaterialButton btAddProduct;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorSettings;
        private MaterialSkin.Controls.MaterialTabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private LollipopFolderInPut folderInput;
        private LollipopFileInput fileInput;
        private MaterialSkin.Controls.MaterialTextBox txtBx_printer;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btExport;
        private MaterialSkin.Controls.MaterialButton btImport;
        private System.Windows.Forms.PictureBox pictureBox_folder;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_file;
        private System.Windows.Forms.Label label_saveFile_desc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_file_desc;
        private MaterialSkin.Controls.MaterialCheckbox chckBx_saveFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel_printer;
        private MaterialSkin.Controls.MaterialLabel materialLabel_template;
        private System.Windows.Forms.TabPage tabApi;
        private MaterialSkin.Controls.MaterialTextBox txtBx_nItems;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox txtBx_APIkey;
        private MaterialSkin.Controls.MaterialTextBox txtBxUrl;
        private MaterialSkin.Controls.MaterialTextBox txtBx_APIusr;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TabPage tabMail;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailPort;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailSubject;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailHost;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailPwd;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel lbl_msg;
        private MaterialSkin.Controls.MaterialButton btSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.Panel panel5;
        private Controls.HTMLWYSIWYG MailContent;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel lblNotification;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private MaterialSkin.Controls.MaterialCheckbox chkBx_cache;
        private MaterialSkin.Controls.MaterialButton btSubtract;
        private MaterialSkin.Controls.MaterialButton btAdd;
        private MaterialSkin.Controls.MaterialProgressBar prgrssBr_minutes;
        private System.Windows.Forms.PictureBox picProxy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialContextMenuStrip OrdersContextMenu;
        private MaterialSkin.Controls.MaterialToolStripMenuItem addOrderMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem editOrderMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem deleteOrderMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private MaterialSkin.Controls.MaterialToolStripMenuItem reloadOrdersMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip StockContextMenuStrip;
        private MaterialSkin.Controls.MaterialToolStripMenuItem addProductMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem editProductMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem deleteProductMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MaterialSkin.Controls.MaterialToolStripMenuItem reloadStockMenuItem;
        private MaterialSkin.Controls.MaterialContextMenuStrip CustomerContextMenuStrip;
        private MaterialSkin.Controls.MaterialToolStripMenuItem addCustomerMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem editCustomerMenuItem;
        private MaterialSkin.Controls.MaterialToolStripMenuItem deleteCustomerMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private MaterialSkin.Controls.MaterialToolStripMenuItem reloadCustomersMenuItem;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialToolStripMenuItem loginMenuItemOrder;
        private MaterialSkin.Controls.MaterialToolStripMenuItem loginMenuItemStock;
        private MaterialSkin.Controls.MaterialToolStripMenuItem loginMenuItemCustomer;
    }
}

