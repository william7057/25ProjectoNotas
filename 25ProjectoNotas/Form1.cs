using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25ProjectoNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            int nota01, nota02, nota03;
            nota01 = int.Parse(this.txt_nota01.Text);
            nota02 = int.Parse(this.txt_nota02.Text);
            nota03 = int.Parse(this.txt_nota03.Text);
            double promedio = 0;
            promedio = (nota01 + nota02 + nota03) / 3.0;
            txt_promedio.Text = promedio.ToString();
        }
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            this.txt_nota01.Text = "";
            this.txt_nota02.Text = "";
            this.txt_nota03.Text = "";
            this.txt_promedio.Clear();

        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
