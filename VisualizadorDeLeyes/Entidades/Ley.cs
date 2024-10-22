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
            return Titulos.FirstOrDefault(t => t.NombreTitulo == textoTitulo);
        }

        public Capitulo ObtenerCapituloByNombreCapitulo(string nombreCapitulo)
        {
            foreach (var titulo in Titulos)
            {
                var capitulo = titulo.Capitulos.FirstOrDefault(c => c.NombreCapitulo == nombreCapitulo);
                if (capitulo != null)
                    return capitulo;
            }
            return null;
        }

        public Seccion ObtenerSeccionByNombreSeccion(string nombreSeccion)
        {
            foreach (var titulo in Titulos)
            {
                foreach (var capitulo in titulo.Capitulos)
                {
                    var seccion = capitulo.Secciones.FirstOrDefault(s => s.NombreSeccion == nombreSeccion);
                    if (seccion != null)
                        return seccion;
                }
            }
            return null;
        }

        public Articulo ObtenerArticuloByNumero(int numeroArticulo)
        {
            foreach (var titulo in Titulos)
            {
                var articulo = titulo.Articulos.FirstOrDefault(a => a.NumeroArticulo == numeroArticulo);
                if (articulo != null)
                    return articulo;

                foreach (var capitulo in titulo.Capitulos)
                {
                    articulo = capitulo.Articulos.FirstOrDefault(a => a.NumeroArticulo == numeroArticulo);
                    if (articulo != null)
                        return articulo;

                    foreach (var seccion in capitulo.Secciones)
                    {
                        articulo = seccion.Articulos.FirstOrDefault(a => a.NumeroArticulo == numeroArticulo);
                        if (articulo != null)
                            return articulo;
                    }
                }
            }
            return null;
        }
    }

   

}
