using System.Text.Json.Serialization;

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
        [JsonPropertyName("NumeroArticulo")]
        public int NumeroArticulo { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del artículo.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("NombreArticulo")]
        public string NombreArticulo { get; set; }

        /// <summary>
        /// Indica si el nombre del artículo es el original o ha sido modificado.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("NombreArticuloOriginal")]
        public bool NombreArticuloOriginal { get; set; }

        /// <summary>
        /// Obtiene o establece un resumen del artículo.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("ResumenArticulo")]
        public string ResumenArticulo { get; set; }

        /// <summary>
        /// Obtiene o establece el texto completo del artículo.
        /// </summary>
        /// <required>true</required>
        [JsonPropertyName("TextoCompletoArticulo")]
        public string TextoCompletoArticulo { get; set; }
    }
}
