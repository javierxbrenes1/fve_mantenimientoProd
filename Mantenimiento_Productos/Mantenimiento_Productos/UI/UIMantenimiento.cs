using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mantenimiento_Productos.WS;
using System.ServiceModel;


namespace Mantenimiento_Productos.UI
{
    public partial class UIMantenimiento : Form
    {
        public UIMantenimiento()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                //string xx = textBox1.Text;
                CustomBinding binding = new CustomBinding(new CustomTextMessageBindingElement("iso-8859-1", "text/xml", MessageVersion.Soap11), new HttpTransportBindingElement());
                FVEWebService.FVEWebServicePortTypeClient prueba = new FVEWebService.FVEWebServicePortTypeClient();
                prueba.Endpoint.Binding = binding;

                FVEWebService.Productos prod = new FVEWebService.Productos();
                
                prod = prueba.foBuscarProducto(20165501);
                MessageBox.Show(prod.prod_nom);
                
                
               
               
                ////string Arreglo =  prueba.Prod();
                //PruebaWS.Productos Arreglo = prueba.foObtenerProductos();
                //if (Arreglo.Length > 0)
                //{
                //    MessageBox.Show("Hay: " + Arreglo.Length + " productos");
                //}
                //else {
                //    MessageBox.Show("No Hay");
                //}

                pictureBox1.Load("http://www.punk-hxc.com/especiales/punk-hardcore.jpg");

            }catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
