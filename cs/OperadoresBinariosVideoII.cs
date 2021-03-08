using System;

class Program
{
    static void Main() {
        CImaginario grupo1 = new CImaginario(11,18);
        CImaginario grupo2 = new CImaginario(5,10);
        
        CImaginario result;
        
        result= grupo1-grupo2;
        
        Console.WriteLine(result);
        
        Console.WriteLine("{0} - {1} = {2}",grupo1,grupo2,result);

    }
}

class CImaginario{
    public double Entero{set; get;}
    public double Imaginario{set; get;}
    
    public CImaginario(double pEntero, double pImaginario){
        Entero = pEntero;
        Imaginario = pImaginario;
    }
    
    public static CImaginario operator -(CImaginario pParam1, CImaginario pParam2){
        
        double r1=0;
        double r2=0;
        
        r1=pParam1.Entero-pParam2.Entero;
        r2=pParam1.Imaginario-pParam2.Imaginario;
        
        CImaginario temp = new CImaginario(r1,r2);
        return temp;
        
    }
    
    public override string ToString(){
        return string.Format("{0} {1}i",Entero,Imaginario);
    }
    
    
}