
using System.Drawing;
using System.Windows.Forms;

namespace app_1_test_menu_desplegable
{   
    partial class Pan_cabecera
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.Sub2Btn2 = new System.Windows.Forms.Button();
            this.Sub1Btn2 = new System.Windows.Forms.Button();
            this.PanelSubBtn1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Pnl2.SuspendLayout();
            this.PanelSubBtn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::app_1_test_menu_desplegable.Properties.Resources.angryimg__3_;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(199, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 31);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::app_1_test_menu_desplegable.Properties.Resources.angryimg__4_;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Btn2);
            this.panel1.Controls.Add(this.Btn1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 450);
            this.panel1.TabIndex = 0;
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(108)))), ((int)(((byte)(221)))));
            this.Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn2.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.Btn2.Location = new System.Drawing.Point(12, 258);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(169, 51);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Boton2";
            this.Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(108)))), ((int)(((byte)(221)))));
            this.Btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Btn1.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.Btn1.Location = new System.Drawing.Point(12, 57);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(169, 51);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "Boton1";
            this.Btn1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Pnl2.Controls.Add(this.Sub2Btn2);
            this.Pnl2.Controls.Add(this.Sub1Btn2);
            this.Pnl2.Location = new System.Drawing.Point(282, 302);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(169, 85);
            this.Pnl2.TabIndex = 4;
            this.Pnl2.Visible = false;
            // 
            // Sub2Btn2
            // 
            this.Sub2Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Sub2Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sub2Btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sub2Btn2.FlatAppearance.BorderSize = 0;
            this.Sub2Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Sub2Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Sub2Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub2Btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub2Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sub2Btn2.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.Sub2Btn2.Location = new System.Drawing.Point(0, 44);
            this.Sub2Btn2.Margin = new System.Windows.Forms.Padding(0);
            this.Sub2Btn2.Name = "Sub2Btn2";
            this.Sub2Btn2.Size = new System.Drawing.Size(169, 41);
            this.Sub2Btn2.TabIndex = 5;
            this.Sub2Btn2.Text = "Sub2";
            this.Sub2Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sub2Btn2.UseVisualStyleBackColor = false;
            // 
            // Sub1Btn2
            // 
            this.Sub1Btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Sub1Btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Sub1Btn2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sub1Btn2.FlatAppearance.BorderSize = 0;
            this.Sub1Btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.Sub1Btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Sub1Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sub1Btn2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sub1Btn2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sub1Btn2.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.Sub1Btn2.Location = new System.Drawing.Point(0, 0);
            this.Sub1Btn2.Name = "Sub1Btn2";
            this.Sub1Btn2.Size = new System.Drawing.Size(169, 41);
            this.Sub1Btn2.TabIndex = 4;
            this.Sub1Btn2.Text = "Sub1";
            this.Sub1Btn2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Sub1Btn2.UseVisualStyleBackColor = false;
            // 
            // PanelSubBtn1
            // 
            this.PanelSubBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.PanelSubBtn1.Controls.Add(this.button1);
            this.PanelSubBtn1.Controls.Add(this.button2);
            this.PanelSubBtn1.Location = new System.Drawing.Point(316, 183);
            this.PanelSubBtn1.Name = "PanelSubBtn1";
            this.PanelSubBtn1.Size = new System.Drawing.Size(169, 85);
            this.PanelSubBtn1.TabIndex = 5;
            this.PanelSubBtn1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.button1.Location = new System.Drawing.Point(0, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sub2";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::app_1_test_menu_desplegable.Properties.Resources.checked_checkbox_24;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Sub1";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Pan_cabecera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PanelSubBtn1);
            this.Controls.Add(this.Pnl2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pan_cabecera";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Pnl2.ResumeLayout(false);
            this.PanelSubBtn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Button Btn2;
        private Button Btn1;
        private Panel Pnl2;
        private Button Sub2Btn2;
        private Button Sub1Btn2;
        private Panel PanelSubBtn1;
        private Button button1;
        private Button button2;
    }
}

