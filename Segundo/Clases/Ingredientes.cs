namespace SEGUNDO.Clases;

public class Ingredientes{
    public string Nombre_Ingrediente;
    public int Cantidad_Ingrediente;
    public int Precio_Ingrediente;

    public Ingredientes(string Nombre, int Cantidad, int Precio){
        this.Nombre_Ingrediente = Nombre;
        this.Cantidad_Ingrediente = Cantidad;
        this.Precio_Ingrediente = Precio;
    }
}
