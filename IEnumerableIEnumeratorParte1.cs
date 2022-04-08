using System;
using System.Collections;

class Program
{
    static void Main() {
        
        CTiendaAutos Tienda = new CTiendaAutos();
        
        
        foreach(CAuto auto in Tienda){
            auto.CalcularCosto(.1);
            auto.getInformacion();
        }
        
    }
}

interface IVehiculo{
    
    void CalcularCosto(double pImpuesto);
    void getInformacion();
}

class CAuto:IVehiculo{
    
    public string Marca{set;get;}
    public double Costo{set;get;}
    public double Tenencia{set;get;}
    
    public CAuto(string pMarca,double pCosto){
        
        Marca = pMarca;
        Costo = pCosto;
        Tenencia = 0;
        
    }
    
    public void getInformacion(){
        Console.WriteLine("Marca: {0} Costo {1} Tenencia{2}",Marca,Costo,Tenencia);
    }
    
    public void CalcularCosto(double pImpuesto){
        Tenencia = Costo * pImpuesto;
    }
}

class CTiendaAutos{
    
    private CAuto[] autosDisponibles;
    
    public CTiendaAutos(){
        
        autosDisponibles = new CAuto[3];
        
        autosDisponibles[0] = new CAuto("chevy",1000);
        autosDisponibles[1] = new CAuto("cheyene",2000);
        autosDisponibles[2] = new CAuto("aveo",3000);

    }
    
    public IEnumerator GetEnumerator(){
        return autosDisponibles.GetEnumerator();
    }
    
    
}