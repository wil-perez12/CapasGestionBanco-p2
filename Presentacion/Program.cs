
using logicaNegocios;

BancoGestionCuentas gestion = new BancoGestionCuentas();


int opcion;
int monto;

Console.WriteLine("Ingrese su nombre");
gestion.propietario.nombre = Console.ReadLine();

Console.WriteLine("ingrese su numero de documento");
gestion.propietario.numeroDocumento = int.Parse(Console.ReadLine());

Console.WriteLine("ingrese su numero de cuenta");
gestion.NumeroCuenta = int.Parse(Console.ReadLine());


do {
	Console.WriteLine("-----------------------");
    Console.WriteLine("BAN RESERVAS");
    Console.WriteLine("-----------------------");
    Console.WriteLine("Selecione una opcion");
	Console.WriteLine("1-Agregar saldo");
    Console.WriteLine("2-Retirar Monto");
    Console.WriteLine("3-Ver informacion de la cuenta");
    Console.WriteLine("4-Ver historial de transacciones");
    Console.WriteLine("5-Salir");
    opcion = int.Parse( Console.ReadLine() );

   

    switch (opcion)
	{
        case 1:
            Console.WriteLine("Ingrese monto a depositar");
            monto = int.Parse(Console.ReadLine());
            gestion.AgregarSaldo(monto);
            break;

        case 2:
            Console.WriteLine("Ingrese monto a retirar");
            monto = int.Parse(Console.ReadLine());
            gestion.RetirarMonto(monto);
            break;

        case 3:
            gestion.MostarInfo();
            break;

        case 4:
            gestion.MostrarHistorial();
            break;

        case 5:
            Console.WriteLine("Saliendoooo");
            break;

        default:
            Console.WriteLine("Opcion seleccionada no valida");
            break;
    }

}while (opcion != 5);