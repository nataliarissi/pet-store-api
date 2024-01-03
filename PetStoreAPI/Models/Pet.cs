namespace PetStoreAPI.Models
{
    public class Pet
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string TypeOfPet { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;
        public Address address { get; set; }
    }
}
