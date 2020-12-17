using System;

class Program
{
    static void Main() {
        
        
        CEmpleado emp1= new CEmpleado("luis",29,"operador",5000);
        emp1.MuestraEmpleado();
        emp1.CambiarDatos("angel", 30,"supervisor",10000);
        emp1.MuestraEmpleado();
    }
}

class CPersona{
    
    private string nombre;
    private int edad;
    
    public CPersona(string pNombre, int pEdad){
        nombre = pNombre;
        edad = pEdad;
    }
    
    
    public string Nombre{
        set{
            nombre = value;
        }
        get{
            return nombre;
        }
    }
    
    public int Edad{
        set{
            edad = value;
        }
        get{
            return edad;
        }
    }
    
    public void Muestra(){
        Console.WriteLine("Nombre: {0} Edad: {1}",nombre,edad);
        
    }
    
    
}

class CEmpleado:CPersona{
    
    private string puesto;
    private double salario;
    
    public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario)
                    : base(pNombre, pEdad)
    {
        puesto = pPuesto;
        salario=pSalario;
        
    }
    
    
    public string Puesto{
        set{
            puesto = value;
        }
        get{
            return puesto;
        }
    }
    
    public double Salario{
        set{
            salario= value;
        }
        get{
            return salario;
        }
    }
    
    public void MuestraEmpleado(){
        Muestra();
        Console.WriteLine("Puesto: {0} Salario: {1}",puesto,salario);
    }
    
    public void CambiarDatos(string pNombre, int pEdad, string pPuesto, double pSalario){
        Nombre = pNombre;
        Edad = pEdad;
        puesto = pPuesto;
        salario = pSalario;
    }
}