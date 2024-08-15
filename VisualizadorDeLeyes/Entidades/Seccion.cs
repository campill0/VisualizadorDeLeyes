using System.Text.Json.Serialization;

namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa una sección dentro de un capítulo de la ley.
    /// </summary>
    public class Seccion
    {
        /// <summary>
        /// Obtiene o establece el nombre de la sección.
        /// </summary>
        /// <required>true</required>
        [JsonPropertyName("NombreSeccion")]
        public string NombreSeccion { get; set; }

        /// <summary>
        /// Obtiene o establece un resumen de la sección.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("ResumenSeccion")]
        public string ResumenSeccion { get; set; }

        /// <summary>
        /// Obtiene o establece la lista de artículos que componen la sección.
        /// </summary>
        /// <required>true</required>
        [JsonPropertyName("Articulos")]
        public List<Articulo> Articulos { get; set; } = new List<Articulo>();
    }
}
