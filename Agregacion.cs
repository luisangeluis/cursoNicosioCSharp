using System;
using System.Collections.Generic;

class Program
{
    static void Main() {
       
        CCarro carro1= new CCarro("chevrolet","deportivo","rojo");
        CCarro carro2= new CCarro("jeep","deportivo","azul");
        CCarro carro3= new CCarro("ford","familiar","negro");
        CCarro carro4= new CCarro("nissan","4*4","blanco");
        
        List <CCarro> Lista = new List<CCarro>();
        
        CPropietario propietario1 = new CPropietario("Luis");
        
        
        Lista.Add(carro1);
        Lista.Add(carro2);
        Lista.Add(carro3);
        Lista.Add(carro4);
        
        propietario1.MostrarCarro();
        
        Console.WriteLine("------------");
        propietario1.AgregarCarro(Lista);
        propietario1.MostrarCarro();

    
    }
}

//CLASE PROPIETARIO
public class CPropietario{
    
    public string Nombre {set;get;}
    
    //private CCarro carro = null;
    private List<CCarro> ListaCarros = null;
    
    
    public CPropietario(string pNombre){
        Nombre = pNombre;
        
    }
    
    public override string ToString(){
        return string.Format("Nombre del propietario: {0}",Nombre);
    }
    public void MostrarCarro(){
        /*
        if(carro !=null){
            
            carro.MostrarInfo();
        }else{
            Console.WriteLine("Aun no hay carro asignado");
        }
        */
        Console.WriteLine(ToString());
        if(ListaCarros!=null){
            foreach(CCarro c in ListaCarros){
                c.MostrarInfo();
            }
        }else{
            
            Console.WriteLine("aun no hay carros");
        }
    }
    
    public void AgregarCarro(List<CCarro> pLista){
        /*
        if(pCarro!=null){
            carro = pCarro;
        }
        */
        
        if(pLista!=null){
            ListaCarros = pLista;
        }
        
    }
    
}

//CLASE CARRO
public class CCarro{
    
    public string Marca {set;get;}
    public string Modelo {set;get;}
    public string Color {set;get;}
    
    public CCarro(string pMarca, string pModelo,string pColor){
        Marca = pMarca;
        Modelo = pModelo;
        Color = pColor;
    }
    
    public void MostrarInfo(){
        Console.WriteLine("Marca: {0} Modelo: {1} Color: {2}",Marca,Modelo,Color);
    }
    
}
