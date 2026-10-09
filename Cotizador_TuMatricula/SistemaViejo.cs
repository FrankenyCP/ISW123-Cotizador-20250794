namespace Cotizador_TuMatricula
{
    public static class SistemaViejo
    {
        public static decimal CalcularDeposito(decimal total)
        {
            decimal porcentaje = 0.30m; // Corregido: 30% en lugar de 3%
            decimal deposito = total * porcentaje;
            return deposito;
        }

        public static decimal APesos(decimal dolares, decimal tasa)
        {
            decimal pesos = dolares * tasa; // Corregido: multiplicación en lugar de división
            return pesos;
        }

        public static decimal TarifaFinDeSemana(decimal tarifa, bool esFinDeSemana)
        {
            if (esFinDeSemana)
            {
                tarifa = tarifa * 1.15m; // Corregido: 1.15m para sumar el 15%
            }
            return tarifa;
        }

        public static decimal TotalExcursion(int personas, decimal precio)
        {
            decimal subtotal = personas * precio;
            decimal descuento = 0m;
            if (personas >= 4) // Corregido: >= en lugar de >
            {
                descuento = subtotal * 0.10m;
            }
            return subtotal - descuento;
        }

        public static decimal TotalMinibar(int cantidad, decimal precio)
        {
            decimal subtotal = cantidad * precio;
            decimal itbis = subtotal * 0.18m;
            decimal total = subtotal + itbis;
            return total; // Corregido: devuelve 'total' en lugar de 'subtotal'
        }
    }
}