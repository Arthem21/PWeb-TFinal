public class Multa
{

    public enum Estados{

        Activa,
        Perdonada,
        Pagada
    }

    public int ID{get; set;}=0;
    public string Cedula { get; set; } = string.Empty;
    public string Nombre { get; set; } = string.Empty;
    public double Coste{get; set;}=0;
    public int AgenteID{get; set;}=0;
    public string Concepto { get; set; } = string.Empty;
    public DateTime Fecha {get; set;}= DateTime.Now;
    public string? Descripcion { get; set; } 
    public double? Latitud { get; set; } 
    public double? Longitud { get; set; } 
    public string? Foto { get; set; } 

    public string Estado {get; set;}= Estados.Activa.ToString();
    
    private string concepto{
        
        get{return Concepto;}
        
    }


}
