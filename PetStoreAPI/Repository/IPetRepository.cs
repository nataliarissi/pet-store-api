using Microsoft.AspNetCore.Mvc;
using PetStoreAPI.Models;

namespace PetStoreAPI.Repository
{
    public interface IPetRepository
    {
        List<Pet> GetAllPets();
        Pet? GetSinglePet(int id);
        List<Pet> AddPet(Pet pet);
        List<Pet>? UpdatePet(int id, Pet request);
        List<Pet>? DeletePet(int id);
    }
}
