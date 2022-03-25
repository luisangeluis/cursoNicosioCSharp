using System;

class Program
{
    static void Main() {
       CCarro detenido1 = new CCarroDetenido("ford","1998",1000,200,100);
       
       detenido1.CalculaCosto();
       detenido1.MuestraInformacion();
       
    }
}

abstract class CVehiculo{
    
    public string Marca{set;get;}
    public string Modelo {set;get;}
    public double PrecioCompra{set;get;}
    public double PrecioVenta{set;get;}
    
    public CVehiculo(string pMarca,string pModelo,double pPrecioCompra){
        Marca = pMarca;
        Modelo = pModelo;
        PrecioCompra = pPrecioCompra;
        PrecioVenta = 0.0;
    }
    
    public virtual void CalculaCosto(){
        Console.WriteLine("calcular costo vehiculo");
        PrecioVenta = PrecioCompra *1.3;
        
    }
    
    public abstract void MuestraInformacion();
    
}

class CCarro:CVehiculo{
    
    public double Impuesto;
    
    public CCarro(string pMarca,string pModelo,double pPrecioCompra, double pImpuesto)
        :base(pMarca,pModelo,pPrecioCompra)
    {
        Impuesto = pImpuesto;
    }
    
    public override void CalculaCosto(){
        Console.WriteLine("calcular costo carro");

        PrecioVenta = PrecioCompra*1.3+Impuesto;
    }
    
    
    public override void MuestraInformacion(){
        Console.WriteLine("Info carro");
        Console.WriteLine("Marca: {0} Modelo: {1} Precio: {2}",Marca,Modelo,PrecioVenta);
    }
    
}

class CCarroDetenido:CCarro{
    public double Multa;
    
    public CCarroDetenido(string pMarca,string pModelo,double pPrecioCompra, double pImpuesto,double pMulta)
        :base(pMarca,pModelo,pPrecioCompra,pImpuesto)    
    {
        Multa = pMulta;
    }
    /*
    public override void MuestraInformacion(){
        Console.WriteLine("hola");
    }
    
    */
}


