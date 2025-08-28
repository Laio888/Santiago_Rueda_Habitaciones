Console.WriteLine("Hello, World!");

var Ocupante = new Ocupantes();
var Tipo = new Tipos();

Ocupante.Id = 1;
Ocupante.Nombre = "Juanse Perez";
Ocupante.Activo = true;
Habitacion.Tipo = new Tipos() { Id = 1, Nombre = "Habitacion Grande" };
Ocupante.Habitaciones = new List<Habitaciones>();
Ocupante.Habitaciones.Add(new Habitaciones() { Id = 1, Nombre = "Habitacion Grande" });
Ocupante.Habitaciones.Add(new Habitaciones() { Id = 2, Nombre = "Habitacion mediana" });
Ocupante.Habitaciones.Add(new Habitaciones() { Id = 2, Nombre = "Habitacion pequeña" });


public class Tipos
{
    public int Id = 0;
    public String? Nombre = "";

    public List<Habitaciones> Habitaciones = new List<Habitaciones>();  
}

public class Ocupantes
{
    public int Id = 0;
    public String? Nombre = "";
    public Tipos Tipo = new Tipos();
    public bool Activo = false;
    public List<Habitaciones> VideoJuegos = new List<Habitaciones>();
}

public class Habitaciones
{
    public int Id = 0;
    public String? Nombre = "";
    public Tipos Tipo = new Tipos();
    public List<Ocupantes> Ocupantes = new List<Ocupantes>();
}

public class Hoteles
{
    public int Id = 0;
    public String? Nombre = "";
}