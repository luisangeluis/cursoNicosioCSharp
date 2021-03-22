using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

class Program
{
    static void Main() {
        
        int opcion=0;   
        Console.WriteLine("Ingrese una opcion ");
        Console.WriteLine("1.-Uno para serializar ");
        Console.WriteLine("2.-Dos para deserializar");
        
        opcion = Convert.ToInt32(Console.ReadLine());
        
        if(opcion ==1){
            
            string marca="";
            string modelo ="";
            
            Console.WriteLine("Ingrese marca:");
            marca = Console.ReadLine();
            
            Console.WriteLine("Ingrese modelo:");
            modelo = Console.ReadLine();
    
            CAuto miAuto = new CAuto(marca,modelo);
            
                BinaryFormatter formateador = new BinaryFormatter();
                
                Stream  myStream = new FileStream("Autos.aut",FileMode.Create,FileAccess.Write, FileShare.None);
                
                formateador.Serialize(myStream,miAuto);
                
                myStream.Close();
                
                Console.WriteLine("adios");
        }
        
        

        
    }
}

[Serializable]

class CAuto{
    private string marca;
    private string modelo;
    
    public CAuto(string pMarca, string pModelo){
        marca = pMarca;
        modelo = pModelo;
    }
    
    public override string ToString(){
        return string.Format("marca: {0} modelo: {1}",marca, modelo);
    }
    
    
}