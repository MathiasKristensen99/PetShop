using System.Collections.Generic;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.Core.IServices
{
    public interface IPetService
    {
        List<Pet> GetAllPets();

        void CreatePet(Pet pet);
    }
}