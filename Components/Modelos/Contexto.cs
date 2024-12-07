using Microsoft.EntityFrameworkCore;

public class Contexto: DbContext{

    public DbSet<Multa> multas{get; set;}
    public DbSet<Agente> Agentes{get; set;}
    public DbSet<Central> Centrales{get; set;}
    public DbSet<Administracion> Administrativos{get; set;}
    public DbSet<Concepto> Conceptos {get; set;}

    public Contexto(DbContextOptions<Contexto> options): base(options){}

    
    
    
}




