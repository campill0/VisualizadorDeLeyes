using System.Collections.Generic;
using System.Text.Json.Serialization;
namespace VisualizadorDeLeyes.Entidades
{
  

    public class Disposiciones
    {
        [JsonPropertyName("DisposicionesAdicionales")]
        public List<Disposicion> DisposicionesAdicionales { get; set; }
        [JsonPropertyName("DisposicionesTransitorias")]
        public List<Disposicion> DisposicionesTransitorias { get; set; }
        [JsonPropertyName("DisposicionesDerogatorias")]
        public List<Disposicion> DisposicionesDerogatorias { get; set; }
        [JsonPropertyName("DisposicionesFinales")]
        public List<Disposicion> DisposicionesFinales { get; set; }

        public Disposiciones()
        {
            DisposicionesAdicionales = new List<Disposicion>();
            DisposicionesTransitorias = new List<Disposicion>();
            DisposicionesDerogatorias = new List<Disposicion>();
            DisposicionesFinales = new List<Disposicion>();
        }
    }

    public class Disposicion
    {
        [JsonPropertyName("NombreDisposicion")]
        public string NombreDisposicion { get; set; }
        [JsonPropertyName("ResumenDisposicion")]
        public string ResumenDisposicion { get; set; }
        [JsonPropertyName("TextoCompletoDisposicion")]
        public string TextoCompletoDisposicion { get; set; }
    }
}
