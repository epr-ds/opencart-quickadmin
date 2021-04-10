namespace WinForms.Views
{
    partial class SettingsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsView));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btBackTo = new MaterialSkin.Controls.MaterialButton();
            this.lblNotification = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_msg = new MaterialSkin.Controls.MaterialLabel();
            this.btSave = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabSelectorSettings = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabSettings = new MaterialSkin.Controls.MaterialTabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.txtBx_printer = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btExport = new MaterialSkin.Controls.MaterialButton();
            this.btImport = new MaterialSkin.Controls.MaterialButton();
            this.chckBx_saveFile = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialLabel_printer = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel_template = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox_folder = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox_file = new System.Windows.Forms.PictureBox();
            this.label_saveFile_desc = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_file_desc = new System.Windows.Forms.Label();
            this.tabApi = new System.Windows.Forms.TabPage();
            this.btnLogin = new MaterialSkin.Controls.MaterialButton();
            this.chkBx_cache = new MaterialSkin.Controls.MaterialCheckbox();
            this.btSubtract = new MaterialSkin.Controls.MaterialButton();
            this.btAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBx_nItems = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_APIkey = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxUrl = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_APIusr = new MaterialSkin.Controls.MaterialTextBox();
            this.prgrssBr_minutes = new MaterialSkin.Controls.MaterialProgressBar();
            this.picProxy = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.tabMail = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBx_mailPort = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailSubject = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailHost = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailPwd = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_mailEmail = new MaterialSkin.Controls.MaterialTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderInput = new LollipopFolderInPut();
            this.fileInput = new LollipopFileInput();
            this.MailContent = new WinForms.Controls.HTMLWYSIWYG();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.btBackTo);
            this.panel2.Controls.Add(this.lblNotification);
            this.panel2.Controls.Add(this.lbl_msg);
            this.panel2.Controls.Add(this.btSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 560);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1003, 40);
            this.panel2.TabIndex = 2;
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
            this.btBackTo.Size = new System.Drawing.Size(122, 40);
            this.btBackTo.TabIndex = 27;
            this.btBackTo.Text = "Regresar";
            this.btBackTo.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btBackTo.UseAccentColor = false;
            this.btBackTo.UseVisualStyleBackColor = true;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Depth = 0;
            this.lblNotification.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNotification.Location = new System.Drawing.Point(125, 11);
            this.lblNotification.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNotification.Size = new System.Drawing.Size(84, 19);
            this.lblNotification.TabIndex = 26;
            this.lblNotification.Text = "Notification";
            // 
            // lbl_msg
            // 
            this.lbl_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Depth = 0;
            this.lbl_msg.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_msg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_msg.Location = new System.Drawing.Point(18, 5);
            this.lbl_msg.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(1, 0);
            this.lbl_msg.TabIndex = 25;
            // 
            // btSave
            // 
            this.btSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSave.Depth = 0;
            this.btSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSave.DrawShadows = true;
            this.btSave.HighEmphasis = true;
            this.btSave.Icon = global::WinForms.Properties.Resources.Save_32px;
            this.btSave.Location = new System.Drawing.Point(887, 0);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(116, 40);
            this.btSave.TabIndex = 4;
            this.btSave.Text = "Guardar";
            this.btSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btSave.UseAccentColor = false;
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 560);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabSelectorSettings);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabSettings);
            this.splitContainer1.Size = new System.Drawing.Size(1003, 560);
            this.splitContainer1.TabIndex = 1;
            // 
            // tabSelectorSettings
            // 
            this.tabSelectorSettings.BaseTabControl = this.tabSettings;
            this.tabSelectorSettings.Depth = 0;
            this.tabSelectorSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSelectorSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tabSelectorSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSelectorSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectorSettings.Name = "tabSelectorSettings";
            this.tabSelectorSettings.Size = new System.Drawing.Size(1003, 50);
            this.tabSelectorSettings.TabIndex = 1;
            this.tabSelectorSettings.Text = "Ajustes";
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabGeneral);
            this.tabSettings.Controls.Add(this.tabApi);
            this.tabSettings.Controls.Add(this.tabMail);
            this.tabSettings.Depth = 0;
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSettings.Multiline = true;
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Drawing.Point(0, 0);
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(1003, 506);
            this.tabSettings.TabIndex = 1;
            // 
            // tabGeneral
            // 
            this.tabGeneral.AutoScroll = true;
            this.tabGeneral.BackColor = System.Drawing.Color.White;
            this.tabGeneral.Controls.Add(this.folderInput);
            this.tabGeneral.Controls.Add(this.fileInput);
            this.tabGeneral.Controls.Add(this.txtBx_printer);
            this.tabGeneral.Controls.Add(this.materialLabel2);
            this.tabGeneral.Controls.Add(this.btExport);
            this.tabGeneral.Controls.Add(this.btImport);
            this.tabGeneral.Controls.Add(this.chckBx_saveFile);
            this.tabGeneral.Controls.Add(this.materialLabel_printer);
            this.tabGeneral.Controls.Add(this.materialLabel_template);
            this.tabGeneral.Controls.Add(this.pictureBox_folder);
            this.tabGeneral.Controls.Add(this.pictureBox4);
            this.tabGeneral.Controls.Add(this.pictureBox_file);
            this.tabGeneral.Controls.Add(this.label_saveFile_desc);
            this.tabGeneral.Controls.Add(this.label12);
            this.tabGeneral.Controls.Add(this.label_file_desc);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(995, 480);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.ToolTipText = "Ajustes generales de la aplicación";
            // 
            // txtBx_printer
            // 
            this.txtBx_printer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_printer.Depth = 0;
            this.txtBx_printer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_printer.Hint = "Nombre de la impresora";
            this.txtBx_printer.Location = new System.Drawing.Point(608, 118);
            this.txtBx_printer.MaxLength = 32767;
            this.txtBx_printer.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_printer.Multiline = false;
            this.txtBx_printer.Name = "txtBx_printer";
            this.txtBx_printer.Size = new System.Drawing.Size(308, 36);
            this.txtBx_printer.TabIndex = 17;
            this.txtBx_printer.TabStop = false;
            this.txtBx_printer.Text = "";
            this.txtBx_printer.UseTallSize = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel2.Location = new System.Drawing.Point(567, 251);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(229, 19);
            this.materialLabel2.TabIndex = 21;
            this.materialLabel2.Text = "Importar/Exportar configuración";
            // 
            // btExport
            // 
            this.btExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btExport.Depth = 0;
            this.btExport.DrawShadows = true;
            this.btExport.HighEmphasis = true;
            this.btExport.Icon = global::WinForms.Properties.Resources.Export_32px;
            this.btExport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btExport.Location = new System.Drawing.Point(793, 316);
            this.btExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btExport.Name = "btExport";
            this.btExport.Size = new System.Drawing.Size(123, 36);
            this.btExport.TabIndex = 23;
            this.btExport.Text = "Exportar";
            this.btExport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btExport.UseAccentColor = false;
            this.btExport.UseVisualStyleBackColor = false;
            // 
            // btImport
            // 
            this.btImport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btImport.Depth = 0;
            this.btImport.DrawShadows = true;
            this.btImport.HighEmphasis = true;
            this.btImport.Icon = global::WinForms.Properties.Resources.Import_32px;
            this.btImport.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btImport.Location = new System.Drawing.Point(570, 316);
            this.btImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btImport.Name = "btImport";
            this.btImport.Size = new System.Drawing.Size(123, 36);
            this.btImport.TabIndex = 22;
            this.btImport.Text = "Importar";
            this.btImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btImport.UseAccentColor = false;
            this.btImport.UseVisualStyleBackColor = false;
            // 
            // chckBx_saveFile
            // 
            this.chckBx_saveFile.AutoSize = true;
            this.chckBx_saveFile.Depth = 0;
            this.chckBx_saveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chckBx_saveFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chckBx_saveFile.Location = new System.Drawing.Point(56, 254);
            this.chckBx_saveFile.Margin = new System.Windows.Forms.Padding(0);
            this.chckBx_saveFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chckBx_saveFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.chckBx_saveFile.Name = "chckBx_saveFile";
            this.chckBx_saveFile.Ripple = true;
            this.chckBx_saveFile.Size = new System.Drawing.Size(262, 37);
            this.chckBx_saveFile.TabIndex = 18;
            this.chckBx_saveFile.Text = "Guardar comprobantes de venta";
            this.chckBx_saveFile.UseVisualStyleBackColor = true;
            // 
            // materialLabel_printer
            // 
            this.materialLabel_printer.AutoSize = true;
            this.materialLabel_printer.Depth = 0;
            this.materialLabel_printer.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_printer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_printer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel_printer.Location = new System.Drawing.Point(567, 58);
            this.materialLabel_printer.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_printer.Name = "materialLabel_printer";
            this.materialLabel_printer.Size = new System.Drawing.Size(72, 19);
            this.materialLabel_printer.TabIndex = 15;
            this.materialLabel_printer.Text = "Impresora";
            // 
            // materialLabel_template
            // 
            this.materialLabel_template.AutoSize = true;
            this.materialLabel_template.Depth = 0;
            this.materialLabel_template.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel_template.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel_template.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel_template.Location = new System.Drawing.Point(56, 58);
            this.materialLabel_template.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel_template.Name = "materialLabel_template";
            this.materialLabel_template.Size = new System.Drawing.Size(161, 19);
            this.materialLabel_template.TabIndex = 12;
            this.materialLabel_template.Text = "Comprobante de venta";
            // 
            // pictureBox_folder
            // 
            this.pictureBox_folder.Image = global::WinForms.Properties.Resources.Open_32px;
            this.pictureBox_folder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_folder.Location = new System.Drawing.Point(56, 320);
            this.pictureBox_folder.Name = "pictureBox_folder";
            this.pictureBox_folder.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_folder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_folder.TabIndex = 24;
            this.pictureBox_folder.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WinForms.Properties.Resources.print_32px;
            this.pictureBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox4.Location = new System.Drawing.Point(570, 121);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox_file
            // 
            this.pictureBox_file.Image = global::WinForms.Properties.Resources.Document_32px;
            this.pictureBox_file.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox_file.Location = new System.Drawing.Point(56, 121);
            this.pictureBox_file.Name = "pictureBox_file";
            this.pictureBox_file.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_file.TabIndex = 26;
            this.pictureBox_file.TabStop = false;
            // 
            // label_saveFile_desc
            // 
            this.label_saveFile_desc.AutoSize = true;
            this.label_saveFile_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_saveFile_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_saveFile_desc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_saveFile_desc.Location = new System.Drawing.Point(88, 288);
            this.label_saveFile_desc.Name = "label_saveFile_desc";
            this.label_saveFile_desc.Size = new System.Drawing.Size(319, 15);
            this.label_saveFile_desc.TabIndex = 19;
            this.label_saveFile_desc.Text = "Carpeta donde se almacenan los comprobantes de venta";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(586, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(245, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "Nombre de la impresora que se desea usar";
            // 
            // label_file_desc
            // 
            this.label_file_desc.AutoSize = true;
            this.label_file_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label_file_desc.ForeColor = System.Drawing.Color.DimGray;
            this.label_file_desc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_file_desc.Location = new System.Drawing.Point(88, 80);
            this.label_file_desc.Name = "label_file_desc";
            this.label_file_desc.Size = new System.Drawing.Size(330, 30);
            this.label_file_desc.TabIndex = 13;
            this.label_file_desc.Text = "Archivo que contiene el diseño y que es usado al momento \r\nde generar el comproba" +
    "nte de venta";
            // 
            // tabApi
            // 
            this.tabApi.BackColor = System.Drawing.Color.White;
            this.tabApi.Controls.Add(this.btnLogin);
            this.tabApi.Controls.Add(this.chkBx_cache);
            this.tabApi.Controls.Add(this.btSubtract);
            this.tabApi.Controls.Add(this.btAdd);
            this.tabApi.Controls.Add(this.materialLabel5);
            this.tabApi.Controls.Add(this.materialLabel8);
            this.tabApi.Controls.Add(this.materialLabel7);
            this.tabApi.Controls.Add(this.materialLabel6);
            this.tabApi.Controls.Add(this.txtBx_nItems);
            this.tabApi.Controls.Add(this.txtBx_APIkey);
            this.tabApi.Controls.Add(this.txtBxUrl);
            this.tabApi.Controls.Add(this.txtBx_APIusr);
            this.tabApi.Controls.Add(this.prgrssBr_minutes);
            this.tabApi.Controls.Add(this.picProxy);
            this.tabApi.Controls.Add(this.label9);
            this.tabApi.Controls.Add(this.label8);
            this.tabApi.Controls.Add(this.label1);
            this.tabApi.Controls.Add(this.pictureBox5);
            this.tabApi.Location = new System.Drawing.Point(4, 22);
            this.tabApi.Name = "tabApi";
            this.tabApi.Padding = new System.Windows.Forms.Padding(3);
            this.tabApi.Size = new System.Drawing.Size(995, 480);
            this.tabApi.TabIndex = 1;
            this.tabApi.Text = "API";
            this.tabApi.ToolTipText = "Ajustar la API";
            // 
            // btnLogin
            // 
            this.btnLogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogin.Depth = 0;
            this.btnLogin.DrawShadows = true;
            this.btnLogin.HighEmphasis = false;
            this.btnLogin.Icon = null;
            this.btnLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogin.Location = new System.Drawing.Point(57, 385);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(128, 36);
            this.btnLogin.TabIndex = 51;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLogin.UseAccentColor = false;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // chkBx_cache
            // 
            this.chkBx_cache.AutoSize = true;
            this.chkBx_cache.Depth = 0;
            this.chkBx_cache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkBx_cache.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkBx_cache.Location = new System.Drawing.Point(789, 234);
            this.chkBx_cache.Margin = new System.Windows.Forms.Padding(0);
            this.chkBx_cache.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkBx_cache.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkBx_cache.Name = "chkBx_cache";
            this.chkBx_cache.Ripple = true;
            this.chkBx_cache.Size = new System.Drawing.Size(115, 37);
            this.chkBx_cache.TabIndex = 52;
            this.chkBx_cache.Text = "Usar Cache";
            this.chkBx_cache.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkBx_cache.UseVisualStyleBackColor = true;
            // 
            // btSubtract
            // 
            this.btSubtract.AutoSize = false;
            this.btSubtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSubtract.Depth = 0;
            this.btSubtract.DrawShadows = true;
            this.btSubtract.HighEmphasis = true;
            this.btSubtract.Icon = null;
            this.btSubtract.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSubtract.Location = new System.Drawing.Point(555, 385);
            this.btSubtract.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btSubtract.MouseState = MaterialSkin.MouseState.HOVER;
            this.btSubtract.Name = "btSubtract";
            this.btSubtract.Size = new System.Drawing.Size(32, 32);
            this.btSubtract.TabIndex = 56;
            this.btSubtract.Text = "-";
            this.btSubtract.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btSubtract.UseAccentColor = false;
            this.btSubtract.UseVisualStyleBackColor = true;
            // 
            // btAdd
            // 
            this.btAdd.AutoSize = false;
            this.btAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAdd.Depth = 0;
            this.btAdd.DrawShadows = true;
            this.btAdd.HighEmphasis = true;
            this.btAdd.Icon = null;
            this.btAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btAdd.Location = new System.Drawing.Point(872, 385);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(32, 32);
            this.btAdd.TabIndex = 57;
            this.btAdd.Text = "+";
            this.btAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btAdd.UseAccentColor = false;
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel5.Location = new System.Drawing.Point(54, 250);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(131, 17);
            this.materialLabel5.TabIndex = 48;
            this.materialLabel5.Text = "Credencial de acceso";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel8.Location = new System.Drawing.Point(54, 136);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(27, 17);
            this.materialLabel8.TabIndex = 43;
            this.materialLabel8.Text = "URL";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.materialLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel7.Location = new System.Drawing.Point(555, 140);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(136, 17);
            this.materialLabel7.TabIndex = 46;
            this.materialLabel7.Text = "Elementos por página";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.Overline;
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel6.Location = new System.Drawing.Point(287, 140);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(117, 13);
            this.materialLabel6.TabIndex = 44;
            this.materialLabel6.Text = "URL de su tienda OpenCart";
            // 
            // txtBx_nItems
            // 
            this.txtBx_nItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_nItems.Depth = 0;
            this.txtBx_nItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_nItems.Hint = "20";
            this.txtBx_nItems.Location = new System.Drawing.Point(596, 160);
            this.txtBx_nItems.MaxLength = 32767;
            this.txtBx_nItems.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_nItems.Multiline = false;
            this.txtBx_nItems.Name = "txtBx_nItems";
            this.txtBx_nItems.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBx_nItems.Size = new System.Drawing.Size(58, 36);
            this.txtBx_nItems.TabIndex = 47;
            this.txtBx_nItems.TabStop = false;
            this.txtBx_nItems.Text = "";
            this.txtBx_nItems.UseTallSize = false;
            // 
            // txtBx_APIkey
            // 
            this.txtBx_APIkey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_APIkey.Depth = 0;
            this.txtBx_APIkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_APIkey.Hint = "Contraseña";
            this.txtBx_APIkey.Location = new System.Drawing.Point(57, 326);
            this.txtBx_APIkey.MaxLength = 32767;
            this.txtBx_APIkey.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_APIkey.Multiline = false;
            this.txtBx_APIkey.Name = "txtBx_APIkey";
            this.txtBx_APIkey.Password = true;
            this.txtBx_APIkey.Size = new System.Drawing.Size(347, 50);
            this.txtBx_APIkey.TabIndex = 50;
            this.txtBx_APIkey.TabStop = false;
            this.txtBx_APIkey.Text = "";
            // 
            // txtBxUrl
            // 
            this.txtBxUrl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxUrl.Depth = 0;
            this.txtBxUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBxUrl.Hint = "https://mystore.com/";
            this.txtBxUrl.Location = new System.Drawing.Point(57, 156);
            this.txtBxUrl.MaxLength = 32767;
            this.txtBxUrl.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxUrl.Multiline = false;
            this.txtBxUrl.Name = "txtBxUrl";
            this.txtBxUrl.Size = new System.Drawing.Size(347, 50);
            this.txtBxUrl.TabIndex = 45;
            this.txtBxUrl.TabStop = false;
            this.txtBxUrl.Text = "";
            // 
            // txtBx_APIusr
            // 
            this.txtBx_APIusr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_APIusr.Depth = 0;
            this.txtBx_APIusr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_APIusr.Hint = "Usuario";
            this.txtBx_APIusr.Location = new System.Drawing.Point(57, 270);
            this.txtBx_APIusr.MaxLength = 32767;
            this.txtBx_APIusr.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_APIusr.Multiline = false;
            this.txtBx_APIusr.Name = "txtBx_APIusr";
            this.txtBx_APIusr.Size = new System.Drawing.Size(347, 50);
            this.txtBx_APIusr.TabIndex = 49;
            this.txtBx_APIusr.TabStop = false;
            this.txtBx_APIusr.Text = "";
            // 
            // prgrssBr_minutes
            // 
            this.prgrssBr_minutes.Depth = 0;
            this.prgrssBr_minutes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.prgrssBr_minutes.Location = new System.Drawing.Point(555, 374);
            this.prgrssBr_minutes.Maximum = 50;
            this.prgrssBr_minutes.MouseState = MaterialSkin.MouseState.HOVER;
            this.prgrssBr_minutes.Name = "prgrssBr_minutes";
            this.prgrssBr_minutes.Size = new System.Drawing.Size(349, 5);
            this.prgrssBr_minutes.Step = 5;
            this.prgrssBr_minutes.TabIndex = 55;
            // 
            // picProxy
            // 
            this.picProxy.Image = global::WinForms.Properties.Resources.DownloadFromCloud_32px;
            this.picProxy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picProxy.Location = new System.Drawing.Point(558, 239);
            this.picProxy.Name = "picProxy";
            this.picProxy.Size = new System.Drawing.Size(32, 32);
            this.picProxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProxy.TabIndex = 59;
            this.picProxy.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(555, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 15);
            this.label9.TabIndex = 54;
            this.label9.Text = "Tiempo para la recarga de datos en cache";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(555, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(352, 30);
            this.label8.TabIndex = 53;
            this.label8.Text = "Al utilizar el servicio de Cache, la carga de datos se hace \r\nmás rápida pero no " +
    "garantiza que los datos estén actualizados.";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(989, 66);
            this.label1.TabIndex = 42;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinForms.Properties.Resources.BulletedList_32px;
            this.pictureBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox5.Location = new System.Drawing.Point(558, 162);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 58;
            this.pictureBox5.TabStop = false;
            // 
            // tabMail
            // 
            this.tabMail.AutoScroll = true;
            this.tabMail.BackColor = System.Drawing.Color.White;
            this.tabMail.Controls.Add(this.panel5);
            this.tabMail.Controls.Add(this.materialLabel4);
            this.tabMail.Controls.Add(this.materialLabel3);
            this.tabMail.Controls.Add(this.txtBx_mailPort);
            this.tabMail.Controls.Add(this.txtBx_mailSubject);
            this.tabMail.Controls.Add(this.txtBx_mailHost);
            this.tabMail.Controls.Add(this.txtBx_mailPwd);
            this.tabMail.Controls.Add(this.txtBx_mailEmail);
            this.tabMail.Controls.Add(this.label6);
            this.tabMail.Controls.Add(this.label2);
            this.tabMail.Location = new System.Drawing.Point(4, 22);
            this.tabMail.Name = "tabMail";
            this.tabMail.Size = new System.Drawing.Size(995, 480);
            this.tabMail.TabIndex = 2;
            this.tabMail.Text = "Correo";
            this.tabMail.ToolTipText = "Ajustes de correo electrónico";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.MailContent);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(978, 251);
            this.panel5.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(40, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mensaje de correo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel4.Location = new System.Drawing.Point(14, 60);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 19);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Servidor SMTP";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialLabel3.Location = new System.Drawing.Point(643, 60);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(91, 19);
            this.materialLabel3.TabIndex = 23;
            this.materialLabel3.Text = "Email cliente";
            // 
            // txtBx_mailPort
            // 
            this.txtBx_mailPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailPort.Depth = 0;
            this.txtBx_mailPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_mailPort.Hint = "Puerto";
            this.txtBx_mailPort.Location = new System.Drawing.Point(309, 82);
            this.txtBx_mailPort.MaxLength = 32767;
            this.txtBx_mailPort.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailPort.Multiline = false;
            this.txtBx_mailPort.Name = "txtBx_mailPort";
            this.txtBx_mailPort.Size = new System.Drawing.Size(85, 50);
            this.txtBx_mailPort.TabIndex = 22;
            this.txtBx_mailPort.TabStop = false;
            this.txtBx_mailPort.Text = "";
            // 
            // txtBx_mailSubject
            // 
            this.txtBx_mailSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailSubject.Depth = 0;
            this.txtBx_mailSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_mailSubject.Hint = "Asunto";
            this.txtBx_mailSubject.Location = new System.Drawing.Point(14, 196);
            this.txtBx_mailSubject.MaxLength = 32767;
            this.txtBx_mailSubject.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailSubject.Multiline = false;
            this.txtBx_mailSubject.Name = "txtBx_mailSubject";
            this.txtBx_mailSubject.Size = new System.Drawing.Size(380, 50);
            this.txtBx_mailSubject.TabIndex = 26;
            this.txtBx_mailSubject.TabStop = false;
            this.txtBx_mailSubject.Text = "";
            // 
            // txtBx_mailHost
            // 
            this.txtBx_mailHost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailHost.Depth = 0;
            this.txtBx_mailHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_mailHost.Hint = "Host/Dominio";
            this.txtBx_mailHost.Location = new System.Drawing.Point(14, 82);
            this.txtBx_mailHost.MaxLength = 32767;
            this.txtBx_mailHost.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailHost.Multiline = false;
            this.txtBx_mailHost.Name = "txtBx_mailHost";
            this.txtBx_mailHost.Size = new System.Drawing.Size(276, 50);
            this.txtBx_mailHost.TabIndex = 21;
            this.txtBx_mailHost.TabStop = false;
            this.txtBx_mailHost.Text = "";
            // 
            // txtBx_mailPwd
            // 
            this.txtBx_mailPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailPwd.Depth = 0;
            this.txtBx_mailPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_mailPwd.Hint = "Contraseña";
            this.txtBx_mailPwd.Location = new System.Drawing.Point(646, 156);
            this.txtBx_mailPwd.MaxLength = 32767;
            this.txtBx_mailPwd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailPwd.Multiline = false;
            this.txtBx_mailPwd.Name = "txtBx_mailPwd";
            this.txtBx_mailPwd.Size = new System.Drawing.Size(276, 50);
            this.txtBx_mailPwd.TabIndex = 25;
            this.txtBx_mailPwd.TabStop = false;
            this.txtBx_mailPwd.Text = "";
            // 
            // txtBx_mailEmail
            // 
            this.txtBx_mailEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_mailEmail.Depth = 0;
            this.txtBx_mailEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBx_mailEmail.Hint = "Correo electrónico";
            this.txtBx_mailEmail.Location = new System.Drawing.Point(646, 82);
            this.txtBx_mailEmail.MaxLength = 32767;
            this.txtBx_mailEmail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_mailEmail.Multiline = false;
            this.txtBx_mailEmail.Name = "txtBx_mailEmail";
            this.txtBx_mailEmail.Size = new System.Drawing.Size(276, 50);
            this.txtBx_mailEmail.TabIndex = 24;
            this.txtBx_mailEmail.TabStop = false;
            this.txtBx_mailEmail.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(224, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Asunto del mensaje de correo";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(978, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "El servicio de correo electrónico de la aplicación permite envíar correos en dete" +
    "rminadas situaciones.";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Archivo de configuración";
            this.openFileDialog.Filter = "Archivos INI|*.ini";
            this.openFileDialog.Title = "Importar archivo de configuración";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Archivos INI|*.ini";
            this.saveFileDialog.Title = "Exportar archivo de configuración";
            // 
            // folderInput
            // 
            this.folderInput.FocusedColor = "#508ef5";
            this.folderInput.FontColor = "#999999";
            this.folderInput.IsEnabled = true;
            this.folderInput.Location = new System.Drawing.Point(94, 328);
            this.folderInput.MaxLength = 32767;
            this.folderInput.Name = "folderInput";
            this.folderInput.ReadOnly = false;
            this.folderInput.Size = new System.Drawing.Size(323, 24);
            this.folderInput.TabIndex = 20;
            this.folderInput.Text = "Directorio";
            this.folderInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.folderInput.UseSystemPasswordChar = false;
            // 
            // fileInput
            // 
            this.fileInput.Filter = "HTML Files (*.html)|*.*";
            this.fileInput.FocusedColor = "#508ef5";
            this.fileInput.FontColor = "#999999";
            this.fileInput.IsEnabled = true;
            this.fileInput.Location = new System.Drawing.Point(94, 129);
            this.fileInput.MaxLength = 32767;
            this.fileInput.Name = "fileInput";
            this.fileInput.ReadOnly = false;
            this.fileInput.Size = new System.Drawing.Size(323, 24);
            this.fileInput.TabIndex = 14;
            this.fileInput.Text = "Archivo HTML";
            this.fileInput.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.fileInput.UseSystemPasswordChar = false;
            // 
            // MailContent
            // 
            this.MailContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MailContent.AutoScroll = true;
            this.MailContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MailContent.Changed = false;
            this.MailContent.HTML = null;
            this.MailContent.Location = new System.Drawing.Point(43, 31);
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
            this.MailContent.Size = new System.Drawing.Size(879, 192);
            this.MailContent.TabIndex = 1;
            // 
            // SettingsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(1003, 600);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
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

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lbl_msg;
        private MaterialSkin.Controls.MaterialButton btSave;
        private MaterialSkin.Controls.MaterialButton btBackTo;
        private MaterialSkin.Controls.MaterialLabel lblNotification;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectorSettings;
        private MaterialSkin.Controls.MaterialTabControl tabSettings;
        private System.Windows.Forms.TabPage tabGeneral;
        private LollipopFolderInPut folderInput;
        private LollipopFileInput fileInput;
        private MaterialSkin.Controls.MaterialTextBox txtBx_printer;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton btExport;
        private MaterialSkin.Controls.MaterialButton btImport;
        private MaterialSkin.Controls.MaterialCheckbox chckBx_saveFile;
        private MaterialSkin.Controls.MaterialLabel materialLabel_printer;
        private MaterialSkin.Controls.MaterialLabel materialLabel_template;
        private System.Windows.Forms.PictureBox pictureBox_folder;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox_file;
        private System.Windows.Forms.Label label_saveFile_desc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_file_desc;
        private System.Windows.Forms.TabPage tabApi;
        private System.Windows.Forms.TabPage tabMail;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialButton btnLogin;
        private MaterialSkin.Controls.MaterialCheckbox chkBx_cache;
        private MaterialSkin.Controls.MaterialButton btSubtract;
        private MaterialSkin.Controls.MaterialButton btAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtBx_nItems;
        private MaterialSkin.Controls.MaterialTextBox txtBx_APIkey;
        private MaterialSkin.Controls.MaterialTextBox txtBxUrl;
        private MaterialSkin.Controls.MaterialTextBox txtBx_APIusr;
        private MaterialSkin.Controls.MaterialProgressBar prgrssBr_minutes;
        private System.Windows.Forms.PictureBox picProxy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel5;
        private Controls.HTMLWYSIWYG MailContent;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailPort;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailSubject;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailHost;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailPwd;
        private MaterialSkin.Controls.MaterialTextBox txtBx_mailEmail;
        private System.Windows.Forms.Label label6;
    }
}
