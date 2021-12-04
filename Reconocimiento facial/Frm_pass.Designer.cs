
namespace Reconocimiento_facial
{
    partial class Frm_pass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.txtSitio = new MetroFramework.Controls.MetroTextBox();
            this.txtContra = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(270, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = " Sitio web";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView.Location = new System.Drawing.Point(24, 228);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(543, 342);
            this.dataGridView.TabIndex = 35;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(29, 169);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(167, 28);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 36;
            this.metroButton1.Text = "Agregar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(214, 169);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(167, 28);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 37;
            this.metroButton2.Text = "Eliminar";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(399, 169);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(167, 28);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 38;
            this.metroButton3.Text = "Actualizar";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // txtSitio
            // 
            // 
            // 
            // 
            this.txtSitio.CustomButton.Image = null;
            this.txtSitio.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtSitio.CustomButton.Name = "";
            this.txtSitio.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSitio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSitio.CustomButton.TabIndex = 1;
            this.txtSitio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSitio.CustomButton.UseSelectable = true;
            this.txtSitio.CustomButton.Visible = false;
            this.txtSitio.Lines = new string[0];
            this.txtSitio.Location = new System.Drawing.Point(23, 116);
            this.txtSitio.MaxLength = 32767;
            this.txtSitio.Name = "txtSitio";
            this.txtSitio.PasswordChar = '\0';
            this.txtSitio.PromptText = "www.dominio.com";
            this.txtSitio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSitio.SelectedText = "";
            this.txtSitio.SelectionLength = 0;
            this.txtSitio.SelectionStart = 0;
            this.txtSitio.ShortcutsEnabled = true;
            this.txtSitio.Size = new System.Drawing.Size(224, 27);
            this.txtSitio.TabIndex = 39;
            this.txtSitio.UseSelectable = true;
            this.txtSitio.WaterMark = "www.dominio.com";
            this.txtSitio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSitio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtContra
            // 
            // 
            // 
            // 
            this.txtContra.CustomButton.Image = null;
            this.txtContra.CustomButton.Location = new System.Drawing.Point(198, 1);
            this.txtContra.CustomButton.Name = "";
            this.txtContra.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtContra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContra.CustomButton.TabIndex = 1;
            this.txtContra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContra.CustomButton.UseSelectable = true;
            this.txtContra.CustomButton.Visible = false;
            this.txtContra.Lines = new string[0];
            this.txtContra.Location = new System.Drawing.Point(273, 116);
            this.txtContra.MaxLength = 32767;
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '\0';
            this.txtContra.PromptText = "******";
            this.txtContra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContra.SelectedText = "";
            this.txtContra.SelectionLength = 0;
            this.txtContra.SelectionStart = 0;
            this.txtContra.ShortcutsEnabled = true;
            this.txtContra.Size = new System.Drawing.Size(224, 27);
            this.txtContra.TabIndex = 40;
            this.txtContra.UseSelectable = true;
            this.txtContra.WaterMark = "******";
            this.txtContra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(374, 93);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 34;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblName.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(523, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 84;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 591);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtSitio);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_pass";
            this.Text = "Frm_pass";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_pass_FormClosing);
            this.Load += new System.EventHandler(this.Frm_pass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroTextBox txtSitio;
        private MetroFramework.Controls.MetroTextBox txtContra;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
    }
}