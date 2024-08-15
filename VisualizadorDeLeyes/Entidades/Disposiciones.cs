using System.Collections.Generic;
namespace VisualizadorDeLeyes.Entidades
{
  

    public class Disposiciones
    {
        public List<Disposicion> DisposicionesAdicionales { get; set; }
        public List<Disposicion> DisposicionesTransitorias { get; set; }
        public List<Disposicion> DisposicionesDerogatorias { get; set; }
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
        public string NombreDisposicion { get; set; }
        public string ResumenDisposicion { get; set; }
        public string TextoCompletoDisposicion { get; set; }
    }
}
