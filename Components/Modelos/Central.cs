
public class Central : Usuario
{

    public static List<Agente> agentes = new List<Agente>();
    public static List<Multa> multas {get;set;}= Agente.multas;

    public Central(){

        Tipo="Central";
    }
}