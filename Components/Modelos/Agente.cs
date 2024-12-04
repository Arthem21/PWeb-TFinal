
public class Agente:Ususario{

    public static List<Multa> multas {get;set;}= new List<Multa>();

    public double comision{get; set;}=0;

    public Agente(){

        Tipo="Agente";
    }

    private double Comision{

        get{
            return comision;
        }

        set{

            double x=0;

            foreach(var multa in multas){

                x+= multa.Coste/10;
            }

            comision=x;
        }

    }
}