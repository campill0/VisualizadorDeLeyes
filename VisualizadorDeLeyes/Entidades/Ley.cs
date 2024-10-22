using System.Text.Json.Serialization;

namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa una ley completa con sus componentes principales.
    /// </summary>
    public class Ley
    {
        /// <summary>
        /// Determina el nombre de la ley.
        /// </summary>
        /// <required>true</required>
        [JsonPropertyName("NombreLey")]
        public string NombreLey { get; set; }

        /// <summary>
        /// Especifica el preámbulo de la ley.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("Preambulo")]
        public Preambulo Preambulo { get; set; }

        /// <summary>
        /// Especifica la lista de títulos que componen la ley.
        /// </summary>
        /// <required>true</required>

        [JsonPropertyName("Titulos")]
        public List<Titulo> Titulos { get; set; } = new List<Titulo>();

        /// <summary>
        /// Contiene las disposiciones de la ley.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("Disposiciones")]
        public Disposiciones Disposiciones { get; set; }

        /// <summary>
        /// Contiene un resumen de la ley.
        /// </summary>
        /// <required>false</required>
        [JsonPropertyName("ResumenLey")]
        public string ResumenLey { get; set; }
        public Titulo ObtenerTituloByTextoTitulo(string textoTitulo)
        {
            return Titulos.Where(x => x.NombreTitulo == textoTitulo).FirstOrDefault();
    }

        public Capitulo ObtenerCapituloByNombreCapitulo(string nombreCapitulo)
        {
            Capitulo capitulo = null;
            foreach (var titulo in Titulos) { 
                capitulo = titulo.ObtenerCapituloByNombreCapitulo(nombreCapitulo);
                if (capitulo != null) { break; }
            }
            return capitulo;
        }
    }

   

}
