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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellView));
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_submain = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrders = new MaterialSkin.Controls.MaterialButton();
            this.btnStock = new MaterialSkin.Controls.MaterialButton();
            this.btnCustomers = new MaterialSkin.Controls.MaterialButton();
            this.btnSettings = new MaterialSkin.Controls.MaterialButton();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Name = "lblStatus";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel_submain);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel_submain
            // 
            resources.ApplyResources(this.panel_submain, "panel_submain");
            this.panel_submain.Name = "panel_submain";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnOrders);
            this.flowLayoutPanel1.Controls.Add(this.btnStock);
            this.flowLayoutPanel1.Controls.Add(this.btnCustomers);
            this.flowLayoutPanel1.Controls.Add(this.btnSettings);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // btnOrders
            // 
            resources.ApplyResources(this.btnOrders, "btnOrders");
            this.btnOrders.Depth = 0;
            this.btnOrders.DrawShadows = false;
            this.btnOrders.HighEmphasis = true;
            this.btnOrders.Icon = global::WinForms.Properties.Resources.Pricing_32px;
            this.btnOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnOrders.UseAccentColor = false;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            resources.ApplyResources(this.btnStock, "btnStock");
            this.btnStock.Depth = 0;
            this.btnStock.DrawShadows = false;
            this.btnStock.HighEmphasis = true;
            this.btnStock.Icon = global::WinForms.Properties.Resources.MultipleDevices_32px;
            this.btnStock.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStock.Name = "btnStock";
            this.btnStock.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnStock.UseAccentColor = false;
            this.btnStock.UseVisualStyleBackColor = true;
            // 
            // btnCustomers
            // 
            resources.ApplyResources(this.btnCustomers, "btnCustomers");
            this.btnCustomers.Depth = 0;
            this.btnCustomers.DrawShadows = false;
            this.btnCustomers.HighEmphasis = true;
            this.btnCustomers.Icon = global::WinForms.Properties.Resources.UserGroups_32px;
            this.btnCustomers.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnCustomers.UseAccentColor = false;
            this.btnCustomers.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            resources.ApplyResources(this.btnSettings, "btnSettings");
            this.btnSettings.Depth = 0;
            this.btnSettings.DrawShadows = false;
            this.btnSettings.HighEmphasis = true;
            this.btnSettings.Icon = global::WinForms.Properties.Resources.Services_32px;
            this.btnSettings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.btnSettings.UseAccentColor = false;
            this.btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel_main
            // 
            this.panel_main.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel_main, "panel_main");
            this.panel_main.Name = "panel_main";
            // 
            // ShellView
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.panel_main);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerUseColors = true;
            this.MaximizeBox = false;
            this.Name = "ShellView";
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_submain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnOrders;
        private MaterialSkin.Controls.MaterialButton btnStock;
        private MaterialSkin.Controls.MaterialButton btnCustomers;
        private MaterialSkin.Controls.MaterialButton btnSettings;
        private System.Windows.Forms.Panel panel_main;
    }
}

