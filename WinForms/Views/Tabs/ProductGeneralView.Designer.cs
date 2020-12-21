namespace WinForms.Views.Tabs
{
    partial class ProductGeneralView
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
            this.txtBx_metaTagKeyWords = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBx_metaTagDesc = new MaterialSkin.Controls.MaterialTextBox();
            this.htmlwysiwyg_description = new WinForms.Controls.HTMLWYSIWYG();
            this.txtBx_Tags = new MaterialSkin.Controls.MaterialTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBx_metatagTitle = new MaterialSkin.Controls.MaterialTextBox();
            this.txtBxProductName = new MaterialSkin.Controls.MaterialTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtBx_metaTagKeyWords);
            this.panel1.Controls.Add(this.txtBx_metaTagDesc);
            this.panel1.Controls.Add(this.htmlwysiwyg_description);
            this.panel1.Controls.Add(this.txtBx_Tags);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtBx_metatagTitle);
            this.panel1.Controls.Add(this.txtBxProductName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 398);
            this.panel1.TabIndex = 0;
            // 
            // txtBx_metaTagKeyWords
            // 
            this.txtBx_metaTagKeyWords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_metaTagKeyWords.Depth = 0;
            this.txtBx_metaTagKeyWords.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_metaTagKeyWords.Hint = "Palabras clave del metatag";
            this.txtBx_metaTagKeyWords.Location = new System.Drawing.Point(55, 242);
            this.txtBx_metaTagKeyWords.MaxLength = 50;
            this.txtBx_metaTagKeyWords.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_metaTagKeyWords.Multiline = false;
            this.txtBx_metaTagKeyWords.Name = "txtBx_metaTagKeyWords";
            this.txtBx_metaTagKeyWords.Size = new System.Drawing.Size(310, 50);
            this.txtBx_metaTagKeyWords.TabIndex = 5;
            this.txtBx_metaTagKeyWords.Text = "";
            // 
            // txtBx_metaTagDesc
            // 
            this.txtBx_metaTagDesc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_metaTagDesc.Depth = 0;
            this.txtBx_metaTagDesc.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_metaTagDesc.Hint = "Descripción del metatag";
            this.txtBx_metaTagDesc.Location = new System.Drawing.Point(55, 168);
            this.txtBx_metaTagDesc.MaxLength = 50;
            this.txtBx_metaTagDesc.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_metaTagDesc.Multiline = false;
            this.txtBx_metaTagDesc.Name = "txtBx_metaTagDesc";
            this.txtBx_metaTagDesc.Size = new System.Drawing.Size(310, 50);
            this.txtBx_metaTagDesc.TabIndex = 4;
            this.txtBx_metaTagDesc.Text = "";
            // 
            // htmlwysiwyg_description
            // 
            this.htmlwysiwyg_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlwysiwyg_description.AutoScroll = true;
            this.htmlwysiwyg_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.htmlwysiwyg_description.Changed = false;
            this.htmlwysiwyg_description.HTML = null;
            this.htmlwysiwyg_description.Location = new System.Drawing.Point(422, 91);
            this.htmlwysiwyg_description.Name = "htmlwysiwyg_description";
            this.htmlwysiwyg_description.ShowAlignCenterButton = true;
            this.htmlwysiwyg_description.ShowAlignLeftButton = true;
            this.htmlwysiwyg_description.ShowAlignRightButton = true;
            this.htmlwysiwyg_description.ShowBackColorButton = true;
            this.htmlwysiwyg_description.ShowBolButton = true;
            this.htmlwysiwyg_description.ShowBulletButton = true;
            this.htmlwysiwyg_description.ShowCopyButton = true;
            this.htmlwysiwyg_description.ShowCutButton = true;
            this.htmlwysiwyg_description.ShowFontFamilyButton = false;
            this.htmlwysiwyg_description.ShowFontSizeButton = false;
            this.htmlwysiwyg_description.ShowIndentButton = true;
            this.htmlwysiwyg_description.ShowItalicButton = true;
            this.htmlwysiwyg_description.ShowJustifyButton = true;
            this.htmlwysiwyg_description.ShowLinkButton = true;
            this.htmlwysiwyg_description.ShowNewButton = false;
            this.htmlwysiwyg_description.ShowOrderedListButton = true;
            this.htmlwysiwyg_description.ShowOutdentButton = true;
            this.htmlwysiwyg_description.ShowPasteButton = true;
            this.htmlwysiwyg_description.ShowPrintButton = false;
            this.htmlwysiwyg_description.ShowTxtBGButton = true;
            this.htmlwysiwyg_description.ShowTxtColorButton = true;
            this.htmlwysiwyg_description.ShowUnderlineButton = true;
            this.htmlwysiwyg_description.ShowUnlinkButton = true;
            this.htmlwysiwyg_description.Size = new System.Drawing.Size(546, 278);
            this.htmlwysiwyg_description.TabIndex = 8;
            // 
            // txtBx_Tags
            // 
            this.txtBx_Tags.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_Tags.Depth = 0;
            this.txtBx_Tags.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_Tags.Hint = "Etiquetas";
            this.txtBx_Tags.Location = new System.Drawing.Point(422, 30);
            this.txtBx_Tags.MaxLength = 32767;
            this.txtBx_Tags.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_Tags.Multiline = false;
            this.txtBx_Tags.Name = "txtBx_Tags";
            this.txtBx_Tags.Size = new System.Drawing.Size(310, 50);
            this.txtBx_Tags.TabIndex = 6;
            this.txtBx_Tags.TabStop = false;
            this.txtBx_Tags.Text = "";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label8.Location = new System.Drawing.Point(896, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(37, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(37, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "*";
            // 
            // txtBx_metatagTitle
            // 
            this.txtBx_metatagTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_metatagTitle.Depth = 0;
            this.txtBx_metatagTitle.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBx_metatagTitle.Hint = "Título de metatag";
            this.txtBx_metatagTitle.Location = new System.Drawing.Point(55, 91);
            this.txtBx_metatagTitle.MaxLength = 32767;
            this.txtBx_metatagTitle.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBx_metatagTitle.Multiline = false;
            this.txtBx_metatagTitle.Name = "txtBx_metatagTitle";
            this.txtBx_metatagTitle.Size = new System.Drawing.Size(310, 50);
            this.txtBx_metatagTitle.TabIndex = 2;
            this.txtBx_metatagTitle.TabStop = false;
            this.txtBx_metatagTitle.Text = "";
            // 
            // txtBxProductName
            // 
            this.txtBxProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxProductName.Depth = 0;
            this.txtBxProductName.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtBxProductName.Hint = "Nombre del producto";
            this.txtBxProductName.Location = new System.Drawing.Point(55, 30);
            this.txtBxProductName.MaxLength = 32767;
            this.txtBxProductName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBxProductName.Multiline = false;
            this.txtBxProductName.Name = "txtBxProductName";
            this.txtBxProductName.Size = new System.Drawing.Size(310, 50);
            this.txtBxProductName.TabIndex = 0;
            this.txtBxProductName.TabStop = false;
            this.txtBxProductName.Text = "";
            // 
            // ProductGeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ProductGeneralView";
            this.Size = new System.Drawing.Size(1022, 398);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox txtBx_Tags;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialTextBox txtBx_metatagTitle;
        private MaterialSkin.Controls.MaterialTextBox txtBxProductName;
        private Controls.HTMLWYSIWYG htmlwysiwyg_description;
        private MaterialSkin.Controls.MaterialTextBox txtBx_metaTagKeyWords;
        private MaterialSkin.Controls.MaterialTextBox txtBx_metaTagDesc;
    }
}
