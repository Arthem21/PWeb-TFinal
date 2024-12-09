using System.ComponentModel.DataAnnotations;

public class Concepto{

    [Key] public int Id {get;set;}=0;
    public string Nombre{get; set;}=string.Empty;
    public double Monto {get;set;}=0;
}