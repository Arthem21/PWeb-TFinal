public class Multa
{
    public enum Estados
    {
        Activa,
        Perdonada,
        Pagada
    }

    public int ID { get; set; } = 0;
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    private double coste { get; set; } = 0;
    public Agente? Agente { get; set; }
    public Concepto Concepto { get; set; } = new Concepto();
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? Descripcion { get; set; }
    public double Latitud { get; set; }=0;
    public double Longitud { get; set; }=0;
    public string? Foto { get; set; }

    public string Estado { get; set; } = Estados.Activa.ToString();

    public double Coste
    {
        set
        {
            if (Concepto != null)
            {
                coste = Concepto.Monto;
            }
        }
        get
        {
            return coste;
        }
    }
}
