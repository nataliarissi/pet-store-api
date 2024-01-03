using Microsoft.AspNetCore.Mvc;
using PetStoreAPI.Models;

namespace PetStoreAPI.Repository
{
    public class PetRepository : IPetRepository
    {
        private static List<Pet> pets = new List<Pet> {
            new Pet
            {
                Id = 1,
                Name = "Luke",
                TypeOfPet = "Guinea pig",
                Age = 2,
                Description = "General consultation",
                address = new Address
                {
                    City = "Porto Alegre",
                    Street = "Street of Love",
                    Neighborhood = "Love",
                    HouseNumber = 1,
                    ZipCode = 00188871
                }
            },
            new Pet
            {
                Id = 2,
                Name = "Itachi",
                TypeOfPet = "Guinea pig",
                Age = 1,
                Description = "Cut the nails",
                address = new Address
                {
                    City = "Torres",
                    Street = "Sea ​​street",
                    Neighborhood = "Beautiful beach",
                    HouseNumber = 2,
                    ZipCode = 87104210
                }
            }
        };

        public List<Pet> AddPet(Pet pet)
        {
            pets.Add(pet);
            return pets;
        }

        public List<Pet>? DeletePet(int id)
        {
            var pet = pets.Find(x => x.Id == id);
            if (pet == null)
                return null;

            pets.Remove(pet);
            return pets;
        }

        public List<Pet> GetAllPets()
        {
            return pets;
        }

        public Pet? GetSinglePet(int id)
        {
            var pet = pets.Find(x => x.Id == id);
            if (pet == null)
                return null;
            return pet;
        }

        public List<Pet>? UpdatePet(int id, Pet request)
        {
            var pet = pets.Find(x => x.Id == id);
            if (pet == null)
                return null;

            pet.Name = request.Name;
            pet.TypeOfPet = request.TypeOfPet;
            pet.Age = request.Age;
            pet.Description = request.Description;
            pet.address = request.address;

            return pets;
        }
    }
}
