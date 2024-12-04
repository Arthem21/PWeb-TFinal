public class Administracion:Ususario{

    public static List<Central> Centrales = new List<Central>();
    public static List<string> Conceptos {get;set;}= new List<string>();

    public Administracion(){

        Tipo="Administracion";
    }
}