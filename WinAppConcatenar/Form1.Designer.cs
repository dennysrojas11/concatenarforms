namespace WinAppConcatenar
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxCadena1 = new System.Windows.Forms.TextBox();
            this.textBoxCadena2 = new System.Windows.Forms.TextBox();
            this.textBoxCadena3 = new System.Windows.Forms.TextBox();
            this.groupBoxCadenas = new System.Windows.Forms.GroupBox();
            this.buttonConcatenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxCadenas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(181, 47);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(765, 39);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "CONCATENACIÓN DE CADENAS DE TEXTO";
            // 
            // textBoxCadena1
            // 
            this.textBoxCadena1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCadena1.Location = new System.Drawing.Point(19, 71);
            this.textBoxCadena1.Name = "textBoxCadena1";
            this.textBoxCadena1.Size = new System.Drawing.Size(220, 30);
            this.textBoxCadena1.TabIndex = 1;
            this.textBoxCadena1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCadena1_KeyPress);
            // 
            // textBoxCadena2
            // 
            this.textBoxCadena2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCadena2.Location = new System.Drawing.Point(270, 71);
            this.textBoxCadena2.Name = "textBoxCadena2";
            this.textBoxCadena2.Size = new System.Drawing.Size(220, 30);
            this.textBoxCadena2.TabIndex = 2;
            this.textBoxCadena2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCadena2_KeyPress);
            // 
            // textBoxCadena3
            // 
            this.textBoxCadena3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCadena3.Location = new System.Drawing.Point(516, 71);
            this.textBoxCadena3.Name = "textBoxCadena3";
            this.textBoxCadena3.Size = new System.Drawing.Size(220, 30);
            this.textBoxCadena3.TabIndex = 3;
            this.textBoxCadena3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCadena3_KeyPress);
            // 
            // groupBoxCadenas
            // 
            this.groupBoxCadenas.Controls.Add(this.buttonConcatenar);
            this.groupBoxCadenas.Controls.Add(this.textBoxCadena1);
            this.groupBoxCadenas.Controls.Add(this.textBoxCadena3);
            this.groupBoxCadenas.Controls.Add(this.textBoxCadena2);
            this.groupBoxCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCadenas.Location = new System.Drawing.Point(53, 193);
            this.groupBoxCadenas.Name = "groupBoxCadenas";
            this.groupBoxCadenas.Size = new System.Drawing.Size(758, 232);
            this.groupBoxCadenas.TabIndex = 4;
            this.groupBoxCadenas.TabStop = false;
            this.groupBoxCadenas.Text = "Cadenas";
            // 
            // buttonConcatenar
            // 
            this.buttonConcatenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConcatenar.Location = new System.Drawing.Point(516, 154);
            this.buttonConcatenar.Name = "buttonConcatenar";
            this.buttonConcatenar.Size = new System.Drawing.Size(220, 54);
            this.buttonConcatenar.TabIndex = 4;
            this.buttonConcatenar.Text = "Concatenar";
            this.buttonConcatenar.UseVisualStyleBackColor = true;
            this.buttonConcatenar.Click += new System.EventHandler(this.buttonConcatenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinAppConcatenar.Properties.Resources.letras;
            this.pictureBox1.Location = new System.Drawing.Point(836, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxCadenas);
            this.Controls.Add(this.labelTitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxCadenas.ResumeLayout(false);
            this.groupBoxCadenas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxCadena1;
        private System.Windows.Forms.TextBox textBoxCadena2;
        private System.Windows.Forms.TextBox textBoxCadena3;
        private System.Windows.Forms.GroupBox groupBoxCadenas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonConcatenar;
    }
}

