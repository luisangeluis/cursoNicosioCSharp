using System;

class Program
{
    static void Main() {
        CImaginario nums1 = new CImaginario(6,6);
        CImaginario nums2 = new CImaginario(2,5);
        
        /*
        Console.WriteLine(nums1);
        nums1++;
        Console.WriteLine(nums1);
        Console.WriteLine("***");
       
        Console.WriteLine(nums2);
        nums2--;
        Console.WriteLine(nums2);
                Console.WriteLine("***");

        Console.WriteLine("***");
        Console.WriteLine("***");

        nums1 += nums2;
        
        Console.WriteLine(nums1);
        */
        
        if(nums1>=nums2){
            Console.WriteLine("Son iguales");
        }

    }
}

class CImaginario{
    private int numEntero;
    private int numImaginario;
    
    public CImaginario(int pNumEntero, int pNumImaginario){
        numEntero = pNumEntero;
        numImaginario = pNumImaginario;
    }
    
    public override string ToString(){
        string datos;
        datos = "Entero: "+numEntero+" Imaginario: "+numImaginario;
        return datos;
    }
    
    //OPERADORS SUMA Y RESTA
    
    public static CImaginario operator +(CImaginario pObj1, CImaginario pObj2){
        int result1;
        int result2;
        
        result1 = pObj1.numEntero+pObj2.numEntero;
        result2 = pObj1.numImaginario +pObj2.numImaginario;
        
        CImaginario temp = new CImaginario(result1,result2);
        return temp;
        
    }
    //OPERADORES UNUARIOS
    public static CImaginario operator ++(CImaginario pObjeto){
        
        CImaginario temp = new CImaginario(pObjeto.numEntero+1,pObjeto.numImaginario+1);
        return temp;
        
    }
    
    public static CImaginario operator --(CImaginario pObjeto){
        
        CImaginario temp = new CImaginario(pObjeto.numEntero-1,pObjeto.numImaginario-1);
        return temp;
        
    }
    
    //SOBRECARGA DE OPERADORES DE IGUALDAD
    
    public override bool Equals(object obj){
        
        if(obj is CImaginario){
            CImaginario temp = (CImaginario)obj;
            
            if(numEntero==temp.numEntero && numImaginario==temp.numImaginario){
                return true;
            }
            
            if(numEntero>=temp.numEntero && numImaginario>=temp.numImaginario){
                return true;
            }
        }
        
        return false;
    } 
    
    
    
    
    public static bool operator ==(CImaginario pImaginario1, CImaginario pImaginario2){
        return pImaginario1.Equals(pImaginario2);
    }
    
    public static bool operator !=(CImaginario pImaginario1, CImaginario pImaginario2){
        return !pImaginario1.Equals(pImaginario2);
    }
    
    public static bool operator >=(CImaginario pImaginario1, CImaginario pImaginario2){
        return pImaginario1.Equals(pImaginario2);
    }
    
    public static bool operator <=(CImaginario pImaginario1, CImaginario pImaginario2){
        return !pImaginario1.Equals(pImaginario2);
    }
    
    
}



