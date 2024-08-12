namespace KlassyCafe.Dtos.Product
{
    public class ResultproductDto
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public bool IsFeature { get; set; }
        public int CategoryId { get; set; }
    }
}
