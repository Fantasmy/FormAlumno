﻿namespace FormAlumnos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.dniBox = new System.Windows.Forms.TextBox();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tipoConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variableDeEntornoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.tipoDeConfiguraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appconfigToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.variableDeEntornoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(145, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Id";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(302, 116);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 26);
            this.nameBox.TabIndex = 4;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // surnameBox
            // 
            this.surnameBox.Location = new System.Drawing.Point(302, 154);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(100, 26);
            this.surnameBox.TabIndex = 5;
            // 
            // dniBox
            // 
            this.dniBox.Location = new System.Drawing.Point(302, 199);
            this.dniBox.Name = "dniBox";
            this.dniBox.Size = new System.Drawing.Size(100, 26);
            this.dniBox.TabIndex = 6;
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(302, 249);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(100, 26);
            this.idBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Formulario Estudiantes";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(535, 190);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(85, 39);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Guardar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoConfigToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(482, 117);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(199, 33);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tipoConfigToolStripMenuItem
            // 
            this.tipoConfigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appConfigToolStripMenuItem,
            this.variableDeEntornoToolStripMenuItem,
            this.txtToolStripMenuItem});
            this.tipoConfigToolStripMenuItem.Name = "tipoConfigToolStripMenuItem";
            this.tipoConfigToolStripMenuItem.Size = new System.Drawing.Size(191, 29);
            this.tipoConfigToolStripMenuItem.Text = "Guardar extensión en";
            this.tipoConfigToolStripMenuItem.Click += new System.EventHandler(this.tipoConfigToolStripMenuItem_Click);
            // 
            // appConfigToolStripMenuItem
            // 
            this.appConfigToolStripMenuItem.Name = "appConfigToolStripMenuItem";
            this.appConfigToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.appConfigToolStripMenuItem.Text = "JSON";
            this.appConfigToolStripMenuItem.Click += new System.EventHandler(this.appConfigToolStripMenuItem_Click);
            // 
            // variableDeEntornoToolStripMenuItem
            // 
            this.variableDeEntornoToolStripMenuItem.Name = "variableDeEntornoToolStripMenuItem";
            this.variableDeEntornoToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.variableDeEntornoToolStripMenuItem.Text = "Xml";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoDeConfiguraciónToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // tipoDeConfiguraciónToolStripMenuItem
            // 
            this.tipoDeConfiguraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appconfigToolStripMenuItem1,
            this.variableDeEntornoToolStripMenuItem1});
            this.tipoDeConfiguraciónToolStripMenuItem.Name = "tipoDeConfiguraciónToolStripMenuItem";
            this.tipoDeConfiguraciónToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.tipoDeConfiguraciónToolStripMenuItem.Text = "Tipo de configuración";
            // 
            // appconfigToolStripMenuItem1
            // 
            this.appconfigToolStripMenuItem1.Name = "appconfigToolStripMenuItem1";
            this.appconfigToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.appconfigToolStripMenuItem1.Text = "App.config";
            // 
            // variableDeEntornoToolStripMenuItem1
            // 
            this.variableDeEntornoToolStripMenuItem1.Name = "variableDeEntornoToolStripMenuItem1";
            this.variableDeEntornoToolStripMenuItem1.Size = new System.Drawing.Size(252, 30);
            this.variableDeEntornoToolStripMenuItem1.Text = "Variable de entorno";
            // 
            // txtToolStripMenuItem
            // 
            this.txtToolStripMenuItem.Name = "txtToolStripMenuItem";
            this.txtToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.txtToolStripMenuItem.Text = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.dniBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox dniBox;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tipoConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appConfigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variableDeEntornoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tipoDeConfiguraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appconfigToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem variableDeEntornoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem txtToolStripMenuItem;
    }
}

