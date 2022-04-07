using System;
using System.Collections.Generic;

class Program
{
    static void Main() {
        
        
        int opcion = 0;
        double valor1=0;
        double valor2=0;
        IOperacion operacion = new CSuma();
        
        
        
        while(opcion != 3){
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("1.-Presiona uno para suma");
            Console.WriteLine("2.-Presiona dos para resta");
            Console.WriteLine("3.-Presiona tres para salir");

            opcion = Convert.ToInt32(Console.ReadLine());
            switch(opcion){
                case 1:
                    operacion = new CSuma();  
                break;
                case 2:
                    operacion = new CResta();  
                break;
                
            }
        
            if(opcion>0 && opcion<3){
                Console.WriteLine("Ingresa el primer valor");
                valor1 =Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor");
                valor2 =Convert.ToDouble(Console.ReadLine());
        
                operacion.Calcular(valor1,valor2);
                operacion.MostrarResultado();
            } 
        }
        
        
        
        

        
    }
}

interface IOperacion{
    void Calcular(double num1,double num2);
    void MostrarResultado();
}

class CSuma:IOperacion{
    
    public double Result{set;get;}
    //private List<double> results = new List<double>();
    
    public CSuma(){
        
    }
    
    public void Calcular(double num1,double num2){
        Result = num1+num2;
    }
    
    public void MostrarResultado(){
        Console.WriteLine("El resultado de la suma es: {0}",Result);
    }
    
    public void MetodoPropio(){
        Console.WriteLine("Metodo propio suma");
    }
    
}

class CResta:IOperacion{
    
    public double Result{set;get;}
    //private List<double> results = new List<double>();
    
    public CResta(){
        
    }
    
    public void Calcular(double num1,double num2){
        Result = num1-num2;
    }
    
    public void MostrarResultado(){
        Console.WriteLine("El resultado de la resta es: {0}",Result);
    }
    
    public void MetodoPropio(){
        Console.WriteLine("Metodo propio resta");
    }
    
}