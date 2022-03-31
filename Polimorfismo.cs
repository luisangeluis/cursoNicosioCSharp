using System;

class Program
{
    static void Main() {
        
        int opcion =0;
        
        Console.WriteLine("Elige que animal");
        
        Console.WriteLine("1.-Uno para perro");
        Console.WriteLine("2.-Dos para gato");
        opcion = Convert.ToInt32(Console.ReadLine());
        
        CAnimal animal = null;
        
        if(opcion ==1)
            animal = new CPerro("perro");
        if(opcion ==2)
            animal = new CGato("gato");
            
        animal.Moverse();

    }
}

class CAnimal{
    public string Nombre{set;get;}
    
    public CAnimal(string pNombre){
        Nombre =pNombre;
    }
    
    public virtual void Moverse(){
        Console.WriteLine("El animal se mueve");
    }
}

class CPerro:CAnimal{
    public CPerro(string pNombre)
        :base(pNombre)
    {
        
    }
    
    public override void Moverse(){
        Console.WriteLine("El perro se mueve");
    }
}

class CGato:CAnimal{
    public CGato(string pNombre)
        :base(pNombre)
    {
        
    }
    
    public override void Moverse(){
        Console.WriteLine("El gato se mueve");
    }
}
