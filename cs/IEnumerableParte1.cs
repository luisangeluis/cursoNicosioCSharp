using System;
using System.Collections;

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;
        CTiendaAutos tienda = new CTiendaAutos(); 

        Console.Write("Sum of x + y ="+ z+"\r\n");

        foreach(CAuto auto in tienda){
            Console.WriteLine(auto.toString());
        }
        
        
    }
}

class CAuto{
    public string Marca {set; get;}
    public string Modelo{set; get;}
    public double Costo{set; get;}
    
    public CAuto(string pMarca, string pModelo, double pCosto){
        Marca=pMarca;
        Modelo = pModelo;
        Costo = pCosto;
    }
    
    public string toString(){
        string datos;
        datos = "marca: "+Marca+" modelo: "+Modelo+ " costo "+Costo+"\r\n";
        return datos;
    }
    
    
    
}

class CTiendaAutos{
    
    private CAuto []autos = null;
    
    public CTiendaAutos(){
        autos = new CAuto[3];
        
        autos[0] = new CAuto("ford", "2000", 10000);
        autos[1] = new CAuto("chevrolet", "2012", 20000);
        autos[2] = new CAuto("nissan", "2010", 30000);
    }
    
    public IEnumerator GetEnumerator(){
        return autos.GetEnumerator();
    }
    
}