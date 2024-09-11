namespace VisualizadorDeLeyes.Entidades
{
    public class FilterItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsSelected { get; set; }
        public List<FilterItem> Children { get; set; } = new List<FilterItem>();
    }
}
