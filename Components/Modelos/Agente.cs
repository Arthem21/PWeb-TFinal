
public class Agente:Ususario{

    public static List<Multa> multas {get;set;}= new List<Multa>();
    private static List<Multa> multasPropias {get; set;}= new List<Multa>();

    private double comision{get; set;}=0;

    public Agente(){

        Tipo="Agente";
    }

    public List<Multa> MultasPropias 
    {
        get
        {
            return multasPropias;
        }
        set
        {
            multasPropias= new List<Multa>();

            foreach(var multa in multas){

                if(multa.Agente.ID==ID){

                    multasPropias.Add(multa);
                }
            }
        }
    }

    public double Comision{

        get{
            return comision;
        }

        set{

            double x=0;

            foreach(var multa in multas){

                if(multa.Estado!="Perdonada"){
                
                    x+= multa.Coste/10;
                }
            }

            comision=x;
        }

    }
}