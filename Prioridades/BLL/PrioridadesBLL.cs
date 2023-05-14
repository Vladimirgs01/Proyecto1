
class PrioridadesBLL
{
    private Contexto _contexto;
    public PrioridadesBLL(Contexto _contexto)
    {
        this._contexto = _contexto;
    }

    public bool Existe (int prioridadId){
        return _contexto.Registros_Prioridad.Any(p => p.PrioridadId == prioridadId);
    }

    public bool Insertar (Registros_Prioridad prioridad){
        _contexto.Registros_Prioridad.Add(prioridad);
        return _contexto.SaveChanges()>0;
    }

    public bool Modificar (Registros_Prioridad prioridad){
        _contexto.Entry(prioridad).State = EntityState.Modified;
        return _contexto.SaveChanges()>0;
    }

    public bool Eliminar (Registros_Prioridad prioridad){
        _contexto.Entry(prioridad).State = EntityState.Deleted;
        return _contexto.SaveChanges()>0;
    }

    public bool Guardar (Registros_Prioridad prioridad){
        if (!Existe (prioridad.PrioridadId))
            return this.Insertar(prioridad);
        else
            return this.Modificar(prioridad);
    }

    public Registros_Prioridad? Buscar (int prioridadId){
        return _contexto.Registros_Prioridad.Where(p => p.PrioridadId == prioridadId).AsNoTracking().SingleOrDefault();
    }

    public List<Registros_Prioridad>GetList(Expression<Func<Registros_Prioridad, bool>>criterio){
        return _contexto.Registros_Prioridad.AsNoTracking().Where(criterio).ToList();
    }
}