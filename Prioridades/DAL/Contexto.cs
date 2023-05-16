 public class Contexto: DbContext{

    #nullable disable
    public DbSet<Registros_Prioridad> Priorities { get; set;}

    public Contexto(DbContextOptions<Contexto> options) : base(options){ }
}