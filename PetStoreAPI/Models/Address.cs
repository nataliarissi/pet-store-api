namespace PetStoreAPI.Models
{
    public class Address
    {
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Neighborhood { get; set; } = string.Empty;
        public int HouseNumber { get; set; }
        public int ZipCode { get; set; }
    }
}