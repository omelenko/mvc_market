namespace mvc_market
{
    public class Product
    {
        public int Id { get; set; }
        public string? Category { get; set; }
        public string? Slug { get; set; }
        //Image(картинка товару),
        public string? Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
