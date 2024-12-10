using System.ComponentModel.DataAnnotations;

public class Multa
{
    public enum Estados
    {
        Activa,
        Perdonada,
        Pagada
    }

    [Key]public int Id { get; set; } = 0;
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public double Costes { get; set; } = 0;
    public Agente? Agente { get; set; }
    
    public Concepto Concepto { get; set; } = new Concepto();
    public DateTime Fecha { get; set; } = DateTime.Now;
    public string? Descripcion { get; set; }
    public double Latitud { get; set; }=0;
    public double Longitud { get; set; } = 0;

    public string? Coordenadas()
    {
        return $"{Latitud}, {Longitud}";
    }
    public string? Foto { get; set; }

    public string Estado { get; set; } = Estados.Activa.ToString();

    //public double Coste
    //{
    //    set
    //    {
    //        if (Concepto != null)
    //        {
    //            Costes = Concepto.Monto;
    //        }
    //    }
    //    get
    //    {
    //        return Costes;
    //    }
    //}
}
