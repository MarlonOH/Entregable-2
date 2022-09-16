using PRIMEROO.Clases;

Fabrica Ferrari = new Fabrica("1","Ferrari");
Fabrica Mclaren = new Fabrica("2","Mclaren");
Fabrica RedBull = new Fabrica("3","RedBull");
Circuito Circuito = new Circuito(Ferrari, Mclaren, RedBull, "Apolo", 3);
Circuito.AgregarMP(Ferrari);
Circuito.Realizar_Prueba(Circuito.RNumero_Vueltas(), Ferrari.RMarca());
Circuito.SacarMP();
Circuito.AgregarMP(Mclaren);
Circuito.Realizar_Prueba(Circuito.RNumero_Vueltas(), Mclaren.RMarca());
Circuito.SacarMP();
Circuito.AgregarMP(RedBull);
Circuito.Realizar_Prueba(Circuito.RNumero_Vueltas(), RedBull.RMarca());
Circuito.SacarMP();
Circuito.ListaR();