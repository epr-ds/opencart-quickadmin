namespace WinForms.Views
{
    partial class CustomerView
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
            this.components = new System.ComponentModel.Container();
            this.toolTip_passwordRecovery = new System.Windows.Forms.ToolTip(this.components);
            this.btEmail = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBx_AFirstname = new MaterialSkin.Controls.MaterialTextBox();
            this.cmbBxZones = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbBxCountries = new MaterialSkin.Controls.MaterialComboBox();
            this.txtBxPostcode = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxCity = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxAddress2 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxAddress1 = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxCompany = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_ALastname = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.switchSafe = new MaterialSkin.Controls.MaterialSwitch();
            this.switchStatus = new MaterialSkin.Controls.MaterialSwitch();
            this.switchNewsletter = new MaterialSkin.Controls.MaterialSwitch();
            this.cmbBxGroupCustomers = new MaterialSkin.Controls.MaterialComboBox();
            this.lollipopLabel3 = new LollipopLabel();
            this.lollipopLabel2 = new LollipopLabel();
            this.lollipopLabel1 = new LollipopLabel();
            this.txtBx_telephone = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_email = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxCLastname = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxCFirstname = new MaterialSkin.Controls.MaterialTextBox();
            this.panel_footer = new System.Windows.Forms.Panel();
            this.lblNotification = new MaterialSkin.Controls.MaterialLabel();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.btBackTo = new MaterialSkin.Controls.MaterialButton();
            this.btSave = new MaterialSkin.Controls.MaterialButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_footer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // toolTip_passwordRecovery
            // 
            this.toolTip_passwordRecovery.Tag = "";
            this.toolTip_passwordRecovery.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_passwordRecovery.ToolTipTitle = "Enviar correo";
            // 
            // btEmail
            // 
            this.btEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btEmail.Depth = 0;
            this.btEmail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btEmail.DrawShadows = true;
            this.btEmail.Enabled = false;
            this.btEmail.HighEmphasis = true;
            this.btEmail.Icon = global::WinForms.Properties.Resources.Envelope_32px;
            this.btEmail.Location = new System.Drawing.Point(890, 0);
            this.btEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(44, 38);
            this.btEmail.TabIndex = 1;
            this.toolTip_passwordRecovery.SetToolTip(this.btEmail, "Enviar Email de bienvenida");
            this.btEmail.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btEmail.UseAccentColor = false;
            this.btEmail.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_footer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 576);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.txtBx_AFirstname);
            this.panel2.Controls.Add(this.cmbBxZones);
            this.panel2.Controls.Add(this.cmbBxCountries);
            this.panel2.Controls.Add(this.txtBxPostcode);
            this.panel2.Controls.Add(this.txtBxCity);
            this.panel2.Controls.Add(this.txtBxAddress2);
            this.panel2.Controls.Add(this.txtBxAddress1);
            this.panel2.Controls.Add(this.txtBxCompany);
            this.panel2.Controls.Add(this.txtBx_ALastname);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.switchSafe);
            this.panel2.Controls.Add(this.switchStatus);
            this.panel2.Controls.Add(this.switchNewsletter);
            this.panel2.Controls.Add(this.cmbBxGroupCustomers);
            this.panel2.Controls.Add(this.lollipopLabel3);
            this.panel2.Controls.Add(this.lollipopLabel2);
            this.panel2.Controls.Add(this.lollipopLabel1);
            this.panel2.Controls.Add(this.txtBx_telephone);
            this.panel2.Controls.Add(this.txtBx_email);
            this.panel2.Controls.Add(this.txtBxCLastname);
            this.panel2.Controls.Add(this.txtBxCFirstname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1050, 538);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WinForms.Properties.Resources.Address_32px;
            this.pictureBox2.Location = new System.Drawing.Point(492, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 91;
            this.pictureBox2.TabStop = false;
            // 
            // txtBx_AFirstname
            // 
            this.txtBx_AFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_AFirstname.Depth = 0;
            this.txtBx_AFirstname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_AFirstname.Hint = "Nombre";
            this.txtBx_AFirstname.Location = new System.Drawing.Point(492, 97);
            this.txtBx_AFirstname.MaxLength = 32767;
            this.txtBx_AFirstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_AFirstname.Multiline = false;
            this.txtBx_AFirstname.Name = "txtBx_AFirstname";
            this.txtBx_AFirstname.Size = new System.Drawing.Size(171, 36);
            this.txtBx_AFirstname.TabIndex = 11;
            this.txtBx_AFirstname.TabStop = false;
            this.txtBx_AFirstname.Text = "";
            this.txtBx_AFirstname.UseTallSize = false;
            // 
            // cmbBxZones
            // 
            this.cmbBxZones.AutoResize = false;
            this.cmbBxZones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBxZones.Depth = 0;
            this.cmbBxZones.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBxZones.DropDownHeight = 118;
            this.cmbBxZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxZones.DropDownWidth = 121;
            this.cmbBxZones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBxZones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBxZones.FormattingEnabled = true;
            this.cmbBxZones.Hint = "Estado/Región";
            this.cmbBxZones.IntegralHeight = false;
            this.cmbBxZones.ItemHeight = 29;
            this.cmbBxZones.Location = new System.Drawing.Point(669, 382);
            this.cmbBxZones.MaxDropDownItems = 4;
            this.cmbBxZones.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBxZones.Name = "cmbBxZones";
            this.cmbBxZones.Size = new System.Drawing.Size(177, 35);
            this.cmbBxZones.TabIndex = 19;
            this.cmbBxZones.UseTallSize = false;
            // 
            // cmbBxCountries
            // 
            this.cmbBxCountries.AutoResize = false;
            this.cmbBxCountries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBxCountries.Depth = 0;
            this.cmbBxCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBxCountries.DropDownHeight = 118;
            this.cmbBxCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxCountries.DropDownWidth = 121;
            this.cmbBxCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBxCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBxCountries.FormattingEnabled = true;
            this.cmbBxCountries.Hint = "País";
            this.cmbBxCountries.IntegralHeight = false;
            this.cmbBxCountries.ItemHeight = 29;
            this.cmbBxCountries.Location = new System.Drawing.Point(492, 382);
            this.cmbBxCountries.MaxDropDownItems = 4;
            this.cmbBxCountries.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBxCountries.Name = "cmbBxCountries";
            this.cmbBxCountries.Size = new System.Drawing.Size(171, 35);
            this.cmbBxCountries.TabIndex = 18;
            this.cmbBxCountries.UseTallSize = false;
            // 
            // txtBxPostcode
            // 
            this.txtBxPostcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxPostcode.Depth = 0;
            this.txtBxPostcode.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxPostcode.Hint = "Código Postal";
            this.txtBxPostcode.Location = new System.Drawing.Point(669, 327);
            this.txtBxPostcode.MaxLength = 32767;
            this.txtBxPostcode.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxPostcode.Multiline = false;
            this.txtBxPostcode.Name = "txtBxPostcode";
            this.txtBxPostcode.Size = new System.Drawing.Size(177, 36);
            this.txtBxPostcode.TabIndex = 17;
            this.txtBxPostcode.TabStop = false;
            this.txtBxPostcode.Text = "";
            this.txtBxPostcode.UseTallSize = false;
            // 
            // txtBxCity
            // 
            this.txtBxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCity.Depth = 0;
            this.txtBxCity.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxCity.Hint = "Ciudad";
            this.txtBxCity.Location = new System.Drawing.Point(492, 327);
            this.txtBxCity.MaxLength = 32767;
            this.txtBxCity.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxCity.Multiline = false;
            this.txtBxCity.Name = "txtBxCity";
            this.txtBxCity.Size = new System.Drawing.Size(171, 36);
            this.txtBxCity.TabIndex = 16;
            this.txtBxCity.TabStop = false;
            this.txtBxCity.Text = "";
            this.txtBxCity.UseTallSize = false;
            // 
            // txtBxAddress2
            // 
            this.txtBxAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxAddress2.Depth = 0;
            this.txtBxAddress2.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxAddress2.Hint = "Domicilio #2";
            this.txtBxAddress2.Location = new System.Drawing.Point(492, 269);
            this.txtBxAddress2.MaxLength = 32767;
            this.txtBxAddress2.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxAddress2.Multiline = false;
            this.txtBxAddress2.Name = "txtBxAddress2";
            this.txtBxAddress2.Size = new System.Drawing.Size(354, 36);
            this.txtBxAddress2.TabIndex = 15;
            this.txtBxAddress2.TabStop = false;
            this.txtBxAddress2.Text = "";
            this.txtBxAddress2.UseTallSize = false;
            // 
            // txtBxAddress1
            // 
            this.txtBxAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxAddress1.Depth = 0;
            this.txtBxAddress1.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxAddress1.Hint = "Domicilio #1";
            this.txtBxAddress1.Location = new System.Drawing.Point(492, 211);
            this.txtBxAddress1.MaxLength = 32767;
            this.txtBxAddress1.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxAddress1.Multiline = false;
            this.txtBxAddress1.Name = "txtBxAddress1";
            this.txtBxAddress1.Size = new System.Drawing.Size(354, 36);
            this.txtBxAddress1.TabIndex = 14;
            this.txtBxAddress1.TabStop = false;
            this.txtBxAddress1.Text = "";
            this.txtBxAddress1.UseTallSize = false;
            // 
            // txtBxCompany
            // 
            this.txtBxCompany.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCompany.Depth = 0;
            this.txtBxCompany.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxCompany.Hint = "Compañía";
            this.txtBxCompany.Location = new System.Drawing.Point(492, 153);
            this.txtBxCompany.MaxLength = 32767;
            this.txtBxCompany.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxCompany.Multiline = false;
            this.txtBxCompany.Name = "txtBxCompany";
            this.txtBxCompany.Size = new System.Drawing.Size(354, 36);
            this.txtBxCompany.TabIndex = 13;
            this.txtBxCompany.TabStop = false;
            this.txtBxCompany.Text = "";
            this.txtBxCompany.UseTallSize = false;
            // 
            // txtBx_ALastname
            // 
            this.txtBx_ALastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_ALastname.Depth = 0;
            this.txtBx_ALastname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_ALastname.Hint = "Apellido";
            this.txtBx_ALastname.Location = new System.Drawing.Point(669, 97);
            this.txtBx_ALastname.MaxLength = 32767;
            this.txtBx_ALastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_ALastname.Multiline = false;
            this.txtBx_ALastname.Name = "txtBx_ALastname";
            this.txtBx_ALastname.Size = new System.Drawing.Size(177, 36);
            this.txtBx_ALastname.TabIndex = 12;
            this.txtBx_ALastname.TabStop = false;
            this.txtBx_ALastname.Text = "";
            this.txtBx_ALastname.UseTallSize = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinForms.Properties.Resources.ContactDetails_32px;
            this.pictureBox1.Location = new System.Drawing.Point(60, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // switchSafe
            // 
            this.switchSafe.AutoSize = true;
            this.switchSafe.Depth = 0;
            this.switchSafe.Location = new System.Drawing.Point(349, 401);
            this.switchSafe.Margin = new System.Windows.Forms.Padding(0);
            this.switchSafe.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchSafe.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchSafe.Name = "switchSafe";
            this.switchSafe.Ripple = true;
            this.switchSafe.Size = new System.Drawing.Size(58, 37);
            this.switchSafe.TabIndex = 10;
            this.switchSafe.UseVisualStyleBackColor = true;
            // 
            // switchStatus
            // 
            this.switchStatus.AutoSize = true;
            this.switchStatus.Depth = 0;
            this.switchStatus.Location = new System.Drawing.Point(199, 401);
            this.switchStatus.Margin = new System.Windows.Forms.Padding(0);
            this.switchStatus.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchStatus.Name = "switchStatus";
            this.switchStatus.Ripple = true;
            this.switchStatus.Size = new System.Drawing.Size(58, 37);
            this.switchStatus.TabIndex = 8;
            this.switchStatus.UseVisualStyleBackColor = true;
            // 
            // switchNewsletter
            // 
            this.switchNewsletter.AutoSize = true;
            this.switchNewsletter.Depth = 0;
            this.switchNewsletter.Location = new System.Drawing.Point(59, 401);
            this.switchNewsletter.Margin = new System.Windows.Forms.Padding(0);
            this.switchNewsletter.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchNewsletter.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchNewsletter.Name = "switchNewsletter";
            this.switchNewsletter.Ripple = true;
            this.switchNewsletter.Size = new System.Drawing.Size(58, 37);
            this.switchNewsletter.TabIndex = 6;
            this.switchNewsletter.UseVisualStyleBackColor = true;
            // 
            // cmbBxGroupCustomers
            // 
            this.cmbBxGroupCustomers.AutoResize = false;
            this.cmbBxGroupCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbBxGroupCustomers.Depth = 0;
            this.cmbBxGroupCustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbBxGroupCustomers.DropDownHeight = 118;
            this.cmbBxGroupCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxGroupCustomers.DropDownWidth = 121;
            this.cmbBxGroupCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbBxGroupCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbBxGroupCustomers.FormattingEnabled = true;
            this.cmbBxGroupCustomers.Hint = "Grupo del cliente";
            this.cmbBxGroupCustomers.IntegralHeight = false;
            this.cmbBxGroupCustomers.ItemHeight = 29;
            this.cmbBxGroupCustomers.Location = new System.Drawing.Point(60, 96);
            this.cmbBxGroupCustomers.MaxDropDownItems = 4;
            this.cmbBxGroupCustomers.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbBxGroupCustomers.Name = "cmbBxGroupCustomers";
            this.cmbBxGroupCustomers.Size = new System.Drawing.Size(347, 35);
            this.cmbBxGroupCustomers.TabIndex = 0;
            this.cmbBxGroupCustomers.UseTallSize = false;
            // 
            // lollipopLabel3
            // 
            this.lollipopLabel3.AutoSize = true;
            this.lollipopLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel3.Location = new System.Drawing.Point(351, 382);
            this.lollipopLabel3.Name = "lollipopLabel3";
            this.lollipopLabel3.Size = new System.Drawing.Size(54, 17);
            this.lollipopLabel3.TabIndex = 9;
            this.lollipopLabel3.Text = "Seguro";
            // 
            // lollipopLabel2
            // 
            this.lollipopLabel2.AutoSize = true;
            this.lollipopLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel2.Location = new System.Drawing.Point(202, 382);
            this.lollipopLabel2.Name = "lollipopLabel2";
            this.lollipopLabel2.Size = new System.Drawing.Size(52, 17);
            this.lollipopLabel2.TabIndex = 7;
            this.lollipopLabel2.Text = "Estado";
            // 
            // lollipopLabel1
            // 
            this.lollipopLabel1.AutoSize = true;
            this.lollipopLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lollipopLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lollipopLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lollipopLabel1.Location = new System.Drawing.Point(63, 382);
            this.lollipopLabel1.Name = "lollipopLabel1";
            this.lollipopLabel1.Size = new System.Drawing.Size(51, 17);
            this.lollipopLabel1.TabIndex = 5;
            this.lollipopLabel1.Text = "Boletín";
            // 
            // txtBx_telephone
            // 
            this.txtBx_telephone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_telephone.Depth = 0;
            this.txtBx_telephone.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_telephone.Hint = "Teléfono";
            this.txtBx_telephone.Location = new System.Drawing.Point(60, 327);
            this.txtBx_telephone.MaxLength = 32767;
            this.txtBx_telephone.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_telephone.Multiline = false;
            this.txtBx_telephone.Name = "txtBx_telephone";
            this.txtBx_telephone.Size = new System.Drawing.Size(347, 36);
            this.txtBx_telephone.TabIndex = 4;
            this.txtBx_telephone.TabStop = false;
            this.txtBx_telephone.Text = "";
            this.txtBx_telephone.UseTallSize = false;
            // 
            // txtBx_email
            // 
            this.txtBx_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_email.Depth = 0;
            this.txtBx_email.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_email.Hint = "E-Mail";
            this.txtBx_email.Location = new System.Drawing.Point(58, 269);
            this.txtBx_email.MaxLength = 32767;
            this.txtBx_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_email.Multiline = false;
            this.txtBx_email.Name = "txtBx_email";
            this.txtBx_email.Size = new System.Drawing.Size(347, 36);
            this.txtBx_email.TabIndex = 3;
            this.txtBx_email.TabStop = false;
            this.txtBx_email.Text = "";
            this.txtBx_email.UseTallSize = false;
            // 
            // txtBxCLastname
            // 
            this.txtBxCLastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCLastname.Depth = 0;
            this.txtBxCLastname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxCLastname.Hint = "Apellido";
            this.txtBxCLastname.Location = new System.Drawing.Point(60, 211);
            this.txtBxCLastname.MaxLength = 32767;
            this.txtBxCLastname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxCLastname.Multiline = false;
            this.txtBxCLastname.Name = "txtBxCLastname";
            this.txtBxCLastname.Size = new System.Drawing.Size(347, 36);
            this.txtBxCLastname.TabIndex = 2;
            this.txtBxCLastname.TabStop = false;
            this.txtBxCLastname.Text = "";
            this.txtBxCLastname.UseTallSize = false;
            // 
            // txtBxCFirstname
            // 
            this.txtBxCFirstname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxCFirstname.Depth = 0;
            this.txtBxCFirstname.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxCFirstname.Hint = "Nombre";
            this.txtBxCFirstname.Location = new System.Drawing.Point(60, 153);
            this.txtBxCFirstname.MaxLength = 32767;
            this.txtBxCFirstname.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxCFirstname.Multiline = false;
            this.txtBxCFirstname.Name = "txtBxCFirstname";
            this.txtBxCFirstname.Size = new System.Drawing.Size(347, 36);
            this.txtBxCFirstname.TabIndex = 1;
            this.txtBxCFirstname.TabStop = false;
            this.txtBxCFirstname.Text = "";
            this.txtBxCFirstname.UseTallSize = false;
            // 
            // panel_footer
            // 
            this.panel_footer.Controls.Add(this.lblNotification);
            this.panel_footer.Controls.Add(this.picLoading);
            this.panel_footer.Controls.Add(this.btEmail);
            this.panel_footer.Controls.Add(this.btBackTo);
            this.panel_footer.Controls.Add(this.btSave);
            this.panel_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_footer.Location = new System.Drawing.Point(0, 538);
            this.panel_footer.Name = "panel_footer";
            this.panel_footer.Size = new System.Drawing.Size(1050, 38);
            this.panel_footer.TabIndex = 3;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Depth = 0;
            this.lblNotification.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNotification.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotification.Location = new System.Drawing.Point(168, 0);
            this.lblNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotification.Size = new System.Drawing.Size(84, 19);
            this.lblNotification.TabIndex = 3;
            this.lblNotification.Text = "Notification";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picLoading
            // 
            this.picLoading.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLoading.Image = global::WinForms.Properties.Resources.loading_squares;
            this.picLoading.Location = new System.Drawing.Point(122, 0);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(46, 38);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading.TabIndex = 9;
            this.picLoading.TabStop = false;
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
            this.btBackTo.Size = new System.Drawing.Size(122, 38);
            this.btBackTo.TabIndex = 0;
            this.btBackTo.Text = "Regresar";
            this.btBackTo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btBackTo.UseAccentColor = false;
            this.btBackTo.UseVisualStyleBackColor = true;
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
            this.btSave.Size = new System.Drawing.Size(116, 38);
            this.btSave.TabIndex = 2;
            this.btSave.Text = "Guardar";
            this.btSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btSave.UseAccentColor = false;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "CustomerView";
            this.Size = new System.Drawing.Size(1050, 576);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_footer.ResumeLayout(false);
            this.panel_footer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip_passwordRecovery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_footer;
        private MaterialSkin.Controls.MaterialLabel lblNotification;
        private System.Windows.Forms.PictureBox picLoading;
        private MaterialSkin.Controls.MaterialButton btEmail;
        private MaterialSkin.Controls.MaterialButton btBackTo;
        private MaterialSkin.Controls.MaterialButton btSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTextBox txtBx_AFirstname;
        private MaterialSkin.Controls.MaterialComboBox cmbBxZones;
        private MaterialSkin.Controls.MaterialComboBox cmbBxCountries;
        private MaterialSkin.Controls.MaterialTextBox txtBxPostcode;
        private MaterialSkin.Controls.MaterialTextBox txtBxCity;
        private MaterialSkin.Controls.MaterialTextBox txtBxAddress2;
        private MaterialSkin.Controls.MaterialTextBox txtBxAddress1;
        private MaterialSkin.Controls.MaterialTextBox txtBxCompany;
        private MaterialSkin.Controls.MaterialTextBox txtBx_ALastname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSwitch switchSafe;
        private MaterialSkin.Controls.MaterialSwitch switchStatus;
        private MaterialSkin.Controls.MaterialSwitch switchNewsletter;
        private MaterialSkin.Controls.MaterialComboBox cmbBxGroupCustomers;
        private LollipopLabel lollipopLabel3;
        private LollipopLabel lollipopLabel2;
        private LollipopLabel lollipopLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtBx_telephone;
        private MaterialSkin.Controls.MaterialTextBox txtBx_email;
        private MaterialSkin.Controls.MaterialTextBox txtBxCLastname;
        private MaterialSkin.Controls.MaterialTextBox txtBxCFirstname;
    }
}
