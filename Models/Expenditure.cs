namespace ASP.Net_Templating.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly Date { get; set; }
        public decimal Price { get; set; }
    }
}
