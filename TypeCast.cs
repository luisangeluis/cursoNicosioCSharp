using System;

class Program
{
    static void Main() {
       CProducto p1 = new CProductoImportado("tele",1000,100);
       
       p1.CalcularPrecio();
       Console.WriteLine(p1);
       
       //Para usar metodos propios de CProductoImportado que no corresponden a la cadena de herencia podemos hacer
       //TypeCast
       ((CProductoImportado)p1).MostrarMensaje();
    }
}

class CProducto{
    public string Nombre{set;get;}
    public double PrecioCompra {set;get;}
    public double PrecioVenta {set;get;}
    
    public CProducto(string pNombre,double pPrecioCompra){
        Nombre = pNombre;
        PrecioCompra = pPrecioCompra;
        PrecioVenta = 0.0;
    }
    
    public virtual void CalcularPrecio(){
        PrecioVenta = PrecioCompra *1.3;
    }
    
    public override string ToString(){
        Console.WriteLine("Mi producto");
        return string.Format("Nombre: {0} Precio de venta: {1}",Nombre,PrecioVenta);
        
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
        PrecioVenta = PrecioCompra*1.3 +Impuesto;
    }
    
    public override string ToString(){
        Console.WriteLine("Mi producto importado");
        return string.Format("Nombre: {0} Precio de venta: {1}",Nombre,PrecioVenta);

    }
    
    public void MostrarMensaje(){
        Console.WriteLine("Soy un producto importado");
    }
}