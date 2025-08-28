Console.WriteLine("Hello, World!");

public class Especies{
    public int id;
    public string? nombre;
    public bool extinto;
    public List<Animales>? animales;
    
}

public class Ubicacion{
    public int id;
    public string? ciudad;
    public string? pais;
    public List<Animales>? lnimales;
    public List<Lugares>? lugares;

}

public class Animales {
    public int id;
    public string? nombre_vulgar;
    public int edad;
    public DateTime fecha_nacimiento;
   
}

public class Lugares {
    public int id;
    public string? nombre;
    public decimal presupuesto;
    public int numero_animales;
    public List<Animales>? animales;

}

