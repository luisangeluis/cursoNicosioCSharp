using System;

class Program
{
    static void Main() {
        int x = 10;
        int y = 25;
        int z = x + y;

        //Console.Write("Sum of x + y = "+ z);
        
        
        CRectangulo[] rects = new CRectangulo[5];
        
        rects[0] = new CRectangulo(10,12);
        rects[1] = new CRectangulo(5,2);

        rects[2] = new CRectangulo(10,10);

        rects[3] = new CRectangulo(29,2);

        rects[4] = new CRectangulo(4,8);
        
        foreach(CRectangulo rect in rects){
            Console.WriteLine(rect);
        }
        
        Console.WriteLine("*********************");
        
        Array.Sort(rects);
        
        foreach(CRectangulo rect in rects){
            Console.WriteLine(rect);
        }

    }
}

class CRectangulo:IComparable{
    
    public double Alto{set; get;}
    public double Ancho{set;get;}
    public double Area{get;set;}
    
    
    public CRectangulo(double pAlto, double pAncho){
        Alto = pAlto;
        Ancho = pAncho;
        CalcularArea();
    }
    
    private void CalcularArea(){
        Area = Alto*Ancho;
    }
    
    public override string ToString(){
        
        return string.Format("Alto: {0} Ancho: {1} Area: {2} \r\n",Alto,Ancho,Area);
    }
    
    
    int IComparable.CompareTo(object obj){
        
        CRectangulo temp = (CRectangulo)obj;
        
        if(Area > temp.Area)
            return 1;
        
        if(Area < temp.Area)
            return -1;
            
        return 0;    
    }
    
    
}