public class MyClass {
    public static void main(String args[]) {
      
      
      CPropietario propietario1 = new CPropietario("luis",29);
      CEdificio edif1 = new CEdificio("a","calle");
      
      propietario1.mostrarPropiedad();
      propietario1.agregarPropiedad(edif1);
      propietario1.mostrarPropiedad();


        //System.out.println("Sum of x+y = " + z);
    }
}

class CEdificio{
    
    
    private String nombre;
    private String direccion;
    
    public CEdificio(String pNombre, String pDireccion){
        nombre = pNombre;
        direccion= pDireccion;
    }
    
    public String toString(){
        String datos= "nombre: "+nombre+" direccion: "+direccion;
        return datos;
    }
    
    
}

class CPropietario{
    
    private String nombre;
    private int edad;
    
    private CEdificio propiedad = null;
    
    public CPropietario(String pNombre, int pEdad){
        nombre = pNombre;
        edad = pEdad;
    }
    
    public void mostrarPropiedad(){
        if (propiedad!=null){
            System.out.println(nombre + " tiene ");
            System.out.println(propiedad.toString());
        }else{
            System.out.println(nombre + " No tiene propiedades ");

        }
    }
    
    public void agregarPropiedad(CEdificio pPropiedad){
        if(pPropiedad!=null){
            propiedad = pPropiedad;
        }
    }
    
    
}