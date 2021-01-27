using System;
using System.Collections;

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;
        CClaseContenedora numeros = new CClaseContenedora();
        

        //Console.Write("Sum of x + y = "+ z);
        
        foreach(int numero in numeros){
            Console.WriteLine(numero);
        }
    }
}

class CClaseContenedora:IEnumerable{
    private int[] numeros = new int[10];
    
    public CClaseContenedora(){
        for(int x =0; x<numeros.Length; x++){
            numeros[x] = x*x;
        }
    }
    
    IEnumerator IEnumerable.GetEnumerator(){
        
        return (new CContenedorEnum(numeros));
    }
    
}

class CContenedorEnum:IEnumerator{
    
    private int []arreglo;
    
    
    private int posicion = -1;
    
    public CContenedorEnum(int []pArreglo){
        arreglo = pArreglo;
        
    }
    
    public bool MoveNext(){
        posicion++;
        if (posicion<arreglo.Length)
            return true;
        else
            return false;
    }
    
    public void Reset(){
        posicion =-1;
    } 
    
    public object Current{
        
        get{
            return arreglo[posicion];
        }
    }
    
    
}