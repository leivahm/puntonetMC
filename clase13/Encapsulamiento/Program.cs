using Encapsulamiento.Modelo;


Console.WriteLine("Estamos creando un nuevo Auto. Ingrese el Tipo de Motor: ");
var tipoMotor = Console.ReadLine();

var miAuto = new Auto();
miAuto.TipoDeMotor = tipoMotor;

Console.WriteLine(miAuto.TipoDeMotor);
