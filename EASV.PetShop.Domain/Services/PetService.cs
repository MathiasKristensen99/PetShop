using System.Collections.Generic;
using EASV.PetShop.Core.IServices;
using EASV.PetShop.Domain.IRepositories;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.Domain.Services
{
    public class PetService : IPetService
    {
        private IPetRepository _petRepository;

        public PetService(IPetRepository repository)
        {
            _petRepository = repository;
        }
        
        public List<Pet> GetAllPets()
        {
            return _petRepository.GetAllPets();
        }

        public void CreatePet(Pet pet)
        {
            _petRepository.CreatePet(pet);
        }

        public void DeletePet(int id)
        {
            _petRepository.DeletePet(id);
        }
    }
}