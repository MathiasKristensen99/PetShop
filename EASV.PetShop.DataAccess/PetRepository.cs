using System;
using System.Collections.Generic;
using EASV.PetShop.Domain.IRepositories;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.DataAccess
{
    public class PetRepository : IPetRepository
    {
        public List<Pet> GetAllPets()
        {
            List<Pet> allPets = new List<Pet>();

            PetType petType1 = new PetType();
            petType1.Id = 1;
            petType1.Name = "Dog";
            
            Pet pet1 = new Pet();
            pet1.Id = 1;
            pet1.Name = "Mike";
            pet1.BirthDate = DateTime.Today;
            pet1.SoldDate = DateTime.Today;
            pet1.Color = "Black";
            pet1.Type = petType1;
            pet1.Price = 5000;
            allPets.Add(pet1);
            
            //TODO
            return allPets;
        }

        public void CreatePet(Pet pet)
        {
            List<Pet> pets = GetAllPets();

            Pet newPet = new Pet();
            newPet.Id = pet.Id;
            newPet.Name = pet.Name;
            newPet.Price = pet.Price;
            newPet.Type = pet.Type;
            newPet.Color = pet.Color;
            newPet.BirthDate = pet.BirthDate;
            newPet.SoldDate = pet.SoldDate;
            
            pets.Add(newPet);
        }
    }
}