using System.Collections.Generic;
using EASV.PetShop.Domain.IRepositories;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.DataAccess
{
    public class PetTypeRepository : IPetTypeRepository
    {
        public List<PetType> GetAllPetTypes()
        {
            List<PetType> allPetTypes = new List<PetType>();

            PetType petType1 = new PetType();
            petType1.Id = 1;
            petType1.Name = "Dog";

            PetType petType2 = new PetType();
            petType2.Id = 2;
            petType2.Name = "Cat";
            return allPetTypes;
        }
    }
}