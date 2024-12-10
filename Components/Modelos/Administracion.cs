public class Administracion: Usuario
{

    public static List<Central> Centrales = new List<Central>();
    public static List<Concepto> Conceptos {get;set;}= new List<Concepto>();

    public Administracion(){

        Tipo="Administracion";
    }
}