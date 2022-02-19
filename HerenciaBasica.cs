using System;

class Program
{
    static void Main() {
        
        CEmpleado persona = new CEmpleado("luis",30,"operador",1000);    
        
        persona.MostrarEmpleado();
    }
}

class CPersona{
    public string Nombre {set;get;}
    public int Edad{set;get;}
    
    public CPersona(string pNombre,int pEdad){
        Nombre = pNombre;
        Edad = pEdad;
    }
    
    public void MostrarInfo(){
        Console.WriteLine("nombre: {0}, edad {1}",Nombre,Edad);
    }
}

class CEmpleado:CPersona{
    public string Puesto{set;get;}
    public double Sueldo{set;get;}
    
    public CEmpleado(string pNombre,int pEdad,string pPuesto,double pSueldo):
                    base(pNombre,pEdad)
    {
        Puesto = pPuesto;
        Sueldo = pSueldo;
    }
    
    public void MostrarEmpleado(){
        MostrarInfo();
        Console.WriteLine("puesto: {0}, sueldo {1}",Puesto,Sueldo);
    }
}