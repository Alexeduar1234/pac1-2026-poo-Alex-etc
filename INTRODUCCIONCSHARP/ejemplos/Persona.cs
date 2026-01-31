using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace INTRODUCCIONCSHARP.ejemplos
{
    public class Persona
    {
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string  genero { get; set; }
        public int edad { get; set; }

        // metodo: constructor
        /*
            1. se llama igual a la clase
            2. no retorna datos (al no retornar datos se utiliza el void)
            3. se utiliza para inicializar valores de propiedades de la clase
            4. se ejecuta cuando se construye el objeto
            5. no se puede llamar por medio de las sintaxis de punto

        */
        public Persona(string Nombre, string Apellidos, string Genero, int Edad)
        {
            nombre=Nombre;
            apellidos=Apellidos;
            genero=Genero;
            edad=Edad;
        }
    }
}