namespace Cotizador_TuMatricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 5;
            x = x + 2;
            x = x * 3;

            // X inicia con el valor de 5, luego se le suma 2 y luego se multiplica por 3


            int n = 7;
            decimal d = 0m;
            if (n > 7)
            {
                d = 50m;
            }

            //La Condicion no se cumple, por lo que d mantiene su mismo valor de cero

            int m = 7;
            bool larga = m >= 7;

            // Como larga se declara como buleano el resultado esperado es true o false
            //dependiendo si se cumple o no la condicion

            decimal t = 120m;
            t = t + t * 0.25m;

            // Tuve problemas ya que estaba sumando todo y luego multiplicando
            // y por regla matematica primero se multiplica

        }

        private void btnPesos_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal tasa = nudTasa.Value;
            decimal pesos = reserva.Total * tasa;
            lstResultados.Items.Add($"Total en pesos: RD$ {pesos:N2}");
        }
    }
}
