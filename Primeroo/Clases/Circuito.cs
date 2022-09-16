namespace PRIMEROO.Clases;
using PRIMEROO.Interfaz;

public class Circuito{
    private string Nombre;
    private int Numero_Vueltas;
    private bool CircuitoD;
    private InterMono Ferrari, Mclaren, RedBull;
    private Random random;
    private int Tiempo;
    private int MejorTF, MejorTM, MejorTR;
    private List<string> Resultados;

    public Circuito (InterMono F, InterMono M, InterMono R,string N, int NV){
        Ferrari = F;
        Mclaren = M;
        RedBull = R;
        Nombre = N;
        Numero_Vueltas = NV;
        CircuitoD = true;
        Tiempo = 0;
        random = new Random();
        MejorTF = 1000000;
        MejorTM = 1000000;
        MejorTR = 1000000;
        Resultados = new List<string>();
    }

    public void AgregarMP(Monoplaza F){
        if(CircuitoD == true){   
            CircuitoD = false; 
        }
    }

    public void Realizar_Prueba(int N, String S){   
        switch (S){
        case "Ferrari":
            Console.WriteLine(Ferrari.ToString());
            for(int i = 0; i < Numero_Vueltas; i++ ){
                Ferrari.Apagar();
                Ferrari.Encender();
                Ferrari.Movimiento();
                Ferrari.Detener();
                Ferrari.Apagar();
                Tiempo = random.Next(111111,999999);
                if(Tiempo < MejorTF){
                    MejorTF = Tiempo;
                }
                Console.WriteLine("Vuelta # " + (i+1) + " " + Tiempo);
            }
            Console.WriteLine("Mejor tiempo: " + MejorTF);
            Resultados.Add(MejorTF.ToString());
            break;

        case "Mclaren":
             Console.WriteLine(Mclaren.ToString());
            for(int i = 0;i < Numero_Vueltas; i++ ){   
                Mclaren.Apagar();
                Mclaren.Encender();
                Mclaren.Movimiento();
                Mclaren.Detener();
                Mclaren.Apagar();
                Tiempo = random.Next(111111,999999);
                if(Tiempo < MejorTM){
                    MejorTM = Tiempo;
                }
                Console.WriteLine("Vuelta # " + (i+1) + " " + Tiempo);
            }
            Console.WriteLine("Mejor tiempo: " + MejorTM);
            Resultados.Add(MejorTM.ToString());
            break;

        case "Redbull":
            Console.WriteLine(RedBull.ToString());
            for(int i=0 ;i < Numero_Vueltas; i++ ){   
                RedBull.Apagar();
                RedBull.Encender();
                RedBull.Movimiento();
                RedBull.Detener();
                RedBull.Apagar();
                Tiempo=random.Next(111111,999999);
                if(Tiempo < MejorTR){
                    MejorTR = Tiempo;
                }
            Console.WriteLine("Vuelta # " + (i+1) + " " + Tiempo);
            }
            Console.WriteLine("Mejor tiempo: " + MejorTR);
            Resultados.Add(MejorTR.ToString());
            break;
        default:
            Console.WriteLine($"Measured value is .");
            break;
        } 
    }
    public void SacarMP(){
        if(CircuitoD == false){    
            CircuitoD = true;
            Console.WriteLine("Circuito disponible");
        }
    }
    public int RNumero_Vueltas(){
        return Numero_Vueltas;
    }
    public void  ListaR(){    
        Console.WriteLine("Tabla de resultados");
        Resultados.Sort();
        
       for(int i=0;i < Resultados.Count; i++){
                 Console.WriteLine("Puesto #" + (i+1) + " " + Resultados[i]);
            }
    }
}