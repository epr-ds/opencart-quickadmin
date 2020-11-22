namespace WinForms.Views
{
    partial class ProductView
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
            this.materialTabSelector_tabs = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl_container = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.tabControl_langs = new System.Windows.Forms.TabControl();
            this.tabPage_Data = new System.Windows.Forms.TabPage();
            this.cmbBx_lengthClass = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBxWidth = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbBx_stockStatus = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBxLength = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbBx_taxclass = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbBx_weightClass = new MaterialSkin.Controls.MaterialComboBox();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.chkBx_status = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkBxShippingRequired = new MaterialSkin.Controls.MaterialCheckbox();
            this.chkBx_subtractStock = new MaterialSkin.Controls.MaterialCheckbox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_mpn = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_price = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxMinQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_weight = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_location = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_isbn = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_jan = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_ean = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_upc = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_sku = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_model = new MaterialSkin.Controls.MaterialTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage_Links = new System.Windows.Forms.TabPage();
            this.cmbBx_manufacturer = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel_relatedProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.flwLytPnl_stores = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_categories = new System.Windows.Forms.FlowLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage_discount = new System.Windows.Forms.TabPage();
            this.cmbBx_DisGroupCustomer = new MaterialSkin.Controls.MaterialComboBox();
            this.lstVwDiscounts = new MaterialSkin.Controls.MaterialListView();
            this.headerDiscGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDiscQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.haederDiscPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDiscPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDiscStartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerDiscFinishDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.removeToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.btAddDiscount = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker_discountDateStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_discountDateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtBx_discountPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_discountPriority = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_discountQuantity = new MaterialSkin.Controls.MaterialTextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage_special = new System.Windows.Forms.TabPage();
            this.cmbBx_SpecGroupCustomer = new MaterialSkin.Controls.MaterialComboBox();
            this.lstVwOffers = new MaterialSkin.Controls.MaterialListView();
            this.headerOfferGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerOfferPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerOfferPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerOfferDateStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerOfferDateEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btAddOffer = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker_SpecDateStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_SpecDateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtBxSpecialPrice = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxSpecialPriority = new MaterialSkin.Controls.MaterialTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tabPage_images = new System.Windows.Forms.TabPage();
            this.btn_addImages = new MaterialSkin.Controls.MaterialButton();
            this.btn_delImg = new MaterialSkin.Controls.MaterialButton();
            this.lbl_ImgMsg = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.picBxImage = new System.Windows.Forms.PictureBox();
            this.imagePanel = new WinForms.Controls.ImageFlowPanel();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.lbl_msg = new MaterialSkin.Controls.MaterialLabel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btSave = new MaterialSkin.Controls.MaterialButton();
            this.btBackTo = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileImage = new System.Windows.Forms.OpenFileDialog();
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTabControl_container.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            this.tabPage_Data.SuspendLayout();
            this.tabPage_Links.SuspendLayout();
            this.tabPage_discount.SuspendLayout();
            this.contextMenu.SuspendLayout();
            this.tabPage_special.SuspendLayout();
            this.tabPage_images.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxImage)).BeginInit();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector_tabs
            // 
            this.materialTabSelector_tabs.BaseTabControl = this.materialTabControl_container;
            this.materialTabSelector_tabs.Depth = 0;
            this.materialTabSelector_tabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector_tabs.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector_tabs.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector_tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector_tabs.Name = "materialTabSelector_tabs";
            this.materialTabSelector_tabs.Size = new System.Drawing.Size(1050, 56);
            this.materialTabSelector_tabs.TabIndex = 0;
            this.materialTabSelector_tabs.Text = "materialTabSelector1";
            // 
            // materialTabControl_container
            // 
            this.materialTabControl_container.Controls.Add(this.tabPage_General);
            this.materialTabControl_container.Controls.Add(this.tabPage_Data);
            this.materialTabControl_container.Controls.Add(this.tabPage_Links);
            this.materialTabControl_container.Controls.Add(this.tabPage_discount);
            this.materialTabControl_container.Controls.Add(this.tabPage_special);
            this.materialTabControl_container.Controls.Add(this.tabPage_images);
            this.materialTabControl_container.Depth = 0;
            this.materialTabControl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl_container.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl_container.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl_container.Multiline = true;
            this.materialTabControl_container.Name = "materialTabControl_container";
            this.materialTabControl_container.SelectedIndex = 0;
            this.materialTabControl_container.Size = new System.Drawing.Size(1050, 483);
            this.materialTabControl_container.TabIndex = 0;
            // 
            // tabPage_General
            // 
            this.tabPage_General.BackColor = System.Drawing.Color.White;
            this.tabPage_General.Controls.Add(this.tabControl_langs);
            this.tabPage_General.Location = new System.Drawing.Point(4, 22);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            // 
            // tabControl_langs
            // 
            this.tabControl_langs.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl_langs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_langs.Location = new System.Drawing.Point(3, 3);
            this.tabControl_langs.Name = "tabControl_langs";
            this.tabControl_langs.SelectedIndex = 0;
            this.tabControl_langs.Size = new System.Drawing.Size(1036, 451);
            this.tabControl_langs.TabIndex = 0;
            // 
            // tabPage_Data
            // 
            this.tabPage_Data.AutoScroll = true;
            this.tabPage_Data.BackColor = System.Drawing.Color.White;
            this.tabPage_Data.Controls.Add(this.cmbBx_lengthClass);
            this.tabPage_Data.Controls.Add(this.txtBxWidth);
            this.tabPage_Data.Controls.Add(this.cmbBx_stockStatus);
            this.tabPage_Data.Controls.Add(this.txtBxLength);
            this.tabPage_Data.Controls.Add(this.cmbBx_taxclass);
            this.tabPage_Data.Controls.Add(this.cmbBx_weightClass);
            this.tabPage_Data.Controls.Add(this.dateRelease);
            this.tabPage_Data.Controls.Add(this.chkBx_status);
            this.tabPage_Data.Controls.Add(this.chkBxShippingRequired);
            this.tabPage_Data.Controls.Add(this.chkBx_subtractStock);
            this.tabPage_Data.Controls.Add(this.label17);
            this.tabPage_Data.Controls.Add(this.label6);
            this.tabPage_Data.Controls.Add(this.txtBx_mpn);
            this.tabPage_Data.Controls.Add(this.txtBx_price);
            this.tabPage_Data.Controls.Add(this.txtBxMinQuantity);
            this.tabPage_Data.Controls.Add(this.txtBxQuantity);
            this.tabPage_Data.Controls.Add(this.txtBx_weight);
            this.tabPage_Data.Controls.Add(this.txtBx_location);
            this.tabPage_Data.Controls.Add(this.txtBx_isbn);
            this.tabPage_Data.Controls.Add(this.txtBx_jan);
            this.tabPage_Data.Controls.Add(this.txtBx_ean);
            this.tabPage_Data.Controls.Add(this.txtBx_upc);
            this.tabPage_Data.Controls.Add(this.txtBx_sku);
            this.tabPage_Data.Controls.Add(this.txtBx_model);
            this.tabPage_Data.Controls.Add(this.panel3);
            this.tabPage_Data.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Data.Name = "tabPage_Data";
            this.tabPage_Data.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Data.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_Data.TabIndex = 1;
            this.tabPage_Data.Text = "Datos";
            // 
            // cmbBx_lengthClass
            // 
            this.cmbBx_lengthClass.AutoResize = false;
            this.cmbBx_lengthClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_lengthClass.Depth = 0;
            this.cmbBx_lengthClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_lengthClass.DropDownHeight = 174;
            this.cmbBx_lengthClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_lengthClass.DropDownWidth = 121;
            this.cmbBx_lengthClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_lengthClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_lengthClass.FormattingEnabled = true;
            this.cmbBx_lengthClass.Hint = "Unidad de longitud";
            this.cmbBx_lengthClass.IntegralHeight = false;
            this.cmbBx_lengthClass.ItemHeight = 43;
            this.cmbBx_lengthClass.Location = new System.Drawing.Point(573, 441);
            this.cmbBx_lengthClass.MaxDropDownItems = 4;
            this.cmbBx_lengthClass.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_lengthClass.Name = "cmbBx_lengthClass";
            this.cmbBx_lengthClass.Size = new System.Drawing.Size(310, 49);
            this.cmbBx_lengthClass.TabIndex = 21;
            // 
            // txtBxWidth
            // 
            this.txtBxWidth.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxWidth.Depth = 0;
            this.txtBxWidth.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxWidth.Hint = "Ancho";
            this.txtBxWidth.Location = new System.Drawing.Point(224, 440);
            this.txtBxWidth.MaxLength = 32767;
            this.txtBxWidth.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxWidth.Multiline = false;
            this.txtBxWidth.Name = "txtBxWidth";
            this.txtBxWidth.Size = new System.Drawing.Size(151, 50);
            this.txtBxWidth.TabIndex = 20;
            this.txtBxWidth.TabStop = false;
            this.txtBxWidth.Text = "";
            // 
            // cmbBx_stockStatus
            // 
            this.cmbBx_stockStatus.AutoResize = false;
            this.cmbBx_stockStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_stockStatus.Depth = 0;
            this.cmbBx_stockStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_stockStatus.DropDownHeight = 174;
            this.cmbBx_stockStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_stockStatus.DropDownWidth = 121;
            this.cmbBx_stockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_stockStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_stockStatus.FormattingEnabled = true;
            this.cmbBx_stockStatus.Hint = "Estado de inventario";
            this.cmbBx_stockStatus.IntegralHeight = false;
            this.cmbBx_stockStatus.ItemHeight = 43;
            this.cmbBx_stockStatus.Location = new System.Drawing.Point(65, 317);
            this.cmbBx_stockStatus.MaxDropDownItems = 4;
            this.cmbBx_stockStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_stockStatus.Name = "cmbBx_stockStatus";
            this.cmbBx_stockStatus.Size = new System.Drawing.Size(310, 49);
            this.cmbBx_stockStatus.TabIndex = 13;
            // 
            // txtBxLength
            // 
            this.txtBxLength.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxLength.Depth = 0;
            this.txtBxLength.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxLength.Hint = "Largo";
            this.txtBxLength.Location = new System.Drawing.Point(65, 440);
            this.txtBxLength.MaxLength = 32767;
            this.txtBxLength.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxLength.Multiline = false;
            this.txtBxLength.Name = "txtBxLength";
            this.txtBxLength.Size = new System.Drawing.Size(153, 50);
            this.txtBxLength.TabIndex = 19;
            this.txtBxLength.TabStop = false;
            this.txtBxLength.Text = "";
            // 
            // cmbBx_taxclass
            // 
            this.cmbBx_taxclass.AutoResize = false;
            this.cmbBx_taxclass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_taxclass.Depth = 0;
            this.cmbBx_taxclass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_taxclass.DropDownHeight = 174;
            this.cmbBx_taxclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_taxclass.DropDownWidth = 121;
            this.cmbBx_taxclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_taxclass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_taxclass.FormattingEnabled = true;
            this.cmbBx_taxclass.Hint = "Tipo de impuesto";
            this.cmbBx_taxclass.IntegralHeight = false;
            this.cmbBx_taxclass.ItemHeight = 43;
            this.cmbBx_taxclass.Location = new System.Drawing.Point(201, 262);
            this.cmbBx_taxclass.MaxDropDownItems = 4;
            this.cmbBx_taxclass.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_taxclass.Name = "cmbBx_taxclass";
            this.cmbBx_taxclass.Size = new System.Drawing.Size(174, 49);
            this.cmbBx_taxclass.TabIndex = 10;
            // 
            // cmbBx_weightClass
            // 
            this.cmbBx_weightClass.AutoResize = false;
            this.cmbBx_weightClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_weightClass.Depth = 0;
            this.cmbBx_weightClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_weightClass.DropDownHeight = 174;
            this.cmbBx_weightClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_weightClass.DropDownWidth = 121;
            this.cmbBx_weightClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_weightClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_weightClass.FormattingEnabled = true;
            this.cmbBx_weightClass.Hint = "Unidad de peso";
            this.cmbBx_weightClass.IntegralHeight = false;
            this.cmbBx_weightClass.ItemHeight = 43;
            this.cmbBx_weightClass.Location = new System.Drawing.Point(738, 317);
            this.cmbBx_weightClass.MaxDropDownItems = 4;
            this.cmbBx_weightClass.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_weightClass.Name = "cmbBx_weightClass";
            this.cmbBx_weightClass.Size = new System.Drawing.Size(145, 49);
            this.cmbBx_weightClass.TabIndex = 15;
            // 
            // dateRelease
            // 
            this.dateRelease.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateRelease.Location = new System.Drawing.Point(738, 404);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(145, 20);
            this.dateRelease.TabIndex = 18;
            this.dateRelease.Value = new System.DateTime(2020, 10, 28, 0, 0, 0, 0);
            // 
            // chkBx_status
            // 
            this.chkBx_status.AutoSize = true;
            this.chkBx_status.Depth = 0;
            this.chkBx_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBx_status.Location = new System.Drawing.Point(65, 268);
            this.chkBx_status.Margin = new System.Windows.Forms.Padding(0);
            this.chkBx_status.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBx_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBx_status.Name = "chkBx_status";
            this.chkBx_status.Ripple = true;
            this.chkBx_status.Size = new System.Drawing.Size(108, 37);
            this.chkBx_status.TabIndex = 9;
            this.chkBx_status.Text = "Habilitado";
            this.chkBx_status.UseVisualStyleBackColor = true;
            // 
            // chkBxShippingRequired
            // 
            this.chkBxShippingRequired.AutoSize = true;
            this.chkBxShippingRequired.Depth = 0;
            this.chkBxShippingRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBxShippingRequired.Location = new System.Drawing.Point(573, 387);
            this.chkBxShippingRequired.Margin = new System.Windows.Forms.Padding(0);
            this.chkBxShippingRequired.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBxShippingRequired.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBxShippingRequired.Name = "chkBxShippingRequired";
            this.chkBxShippingRequired.Ripple = true;
            this.chkBxShippingRequired.Size = new System.Drawing.Size(138, 37);
            this.chkBxShippingRequired.TabIndex = 17;
            this.chkBxShippingRequired.Text = "Requiere envío";
            this.chkBxShippingRequired.UseVisualStyleBackColor = true;
            // 
            // chkBx_subtractStock
            // 
            this.chkBx_subtractStock.AutoSize = true;
            this.chkBx_subtractStock.Depth = 0;
            this.chkBx_subtractStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBx_subtractStock.Location = new System.Drawing.Point(65, 387);
            this.chkBx_subtractStock.Margin = new System.Windows.Forms.Padding(0);
            this.chkBx_subtractStock.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBx_subtractStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBx_subtractStock.Name = "chkBx_subtractStock";
            this.chkBx_subtractStock.Ripple = true;
            this.chkBx_subtractStock.Size = new System.Drawing.Size(204, 37);
            this.chkBx_subtractStock.TabIndex = 16;
            this.chkBx_subtractStock.Text = "Sustraer del \r\ninventario";
            this.chkBx_subtractStock.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label17.Location = new System.Drawing.Point(735, 386);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 15);
            this.label17.TabIndex = 88;
            this.label17.Text = "Fecha disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(47, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 89;
            this.label6.Text = "*";
            // 
            // txtBx_mpn
            // 
            this.txtBx_mpn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mpn.Depth = 0;
            this.txtBx_mpn.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_mpn.Hint = "Número de pieza del fabricante";
            this.txtBx_mpn.Location = new System.Drawing.Point(65, 38);
            this.txtBx_mpn.MaxLength = 32767;
            this.txtBx_mpn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mpn.Multiline = false;
            this.txtBx_mpn.Name = "txtBx_mpn";
            this.txtBx_mpn.Size = new System.Drawing.Size(310, 50);
            this.txtBx_mpn.TabIndex = 0;
            this.txtBx_mpn.TabStop = false;
            this.txtBx_mpn.Text = "";
            // 
            // txtBx_price
            // 
            this.txtBx_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_price.Depth = 0;
            this.txtBx_price.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_price.Hint = "Precio";
            this.txtBx_price.Location = new System.Drawing.Point(738, 206);
            this.txtBx_price.MaxLength = 32767;
            this.txtBx_price.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_price.Multiline = false;
            this.txtBx_price.Name = "txtBx_price";
            this.txtBx_price.Size = new System.Drawing.Size(145, 50);
            this.txtBx_price.TabIndex = 8;
            this.txtBx_price.TabStop = false;
            this.txtBx_price.Text = "";
            // 
            // txtBxMinQuantity
            // 
            this.txtBxMinQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxMinQuantity.Depth = 0;
            this.txtBxMinQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxMinQuantity.Hint = "Cantidad mínima";
            this.txtBxMinQuantity.Location = new System.Drawing.Point(738, 262);
            this.txtBxMinQuantity.MaxLength = 32767;
            this.txtBxMinQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxMinQuantity.Multiline = false;
            this.txtBxMinQuantity.Name = "txtBxMinQuantity";
            this.txtBxMinQuantity.Size = new System.Drawing.Size(145, 50);
            this.txtBxMinQuantity.TabIndex = 12;
            this.txtBxMinQuantity.TabStop = false;
            this.txtBxMinQuantity.Text = "";
            // 
            // txtBxQuantity
            // 
            this.txtBxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxQuantity.Depth = 0;
            this.txtBxQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxQuantity.Hint = "Cantidad";
            this.txtBxQuantity.Location = new System.Drawing.Point(573, 262);
            this.txtBxQuantity.MaxLength = 32767;
            this.txtBxQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxQuantity.Multiline = false;
            this.txtBxQuantity.Name = "txtBxQuantity";
            this.txtBxQuantity.Size = new System.Drawing.Size(145, 50);
            this.txtBxQuantity.TabIndex = 11;
            this.txtBxQuantity.TabStop = false;
            this.txtBxQuantity.Text = "";
            // 
            // txtBx_weight
            // 
            this.txtBx_weight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_weight.Depth = 0;
            this.txtBx_weight.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_weight.Hint = "Peso";
            this.txtBx_weight.Location = new System.Drawing.Point(573, 317);
            this.txtBx_weight.MaxLength = 32767;
            this.txtBx_weight.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_weight.Multiline = false;
            this.txtBx_weight.Name = "txtBx_weight";
            this.txtBx_weight.Size = new System.Drawing.Size(145, 50);
            this.txtBx_weight.TabIndex = 14;
            this.txtBx_weight.TabStop = false;
            this.txtBx_weight.Text = "";
            // 
            // txtBx_location
            // 
            this.txtBx_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_location.Depth = 0;
            this.txtBx_location.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_location.Hint = "Locación";
            this.txtBx_location.Location = new System.Drawing.Point(573, 206);
            this.txtBx_location.MaxLength = 32767;
            this.txtBx_location.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_location.Multiline = false;
            this.txtBx_location.Name = "txtBx_location";
            this.txtBx_location.Size = new System.Drawing.Size(145, 50);
            this.txtBx_location.TabIndex = 7;
            this.txtBx_location.TabStop = false;
            this.txtBx_location.Text = "";
            // 
            // txtBx_isbn
            // 
            this.txtBx_isbn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_isbn.Depth = 0;
            this.txtBx_isbn.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_isbn.Hint = "Numero de libro internacional estándar";
            this.txtBx_isbn.Location = new System.Drawing.Point(573, 150);
            this.txtBx_isbn.MaxLength = 32767;
            this.txtBx_isbn.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_isbn.Multiline = false;
            this.txtBx_isbn.Name = "txtBx_isbn";
            this.txtBx_isbn.Size = new System.Drawing.Size(310, 50);
            this.txtBx_isbn.TabIndex = 5;
            this.txtBx_isbn.TabStop = false;
            this.txtBx_isbn.Text = "";
            // 
            // txtBx_jan
            // 
            this.txtBx_jan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_jan.Depth = 0;
            this.txtBx_jan.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_jan.Hint = "Número de refencia japonesa";
            this.txtBx_jan.Location = new System.Drawing.Point(65, 150);
            this.txtBx_jan.MaxLength = 32767;
            this.txtBx_jan.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_jan.Multiline = false;
            this.txtBx_jan.Name = "txtBx_jan";
            this.txtBx_jan.Size = new System.Drawing.Size(310, 50);
            this.txtBx_jan.TabIndex = 4;
            this.txtBx_jan.TabStop = false;
            this.txtBx_jan.Text = "";
            // 
            // txtBx_ean
            // 
            this.txtBx_ean.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_ean.Depth = 0;
            this.txtBx_ean.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_ean.Hint = "Numero de artículo europeo (internacional)";
            this.txtBx_ean.Location = new System.Drawing.Point(573, 94);
            this.txtBx_ean.MaxLength = 32767;
            this.txtBx_ean.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_ean.Multiline = false;
            this.txtBx_ean.Name = "txtBx_ean";
            this.txtBx_ean.Size = new System.Drawing.Size(310, 50);
            this.txtBx_ean.TabIndex = 3;
            this.txtBx_ean.TabStop = false;
            this.txtBx_ean.Text = "";
            // 
            // txtBx_upc
            // 
            this.txtBx_upc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_upc.Depth = 0;
            this.txtBx_upc.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_upc.Hint = "Codigo universal del producto";
            this.txtBx_upc.Location = new System.Drawing.Point(65, 94);
            this.txtBx_upc.MaxLength = 32767;
            this.txtBx_upc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_upc.Multiline = false;
            this.txtBx_upc.Name = "txtBx_upc";
            this.txtBx_upc.Size = new System.Drawing.Size(310, 50);
            this.txtBx_upc.TabIndex = 2;
            this.txtBx_upc.TabStop = false;
            this.txtBx_upc.Text = "";
            // 
            // txtBx_sku
            // 
            this.txtBx_sku.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_sku.Depth = 0;
            this.txtBx_sku.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_sku.Hint = "Número de referencia";
            this.txtBx_sku.Location = new System.Drawing.Point(573, 38);
            this.txtBx_sku.MaxLength = 32767;
            this.txtBx_sku.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_sku.Multiline = false;
            this.txtBx_sku.Name = "txtBx_sku";
            this.txtBx_sku.Size = new System.Drawing.Size(310, 50);
            this.txtBx_sku.TabIndex = 1;
            this.txtBx_sku.TabStop = false;
            this.txtBx_sku.Text = "";
            // 
            // txtBx_model
            // 
            this.txtBx_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_model.Depth = 0;
            this.txtBx_model.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_model.Hint = "Modelo del producto";
            this.txtBx_model.Location = new System.Drawing.Point(65, 206);
            this.txtBx_model.MaxLength = 32767;
            this.txtBx_model.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_model.Multiline = false;
            this.txtBx_model.Name = "txtBx_model";
            this.txtBx_model.Size = new System.Drawing.Size(310, 50);
            this.txtBx_model.TabIndex = 6;
            this.txtBx_model.TabStop = false;
            this.txtBx_model.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 487);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1019, 57);
            this.panel3.TabIndex = 65;
            // 
            // tabPage_Links
            // 
            this.tabPage_Links.AutoScroll = true;
            this.tabPage_Links.BackColor = System.Drawing.Color.White;
            this.tabPage_Links.Controls.Add(this.cmbBx_manufacturer);
            this.tabPage_Links.Controls.Add(this.materialLabel2);
            this.tabPage_Links.Controls.Add(this.materialLabel1);
            this.tabPage_Links.Controls.Add(this.flowLayoutPanel_relatedProducts);
            this.tabPage_Links.Controls.Add(this.flwLytPnl_stores);
            this.tabPage_Links.Controls.Add(this.flowLayoutPanel_categories);
            this.tabPage_Links.Controls.Add(this.label28);
            this.tabPage_Links.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Links.Name = "tabPage_Links";
            this.tabPage_Links.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Links.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_Links.TabIndex = 5;
            this.tabPage_Links.Text = "Enlaces";
            // 
            // cmbBx_manufacturer
            // 
            this.cmbBx_manufacturer.AutoResize = false;
            this.cmbBx_manufacturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_manufacturer.Depth = 0;
            this.cmbBx_manufacturer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_manufacturer.DropDownHeight = 174;
            this.cmbBx_manufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_manufacturer.DropDownWidth = 121;
            this.cmbBx_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_manufacturer.FormattingEnabled = true;
            this.cmbBx_manufacturer.Hint = "Fabricante";
            this.cmbBx_manufacturer.IntegralHeight = false;
            this.cmbBx_manufacturer.ItemHeight = 43;
            this.cmbBx_manufacturer.Location = new System.Drawing.Point(30, 27);
            this.cmbBx_manufacturer.MaxDropDownItems = 4;
            this.cmbBx_manufacturer.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_manufacturer.Name = "cmbBx_manufacturer";
            this.cmbBx_manufacturer.Size = new System.Drawing.Size(260, 49);
            this.cmbBx_manufacturer.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(748, 95);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(168, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Productos relacionados";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(390, 95);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Categorias";
            // 
            // flowLayoutPanel_relatedProducts
            // 
            this.flowLayoutPanel_relatedProducts.AutoScroll = true;
            this.flowLayoutPanel_relatedProducts.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_relatedProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_relatedProducts.Location = new System.Drawing.Point(748, 115);
            this.flowLayoutPanel_relatedProducts.MaximumSize = new System.Drawing.Size(260, 290);
            this.flowLayoutPanel_relatedProducts.MinimumSize = new System.Drawing.Size(200, 0);
            this.flowLayoutPanel_relatedProducts.Name = "flowLayoutPanel_relatedProducts";
            this.flowLayoutPanel_relatedProducts.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_relatedProducts.Size = new System.Drawing.Size(260, 290);
            this.flowLayoutPanel_relatedProducts.TabIndex = 3;
            this.flowLayoutPanel_relatedProducts.WrapContents = false;
            // 
            // flwLytPnl_stores
            // 
            this.flwLytPnl_stores.AutoScroll = true;
            this.flwLytPnl_stores.BackColor = System.Drawing.SystemColors.Control;
            this.flwLytPnl_stores.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwLytPnl_stores.Location = new System.Drawing.Point(33, 115);
            this.flwLytPnl_stores.MaximumSize = new System.Drawing.Size(260, 290);
            this.flwLytPnl_stores.MinimumSize = new System.Drawing.Size(220, 0);
            this.flwLytPnl_stores.Name = "flwLytPnl_stores";
            this.flwLytPnl_stores.Padding = new System.Windows.Forms.Padding(5);
            this.flwLytPnl_stores.Size = new System.Drawing.Size(260, 290);
            this.flwLytPnl_stores.TabIndex = 1;
            this.flwLytPnl_stores.WrapContents = false;
            // 
            // flowLayoutPanel_categories
            // 
            this.flowLayoutPanel_categories.AutoScroll = true;
            this.flowLayoutPanel_categories.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel_categories.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_categories.Location = new System.Drawing.Point(390, 115);
            this.flowLayoutPanel_categories.MaximumSize = new System.Drawing.Size(260, 290);
            this.flowLayoutPanel_categories.MinimumSize = new System.Drawing.Size(220, 0);
            this.flowLayoutPanel_categories.Name = "flowLayoutPanel_categories";
            this.flowLayoutPanel_categories.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel_categories.Size = new System.Drawing.Size(260, 290);
            this.flowLayoutPanel_categories.TabIndex = 2;
            this.flowLayoutPanel_categories.WrapContents = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label28.Location = new System.Drawing.Point(30, 97);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(51, 15);
            this.label28.TabIndex = 4;
            this.label28.Text = "Tiendas";
            // 
            // tabPage_discount
            // 
            this.tabPage_discount.BackColor = System.Drawing.Color.White;
            this.tabPage_discount.Controls.Add(this.cmbBx_DisGroupCustomer);
            this.tabPage_discount.Controls.Add(this.lstVwDiscounts);
            this.tabPage_discount.Controls.Add(this.btAddDiscount);
            this.tabPage_discount.Controls.Add(this.dateTimePicker_discountDateStart);
            this.tabPage_discount.Controls.Add(this.dateTimePicker_discountDateEnd);
            this.tabPage_discount.Controls.Add(this.txtBx_discountPrice);
            this.tabPage_discount.Controls.Add(this.txtBx_discountPriority);
            this.tabPage_discount.Controls.Add(this.txtBx_discountQuantity);
            this.tabPage_discount.Controls.Add(this.label32);
            this.tabPage_discount.Controls.Add(this.label29);
            this.tabPage_discount.Location = new System.Drawing.Point(4, 22);
            this.tabPage_discount.Name = "tabPage_discount";
            this.tabPage_discount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_discount.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_discount.TabIndex = 3;
            this.tabPage_discount.Text = "Descuento";
            // 
            // cmbBx_DisGroupCustomer
            // 
            this.cmbBx_DisGroupCustomer.AutoResize = false;
            this.cmbBx_DisGroupCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_DisGroupCustomer.Depth = 0;
            this.cmbBx_DisGroupCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_DisGroupCustomer.DropDownHeight = 174;
            this.cmbBx_DisGroupCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_DisGroupCustomer.DropDownWidth = 121;
            this.cmbBx_DisGroupCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_DisGroupCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_DisGroupCustomer.FormattingEnabled = true;
            this.cmbBx_DisGroupCustomer.Hint = "Grupo de clientes";
            this.cmbBx_DisGroupCustomer.IntegralHeight = false;
            this.cmbBx_DisGroupCustomer.ItemHeight = 43;
            this.cmbBx_DisGroupCustomer.Location = new System.Drawing.Point(97, 17);
            this.cmbBx_DisGroupCustomer.MaxDropDownItems = 4;
            this.cmbBx_DisGroupCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_DisGroupCustomer.Name = "cmbBx_DisGroupCustomer";
            this.cmbBx_DisGroupCustomer.Size = new System.Drawing.Size(200, 49);
            this.cmbBx_DisGroupCustomer.TabIndex = 0;
            // 
            // lstVwDiscounts
            // 
            this.lstVwDiscounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVwDiscounts.AutoSizeTable = false;
            this.lstVwDiscounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwDiscounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwDiscounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerDiscGroup,
            this.headerDiscQuantity,
            this.haederDiscPriority,
            this.headerDiscPrice,
            this.headerDiscStartDate,
            this.headerDiscFinishDate});
            this.lstVwDiscounts.ContextMenuStrip = this.contextMenu;
            this.lstVwDiscounts.Depth = 0;
            this.lstVwDiscounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVwDiscounts.FullRowSelect = true;
            this.lstVwDiscounts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwDiscounts.HideSelection = false;
            this.lstVwDiscounts.Location = new System.Drawing.Point(363, 62);
            this.lstVwDiscounts.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstVwDiscounts.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwDiscounts.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwDiscounts.Name = "lstVwDiscounts";
            this.lstVwDiscounts.OwnerDraw = true;
            this.lstVwDiscounts.Size = new System.Drawing.Size(655, 369);
            this.lstVwDiscounts.TabIndex = 7;
            this.lstVwDiscounts.UseCompatibleStateImageBehavior = false;
            this.lstVwDiscounts.View = System.Windows.Forms.View.Details;
            // 
            // headerDiscGroup
            // 
            this.headerDiscGroup.Text = "Grupo";
            this.headerDiscGroup.Width = 120;
            // 
            // headerDiscQuantity
            // 
            this.headerDiscQuantity.Text = "Cantidad";
            this.headerDiscQuantity.Width = 97;
            // 
            // haederDiscPriority
            // 
            this.haederDiscPriority.Text = "Prioridad";
            this.haederDiscPriority.Width = 101;
            // 
            // headerDiscPrice
            // 
            this.headerDiscPrice.Text = "Precio";
            this.headerDiscPrice.Width = 95;
            // 
            // headerDiscStartDate
            // 
            this.headerDiscStartDate.Text = "Fecha de inicio";
            this.headerDiscStartDate.Width = 139;
            // 
            // headerDiscFinishDate
            // 
            this.headerDiscFinishDate.Text = "Fecha de finalización";
            this.headerDiscFinishDate.Width = 120;
            // 
            // contextMenu
            // 
            this.contextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenu.Depth = 0;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStrip});
            this.contextMenu.MouseState = MaterialSkin.MouseState.HOVER;
            this.contextMenu.Name = "contextMenuDiscount";
            this.contextMenu.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStrip
            // 
            this.removeToolStrip.Image = global::WinForms.Properties.Resources.Trash_32px;
            this.removeToolStrip.Name = "removeToolStrip";
            this.removeToolStrip.Size = new System.Drawing.Size(117, 22);
            this.removeToolStrip.Text = "Eliminar";
            // 
            // btAddDiscount
            // 
            this.btAddDiscount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddDiscount.Depth = 0;
            this.btAddDiscount.DrawShadows = true;
            this.btAddDiscount.HighEmphasis = true;
            this.btAddDiscount.Icon = global::WinForms.Properties.Resources.NewProduct_32px;
            this.btAddDiscount.Location = new System.Drawing.Point(363, 17);
            this.btAddDiscount.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddDiscount.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddDiscount.Name = "btAddDiscount";
            this.btAddDiscount.Size = new System.Drawing.Size(102, 36);
            this.btAddDiscount.TabIndex = 6;
            this.btAddDiscount.Text = "Añadir";
            this.btAddDiscount.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddDiscount.UseAccentColor = false;
            this.btAddDiscount.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_discountDateStart
            // 
            this.dateTimePicker_discountDateStart.Location = new System.Drawing.Point(97, 313);
            this.dateTimePicker_discountDateStart.Name = "dateTimePicker_discountDateStart";
            this.dateTimePicker_discountDateStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_discountDateStart.TabIndex = 4;
            // 
            // dateTimePicker_discountDateEnd
            // 
            this.dateTimePicker_discountDateEnd.Location = new System.Drawing.Point(97, 388);
            this.dateTimePicker_discountDateEnd.Name = "dateTimePicker_discountDateEnd";
            this.dateTimePicker_discountDateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_discountDateEnd.TabIndex = 5;
            // 
            // txtBx_discountPrice
            // 
            this.txtBx_discountPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_discountPrice.Depth = 0;
            this.txtBx_discountPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_discountPrice.Hint = "Precio";
            this.txtBx_discountPrice.Location = new System.Drawing.Point(97, 235);
            this.txtBx_discountPrice.MaxLength = 32767;
            this.txtBx_discountPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_discountPrice.Multiline = false;
            this.txtBx_discountPrice.Name = "txtBx_discountPrice";
            this.txtBx_discountPrice.Size = new System.Drawing.Size(200, 50);
            this.txtBx_discountPrice.TabIndex = 3;
            this.txtBx_discountPrice.TabStop = false;
            this.txtBx_discountPrice.Text = "";
            // 
            // txtBx_discountPriority
            // 
            this.txtBx_discountPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_discountPriority.Depth = 0;
            this.txtBx_discountPriority.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_discountPriority.Hint = "Prioridad";
            this.txtBx_discountPriority.Location = new System.Drawing.Point(97, 162);
            this.txtBx_discountPriority.MaxLength = 32767;
            this.txtBx_discountPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_discountPriority.Multiline = false;
            this.txtBx_discountPriority.Name = "txtBx_discountPriority";
            this.txtBx_discountPriority.Size = new System.Drawing.Size(200, 50);
            this.txtBx_discountPriority.TabIndex = 2;
            this.txtBx_discountPriority.TabStop = false;
            this.txtBx_discountPriority.Text = "";
            // 
            // txtBx_discountQuantity
            // 
            this.txtBx_discountQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_discountQuantity.Depth = 0;
            this.txtBx_discountQuantity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_discountQuantity.Hint = "Cantidad";
            this.txtBx_discountQuantity.Location = new System.Drawing.Point(97, 89);
            this.txtBx_discountQuantity.MaxLength = 32767;
            this.txtBx_discountQuantity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_discountQuantity.Multiline = false;
            this.txtBx_discountQuantity.Name = "txtBx_discountQuantity";
            this.txtBx_discountQuantity.Size = new System.Drawing.Size(200, 50);
            this.txtBx_discountQuantity.TabIndex = 1;
            this.txtBx_discountQuantity.TabStop = false;
            this.txtBx_discountQuantity.Text = "";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label32.Location = new System.Drawing.Point(230, 411);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(67, 15);
            this.label32.TabIndex = 10;
            this.label32.Text = "Fecha final";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label29.Location = new System.Drawing.Point(207, 336);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(90, 15);
            this.label29.TabIndex = 10;
            this.label29.Text = "Fecha de inicio";
            // 
            // tabPage_special
            // 
            this.tabPage_special.BackColor = System.Drawing.Color.White;
            this.tabPage_special.Controls.Add(this.cmbBx_SpecGroupCustomer);
            this.tabPage_special.Controls.Add(this.lstVwOffers);
            this.tabPage_special.Controls.Add(this.btAddOffer);
            this.tabPage_special.Controls.Add(this.dateTimePicker_SpecDateStart);
            this.tabPage_special.Controls.Add(this.dateTimePicker_SpecDateEnd);
            this.tabPage_special.Controls.Add(this.txtBxSpecialPrice);
            this.tabPage_special.Controls.Add(this.txtBxSpecialPriority);
            this.tabPage_special.Controls.Add(this.label39);
            this.tabPage_special.Controls.Add(this.label40);
            this.tabPage_special.Location = new System.Drawing.Point(4, 22);
            this.tabPage_special.Name = "tabPage_special";
            this.tabPage_special.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_special.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_special.TabIndex = 4;
            this.tabPage_special.Text = "Oferta";
            // 
            // cmbBx_SpecGroupCustomer
            // 
            this.cmbBx_SpecGroupCustomer.AutoResize = false;
            this.cmbBx_SpecGroupCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBx_SpecGroupCustomer.Depth = 0;
            this.cmbBx_SpecGroupCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBx_SpecGroupCustomer.DropDownHeight = 174;
            this.cmbBx_SpecGroupCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBx_SpecGroupCustomer.DropDownWidth = 121;
            this.cmbBx_SpecGroupCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBx_SpecGroupCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBx_SpecGroupCustomer.FormattingEnabled = true;
            this.cmbBx_SpecGroupCustomer.Hint = "Grupo de clientes";
            this.cmbBx_SpecGroupCustomer.IntegralHeight = false;
            this.cmbBx_SpecGroupCustomer.ItemHeight = 43;
            this.cmbBx_SpecGroupCustomer.Location = new System.Drawing.Point(97, 17);
            this.cmbBx_SpecGroupCustomer.MaxDropDownItems = 4;
            this.cmbBx_SpecGroupCustomer.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBx_SpecGroupCustomer.Name = "cmbBx_SpecGroupCustomer";
            this.cmbBx_SpecGroupCustomer.Size = new System.Drawing.Size(200, 49);
            this.cmbBx_SpecGroupCustomer.TabIndex = 0;
            // 
            // lstVwOffers
            // 
            this.lstVwOffers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVwOffers.AutoSizeTable = false;
            this.lstVwOffers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwOffers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwOffers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerOfferGroup,
            this.headerOfferPriority,
            this.headerOfferPrice,
            this.headerOfferDateStart,
            this.headerOfferDateEnd});
            this.lstVwOffers.ContextMenuStrip = this.contextMenu;
            this.lstVwOffers.Depth = 0;
            this.lstVwOffers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVwOffers.FullRowSelect = true;
            this.lstVwOffers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwOffers.HideSelection = false;
            this.lstVwOffers.Location = new System.Drawing.Point(363, 62);
            this.lstVwOffers.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstVwOffers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwOffers.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwOffers.Name = "lstVwOffers";
            this.lstVwOffers.OwnerDraw = true;
            this.lstVwOffers.Size = new System.Drawing.Size(655, 369);
            this.lstVwOffers.TabIndex = 6;
            this.lstVwOffers.UseCompatibleStateImageBehavior = false;
            this.lstVwOffers.View = System.Windows.Forms.View.Details;
            // 
            // headerOfferGroup
            // 
            this.headerOfferGroup.Text = "Grupo";
            this.headerOfferGroup.Width = 120;
            // 
            // headerOfferPriority
            // 
            this.headerOfferPriority.Text = "Prioridad";
            this.headerOfferPriority.Width = 112;
            // 
            // headerOfferPrice
            // 
            this.headerOfferPrice.Text = "Precio";
            this.headerOfferPrice.Width = 93;
            // 
            // headerOfferDateStart
            // 
            this.headerOfferDateStart.Text = "Fecha de inicio";
            this.headerOfferDateStart.Width = 141;
            // 
            // headerOfferDateEnd
            // 
            this.headerOfferDateEnd.Text = "Fecha de finalización";
            this.headerOfferDateEnd.Width = 173;
            // 
            // btAddOffer
            // 
            this.btAddOffer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddOffer.Depth = 0;
            this.btAddOffer.DrawShadows = true;
            this.btAddOffer.HighEmphasis = true;
            this.btAddOffer.Icon = global::WinForms.Properties.Resources.NewProduct_32px;
            this.btAddOffer.Location = new System.Drawing.Point(363, 17);
            this.btAddOffer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddOffer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddOffer.Name = "btAddOffer";
            this.btAddOffer.Size = new System.Drawing.Size(102, 36);
            this.btAddOffer.TabIndex = 5;
            this.btAddOffer.Text = "Añadir";
            this.btAddOffer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddOffer.UseAccentColor = false;
            this.btAddOffer.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_SpecDateStart
            // 
            this.dateTimePicker_SpecDateStart.Location = new System.Drawing.Point(97, 244);
            this.dateTimePicker_SpecDateStart.Name = "dateTimePicker_SpecDateStart";
            this.dateTimePicker_SpecDateStart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_SpecDateStart.TabIndex = 3;
            // 
            // dateTimePicker_SpecDateEnd
            // 
            this.dateTimePicker_SpecDateEnd.Location = new System.Drawing.Point(97, 322);
            this.dateTimePicker_SpecDateEnd.Name = "dateTimePicker_SpecDateEnd";
            this.dateTimePicker_SpecDateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_SpecDateEnd.TabIndex = 4;
            // 
            // txtBxSpecialPrice
            // 
            this.txtBxSpecialPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSpecialPrice.Depth = 0;
            this.txtBxSpecialPrice.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxSpecialPrice.Hint = "Precio";
            this.txtBxSpecialPrice.Location = new System.Drawing.Point(97, 162);
            this.txtBxSpecialPrice.MaxLength = 32767;
            this.txtBxSpecialPrice.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSpecialPrice.Multiline = false;
            this.txtBxSpecialPrice.Name = "txtBxSpecialPrice";
            this.txtBxSpecialPrice.Size = new System.Drawing.Size(200, 50);
            this.txtBxSpecialPrice.TabIndex = 2;
            this.txtBxSpecialPrice.TabStop = false;
            this.txtBxSpecialPrice.Text = "";
            // 
            // txtBxSpecialPriority
            // 
            this.txtBxSpecialPriority.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSpecialPriority.Depth = 0;
            this.txtBxSpecialPriority.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxSpecialPriority.Hint = "Prioridad";
            this.txtBxSpecialPriority.Location = new System.Drawing.Point(97, 89);
            this.txtBxSpecialPriority.MaxLength = 32767;
            this.txtBxSpecialPriority.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSpecialPriority.Multiline = false;
            this.txtBxSpecialPriority.Name = "txtBxSpecialPriority";
            this.txtBxSpecialPriority.Size = new System.Drawing.Size(200, 50);
            this.txtBxSpecialPriority.TabIndex = 1;
            this.txtBxSpecialPriority.TabStop = false;
            this.txtBxSpecialPriority.Text = "";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label39.Location = new System.Drawing.Point(230, 345);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 15);
            this.label39.TabIndex = 19;
            this.label39.Text = "Fecha final";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label40.Location = new System.Drawing.Point(207, 267);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(90, 15);
            this.label40.TabIndex = 20;
            this.label40.Text = "Fecha de inicio";
            // 
            // tabPage_images
            // 
            this.tabPage_images.BackColor = System.Drawing.Color.White;
            this.tabPage_images.Controls.Add(this.btn_addImages);
            this.tabPage_images.Controls.Add(this.btn_delImg);
            this.tabPage_images.Controls.Add(this.lbl_ImgMsg);
            this.tabPage_images.Controls.Add(this.label43);
            this.tabPage_images.Controls.Add(this.label36);
            this.tabPage_images.Controls.Add(this.picBxImage);
            this.tabPage_images.Controls.Add(this.imagePanel);
            this.tabPage_images.Location = new System.Drawing.Point(4, 22);
            this.tabPage_images.Name = "tabPage_images";
            this.tabPage_images.Size = new System.Drawing.Size(1042, 457);
            this.tabPage_images.TabIndex = 6;
            this.tabPage_images.Text = "Imágenes";
            // 
            // btn_addImages
            // 
            this.btn_addImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addImages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_addImages.Depth = 0;
            this.btn_addImages.DrawShadows = true;
            this.btn_addImages.HighEmphasis = true;
            this.btn_addImages.Icon = global::WinForms.Properties.Resources.AddImage_32px;
            this.btn_addImages.Location = new System.Drawing.Point(833, 131);
            this.btn_addImages.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_addImages.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_addImages.Name = "btn_addImages";
            this.btn_addImages.Size = new System.Drawing.Size(162, 36);
            this.btn_addImages.TabIndex = 1;
            this.btn_addImages.Text = "Añadir imagen";
            this.btn_addImages.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btn_addImages.UseAccentColor = false;
            this.btn_addImages.UseVisualStyleBackColor = true;
            // 
            // btn_delImg
            // 
            this.btn_delImg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_delImg.Depth = 0;
            this.btn_delImg.DrawShadows = true;
            this.btn_delImg.HighEmphasis = true;
            this.btn_delImg.Icon = global::WinForms.Properties.Resources.Trash_32px;
            this.btn_delImg.Location = new System.Drawing.Point(172, 46);
            this.btn_delImg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_delImg.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_delImg.Name = "btn_delImg";
            this.btn_delImg.Size = new System.Drawing.Size(44, 36);
            this.btn_delImg.TabIndex = 0;
            this.btn_delImg.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btn_delImg.UseAccentColor = false;
            this.btn_delImg.UseVisualStyleBackColor = false;
            // 
            // lbl_ImgMsg
            // 
            this.lbl_ImgMsg.AutoSize = true;
            this.lbl_ImgMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImgMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_ImgMsg.Location = new System.Drawing.Point(184, 131);
            this.lbl_ImgMsg.Name = "lbl_ImgMsg";
            this.lbl_ImgMsg.Size = new System.Drawing.Size(174, 15);
            this.lbl_ImgMsg.TabIndex = 22;
            this.lbl_ImgMsg.Text = "Imagen subida correctamente.";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label43.Location = new System.Drawing.Point(46, 28);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(99, 15);
            this.label43.TabIndex = 22;
            this.label43.Text = "Imagen principal";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label36.Location = new System.Drawing.Point(38, 171);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(128, 15);
            this.label36.TabIndex = 22;
            this.label36.Text = "Imágenes adicionales";
            // 
            // picBxImage
            // 
            this.picBxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBxImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBxImage.ErrorImage = global::WinForms.Properties.Resources.OpenCart_32px;
            this.picBxImage.Image = global::WinForms.Properties.Resources.OpenCart_32px;
            this.picBxImage.InitialImage = global::WinForms.Properties.Resources.OpenCart_32px;
            this.picBxImage.Location = new System.Drawing.Point(45, 46);
            this.picBxImage.Name = "picBxImage";
            this.picBxImage.Size = new System.Drawing.Size(120, 100);
            this.picBxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxImage.TabIndex = 0;
            this.picBxImage.TabStop = false;
            // 
            // imagePanel
            // 
            this.imagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagePanel.ContextMenuStrip = this.contextMenu;
            this.imagePanel.DataSource = null;
            this.imagePanel.Location = new System.Drawing.Point(38, 189);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(957, 263);
            this.imagePanel.TabIndex = 2;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.lbl_msg);
            this.panel_footer.Controls.Add(this.picLoading);
            this.panel_footer.Controls.Add(this.btSave);
            this.panel_footer.Controls.Add(this.btBackTo);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 539);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1050, 37);
            this.panel_footer.TabIndex = 4;
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Depth = 0;
            this.lbl_msg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_msg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_msg.Location = new System.Drawing.Point(174, 0);
            this.lbl_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_msg.Size = new System.Drawing.Size(132, 19);
            this.lbl_msg.TabIndex = 5;
            this.lbl_msg.Text = "Notification status";
            this.lbl_msg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLoading
            // 
            this.picLoading.Cursor = System.Windows.Forms.Cursors.Default;
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picLoading.Location = new System.Drawing.Point(122, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Padding = new System.Windows.Forms.Padding(5);
            this.picLoading.Size = new System.Drawing.Size(52, 37);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 4;
            this.picLoading.TabStop = false;
            // 
            // btSave
            // 
            this.btSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSave.Depth = 0;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.DrawShadows = true;
            this.btSave.HighEmphasis = true;
            this.btSave.Icon = global::WinForms.Properties.Resources.Save_32px;
            this.btSave.Location = new System.Drawing.Point(934, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(116, 37);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Guardar";
            this.btSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btSave.UseAccentColor = false;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // btBackTo
            // 
            this.btBackTo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btBackTo.Depth = 0;
            this.btBackTo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBackTo.DrawShadows = true;
            this.btBackTo.HighEmphasis = true;
            this.btBackTo.Icon = global::WinForms.Properties.Resources.BackTo_32px;
            this.btBackTo.Location = new System.Drawing.Point(0, 0);
            this.btBackTo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btBackTo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btBackTo.Name = "btBackTo";
            this.btBackTo.Size = new System.Drawing.Size(122, 37);
            this.btBackTo.TabIndex = 0;
            this.btBackTo.Text = "Regresar";
            this.btBackTo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btBackTo.UseAccentColor = false;
            this.btBackTo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialTabControl_container);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 483);
            this.panel1.TabIndex = 5;
            // 
            // fileImage
            // 
            this.fileImage.FileName = "Imágenes";
            this.fileImage.Filter = "Imágenes (*.JPEG;*.JPG;*.PNG)|*.JPEG;*.JPG;*.PNG|All files (*.*)|*.*";
            this.fileImage.Title = "Seleccionar imagen";
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(104, 37);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_footer);
            this.Controls.Add(this.materialTabSelector_tabs);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.materialTabControl_container.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            this.tabPage_Data.ResumeLayout(false);
            this.tabPage_Data.PerformLayout();
            this.tabPage_Links.ResumeLayout(false);
            this.tabPage_Links.PerformLayout();
            this.tabPage_discount.ResumeLayout(false);
            this.tabPage_discount.PerformLayout();
            this.contextMenu.ResumeLayout(false);
            this.tabPage_special.ResumeLayout(false);
            this.tabPage_special.PerformLayout();
            this.tabPage_images.ResumeLayout(false);
            this.tabPage_images.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxImage)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector_tabs;
        private System.Windows.Forms.Panel panel_footer;
        private MaterialSkin.Controls.MaterialButton btSave;
        private MaterialSkin.Controls.MaterialButton btBackTo;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl_container;
        private System.Windows.Forms.TabPage tabPage_General;
        private System.Windows.Forms.TabPage tabPage_Data;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPage_Links;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_relatedProducts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_categories;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabPage_discount;
        private MaterialSkin.Controls.MaterialButton btAddDiscount;
        private System.Windows.Forms.DateTimePicker dateTimePicker_discountDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_discountDateEnd;
        private MaterialSkin.Controls.MaterialTextBox txtBx_discountPrice;
        private MaterialSkin.Controls.MaterialTextBox txtBx_discountPriority;
        private MaterialSkin.Controls.MaterialTextBox txtBx_discountQuantity;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPage_special;
        private MaterialSkin.Controls.MaterialButton btAddOffer;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SpecDateStart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_SpecDateEnd;
        private MaterialSkin.Controls.MaterialTextBox txtBxSpecialPrice;
        private MaterialSkin.Controls.MaterialTextBox txtBxSpecialPriority;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TabPage tabPage_images;
        private MaterialSkin.Controls.MaterialButton btn_delImg;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.PictureBox picBxImage;
        private MaterialSkin.Controls.MaterialListView lstVwDiscounts;
        private System.Windows.Forms.TabControl tabControl_langs;
        private System.Windows.Forms.ColumnHeader headerOfferGroup;
        private System.Windows.Forms.ColumnHeader headerOfferPriority;
        private System.Windows.Forms.ColumnHeader headerOfferPrice;
        private System.Windows.Forms.ColumnHeader headerDiscGroup;
        private System.Windows.Forms.ColumnHeader headerDiscPrice;
        private System.Windows.Forms.ColumnHeader headerDiscQuantity;
        private System.Windows.Forms.ColumnHeader headerOfferDateStart;
        private System.Windows.Forms.ColumnHeader headerOfferDateEnd;
        private System.Windows.Forms.OpenFileDialog fileImage;
        private MaterialSkin.Controls.MaterialContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem removeToolStrip;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.ColumnHeader haederDiscPriority;
        private System.Windows.Forms.ColumnHeader headerDiscStartDate;
        private System.Windows.Forms.ColumnHeader headerDiscFinishDate;
        private System.Windows.Forms.Label lbl_ImgMsg;
        private Controls.ImageFlowPanel imagePanel;
        private MaterialSkin.Controls.MaterialListView lstVwOffers;
        private MaterialSkin.Controls.MaterialLabel lbl_msg;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_manufacturer;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_DisGroupCustomer;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_SpecGroupCustomer;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialButton btn_addImages;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_lengthClass;
        private MaterialSkin.Controls.MaterialTextBox txtBxWidth;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_stockStatus;
        private MaterialSkin.Controls.MaterialTextBox txtBxLength;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_taxclass;
        private MaterialSkin.Controls.MaterialComboBox cmbBx_weightClass;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private MaterialSkin.Controls.MaterialCheckbox chkBx_status;
        private MaterialSkin.Controls.MaterialCheckbox chkBxShippingRequired;
        private MaterialSkin.Controls.MaterialCheckbox chkBx_subtractStock;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mpn;
        private MaterialSkin.Controls.MaterialTextBox txtBx_price;
        private MaterialSkin.Controls.MaterialTextBox txtBxMinQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtBxQuantity;
        private MaterialSkin.Controls.MaterialTextBox txtBx_weight;
        private MaterialSkin.Controls.MaterialTextBox txtBx_location;
        private MaterialSkin.Controls.MaterialTextBox txtBx_isbn;
        private MaterialSkin.Controls.MaterialTextBox txtBx_jan;
        private MaterialSkin.Controls.MaterialTextBox txtBx_ean;
        private MaterialSkin.Controls.MaterialTextBox txtBx_upc;
        private MaterialSkin.Controls.MaterialTextBox txtBx_sku;
        private MaterialSkin.Controls.MaterialTextBox txtBx_model;
        private System.Windows.Forms.FlowLayoutPanel flwLytPnl_stores;
    }
}
