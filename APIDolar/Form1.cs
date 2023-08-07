using APIDolar.Models;
using System.ComponentModel;

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
            await CargarDatos();
        }


        public async Task CargarDatos()
        {
            List<Casas2> casaList = await API.ObtenerCasas();
            Dolares dolar = await API.ObtenerDolares();
            lblvalorventaoficial.Text = '$' + dolar.oficial.value_sell.ToString();
            lblvalorcompraoficial.Text = '$' + dolar.oficial.value_buy.ToString();
            lblblueventa.Text = '$' + dolar.blue.value_sell.ToString();
            lblbluecompra.Text = '$' + dolar.blue.value_buy.ToString();
            lblcompraccl.Text = '$' + casaList[3].casa.compra.ToString();
            lblventaccl.Text = '$' + casaList[3].casa.venta.ToString();
            lblcomprabolsa.Text = '$' + casaList[4].casa.compra.ToString();
            lblventabolsa.Text = '$' + casaList[4].casa.venta.ToString();
            lblcompraturista.Text = '$' + casaList[6].casa.compra.ToString();
            lblventaturista.Text = casaList[6].casa.venta.ToString();


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
    }
}