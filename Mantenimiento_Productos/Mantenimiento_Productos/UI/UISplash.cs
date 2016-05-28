using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mantenimiento_Productos.UI
{
    public partial class UISplash : Form
    {
        public UISplash()
        {
            InitializeComponent();
            //Inicializa variables del timer
            lblTitulo.Text = "VerfrutaExpress | " + DateTime.Now.Year;
            tmrTiempo.Enabled = true;
            tmrTiempo.Interval = 5000;
            
        }

        private void tmrTiempo_Tick(object sender, EventArgs e)
        {
            try
            {
                //Realiza una accion
                tmrTiempo.Stop();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                //Muestra el error
                MessageBox.Show("Ocurrio un error: " + ex.Message, "Error.!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
