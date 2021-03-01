using System;

class Program
{
    static void Main() {
        DReservasBajas kilos1 = new DReservasBajas(alertaReservasBajas);
        DReservasBajas kilos2 = new DReservasBajas(CTienda.EnviarSuministros);

        DDescongelado grados1 = new DDescongelado(alertaTemperatura);
        
        
        CRefri miRefri = new CRefri(70,-20);
        
        miRefri.AdicionarMetodoReservas(kilos1);
        miRefri.AdicionarMetodoReservas(kilos2);

        miRefri.AdicionarMetodoDescongelado(grados1);
        
        
        Random rnd = new Random();
        
        while(miRefri.Kilos>0){
            miRefri.Trabajar(rnd.Next(1,5));
        }
        
        
        
    }
    
    public static void alertaReservasBajas(int pKilos){
        Console.WriteLine("Reservas bajas");
        Console.WriteLine("Quedan {0}, kilos",pKilos);
    }
    
    public static void alertaTemperatura(int pGrados){
        Console.WriteLine("Alerta temperatura");
        Console.WriteLine("Grados: {0}", pGrados);
    }
}


 delegate void DReservasBajas(int pKilos);
 delegate void DDescongelado(int pGrados);
 
class CRefri{
    
    
    public int Kilos{set; get;}
    public int Grados{set; get;}
    
    
    private DReservasBajas delReservasBajas;
    private DDescongelado delDescongelado;
    
    public CRefri(int pKilos, int pGrados){
        Kilos = pKilos;
        Grados = pGrados;
    }
    
    
    public void AdicionarMetodoReservas(DReservasBajas pMetodo){
        delReservasBajas+=pMetodo ; 
    }
    
    public void AdicionarMetodoDescongelado(DDescongelado pMetodo){
        delDescongelado +=pMetodo;
    }
    
    public void Trabajar(int pConsumo){
        Kilos-=pConsumo;
        Grados++;
        
        
        Console.WriteLine("KILOS: {0}",Kilos);
        Console.WriteLine("GRADOS: {0}",Grados);
        
        if(Kilos<10){
            delReservasBajas(Kilos);
        }
        
        if(Grados>0){
            delDescongelado(Grados);
        }
    }
    
}

class CTienda{
    
    public static void EnviarSuministros(int pKilos){
        Console.WriteLine("Se recibio su solicitud");
        Console.WriteLine("Se enviaran {0}", pKilos);
    }
    
}
