 public class Contexto: DbContext{

    #nullable disable
    public DbSet<Registros_Prioridad> Registros_Prioridad { get; set;}

    public Contexto(DbContextOptions<Contexto> options) : base(options){ }
}