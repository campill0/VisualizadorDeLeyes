using static System.Collections.Specialized.BitVector32;

namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa un capítulo dentro de un título de la ley.
    /// </summary>
    public class Capitulo
    {
        /// <summary>
        /// Obtiene o establece el nombre del capítulo.
        /// </summary>
        /// <required>true</required>
        public string NombreCapitulo { get; set; }

        /// <summary>
        /// Obtiene o establece un resumen del capítulo.
        /// </summary>
        /// <required>false</required>
        public string ResumenCapitulo { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de secciones que componen el capítulo.
        /// </summary>
        /// <required>false</required>
        public List<Seccion> Secciones { get; set; } = new List<Seccion>();

        /// <summary>
        /// Obtiene o establece la lista de artículos directamente bajo este capítulo.
        /// </summary>
        /// <required>true</required>
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();
    }
}
