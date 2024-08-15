namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa un artículo individual dentro de la ley.
    /// </summary>
    public class Articulo
    {
        /// <summary>
        /// Obtiene o establece el número del artículo.
        /// </summary>
        /// <required>true</required>
        public int NumeroArticulo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del artículo.
        /// </summary>
        /// <required>false</required>
        public string NombreArticulo { get; set; }

        /// <summary>
        /// Indica si el nombre del artículo es el original o ha sido modificado.
        /// </summary>
        /// <required>false</required>
        public bool NombreArticuloOriginal { get; set; }

        /// <summary>
        /// Obtiene o establece un resumen del artículo.
        /// </summary>
        /// <required>false</required>
        public string ResumenArticulo { get; set; }

        /// <summary>
        /// Obtiene o establece el texto completo del artículo.
        /// </summary>
        /// <required>true</required>
        public string TextoCompletoArticulo { get; set; }
    }
}
