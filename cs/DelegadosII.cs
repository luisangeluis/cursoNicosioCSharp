using System;

class Program
{
    static void Main() {
       CRefri miRefri = new CRefri(50, -20);
       
       Random rnd = new Random();
       
       miRefri.AgregarDelReservasBajas(new CRefri.DelReservasBajas(alertarReservasBajas));
       miRefri.AgregarDelDescongelado(new CRefri.DelDescongelado(alertaGradosRefri));
       
       
       while(miRefri.Kilos>0 ){
           miRefri.Trabajar(rnd.Next(1,5));
       }
    }
    
    public static void alertarReservasBajas(int pKilos){
        Console.WriteLine("Reservas bajas");
        Console.WriteLine("quedan {0}",pKilos);
        Console.WriteLine("Pedir alimentos");
    }
    
    public static void alertaGradosRefri(int pGrados){
        Console.WriteLine("Alerta temperatura");
        Console.WriteLine("Grados {0}",pGrados);


    }
}

class CRefri{
    public int Kilos{set; get;}
    public int Grados{set; get;}
    
    public delegate void DelReservasBajas(int pKilos);
    public delegate void DelDescongelado(int pGrados);
    
    DelReservasBajas delReservas;
    DelDescongelado delDescong;
    
    public CRefri(int pKilos, int pGrados){
       Kilos = pKilos;
       Grados = pGrados;
    }
    
    
    public void AgregarDelReservasBajas(DelReservasBajas pMetodo){
        delReservas = pMetodo;
    }
    
    public void AgregarDelDescongelado(DelDescongelado pMetodo){
        delDescong = pMetodo;
    }
    
    public void Trabajar(int pConsumo){
        
        
        Kilos -=pConsumo;
        Grados++;
        
        Console.WriteLine("kilos: {0}",Kilos);
        Console.WriteLine("Grados: {0}",Grados);
        
        if(Kilos<10){
          delReservas(Kilos);
        }
        
        if(Grados>0){
           delDescong(Grados); 
        }

        
        
    }
    
     
}