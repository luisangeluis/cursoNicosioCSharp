using System;

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        Console.Write("Sum of x + y = "+ z+"\r\n");
        
        
        CFrutas f1 = new CFrutas(5,10);
        CFrutas f2 = new CFrutas(3,11);
        CFrutas fResult;
        fResult = f1+f2;
        Console.WriteLine(fResult);
        
        

    }
}


class CFrutas{
    public int NumManzanas {set; get;}
    public int NumNaranjas{set; get;}
    
    public CFrutas(int pNumManzanas, int pNumNaranjas){
       NumManzanas = pNumManzanas;
       NumNaranjas = pNumNaranjas;
    }
    
    public static CFrutas operator +(CFrutas frutas1, CFrutas frutas2){
        int r1;
        int r2;
        
        r1 = frutas1.NumManzanas+frutas2.NumManzanas;
        r2 = frutas1.NumNaranjas + frutas2.NumNaranjas;
        
        CFrutas temp = new CFrutas(r1,r2);
        return temp;
    }
    
    public override string ToString(){
        return string.Format("manzanas:{0} naranjas{1}",NumManzanas,NumNaranjas);
    }
    
    
}