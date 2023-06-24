/*Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:"+b);*/
//Punto1
/*Console.WriteLine("Escriba un numero:");
if (float.TryParse(Console.ReadLine(),out float num))
{
    if (num > 0)
    {
        float invertido = (1/num);
        Console.WriteLine("El numero invertido es: "+invertido);
    }
}
else
{
    Console.WriteLine("No ingresaste un numero");
}*/

//Punto2
/*int a, r, b, i = 1;
while (i != 0)
{
    Console.WriteLine("Seleccione la operacion que desea realizar:");
    Console.WriteLine("1-Sumar");
    Console.WriteLine("2-Restar");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    r = int.Parse(Console.ReadLine());
    //int.TryParse(Console.ReadLine(),out r);
    switch (r)
    {
        case 1:
            Console.WriteLine("Ingrese 2 numeros");
            int.TryParse(Console.ReadLine(),out a);
            int.TryParse(Console.ReadLine(),out b);
            Console.WriteLine("El resultado es:" + (a + b));
            break;
        case 2:
            Console.WriteLine("Ingrese 2 numeros");
            int.TryParse(Console.ReadLine(),out a);
            int.TryParse(Console.ReadLine(),out b);
            Console.WriteLine("El resultado es:" + (a - b));
            break;
        case 3:
            Console.WriteLine("Ingrese 2 numeros");
            int.TryParse(Console.ReadLine(),out a);
            int.TryParse(Console.ReadLine(),out b);
            Console.WriteLine("El resultado es:" + (a * b));
            break;
        case 4:
            Console.WriteLine("Ingrese 2 numeros");
            int.TryParse(Console.ReadLine(),out a);
            int.TryParse(Console.ReadLine(),out b);
            Console.WriteLine("El resultado es:" + (a / b));
            break;
        default:
            Console.WriteLine("No ingresaste una opcion valida");
            break;
    }
    Console.WriteLine("¿Desea seguir operando?(Si=1 - No=0)");
    int.TryParse(Console.ReadLine(),out i);
}*/