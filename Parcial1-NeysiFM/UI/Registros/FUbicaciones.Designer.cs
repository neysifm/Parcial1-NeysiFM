namespace Parcial1_NeysiFM.UI.Registros
{
    partial class FUbicaciones
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BuscarmetroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.DescripcionmetroTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.GuardarmetroButton3 = new MetroFramework.Controls.MetroButton();
            this.EliminarmetroButton4 = new MetroFramework.Controls.MetroButton();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(52, 109);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(24, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "ID:";
            // 
            // BuscarmetroButton1
            // 
            this.BuscarmetroButton1.Location = new System.Drawing.Point(180, 108);
            this.BuscarmetroButton1.Name = "BuscarmetroButton1";
            this.BuscarmetroButton1.Size = new System.Drawing.Size(75, 23);
            this.BuscarmetroButton1.TabIndex = 2;
            this.BuscarmetroButton1.Text = "Buscar";
            this.BuscarmetroButton1.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(135, 167);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Descripcion";
            this.metroLabel2.Click += new System.EventHandler(this.MetroLabel2_Click);
            // 
            // DescripcionmetroTextBox
            // 
            // 
            // 
            // 
            this.DescripcionmetroTextBox.CustomButton.Image = null;
            this.DescripcionmetroTextBox.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.DescripcionmetroTextBox.CustomButton.Name = "";
            this.DescripcionmetroTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DescripcionmetroTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DescripcionmetroTextBox.CustomButton.TabIndex = 1;
            this.DescripcionmetroTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DescripcionmetroTextBox.CustomButton.UseSelectable = true;
            this.DescripcionmetroTextBox.CustomButton.Visible = false;
            this.DescripcionmetroTextBox.Lines = new string[0];
            this.DescripcionmetroTextBox.Location = new System.Drawing.Point(52, 189);
            this.DescripcionmetroTextBox.MaxLength = 32767;
            this.DescripcionmetroTextBox.Name = "DescripcionmetroTextBox";
            this.DescripcionmetroTextBox.PasswordChar = '\0';
            this.DescripcionmetroTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DescripcionmetroTextBox.SelectedText = "";
            this.DescripcionmetroTextBox.SelectionLength = 0;
            this.DescripcionmetroTextBox.SelectionStart = 0;
            this.DescripcionmetroTextBox.ShortcutsEnabled = true;
            this.DescripcionmetroTextBox.Size = new System.Drawing.Size(265, 23);
            this.DescripcionmetroTextBox.TabIndex = 4;
            this.DescripcionmetroTextBox.UseSelectable = true;
            this.DescripcionmetroTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DescripcionmetroTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(52, 259);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 23);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Nuevo";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // GuardarmetroButton3
            // 
            this.GuardarmetroButton3.Location = new System.Drawing.Point(149, 259);
            this.GuardarmetroButton3.Name = "GuardarmetroButton3";
            this.GuardarmetroButton3.Size = new System.Drawing.Size(75, 23);
            this.GuardarmetroButton3.TabIndex = 6;
            this.GuardarmetroButton3.Text = "Guardar";
            this.GuardarmetroButton3.UseSelectable = true;
            this.GuardarmetroButton3.Click += new System.EventHandler(this.GuardarmetroButton3_Click);
            // 
            // EliminarmetroButton4
            // 
            this.EliminarmetroButton4.Location = new System.Drawing.Point(242, 259);
            this.EliminarmetroButton4.Name = "EliminarmetroButton4";
            this.EliminarmetroButton4.Size = new System.Drawing.Size(75, 23);
            this.EliminarmetroButton4.TabIndex = 7;
            this.EliminarmetroButton4.Text = "Eliminar";
            this.EliminarmetroButton4.UseSelectable = true;
            this.EliminarmetroButton4.Click += new System.EventHandler(this.MetroButton4_Click);
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(83, 108);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.IdnumericUpDown.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Ubicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 330);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.EliminarmetroButton4);
            this.Controls.Add(this.GuardarmetroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.DescripcionmetroTextBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.BuscarmetroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Ubicaciones";
            this.Text = "Ubicaciones de los Productos";
            this.Load += new System.EventHandler(this.Ubicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BuscarmetroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox DescripcionmetroTextBox;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton GuardarmetroButton3;
        private MetroFramework.Controls.MetroButton EliminarmetroButton4;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}