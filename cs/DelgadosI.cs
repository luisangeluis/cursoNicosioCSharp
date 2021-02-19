using System;


                public delegate void MiDelegado(string pM);

class Program
{

    static void Main() {
        
        MiDelegado delegado1 = new MiDelegado(CRadio.MensajeRadio);
        
        delegado1("hola");
        
        delegado1 = new MiDelegado(CPastel.MensajePastel);
        
        delegado1("feliz cumpleaños");
        
        
        
    }
}

class CRadio{
    
    public static void MensajeRadio(string pM){
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Estamos en la clase radio");
        Console.WriteLine("tu mensaje de la radio es: {0}",pM);
    }
    
}

class CPastel{
    public static void MensajePastel(string pM){
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Estamos en la clase pastel");
        Console.WriteLine("tu mensaje de cumpleaños es: {0}",pM);
    }
}