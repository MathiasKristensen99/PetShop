using System.Collections.Generic;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.Domain.IRepositories
{
    public interface IPetRepository
    {
        List<Pet> GetAllPets();

        void CreatePet(Pet pet);

        void DeletePet(int id);
    }
}