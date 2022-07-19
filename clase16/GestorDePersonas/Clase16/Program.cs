//// Gestor de personas trabajadoras (empleados, desempleados, jubilados)
//// Insertar personas en una base de datos, mostrar datos de una determinada persona,
//// o de todas las personas.

//using Clase16.Modelo;
//using Clase16.Repositorio;

////var listaDePersonasTrabajadoras = new List<Persona>();
//// //en este caso no me 
////listaDePersonasTrabajadoras.Add(new Empleado());

//var repositorio = new RepositorioDePersona();
//repositorio.Existe("23721352");

////Le pido al usuario los datos de una persona para agregar
////El usuario debería elegir el tipo de persona a agregar
//var usuarioNombre = "Ezequiel";
//var usuarioApellido = "Etchecoin";
//var usuarioDNI = "23721352";

//repositorio.Insertar(new Desempleado
//{
//    Nombre = usuarioNombre,
//    Apellido = usuarioApellido
//});

////var menuAplicacion = new MenuAplicacion();
////menuAplicacion.Iniciar();

using Clase16.Frontend;

var menuAplicacion = new MenuAplicacion();
menuAplicacion.Iniciar();