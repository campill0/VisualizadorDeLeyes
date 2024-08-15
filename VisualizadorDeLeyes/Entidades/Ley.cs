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
        public string NombreLey { get; set; }

        /// <summary>
        /// Especifica el preámbulo de la ley.
        /// </summary>
        /// <required>false</required>
        public Preambulo Preambulo { get; set; }

        /// <summary>
        /// Especifica la lista de títulos que componen la ley.
        /// </summary>
        /// <required>true</required>
        public List<Titulo> Titulos { get; set; } = new List<Titulo>();

        /// <summary>
        /// Contiene las disposiciones de la ley.
        /// </summary>
        /// <required>false</required>
        public Disposiciones Disposiciones { get; set; }

        /// <summary>
        /// Contiene un resumen de la ley.
        /// </summary>
        /// <required>false</required>
        public string ResumenLey { get; set; }
    }


}
