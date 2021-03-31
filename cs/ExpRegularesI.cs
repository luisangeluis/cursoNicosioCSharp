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

        
    }
    
    
    public static void MatchesExpress(string pTexto, string pExp){
        
        MatchCollection encontrado = Regex.Matches(pTexto,pExp);
        
        foreach(Match e in encontrado){
            Console.WriteLine(e);
        }
        
        Console.WriteLine("-----------------------");
        
    }
}