namespace Reconocimiento_facial
{
    partial class Frm_Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Registrar));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroDetect = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.txt_nombre = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btn_mini
            // 
            this.btn_mini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.ForeColor = System.Drawing.Color.White;
            this.btn_mini.Image = ((System.Drawing.Image)(resources.GetObject("btn_mini.Image")));
            this.btn_mini.Location = new System.Drawing.Point(793, 4);
            this.btn_mini.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(43, 39);
            this.btn_mini.TabIndex = 11;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ForeColor = System.Drawing.Color.White;
            this.btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("btn_Salir.Image")));
            this.btn_Salir.Location = new System.Drawing.Point(832, 4);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(43, 39);
            this.btn_Salir.TabIndex = 10;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(10, 64);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(349, 287);
            this.imageBoxFrameGrabber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBoxFrameGrabber.TabIndex = 28;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Click += new System.EventHandler(this.imageBoxFrameGrabber_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(397, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Rostros detectados:";
            // 
            // lblNumeroDetect
            // 
            this.lblNumeroDetect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroDetect.AutoSize = true;
            this.lblNumeroDetect.BackColor = System.Drawing.Color.Transparent;
            this.lblNumeroDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDetect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNumeroDetect.Location = new System.Drawing.Point(559, 65);
            this.lblNumeroDetect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroDetect.Name = "lblNumeroDetect";
            this.lblNumeroDetect.Size = new System.Drawing.Size(17, 17);
            this.lblNumeroDetect.TabIndex = 39;
            this.lblNumeroDetect.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 16);
            this.label4.TabIndex = 72;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(744, 517);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Código:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(797, 507);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(271, 30);
            this.txt_codigo.TabIndex = 78;
            // 
            // imageBox2
            // 
            this.imageBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(1082, 62);
            this.imageBox2.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(31, 216);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox2.TabIndex = 65;
            this.imageBox2.TabStop = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(926, 275);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 64;
            // 
            // txt_nombre
            // 
            // 
            // 
            // 
            this.txt_nombre.CustomButton.Image = null;
            this.txt_nombre.CustomButton.Location = new System.Drawing.Point(396, 2);
            this.txt_nombre.CustomButton.Name = "";
            this.txt_nombre.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.txt_nombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_nombre.CustomButton.TabIndex = 1;
            this.txt_nombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.CustomButton.UseSelectable = true;
            this.txt_nombre.CustomButton.Visible = false;
            this.txt_nombre.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txt_nombre.Lines = new string[0];
            this.txt_nombre.Location = new System.Drawing.Point(400, 149);
            this.txt_nombre.MaxLength = 32767;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PromptText = "Nombre";
            this.txt_nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.SelectionLength = 0;
            this.txt_nombre.SelectionStart = 0;
            this.txt_nombre.ShortcutsEnabled = true;
            this.txt_nombre.Size = new System.Drawing.Size(434, 40);
            this.txt_nombre.Style = MetroFramework.MetroColorStyle.White;
            this.txt_nombre.TabIndex = 81;
            this.txt_nombre.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_nombre.UseSelectable = true;
            this.txt_nombre.UseStyleColors = true;
            this.txt_nombre.WaterMark = "Nombre";
            this.txt_nombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_nombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(742, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 39);
            this.button1.TabIndex = 82;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(396, 226);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(217, 125);
            this.metroTile1.TabIndex = 83;
            this.metroTile1.Text = "Limpiar";
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(617, 226);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(217, 125);
            this.metroTile2.TabIndex = 84;
            this.metroTile2.Text = "Registrar";
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // Frm_Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 410);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.btn_mini);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNumeroDetect);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Registrar";
            this.Text = "Registro";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Frm_Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.Button btn_Salir;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeroDetect;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MetroFramework.Controls.MetroTextBox txt_nombre;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}