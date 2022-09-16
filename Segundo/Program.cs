using System.Collections.Generic;
using SEGUNDO.Clases;
using SEGUNDO.Interfaz;

List<Ingredientes> Lista_Ingredientes = new List<Ingredientes>();

Pastel P = new Pastel("Pastel de Chocolate ", 25, Lista_Ingredientes);
P.Agregar(Lista_Ingredientes, "Harina",10, 8000);
P.Agregar(Lista_Ingredientes, "Chocolate", 15, 10000);
P.Agregar(Lista_Ingredientes, "Azucar", 7, 3000);
P.Agregar(Lista_Ingredientes, "Chips",25, 1000);
P.Listar(Lista_Ingredientes);
P.Costo(Lista_Ingredientes);
P.Cantidad(Lista_Ingredientes);
