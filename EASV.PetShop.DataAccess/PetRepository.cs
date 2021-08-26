using System;
using System.Collections.Generic;
using System.Linq;
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

            PetType petType2 = new PetType();
            petType2.Id = 2;
            petType2.Name = "Cat";
            
            Pet pet1 = new Pet();
            pet1.Id = 1;
            pet1.Name = "Mike";
            pet1.BirthDate = DateTime.Today;
            pet1.SoldDate = DateTime.Today;
            pet1.Color = "Black";
            pet1.Type = petType1;
            pet1.Price = 5000;
            allPets.Add(pet1);

            Pet pet2 = new Pet();
            pet2.Id = 2;
            pet2.Name = "Charles";
            pet2.BirthDate = DateTime.Today;
            pet2.SoldDate = DateTime.Today;
            pet2.Color = "White";
            pet2.Type = petType2;
            pet2.Price = 2000;
            allPets.Add(pet2);
            
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

        public void DeletePet(int id)
        {
            List<Pet> pets = GetAllPets();

            foreach (Pet pet in pets.ToList())
            {
                if (pet.Id.Equals(id))
                {
                    pets.Remove(pet);
                }
            }
        }
    }
}