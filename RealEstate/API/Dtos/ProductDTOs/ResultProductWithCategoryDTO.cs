namespace API.Dtos.ProductDTOs
{
    public class ResultProductWithCategoryDTO
    {
        public int ID { get; set; }
        public string TITLE { get; set; }
        public decimal PRICE { get; set; }
        public string CITY { get; set; }
        public string DISTRICT { get; set; }
        public string CATEGORYNAME { get; set; }
        public string COVERIMAGE { get; set; }
        public string TYPE { get; set; }
        public string ADDRESS { get; set; }
    }
}
