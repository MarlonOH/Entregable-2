namespace PRIMEROO.Clases;
using PRIMEROO.Interfaz;

public abstract class Monoplaza : InterMono{
    protected string Escuderia;
    protected bool Motor;
    protected string Marca;
    protected bool EstadoM;
    protected bool MovimientoM;

    public Monoplaza(string E, string M){
        Marca = M.ToLower();
        Escuderia = E;
        EstadoM = false;
        MovimientoM = false;
    }

    public void Encender(){
       if(EstadoM == false){    
            EstadoM = true;
            Console.WriteLine("El vehiculo esta encendido");
       }
    }

    public void Apagar(){
        if(EstadoM == true && MovimientoM == false){
            EstadoM = false;
            Console.WriteLine("El vehiculo esta apagado");
        }else{
           Console.WriteLine("El vehiculo esta apagado"); 
        }  
    }

    public void Detener(){
       if(EstadoM == true && MovimientoM== true){    
            MovimientoM = false;
            Console.WriteLine("El vehiculo esta detenido");
       }
    }

    public void Movimiento(){
        if(EstadoM == true && MovimientoM == false){   
            MovimientoM = true;
            Console.WriteLine("El vehiculo esta en movimiento");
        }
    }

    public string REscuderia(){
        return Escuderia;
    }
    public string RMarca(){
        return Marca;
    }
    public bool RMotor(){
        return Motor;
    }

    public override string ToString(){
      return  "Marca: " + Marca.ToString() + " Escuderia: " + Escuderia.ToString() + " ";
   }
}