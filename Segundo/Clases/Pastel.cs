namespace SEGUNDO.Clases;
using System.Collections.Generic;
using SEGUNDO.Interfaz;

public class Pastel : InterPas{

    public string Nombre_Pastel;
    public int Tamaño;
    public List<Ingredientes> Lista_Ingredientes;

    public Pastel(string Nombre, int Tamaño, List<Ingredientes> Lista_Ingredientes){
        this.Nombre_Pastel = Nombre;
        this.Tamaño = Tamaño;
        this.Lista_Ingredientes = Lista_Ingredientes;
    }

    public void Costo(List<Ingredientes> Lista_Ingredientes){
        int Total = 0;
        for (int i = 0; i < Lista_Ingredientes.Count; i++){
            Total = Total + Lista_Ingredientes[i].Precio_Ingrediente;
        }
        Console.WriteLine("El precio del pastel: "+ Total);
    }

    public void Listar(List<Ingredientes> Lista_Ingredientes){
        Console.WriteLine("Ingredientes");
        for (int i = 0; i < Lista_Ingredientes.Count; i++){
            Console.WriteLine(Lista_Ingredientes[i].Nombre_Ingrediente);
        }
    }

    public void Cantidad(List<Ingredientes> Lista_Ingredientes){
        int Cantidad;
        Cantidad = Lista_Ingredientes.Count;
        Console.WriteLine("Cantidad de ingredientes: "+ Cantidad);
    }

    public void Agregar(List<Ingredientes> Lista_Ingredientes, string Nombrei, int Cantidadi, int Precioi){
        Lista_Ingredientes.Add(new Ingredientes(Nombrei, Cantidadi, Precioi));
    }
}

