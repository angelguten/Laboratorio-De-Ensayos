using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaMetodosDeExtension
{
    public static class MetodosDeExtension
    {
        /// <summary>
        /// metodo de extension, siempre
        /// PUBLIC STATIC
        /// THIS, seguido de la clase que queremos extender
        /// y un identificador de la instancia de esa clase que extendimos
        /// sirve para agregar un metodo mas a cualquier clase.
        /// El metodo de extension, SOLO EXISTE DENTRO DEL NAMESPACE DONDE LO DECLARAMOS
        /// PUEDEN EXTENDER CLASES E INTERFACES
        /// Si quisieramos que el metodo de extension reciba parametros,
        /// despues del identificador de  instancia(dato), separados por coma, indicamos los 
        /// parametros a pasar
        /// 
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public static int MetodoExtensionDeClaseSTRING_ContadorLetras(this string dato)
        {
            return dato.Length;
        }

        /// <summary>
        /// string seguro
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public static string SafeString(this string cadena)
        {
            if (!(string.IsNullOrEmpty(cadena)))
            {
                cadena = cadena.Trim();
            }
            return cadena;
        }
    }
}
