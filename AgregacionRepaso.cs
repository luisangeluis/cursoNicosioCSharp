using System;

class Program
{
    static void Main() {
        CEdificio edif1= new CEdificio("silvestre vargas",5);
        CPropietario propietario1 = new CPropietario("luis",30);
        
        Console.WriteLine(propietario1.mostrarPropiedad());
        propietario1.agregarPropiedad(edif1);
        Console.WriteLine(propietario1.mostrarPropiedad());

        
    }
}


class CEdificio{
    
    
    //private string direccion="";
    //private int numDepart=0;
    
    public string Direccion{set;get;}
    public int NumDepart{set;get;}
    
    public CEdificio(string pDireccion, int pNumDepart ){
        Direccion = pDireccion;
        NumDepart = pNumDepart;
    }
    
    public string toString(){
        
     string datos;
     datos="direccion: "+Direccion+" numero de Deptos: "+NumDepart;
     return datos;
     
    }
    
    
    
}

class CPropietario{
    
    private string nombre="";
    private int edad=0;
    
    
    
    private CEdificio propiedad=null;
    
    public CPropietario(string pNombre, int pEdad){
        nombre = pNombre;
        edad = pEdad;
    }
    
    public string mostrarPropiedad(){
        
        string infoPropiedad="";
        if(propiedad!=null){
            infoPropiedad = nombre+" tiene propiedad en: "+ propiedad.toString();
            
        }else{
            infoPropiedad = nombre+" no tiene propiedades";
            
        }
        
        return infoPropiedad;

    }
    
    public void agregarPropiedad(CEdificio pPropiedad){
        if(pPropiedad!=null){
            propiedad = pPropiedad;
        }
        
    }
}
