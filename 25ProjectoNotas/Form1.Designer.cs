
namespace _25ProjectoNotas
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
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nota01 = new System.Windows.Forms.TextBox();
            this.txt_nota02 = new System.Windows.Forms.TextBox();
            this.txt_nota03 = new System.Windows.Forms.TextBox();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(312, 75);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(107, 41);
            this.btn_Ejecutar.TabIndex = 0;
            this.btn_Ejecutar.Text = "&Ejecutar";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(312, 152);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(107, 47);
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "&Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(312, 243);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(107, 41);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Text = "&Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOTA 01 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTA 02 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOTA 03:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "PROMEDIO :";
            // 
            // txt_nota01
            // 
            this.txt_nota01.Location = new System.Drawing.Point(135, 72);
            this.txt_nota01.Multiline = true;
            this.txt_nota01.Name = "txt_nota01";
            this.txt_nota01.Size = new System.Drawing.Size(100, 34);
            this.txt_nota01.TabIndex = 7;
            // 
            // txt_nota02
            // 
            this.txt_nota02.Location = new System.Drawing.Point(135, 129);
            this.txt_nota02.Multiline = true;
            this.txt_nota02.Name = "txt_nota02";
            this.txt_nota02.Size = new System.Drawing.Size(100, 36);
            this.txt_nota02.TabIndex = 8;
            // 
            // txt_nota03
            // 
            this.txt_nota03.Location = new System.Drawing.Point(135, 188);
            this.txt_nota03.Multiline = true;
            this.txt_nota03.Name = "txt_nota03";
            this.txt_nota03.Size = new System.Drawing.Size(100, 33);
            this.txt_nota03.TabIndex = 9;
            // 
            // txt_promedio
            // 
            this.txt_promedio.Location = new System.Drawing.Point(135, 252);
            this.txt_promedio.Multiline = true;
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.Size = new System.Drawing.Size(144, 32);
            this.txt_promedio.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(334, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "PROMEDIO DE NOTAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 319);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.txt_nota03);
            this.Controls.Add(this.txt_nota02);
            this.Controls.Add(this.txt_nota01);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Ejecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.Button btn_Limpiar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nota01;
        private System.Windows.Forms.TextBox txt_nota02;
        private System.Windows.Forms.TextBox txt_nota03;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.Label label5;
    }
}

