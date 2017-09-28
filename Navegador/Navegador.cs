using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador.Utilidades;

namespace Navegador
{
    public partial class Navegador : UserControl
    {
        [Description("BaseDatos")]
        [Category("ParametrosBD")]
        public EventHandler nuevoEvento;
        [Description("NombreTabla")]
        [Category("ParametrosBD")]
        public String NombreTabla { get; set; }


        public string msgC;

        public Navegador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Insertrecieve != null)
                this.Insertrecieve(this,e);
            Conector c = new Conector();
            bool a = c.OpenConnection();
          

        }

        private void Navegador_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public event EventHandler Insertrecieve;

        public String msg{
            set {
                msgC = value;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
