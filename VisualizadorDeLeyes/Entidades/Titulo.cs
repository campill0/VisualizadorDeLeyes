namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa un título dentro de una ley.
    /// </summary>
    public class Titulo
    {
        /// <summary>
        /// Contiene el nombre del título.
        /// </summary>
        /// <required>true</required>
        public string NombreTitulo { get; set; }

        /// <summary>
        /// Obtiene o establece un resumen del título.
        /// </summary>
        /// <required>false</required>
        public string ResumenTitulo { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de capítulos que componen el título.
        /// </summary>
        /// <required>true</required>
        public List<Capitulo> Capitulos { get; set; } = new List<Capitulo>();

        /// <summary>
        /// Obtiene o establece la lista de artículos directamente bajo este título.
        /// </summary>
        /// <required>false</required>
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();
    }
}
