using System;
namespace MetodosAdicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Texto de teste";
            Console.WriteLine(texto.ToLower());//IGUAL A JS. CONVERTE TUDO PARA MINÚSCOLO.
            Console.WriteLine(texto.ToUpper());//IGUAL A JS. COVERTE TUDO PARA MAIÚSCULO.
            Console.WriteLine(texto.Insert(6, "AQUI "));//VAI INSERIR A PARTIR DO ÍNDICE 6 A STRING PASSADA.
            Console.WriteLine(texto.Remove(6, 4));//REMOVE 4 CARACTERES A PARTIR DO ÍNDICE 6. MAS TÁ REMOVENDO MAIS. INCLUSIVE NA AULA.
            Console.WriteLine(texto.Length);//RETORNA 14. IGUAL AO JS
        }
    }
}