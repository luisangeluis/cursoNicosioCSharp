using System;

class Program
{
    static void Main() {
        CProducto p1 = new CProducto("producto 1",1000);
        p1.CalcularPrecio();
        p1.MostrarProducto();
        
        Console.WriteLine();
        
        CProductoImportado p2 = new CProductoImportado("producto 2",1000,100);
        p2.CalcularPrecio();
        p2.MostrarProducto();
        
        Console.WriteLine();

        //Al hacer la varible polimorfica el uso de new en metodos ya no funciona
        //Evitar usar new en metodos si vamos a usar variables polimorficas.
        CProducto p3= new CProductoImportado("producto 3",1000,100);
        p3.CalcularPrecio();
        p3.MostrarProducto();
        
    }
}

class CProducto{
    
    public string Nombre{set;get;}
    public double PrecioCompra{set;get;}
    public double PrecioVenta{set;get;}
    
    public CProducto(string pNombre, double pPrecioCompra){
        Nombre = pNombre;
        PrecioCompra = pPrecioCompra;
        PrecioVenta = 0.0;
    }
    
    public virtual void CalcularPrecio(){
        Console.WriteLine("Calcula precio de producto");
        PrecioVenta = PrecioCompra*1.3;
    }
    
    public void MostrarProducto(){
        Console.WriteLine("Mostrar producto");
        Console.WriteLine("Nombre: {0} Precio: {1}",Nombre,PrecioVenta);
        
    }
    
    
}

class CProductoImportado:CProducto{
    
    public double Impuesto{set;get;}
    
    public CProductoImportado(string pNombre,double pPrecioCompra,double pImpuesto)
        :base(pNombre,pPrecioCompra)
    {
        Impuesto = pImpuesto;
        
    }
    
    public override void CalcularPrecio(){
        Console.WriteLine("Calcula precio de importado");
        PrecioVenta = PrecioCompra*1.3 +Impuesto;       
 
    }
    
    public new void MostrarProducto(){
        Console.WriteLine("Mostrar importado");
        Console.WriteLine("Nombre: {0} Precio: {1}",Nombre,PrecioVenta);

    }
    
    
}