public class MyClass {
    public static void main(String args[]) {
      int x=10;
      int y=25;
      int z=x+y;

      System.out.println("Sum of x+y = " + z);
    }
}

class CProducto{
    
    private String descripcion;
    private double precioCompra;
    private double precioVenta;
    private double iva;

    public CProducto(String pDescripcion, double pPrecioCompra){
        
        descripcion = pDescripcion;
        precioCompra = pPrecioCompra;
        precioVenta = 0.0;
        
    }
    
    public void calcularPrecio(){
        
        iva =precioCompra*.16;
        
        precioVenta=  precioCompra+iva;
    }
    
    public String muestraInformacion(){
        String informacion;
        informacion = "Descripcion: "+descripcion+" Precio: "+precioCompra+" iva: "+iva+" total: "+precioVenta;
        return informacion;
    }
    
}

class CProductoImportado extends CProducto{
    
    private double impuesto;
    
    public CProductoImportado(String pDescripcion,double pPrecioCompra){
        super(pDescripcion,pPrecioCompra);
        impuesto=0.0;
        
    }
    @Override
    public void calcularPrecio(){
        
        impuesto = 200;
        precioVenta=  precioCompra+iva+impuesto;
    }
    
    @Override
    public String muestraInformacion(){
        
        String informacion;
        calcularPrecio();
        
        informacion = "Descripcion: "+descripcion+" Precio: "+precioCompra+" iva: "+iva+" impuesto: "+impuesto+" total: "+precioVenta;
        return informacion;
    }
    
}
