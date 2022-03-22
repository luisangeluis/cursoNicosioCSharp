using System;

class Program
{
    static void Main() {
        CProduct uno = new CProduct("producto 1", 10);
        uno.CalculaPrecioVenta();
        Console.WriteLine(uno);
        
        Console.WriteLine();
        
        CProductoImportado dos = new CProductoImportado("producto 2", 10,2);
        dos.CalculaPrecioVenta();
        Console.WriteLine(dos);
        
        Console.WriteLine();

        CProductoDetenido tres = new CProductoDetenido("producto 3", 10,2,2);
        tres.CalculaPrecioVenta();
        Console.WriteLine(tres);



    }
}

class CProduct{
    public string Nombre;
    private double precioCompra; 
    private double precioVenta;
    
    //SETTERS Y GETTERS
    public double PrecioCompra{
        set{precioCompra = value;}
        get{return precioCompra;}
    }
    public double PrecioVenta{
        
        set{precioVenta = value;}
        get{return precioVenta;}
        
    }
    
    //CONSTRUCTOR
    public CProduct(string pNombre,double pPrecioCompra){
        Nombre = pNombre;
        PrecioCompra = pPrecioCompra;
        PrecioVenta = 0.0;
    }
    
    public virtual void CalculaPrecioVenta(){
        Console.WriteLine("Calcula precio de venta");
        precioVenta = precioCompra * 1.3;
    }
    
    
    
    public override string ToString(){
        return string.Format("Nombre: {0} Precio de venta: {1}",Nombre,PrecioVenta);
    }
       
}

class CProductoImportado:CProduct{
    public double Impuesto{set;get;}
    
    public CProductoImportado(string pNombre,double pPrecioCompra,double pImpuesto)
        :base(pNombre,pPrecioCompra)                            
    {
        Impuesto = pImpuesto;
    }
    
    public override void CalculaPrecioVenta(){
        Console.WriteLine("Calcula precio de importado");
        PrecioVenta = PrecioCompra * 1.3 + Impuesto;

    }
    
        
}

class CProductoDetenido:CProductoImportado{
    
    public double Multa{set;get;}
    
    public CProductoDetenido(string pNombre, double pPrecioCompra, double pImpuesto,double pMulta)
        :base(pNombre,pPrecioCompra,pImpuesto)
    {
        Multa = pMulta;
    }
    
    public sealed override void CalculaPrecioVenta(){
        Console.WriteLine("Calcula producto detenido");
        PrecioVenta = PrecioCompra *1.3 +Impuesto + Multa;
    }
    
    
}
    
