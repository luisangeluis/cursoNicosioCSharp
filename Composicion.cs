using System;
using System.Collections.Generic;

class Program
{
    static void Main() {
        
        CPropietario pedro = new CPropietario("pedro");
        
        pedro.MostrarPropiedades();
        
        pedro.AgregarPropiedades(3);
        
        pedro.MostrarPropiedades();

    }
}

class CPropietario{
    public string Nombre {set;get;}
    private List<CPropiedad> Propiedades = null;
    
    public CPropietario(string pNombre){
        
        Nombre = pNombre;
        
        Propiedades = new List<CPropiedad>();
    }
    
    public void MostrarPropiedades(){
        if(Propiedades.Count>0){
            foreach(CPropiedad p in Propiedades){
                Console.WriteLine(p);
            }
        }else{
            Console.WriteLine("Aun no hay propiedades");
        }
    }
    
    public bool AgregarPropiedades(int pCantidad){
        
        bool agregadas = false;
        int propiedadesAgregadas =0;
        string nombre ="";
        int numCuartos=0;
        CPropiedad propiedad = null;
        
        for(int i =0; i<pCantidad;i++){
            try{
                Console.WriteLine("Ingrese el nombre de la propiedad");
                nombre = Console.ReadLine();
            
                Console.WriteLine("Ingrese el numero de cuartos");
                numCuartos = Convert.ToInt32(Console.ReadLine());
            
                propiedad = new CPropiedad(nombre,numCuartos);
                
                Propiedades.Add(propiedad);
                propiedadesAgregadas++;
            }catch(Exception e){
                Console.WriteLine(e);
            }
                
           
            
        }
        
        if(propiedadesAgregadas>0)
            agregadas = true;
        
        return agregadas;
        
    }
    
    
    
}

class CPropiedad{
    public string Nombre{set;get;}
    public int NumCuartos{set;get;}
    
    public CPropiedad(string pNombre,int pNumCuartos){
        Nombre = pNombre;
        NumCuartos = pNumCuartos;
    }
    
    public override string ToString(){
        return string.Format("Nombre de la propiedad: {0} \n\r Numero de cuartos: {1}",Nombre,NumCuartos);
    }
    
}