using APIDolar.Models;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using Timer = System.Windows.Forms.Timer;

namespace APIDolar
{
    public partial class Form1 : Form
    {



        public Form1()
        {

            InitializeComponent();
            Load += Form1_Load;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try { 
            await CargarDatos();
            }
            catch(Exception ex)
            {
                
            }

        }


        public async Task CargarDatos()
        {
            Dolares dolar = await API.ObtenerDolares();
            List<Casas2> casaList = await API.ObtenerCasas();
            
            lblvalorventaoficial.Text = '$' + dolar.oficial.value_sell.ToString("F2");
            lblvalorcompraoficial.Text = '$' + dolar.oficial.value_buy.ToString("F2");
            lblblueventa.Text = '$' + dolar.blue.value_sell.ToString("F2");
            lblbluecompra.Text = '$' + dolar.blue.value_buy.ToString("F2");
            lblcompraccl.Text = '$' + casaList[3].casa.compra.ToString();
            lblventaccl.Text = '$' + casaList[3].casa.venta.ToString();
            lblcomprabolsa.Text = '$' + casaList[4].casa.compra.ToString();
            lblventabolsa.Text = '$' + casaList[4].casa.venta.ToString();
            lblcompraturista.Text = casaList[6].casa.compra.ToString();
            lblventaturista.Text = '$' + casaList[6].casa.venta;

            

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private async void btnactualizar_ClickAsync(object sender, EventArgs e)
        {

            try
            {
                await CargarDatos();
                lblok2.Text = "OK";
            }

            catch
            {
                lblok2.Text = "Error";
            }


        }

        
    }

}