namespace SEGUNDO.Interfaz;
using System.Collections.Generic;
using SEGUNDO.Clases;

public interface InterPas{
    public void Listar(List<Ingredientes> Lista_Ingredientes);
    public void Cantidad(List<Ingredientes> Lista_Ingredientes);
    public void Agregar(List<Ingredientes> Lista_Ingredientes, string Nombrei, int Cantidadi, int Precioi);
    public void Costo(List<Ingredientes> Lista_Ingredientes);
}
