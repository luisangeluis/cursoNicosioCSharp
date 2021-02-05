using System;
using System.Collections;
class Program
{
    static void Main() {
        CRefri miRefri = new CRefri(50,15);
        
        IEventosRefri sink = new CRefriSink();
        
        Random rnd = new Random();
        
        miRefri.AgregarSink(sink);
        
        while(miRefri.Kilos>=10){
            miRefri.Trabajar(rnd.Next(1,5));

        }
        

        
    }
}

interface IEventosRefri{
    
    void EReservasBajas(int pKilos);
}

class CRefriSink: IEventosRefri{
    
    public void EReservasBajas(int pKilos){
        
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Reservas Bajas");
        Console.WriteLine("Quedan {0} kilos", pKilos);
    }
}


class CRefri{
    
    private ArrayList listaSinks = new ArrayList();
    
    public int Kilos{set; get;}
    public double Grados{set;get;}
    
    public CRefri(int pKilos, double pGrados){
        Kilos = pKilos;
        Grados= pGrados;
    }
    
    public void AgregarSink(IEventosRefri pSink){
        if(pSink !=null){
            listaSinks.Add(pSink);
        }
    }
    
    public void EliminarSink(IEventosRefri pSink){
        
        if(listaSinks.Contains(pSink)){
            listaSinks.Remove(pSink);
        }
    }
    
    public void Trabajar(int pConsumo){
        Kilos -=pConsumo;
        Grados+=1;
        
        Console.WriteLine("kilos {0}",Kilos);
        Console.WriteLine("grados: {0}",Grados);
        
        if(Kilos<10){
            foreach(IEventosRefri handler in listaSinks){
                handler.EReservasBajas(Kilos);
            }
        }
        
    }
    
}