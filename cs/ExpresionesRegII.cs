using System;

using System.Text.RegularExpressions;


class Program
{
    static void Main() {
       
       
       //Primer metodo para buscar
        string texto ="La casa del casamentero";
        string exp = "casa";
        
        MatchCollection encontrado = Regex.Matches(texto,exp);
        
        foreach(Match e in encontrado){
            Console.WriteLine(e);
        }
        Console.WriteLine("---------------------------------");
        
        //Segundo metodo para buscar
        texto = "El estudiante es un casanova en la escuela casa";
        exp ="casa";
        
        Regex expReg = new Regex(exp);
        
        encontrado = expReg.Matches(texto);
        
        foreach(Match e in encontrado){
            Console.WriteLine(e);
        }
        
        Console.WriteLine("---------------------------------");

        //El punto indica cualquier caracter despues de lo buscado
        //La expresion siguiente lleva un espacio en blanco
        
        texto="Saludos al mas cabal";
        exp= " ca.";
        MatchesExpress(texto,exp);
        
        //Uso de clases de caracteres
        //Busca la e y la i  
        texto="Hola Nico";
        exp= "N[ei]c";
        MatchesExpress(texto,exp);

        //Uso de rangos
        
        Console.WriteLine("uso de rangos");
        texto = "hola Ngco";
        //El rango indicado sigue el orden alfabetico
        exp = "N[a-u]c";
        
        MatchesExpress(texto,exp);
        
        //Uso de complemento
        // ^ se usa para omitr
        Console.WriteLine("^ se usa para omitir que busque lo de adentro de los corchetes");
        texto = "hola Naco";
        exp = "N[^ie]c";
        MatchesExpress(texto,exp);

        //isMatch: regresa un bool e indica la posicion a partir de donde buscar
        Console.WriteLine("metodo isMatch()");
        texto = "De you tube Nicosiored es mi canal favorito";
        exp = "N[ie]c";
        expReg = new Regex(exp);
        if(expReg.IsMatch(texto,5))
        Console.WriteLine("si tiene");
        else
        Console.WriteLine("no tiene");
    
        //Para saber si una cadena termina con determinada expresion
        
        texto = "De you tube Nicosiored es mi canal favorito Nic";
        exp = "N[ie]c$";
        Console.WriteLine("$ el signo indica si al final tiene determinada expresion");
        MatchesExpress(texto,exp);
        
        //? Cumple la condicion si el elemento despues de ? existe o no
        //Elementos opcionales
        texto = "Hola Nio";
        exp="N[ie]c?o";
        
        Console.WriteLine("Elementos opcionales");
        MatchesExpress(texto,exp);
        
        //Cuantificador
        //Revisa si la expresion se repite n numero de veces
        
        texto="Hola 21 Nico";
        exp = "[0-9]{2}";
        Console.WriteLine("Cuantificador");
        MatchesExpress(texto,exp);
        
        //Alternaciones
        //Busca si hay  alguna de las expresiones entre los parentesis
        texto="Yo se programar en java y c";
        exp="(java|c|python)";
        Console.WriteLine("Alternaciones");
        MatchesExpress(texto,exp);
        
        //Split
        //Hace una subcadena cada vez que la expresion coincide
        
        texto="Este es un test de separacion, division";
        exp ="e";
                Console.WriteLine("Uso de explit");

        string[] cadena = Regex.Split(texto,exp);
        
        foreach(string c in cadena){
            Console.WriteLine(c);
        }
        
        //Para reemplazar
        
        texto = "Yo hablo ingles y no soy ingles";
        expReg = new Regex("ingles");
        
        string reemplazo = "español";
        string resultado = expReg.Replace(texto,reemplazo);
        
        Console.WriteLine("Para reemplazar expresiones en la cadena, no afecta a la cadena original");

        Console.WriteLine(texto);
        Console.WriteLine(resultado);
        


    }
    
    
    public static void MatchesExpress(string pTexto, string pExp){
        
        MatchCollection encontrado = Regex.Matches(pTexto,pExp);
        
        foreach(Match e in encontrado){
            Console.WriteLine(e);
        }
        
        Console.WriteLine("-----------------------");
        
    }
}