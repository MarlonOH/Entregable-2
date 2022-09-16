using PRIIMERO;

Carro vec = new Carro("McLaren", "2");
Carro asd = new Carro("Ferraria", "2");
Carro qda = new Carro("Redbull", "2");
Circuito cir = new Circuito(6, "Nascar");

cir.Añadir_Carro(vec);
var dict = cir.Realizar_Prueba();