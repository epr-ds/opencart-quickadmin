namespace WinForms.Views
{
    partial class CustomersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_message = new LollipopLabel();
            this.pictureBox_iconSearch = new System.Windows.Forms.PictureBox();
            this.txtBxSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.btNext = new MaterialSkin.Controls.MaterialButton();
            this.btPrev = new MaterialSkin.Controls.MaterialButton();
            this.btEditCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btAddCustomer = new MaterialSkin.Controls.MaterialButton();
            this.btDeleteCustomer = new MaterialSkin.Controls.MaterialButton();
            this.lstVwCustomers = new MaterialSkin.Controls.MaterialListView();
            this.headerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lbl_message);
            this.panel1.Controls.Add(this.pictureBox_iconSearch);
            this.panel1.Controls.Add(this.txtBxSearch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btEditCustomer);
            this.panel1.Controls.Add(this.btAddCustomer);
            this.panel1.Controls.Add(this.btDeleteCustomer);
            this.panel1.Controls.Add(this.lstVwCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 600);
            this.panel1.TabIndex = 0;
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.BackColor = System.Drawing.Color.Transparent;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lbl_message.Location = new System.Drawing.Point(101, 494);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(65, 17);
            this.lbl_message.TabIndex = 11;
            this.lbl_message.Text = "Message";
            // 
            // pictureBox_iconSearch
            // 
            this.pictureBox_iconSearch.Image = global::WinForms.Properties.Resources.Search_32px;
            this.pictureBox_iconSearch.Location = new System.Drawing.Point(101, 45);
            this.pictureBox_iconSearch.Name = "pictureBox_iconSearch";
            this.pictureBox_iconSearch.Size = new System.Drawing.Size(53, 53);
            this.pictureBox_iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_iconSearch.TabIndex = 10;
            this.pictureBox_iconSearch.TabStop = false;
            // 
            // txtBxSearch
            // 
            this.txtBxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxSearch.Depth = 0;
            this.txtBxSearch.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxSearch.Hint = "Buscar...";
            this.txtBxSearch.Location = new System.Drawing.Point(160, 45);
            this.txtBxSearch.MaxLength = 32767;
            this.txtBxSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxSearch.Multiline = false;
            this.txtBxSearch.Name = "txtBxSearch";
            this.txtBxSearch.Size = new System.Drawing.Size(443, 50);
            this.txtBxSearch.TabIndex = 9;
            this.txtBxSearch.TabStop = false;
            this.txtBxSearch.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox_loading);
            this.panel2.Controls.Add(this.btNext);
            this.panel2.Controls.Add(this.btPrev);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 563);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(950, 37);
            this.panel2.TabIndex = 8;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox_loading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.pictureBox_loading.Location = new System.Drawing.Point(889, 0);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(61, 37);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_loading.TabIndex = 9;
            this.pictureBox_loading.TabStop = false;
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
            this.btNext.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
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
            this.btPrev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btPrev.UseAccentColor = false;
            this.btPrev.UseVisualStyleBackColor = true;
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEditCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEditCustomer.Depth = 0;
            this.btEditCustomer.DrawShadows = true;
            this.btEditCustomer.HighEmphasis = true;
            this.btEditCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("btEditCustomer.Icon")));
            this.btEditCustomer.Location = new System.Drawing.Point(862, 155);
            this.btEditCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btEditCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(44, 36);
            this.btEditCustomer.TabIndex = 6;
            this.btEditCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btEditCustomer.UseAccentColor = false;
            this.btEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddCustomer.Depth = 0;
            this.btAddCustomer.DrawShadows = true;
            this.btAddCustomer.HighEmphasis = true;
            this.btAddCustomer.Icon = ((System.Drawing.Image)(resources.GetObject("btAddCustomer.Icon")));
            this.btAddCustomer.Location = new System.Drawing.Point(862, 104);
            this.btAddCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAddCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(44, 36);
            this.btAddCustomer.TabIndex = 5;
            this.btAddCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAddCustomer.UseAccentColor = false;
            this.btAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btDeleteCustomer
            // 
            this.btDeleteCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDeleteCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteCustomer.Depth = 0;
            this.btDeleteCustomer.DrawShadows = true;
            this.btDeleteCustomer.HighEmphasis = true;
            this.btDeleteCustomer.Icon = global::WinForms.Properties.Resources.Denied_32px;
            this.btDeleteCustomer.Location = new System.Drawing.Point(862, 206);
            this.btDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btDeleteCustomer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btDeleteCustomer.Name = "btDeleteCustomer";
            this.btDeleteCustomer.Size = new System.Drawing.Size(44, 36);
            this.btDeleteCustomer.TabIndex = 7;
            this.btDeleteCustomer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btDeleteCustomer.UseAccentColor = false;
            this.btDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // lstVwCustomers
            // 
            this.lstVwCustomers.AllowColumnReorder = true;
            this.lstVwCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstVwCustomers.AutoSizeTable = false;
            this.lstVwCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstVwCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstVwCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerID,
            this.headerFullname,
            this.headerEmail,
            this.headerPhone});
            this.lstVwCustomers.Depth = 0;
            this.lstVwCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lstVwCustomers.FullRowSelect = true;
            this.lstVwCustomers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstVwCustomers.HideSelection = false;
            this.lstVwCustomers.Location = new System.Drawing.Point(101, 104);
            this.lstVwCustomers.MinimumSize = new System.Drawing.Size(200, 100);
            this.lstVwCustomers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lstVwCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.lstVwCustomers.MultiSelect = false;
            this.lstVwCustomers.Name = "lstVwCustomers";
            this.lstVwCustomers.OwnerDraw = true;
            this.lstVwCustomers.ShowGroups = false;
            this.lstVwCustomers.Size = new System.Drawing.Size(754, 383);
            this.lstVwCustomers.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.lstVwCustomers.TabIndex = 0;
            this.lstVwCustomers.UseCompatibleStateImageBehavior = false;
            this.lstVwCustomers.View = System.Windows.Forms.View.Details;
            // 
            // headerID
            // 
            this.headerID.Text = "ID";
            // 
            // headerFullname
            // 
            this.headerFullname.Text = "Nombre";
            this.headerFullname.Width = 300;
            // 
            // headerEmail
            // 
            this.headerEmail.Text = "Email";
            this.headerEmail.Width = 150;
            // 
            // headerPhone
            // 
            this.headerPhone.Text = "Teléfono";
            this.headerPhone.Width = 150;
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(950, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_iconSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialListView lstVwCustomers;
        private MaterialSkin.Controls.MaterialButton btEditCustomer;
        private MaterialSkin.Controls.MaterialButton btAddCustomer;
        private MaterialSkin.Controls.MaterialButton btDeleteCustomer;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton btNext;
        private MaterialSkin.Controls.MaterialButton btPrev;
        private System.Windows.Forms.PictureBox pictureBox_loading;
        private System.Windows.Forms.PictureBox pictureBox_iconSearch;
        private MaterialSkin.Controls.MaterialTextBox txtBxSearch;
        private System.Windows.Forms.ColumnHeader headerID;
        private System.Windows.Forms.ColumnHeader headerFullname;
        private System.Windows.Forms.ColumnHeader headerEmail;
        private System.Windows.Forms.ColumnHeader headerPhone;
        private LollipopLabel lbl_message;
    }
}
