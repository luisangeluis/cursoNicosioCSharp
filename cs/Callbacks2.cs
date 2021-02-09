using System;
using System.Collections;
class Program
{
    static void Main() {
        CRefri miRefri = new CRefri(50,-20);
        
        IEventosRefri sink = new CRefriSink();
        IEventosRefri sinkTienda = new CTiendaSink();
        
        Random rnd = new Random();
        
        miRefri.AgregarSink(sink);
        miRefri.AgregarSink(sinkTienda);
        
        while(miRefri.Kilos>0 && sinkTienda.Paro==false){
            miRefri.Trabajar(rnd.Next(1,5));

        }
        

        
    }
}

interface IEventosRefri{
    
    void EReservasBajas(int pKilos);
    void EDescongelado(double pGrados);
}

class CRefriSink: IEventosRefri{
    
    
    private bool paro=false;
    public bool Paro{get{return Paro;}}
    
    public void EReservasBajas(int pKilos){
        
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Reservas Bajas");
        Console.WriteLine("Quedan {0} kilos", pKilos);
    }
    
    public void EDescongelado(double pGrados){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("El refri se descongela");
        
        
        if(pGrados>0)
        paro = true;
    }
    
}

class CTiendaSink: IEventosRefri{
    
    public void EReservasBajas(int pKilos){
        
        
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Le enviaremos sus viveres");
        Console.WriteLine("Seran: {0}", pKilos);
    }
    
    
    public void EDescongelado(double pGrados){
        
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
        
        if(Grados>=0){
            foreach(IEventosRefri handler in listaSinks){
                handler.EDescongelado(Grados);
            }
        }
        
    }
    
}