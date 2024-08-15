namespace VisualizadorDeLeyes.Entidades
{
    /// <summary>
    /// Representa el preámbulo de una ley.
    /// </summary>
    public class Preambulo
    {
        /// <summary>
        /// Contiene un resumen del preámbulo.
        /// </summary>
        /// <required>true</required>
        public string ResumenPreambulo { get; set; }

        /// <summary>
        /// Contiene el texto completo del preámbulo. En formato markdown
        /// </summary>
        /// <required>true</required>
        public string TextoCompletoPreambulo { get; set; }
    }
}
