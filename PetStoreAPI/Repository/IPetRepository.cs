using Microsoft.AspNetCore.Mvc;
using PetStoreAPI.Models;

namespace PetStoreAPI.Repository
{
    public interface IPetRepository
    {
        Task<List<Pet>> GetAllPets();
        Task<Pet>? GetSinglePet(int id);
        Task<List<Pet>> AddPet(Pet pet);
        Task<List<Pet>?> UpdatePet(int id, Pet request);
        Task<List<Pet>?> DeletePet(int id);
    }
}