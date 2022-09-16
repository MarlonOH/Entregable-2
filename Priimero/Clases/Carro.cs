using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PRIIMERO.Monoplaza;

namespace PRIIMERO{
    public class Carro : Monoplaza{
        string Tipo { get; set; }
        string Escuderia { get; set; }
        public List <Estado> Estado { get; private set; } = new List<Estado>();

        public Carro (string tipo, string escuderia){
            this.Tipo = tipo;
            this.Escuderia = escuderia;
            this.Estado.Add(PRIIMERO.Estado.APAGADO);
        }

        public void Encender(){
            if (this.Estado.Contains(PRIIMERO.Estado.APAGADO)){
                this.Estado.Clear();
                this.Estado.Add(PRIIMERO.Estado.ENCENDIDO);
                this.Estado.Add(PRIIMERO.Estado.PARADO);

                Console.WriteLine($"Encendiendo {this.Tipo}");
                return;
            }
            Console.WriteLine("Apaga el carro");
        }

          public void Apagar(){
            if (this.Estado.Contains(PRIIMERO.Estado.ENCENDIDO) && this.Estado.Contains(PRIIMERO.Estado.PARADO)){
                this.Estado.Clear();
                this.Estado.Add(PRIIMERO.Estado.APAGADO);
                Console.WriteLine($"Apagando {this.Tipo}");
                return;
            }
            Console.WriteLine("El vehiculo debe estar encendido y parado");
        }

        public void Movimiento(){
            if (this.Estado.Contains(PRIIMERO.Estado.ENCENDIDO) && this.Estado.Contains(PRIIMERO.Estado.PARADO)){
                this.Estado.Clear();
                this.Estado.Add(PRIIMERO.Estado.MOVIMIENTO);
                this.Estado.Add(PRIIMERO.Estado.ENCENDIDO);
                Console.WriteLine($"{this.Tipo} En movimiento");
                return;
            }
            Console.WriteLine("El Carro debe estar encendido y parado");
        }

        public void Detener(){
            if (this.Estado.Contains(PRIIMERO.Estado.ENCENDIDO) && this.Estado.Contains(PRIIMERO.Estado.MOVIMIENTO)){
                this.Estado.Clear();
                this.Estado.Add(PRIIMERO.Estado.PARADO);
                this.Estado.Add(PRIIMERO.Estado.ENCENDIDO);
                Console.WriteLine($"Parando McLaren {this.Tipo}");
                return;
            }
            Console.WriteLine("El vehiculo debe estar encendido y en movimiento");
        }
    }

    public enum Estado{
        APAGADO,
        ENCENDIDO, 
        MOVIMIENTO, 
        PARADO
    }
}

