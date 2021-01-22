using System;

class Program
{
    static void Main() {
       int opcion=0;
       int num1;
       int num2;
       
       IOperacion operacion = null;
       
       
       
            
        do{
            try{
            
                do{
                    Console.WriteLine("ingrese la opcion");
                    Console.WriteLine("1 para suma");
                    Console.WriteLine("2 para resta");
                    Console.WriteLine("3 para multiplicacion");
        
                    opcion = Convert.ToInt32(Console.ReadLine());
                    
                    if(opcion <=0 || opcion>3)
                    Console.WriteLine("opcion no valida");
            
                }while(opcion<=0 || opcion>3);
                
            
            
            
                    Console.WriteLine("ingrese el primer numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
        
                    Console.WriteLine("ingrese el segundo numero");
                    num2 = Convert.ToInt32(Console.ReadLine());
        
                    if(opcion ==1)
                    operacion = new CSuma(num1,num2);
        
                    if(opcion ==2)
                    operacion = new CResta(num1,num2);
        
                    if(opcion ==3)
                    operacion = new CMultiplicacion(num1,num2);
        
                    operacion.calcularOperacion();
                    Console.WriteLine(operacion.getResultado());
                
                
                
                
                
            }catch(Exception e){
                Console.WriteLine("opcion no valida");
            }            
                
                
        }while(operacion==null);
        
            
          
        
        
       
        
        Console.WriteLine("hola");
        
        

       
    }
}

interface IOperacion{
    void calcularOperacion();
    int getResultado();

    
}

class CSuma: IOperacion{
    

    public int Resultado{set;get;}
    public int Num1{get;}
    public int Num2{get;}
    
    public CSuma(int pNum1, int pNum2){
        Num1 = pNum1;
        Num2 = pNum2;
    }
    
    public void calcularOperacion(){
        
        Resultado = Num1 + Num2;
    }
    
    public int getResultado(){
        return Resultado;
    }
    
    
}

class CResta: IOperacion{
    
    public int Resultado{set;get;}
    public int Num1{get;}
    public int Num2{get;}
    
    public CResta(int pNum1, int pNum2){
        Num1 = pNum1;
        Num2 = pNum2;
    }
    
    public void calcularOperacion(){
        
        Resultado = Num1 - Num2;
    }
    
    public int getResultado(){
        return Resultado;
    }
    
}

class CMultiplicacion : IOperacion{
    
    public int Resultado{set;get;}
    public int Num1{get;}
    public int Num2{get;}
    
    public CMultiplicacion(int pNum1, int pNum2){
        Num1 = pNum1;
        Num2 = pNum2;
    }
    
    public void calcularOperacion(){
        
        Resultado = Num1 * Num2;
    }
    
    public int getResultado(){
        return Resultado;
    }
    
}