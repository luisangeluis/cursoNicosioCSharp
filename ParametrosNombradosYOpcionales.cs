using System;

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z);
        Console.WriteLine();
        
        mostrarDatos(1,2,3);
        //PARAMETROS NOMBRADOS: INDICAS DONDE PONER EL ARGUMENTO 
        //parametros nombrados sin importar el orden del argumento tu indicas que valor asignarle a los parametros
        //puedes combinarlos la unica combinacion 
        //no valida es: mostrarDatos(pB:10,7,8); porque empieza con uno nombrado y los demas posicionales
        mostrarDatos(1,pC:2,pB:10);
        
        //CON PARAMETROS OPCIONALES
        
        mostrarOpcionales(pC:10);
        
    }
    
    public static void mostrarDatos(int pA, int pB, int pC){
        Console.WriteLine("a: {0}",pA);
        Console.WriteLine("b: {0}",pB);
        Console.WriteLine("c: {0}",pC);

    }
    
    public static void mostrarOpcionales(int pA=1, int pB=2, int pC=3){
        Console.WriteLine("Parametros opcionales");

        Console.WriteLine("a: {0}",pA);
        Console.WriteLine("b: {0}",pB);
        Console.WriteLine("c: {0}",pC);

    }
}