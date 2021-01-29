using System;

class Program
{
    static void Main() {
        CAutomovil auto1 = new CAutomovil("cheyene",2000);
        auto1.CalculaTenencia();
        Console.WriteLine(auto1.MuestraInformacion());
        
        CAutomovil auto2 = (CAutomovil)auto1.Clone();
        
        Console.WriteLine("hola");
        
        Console.WriteLine(auto2.MuestraInformacion());
        
        auto1.Modelo= "ford";
        Console.WriteLine(auto1.MuestraInformacion());
        Console.WriteLine(auto2.MuestraInformacion());


        
    }
}

interface IVehiculo{
    void CalculaTenencia();
    string MuestraInformacion();
    
}

class CAutomovil: IVehiculo, ICloneable{
    
    public double Costo {set;get;}
    public string Modelo{set;get;}
    public double Tenencia {set;get;}
    
    
    public CAutomovil(string pModelo, double pCosto){
        Modelo = pModelo;
        Costo = pCosto;
        Tenencia=0.0;
        
    }
    
    public void CalculaTenencia(){
        Tenencia = Costo *.10;
    }
    
    public string MuestraInformacion(){
        string datos;
        datos = "Modelo: "+Modelo+" Costo: "+Costo+ " Tenencia: "+Tenencia;
        return datos;
    }
    
    public object Clone(){
        CAutomovil temp = new CAutomovil(Modelo,Costo);
        temp.Tenencia = Tenencia;
        return temp;
    }
    
    
}