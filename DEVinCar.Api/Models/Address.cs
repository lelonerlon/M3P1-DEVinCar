namespace DEVinCar.Api.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Street { get; set; }
        public string Cep { get; set; }
        public int Number { get; set; }
        public string Complement { get; set; }

        public City City { get; set; }

        public List<Delivery> Deliveries {get; set;}
    }
}