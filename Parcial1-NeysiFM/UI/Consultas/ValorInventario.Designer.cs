namespace Parcial1_NeysiFM.UI.Consultas
{
    partial class ValorInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ValorInventario));
            this.MetroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.MetroTextBoxValorInventario = new MetroFramework.Controls.MetroTextBox();
            this.MetroTileRefrescar = new MetroFramework.Controls.MetroTile();
            this.MetroTileInicio = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // MetroLabel1
            // 
            this.MetroLabel1.AutoSize = true;
            this.MetroLabel1.BackColor = System.Drawing.Color.White;
            this.MetroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MetroLabel1.Location = new System.Drawing.Point(38, 98);
            this.MetroLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MetroLabel1.Name = "MetroLabel1";
            this.MetroLabel1.Size = new System.Drawing.Size(152, 19);
            this.MetroLabel1.TabIndex = 0;
            this.MetroLabel1.Text = "Valor Total de Inventario:";
            this.MetroLabel1.Click += new System.EventHandler(this.MetroLabel1_Click);
            // 
            // MetroTextBoxValorInventario
            // 
            // 
            // 
            // 
            this.MetroTextBoxValorInventario.CustomButton.Image = null;
            this.MetroTextBoxValorInventario.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.MetroTextBoxValorInventario.CustomButton.Name = "";
            this.MetroTextBoxValorInventario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.MetroTextBoxValorInventario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MetroTextBoxValorInventario.CustomButton.TabIndex = 1;
            this.MetroTextBoxValorInventario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MetroTextBoxValorInventario.CustomButton.UseSelectable = true;
            this.MetroTextBoxValorInventario.CustomButton.Visible = false;
            this.MetroTextBoxValorInventario.Enabled = false;
            this.MetroTextBoxValorInventario.Lines = new string[0];
            this.MetroTextBoxValorInventario.Location = new System.Drawing.Point(189, 98);
            this.MetroTextBoxValorInventario.MaxLength = 32767;
            this.MetroTextBoxValorInventario.Name = "MetroTextBoxValorInventario";
            this.MetroTextBoxValorInventario.PasswordChar = '\0';
            this.MetroTextBoxValorInventario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MetroTextBoxValorInventario.SelectedText = "";
            this.MetroTextBoxValorInventario.SelectionLength = 0;
            this.MetroTextBoxValorInventario.SelectionStart = 0;
            this.MetroTextBoxValorInventario.ShortcutsEnabled = true;
            this.MetroTextBoxValorInventario.Size = new System.Drawing.Size(101, 23);
            this.MetroTextBoxValorInventario.TabIndex = 1;
            this.MetroTextBoxValorInventario.UseSelectable = true;
            this.MetroTextBoxValorInventario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MetroTextBoxValorInventario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MetroTileRefrescar
            // 
            this.MetroTileRefrescar.ActiveControl = null;
            this.MetroTileRefrescar.AutoSize = true;
            this.MetroTileRefrescar.Location = new System.Drawing.Point(38, 131);
            this.MetroTileRefrescar.Name = "MetroTileRefrescar";
            this.MetroTileRefrescar.Size = new System.Drawing.Size(142, 89);
            this.MetroTileRefrescar.TabIndex = 2;
            this.MetroTileRefrescar.Text = "Refrescar";
            this.MetroTileRefrescar.TileImage = ((System.Drawing.Image)(resources.GetObject("MetroTileRefrescar.TileImage")));
            this.MetroTileRefrescar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroTileRefrescar.UseSelectable = true;
            this.MetroTileRefrescar.UseTileImage = true;
            this.MetroTileRefrescar.Click += new System.EventHandler(this.MetroTileRefrescar_Click);
            // 
            // MetroTileInicio
            // 
            this.MetroTileInicio.ActiveControl = null;
            this.MetroTileInicio.Location = new System.Drawing.Point(189, 131);
            this.MetroTileInicio.Name = "MetroTileInicio";
            this.MetroTileInicio.Size = new System.Drawing.Size(101, 89);
            this.MetroTileInicio.TabIndex = 0;
            this.MetroTileInicio.Text = "Inicio";
            this.MetroTileInicio.TileImage = ((System.Drawing.Image)(resources.GetObject("MetroTileInicio.TileImage")));
            this.MetroTileInicio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MetroTileInicio.UseSelectable = true;
            this.MetroTileInicio.UseTileImage = true;
            this.MetroTileInicio.Click += new System.EventHandler(this.MetroTileInicio_Click);
            // 
            // ValorInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 271);
            this.Controls.Add(this.MetroTileInicio);
            this.Controls.Add(this.MetroTileRefrescar);
            this.Controls.Add(this.MetroTextBoxValorInventario);
            this.Controls.Add(this.MetroLabel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ValorInventario";
            this.Padding = new System.Windows.Forms.Padding(33, 83, 33, 28);
            this.Text = "Ver Valor de Inventario";
            this.Load += new System.EventHandler(this.ValorInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel MetroLabel1;
        private MetroFramework.Controls.MetroTextBox MetroTextBoxValorInventario;
        private MetroFramework.Controls.MetroTile MetroTileRefrescar;
        private MetroFramework.Controls.MetroTile MetroTileInicio;
    }
}