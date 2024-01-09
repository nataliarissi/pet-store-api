using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetStoreAPI.Data;
using PetStoreAPI.Models;

namespace PetStoreAPI.Repository
{
    public class PetRepository : IPetRepository
    {
        //private static List<Pet> pets = new List<Pet> {
        //    new Pet
        //    {
        //        Id = 1,
        //        Name = "Luke",
        //        TypeOfPet = "Guinea pig",
        //        Age = 2,
        //        Description = "General consultation",
        //        Address = new Address
        //        {
        //            Id = 1,
        //            City = "Porto Alegre",
        //            Street = "Street of Love",
        //            Neighborhood = "Love",
        //            HouseNumber = 1,
        //            ZipCode = 00188871
        //        }
        //    },
        //    new Pet
        //    {
        //        Id = 2,
        //        Name = "Itachi",
        //        TypeOfPet = "Guinea pig",
        //        Age = 1,
        //        Description = "Cut the nails",
        //        Address = new Address
        //        {
        //            Id = 2,
        //            City = "Torres",
        //            Street = "Sea ​​street",
        //            Neighborhood = "Beautiful beach",
        //            HouseNumber = 2,
        //            ZipCode = 87104210
        //        }
        //    }
        //};

        private readonly DataContext _context;

        public PetRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Pet>> AddPet(Pet pet)
        {
            _context.Pets.Add(pet);
            await _context.SaveChangesAsync();

            return await _context.Pets.ToListAsync();
        }

        public async Task<List<Pet>?> DeletePet(int id)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
                return null;

           _context.Pets.Remove(pet);
            await _context.SaveChangesAsync();

            return await _context.Pets.ToListAsync();
        }

        public async Task<List<Pet>> GetAllPets()
        {
            var pets = await _context.Pets.ToListAsync();
            return pets;
        }

        public async Task<Pet?> GetSinglePet(int id)
        {
            var pet =  await _context.Pets.FindAsync(id);
            if (pet == null)
                return null;
            return pet;
        }

        public async Task<List<Pet>?> UpdatePet(int id, Pet request)
        {
            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
                return null;

            pet.Name = request.Name;
            pet.TypeOfPet = request.TypeOfPet;
            pet.Age = request.Age;
            pet.Description = request.Description;
            pet.Address = request.Address;

            await _context.SaveChangesAsync();

            return await _context.Pets.ToListAsync();
        }
    }
}
