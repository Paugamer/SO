﻿namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Mayus = new System.Windows.Forms.RadioButton();
            this.Palindromo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.Altura = new System.Windows.Forms.RadioButton();
            this.Longitud = new System.Windows.Forms.RadioButton();
            this.Bonito = new System.Windows.Forms.RadioButton();
            this.desconnexion = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.conLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(126, 80);
            this.IP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(193, 26);
            this.IP.TabIndex = 2;
            this.IP.Text = "192.168.56.102";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(174, 48);
            this.nombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(244, 26);
            this.nombre.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 276);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.Mayus);
            this.groupBox1.Controls.Add(this.Palindromo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.alturaTextBox);
            this.groupBox1.Controls.Add(this.Altura);
            this.groupBox1.Controls.Add(this.Longitud);
            this.groupBox1.Controls.Add(this.Bonito);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Location = new System.Drawing.Point(13, 162);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 345);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // Mayus
            // 
            this.Mayus.AutoSize = true;
            this.Mayus.Location = new System.Drawing.Point(174, 242);
            this.Mayus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mayus.Name = "Mayus";
            this.Mayus.Size = new System.Drawing.Size(205, 24);
            this.Mayus.TabIndex = 13;
            this.Mayus.TabStop = true;
            this.Mayus.Text = "Ponmelo en mayusculas";
            this.Mayus.UseVisualStyleBackColor = true;
            // 
            // Palindromo
            // 
            this.Palindromo.AutoSize = true;
            this.Palindromo.Location = new System.Drawing.Point(174, 208);
            this.Palindromo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Palindromo.Name = "Palindromo";
            this.Palindromo.Size = new System.Drawing.Size(196, 24);
            this.Palindromo.TabIndex = 12;
            this.Palindromo.TabStop = true;
            this.Palindromo.Text = "Dime si soy palíndromo";
            this.Palindromo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Altura";
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.Location = new System.Drawing.Point(40, 138);
            this.alturaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(72, 26);
            this.alturaTextBox.TabIndex = 10;
            // 
            // Altura
            // 
            this.Altura.AutoSize = true;
            this.Altura.Location = new System.Drawing.Point(174, 174);
            this.Altura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Altura.Name = "Altura";
            this.Altura.Size = new System.Drawing.Size(144, 24);
            this.Altura.TabIndex = 9;
            this.Altura.TabStop = true;
            this.Altura.Text = "Dime si soy alto";
            this.Altura.UseVisualStyleBackColor = true;
            // 
            // Longitud
            // 
            this.Longitud.AutoSize = true;
            this.Longitud.Location = new System.Drawing.Point(174, 140);
            this.Longitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Longitud.Name = "Longitud";
            this.Longitud.Size = new System.Drawing.Size(247, 24);
            this.Longitud.TabIndex = 7;
            this.Longitud.TabStop = true;
            this.Longitud.Text = "Dime la longitud de mi nombre";
            this.Longitud.UseVisualStyleBackColor = true;
            // 
            // Bonito
            // 
            this.Bonito.AutoSize = true;
            this.Bonito.Location = new System.Drawing.Point(174, 105);
            this.Bonito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bonito.Name = "Bonito";
            this.Bonito.Size = new System.Drawing.Size(233, 24);
            this.Bonito.TabIndex = 8;
            this.Bonito.TabStop = true;
            this.Bonito.Text = "Dime si mi nombre es bonito";
            this.Bonito.UseVisualStyleBackColor = true;
            // 
            // desconnexion
            // 
            this.desconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desconnexion.Location = new System.Drawing.Point(13, 535);
            this.desconnexion.Name = "desconnexion";
            this.desconnexion.Size = new System.Drawing.Size(287, 76);
            this.desconnexion.TabIndex = 7;
            this.desconnexion.Text = "Desconnectar";
            this.desconnexion.UseVisualStyleBackColor = true;
            this.desconnexion.Click += new System.EventHandler(this.desconnexion_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(600, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(198, 108);
            this.button3.TabIndex = 8;
            this.button3.Text = "¿Cuantos Servicios?";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // conLbl
            // 
            this.conLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.conLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conLbl.Location = new System.Drawing.Point(600, 273);
            this.conLbl.Name = "conLbl";
            this.conLbl.Size = new System.Drawing.Size(198, 133);
            this.conLbl.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 865);
            this.Controls.Add(this.conLbl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.desconnexion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IP;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Longitud;
        private System.Windows.Forms.RadioButton Bonito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.RadioButton Altura;
        private System.Windows.Forms.Button desconnexion;
        private System.Windows.Forms.RadioButton Palindromo;
        private System.Windows.Forms.RadioButton Mayus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label conLbl;
    }
}

