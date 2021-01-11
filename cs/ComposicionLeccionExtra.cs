using System;

class Program
{
    static void Main() {
        CEscuela escuela = new CEscuela("ESCUELA LUIS");
        
        escuela.asignarAulas();
       Console.WriteLine(escuela.ToString());
    }
}

class CAula{
    
    //private string nombre;
    //private int cantidadAlumn;
    
    public string Nombre{set; get;}
    public int CantidadAlumn{set; get;}
    
    public CAula(string pNombre, int pCantidadAlumn){
        Nombre = pNombre;
        CantidadAlumn = pCantidadAlumn;
    }
    
    public override string ToString(){
        
        string informacion="";
        
        informacion = string.Format("El aula {0} tiene {1} alumnos",Nombre,CantidadAlumn);
        return informacion;
    }
}



class CEscuela{
    
    private string NombreEscuela{set; get;}
    
    private CAula[] aulas = new CAula[3];
    
    public CEscuela(string pNombreEscuela){
        NombreEscuela = pNombreEscuela;
    }
    
    public void asignarAulas(){
        string nombre;
        int cantidad;
        string dato;
        
        try{
            for(int x=0; x<aulas.Length; x++){
            Console.WriteLine("Ingresa el nombre del aula: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingresa la cantidad de alumnos");
            dato = Console.ReadLine();
            cantidad = Convert.ToInt32(dato);
            
            aulas[x]= new CAula(nombre, cantidad); 
        }
            
        }catch(Exception e){
            Console.WriteLine("Salio un error: {0}", e);
        }
        
        Console.WriteLine("intenta de nuevo");
        
    }
    
    public override string ToString(){
        
        string informacion="";
        
        informacion = string.Format("Bienvenidos a la escuela: {0}\r\n",NombreEscuela);
        for(int x = 0; x<aulas.Length; x++){
            
           informacion += aulas[x].ToString()+"\r\n";
        }
        
        return informacion;
    }
    
    
}