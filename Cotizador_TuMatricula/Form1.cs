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

        private void btnPorPersona_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };


            decimal porPersona = reserva.Total / nudPersonas.Value;

            lstResultados.Items.Add($"Cada persona paga: US$ {porPersona:N2}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            decimal deposito = reserva.Total * 0.30m;
            decimal saldo = reserva.Total - deposito;

            lstResultados.Items.Add($"Depósito (30%): US$ {deposito:N2}");
            lstResultados.Items.Add($"Saldo pendiente: US$ {saldo:N2}");
        }

        private void btnFinSemana_Click(object sender, EventArgs e)
        {
            decimal tarifa = nudTarifa.Value;


            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }


            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };


            lstResultados.Items.Add($"Total (Fin de semana): US$ {reserva.Total:N2}");
        }

        private void btnDesglose_Click(object sender, EventArgs e)
        {
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            lstResultados.Items.Add($"Subtotal: US$ {reserva.Subtotal:N2}");
            lstResultados.Items.Add($"Descuento: US$ {reserva.Descuento:N2}");
            lstResultados.Items.Add($"Base Imponible: US$ {reserva.BaseImponible:N2}");
            lstResultados.Items.Add($"ITBIS (18%): US$ {reserva.Itbis:N2}");
            lstResultados.Items.Add($"Servicio (10%): US$ {reserva.Servicio:N2}");
            lstResultados.Items.Add($"Total: US$ {reserva.Total:N2}");
        }

        private void btnTraslado_Click(object sender, EventArgs e)
        {
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value, // O tus 3 personas
                Nocturno = true
            };

            lstResultados.Items.Add($"Traslado Aeropuerto: US$ {traslado.Total:N2}");
        }

        private void btnExcursion_Click(object sender, EventArgs e)
        {
            var excursion = new Excursion
            {
                Personas = 5,           // Tus personas + 2 (3 + 2 = 5)
                PrecioPorPersona = 65m  // 45 + 5 * 4 = 65.00
            };

            lstResultados.Items.Add($"Excursión Saona: US$ {excursion.Total:N2}");
        }

        private void btnMinibar_Click(object sender, EventArgs e)
        {
            var minibar = new ConsumoMinibar
            {
                Cantidad = 6,          // Último dígito + 2 (4 + 2 = 6)
                PrecioUnitario = 3.50m
            };

            lstResultados.Items.Add($"Consumo Minibar: US$ {minibar.Total:N2}");
        }

        private void btnCuentaTotal_Click(object sender, EventArgs e)

        {  // 1. Reserva (con los datos del formulario)
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = nudTarifa.Value
            };

            // 2. Traslado de aeropuerto (3.1)
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value,
                Nocturno = true
            };

            // 3. Excursión a Saona (3.2)
            var excursion = new Excursion
            {
                Personas = 5,
                PrecioPorPersona = 65m
            };

            // 4. Consumo de minibar (3.3)
            var minibar = new ConsumoMinibar
            {
                Cantidad = 6,
                PrecioUnitario = 3.50m
            };

            // Suma de los 4 totales
            decimal cuentaTotalUSD = reserva.Total + traslado.Total + excursion.Total + minibar.Total;

            lstResultados.Items.Add($"--- CUENTA TOTAL ESTADÍA ---");
            lstResultados.Items.Add($"Total Estadía: US$ {cuentaTotalUSD:N2}");
        }

        private void btnViejo_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Add($"Depósito de 1000: {SistemaViejo.CalcularDeposito(1000m):N2} (debe dar 300.00)");
            lstResultados.Items.Add($"100 USD a tasa 60: {SistemaViejo.APesos(100m, 60m):N2} (debe dar 6,000.00)");
            lstResultados.Items.Add($"Tarifa 200 fin de semana: {SistemaViejo.TarifaFinDeSemana(200m, true):N2} (debe dar 230.00)");
            lstResultados.Items.Add($"Excursión 4 × 50: {SistemaViejo.TotalExcursion(4, 50m):N2} (debe dar 180.00)");
            lstResultados.Items.Add($"Minibar 3 × 4: {SistemaViejo.TotalMinibar(3, 4m):N2} (debe dar 14.16)");
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            // 1. Limpiar el ListBox para mostrar la nueva factura
            lstResultados.Items.Clear();

            // 2. Aplicar recargo de fin de semana si la casilla está marcada
            decimal tarifa = nudTarifa.Value;
            if (chkFinSemana.Checked)
            {
                tarifa = tarifa * 1.15m;
            }

            // 3. Crear el objeto Reserva con los valores de la interfaz
            var reserva = new Reserva
            {
                Huesped = txtHuesped.Text,
                Noches = (int)nudNoches.Value,
                TarifaPorNoche = tarifa
            };

            // 4. Crear los objetos de servicios con tus datos calculados de la matrícula
            var traslado = new TrasladoAeropuerto
            {
                Pasajeros = (int)nudPersonas.Value, // O tus 3 personas
                Nocturno = true
            };

            var excursion = new Excursion
            {
                Personas = 5,           // Personas + 2 (3 + 2 = 5)
                PrecioPorPersona = 65m  // 45 + 5 * 4 = 65.00
            };

            var minibar = new ConsumoMinibar
            {
                Cantidad = 6,          // Último dígito + 2 (4 + 2 = 6)
                PrecioUnitario = 3.50m
            };

            // 5. Calcular los totales acumulados en USD y RD$
            decimal totalGeneralUSD = reserva.Total + traslado.Total + excursion.Total + minibar.Total;
            decimal totalGeneralRD = totalGeneralUSD * nudTasa.Value;

            // 6. Calcular el depósito obligatorio (30%) usando el método corregido de SistemaViejo
            decimal depositoUSD = SistemaViejo.CalcularDeposito(totalGeneralUSD);

            // 7. Imprimir el desglose detallado en la lista
            lstResultados.Items.Add("======== FACTURA DE LA ESTADÍA ========");
            lstResultados.Items.Add($"Huésped: {reserva.Huesped}");
            lstResultados.Items.Add("----------------------------------------");
            lstResultados.Items.Add($"1. Hospedaje ({reserva.Noches} noches): US$ {reserva.Total:N2}");
            lstResultados.Items.Add($"2. Traslado Aeropuerto: US$ {traslado.Total:N2}");
            lstResultados.Items.Add($"3. Excursión Saona: US$ {excursion.Total:N2}");
            lstResultados.Items.Add($"4. Consumo Minibar: US$ {minibar.Total:N2}");
            lstResultados.Items.Add("----------------------------------------");
            lstResultados.Items.Add($"TOTAL GENERAL (USD): US$ {totalGeneralUSD:N2}");
            lstResultados.Items.Add($"TOTAL GENERAL (RD$): RD$ {totalGeneralRD:N2}");
            lstResultados.Items.Add($"Depósito Requerido (30%): US$ {depositoUSD:N2}");
            lstResultados.Items.Add("========================================");
        }
    }
}
