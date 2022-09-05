namespace NLayer.Core.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        public string? color { get; set; }
        public Product? Product { get; set; }
        public int ProductId { get; set; }

    }
}
