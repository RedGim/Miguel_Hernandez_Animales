Console.WriteLine("Hello, World!");

Console.WriteLine("hiii");
public class Especies{
    public int id;
    public string? nombre;
    public bool extinto;
    public List<Animales>? animales;
    
}

public class Ubicaciones{
    public int id;
    public string? ciudad;
    public string? pais;
    public List<Animales>? animales;
    public List<Lugares>? lugares;

}

public class Animales {
    public int id;
    public string? nombre_vulgar;
    public int edad;
    public DateTime fecha_nacimiento;
    public Lugares? lugares;
    public Ubicaciones? ubicacion;
    public Especies? especies;

   
}

public class Lugares {
    public int id;
    public string? nombre;
    public decimal presupuesto;
    public int numero_animales;
    public Ubicaciones? ubicacion;
    public List<Animales>? animales;

}

