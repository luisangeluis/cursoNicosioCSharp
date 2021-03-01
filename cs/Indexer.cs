using System;

class Program
{
    static void Main() {
        
        CTienda miTienda = new CTienda();
        CAuto auto1 = miTienda[1];
        
        auto1.MostrarInformacion();
        
        Console.WriteLine("*************");
        
        miTienda[3]=auto1;
        
        
        for(int i =0; i<4;i++){
            miTienda[i].MostrarInformacion();
        }
    }
}

class CAuto{
    private string marca;
    private double costo;
    
    public string Marca{
        set{
            marca = value;
        }
        get{
           return marca; 
        }
    }
    
    public CAuto(string pMarca, double pCosto ){
        marca= pMarca;
        costo = pCosto;
    }
    
    public void MostrarInformacion(){
        Console.WriteLine("MARCA: {0} COSTO:{1}",marca,costo);
    }
    
}

class CTienda{
    private CAuto[] disponibles=null;
    
  public CTienda(){
    disponibles = new CAuto[4];
    disponibles[0] = new CAuto("ford",100);
    disponibles[1] = new CAuto("HONDA",200);
    disponibles[2] = new CAuto("NISSAN",300);
    disponibles[3] = new CAuto("CHEVROLET",400);

  }  
  
  
  public CAuto this[int indice]{
      get{
        return disponibles[indice];
      }
      set{
         disponibles[indice]=value; 
      }
  }
  
}
