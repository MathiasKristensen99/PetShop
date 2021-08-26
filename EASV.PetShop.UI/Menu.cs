using System;
using System.Collections.Generic;
using EASV.PetShop.Core.IServices;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.UI
{
    internal class Menu
    {
        private IPetService _petService;
        private IPetTypeService _petTypeService;

        public Menu(IPetService petService, IPetTypeService petTypeService)
        {
            _petService = petService;
            _petTypeService = petTypeService;
        }

        public void Start()
        {
            ShowWelcomeGreeting();
            StartLoop();
        }

        private void StartLoop()
        {
            int choice;
            while ((choice = GetMainMenuSelection()) != 0)
            {
                if (choice == 1)
                {
                    ShowAllPets();
                }

                if (choice == 2)
                {
                    CreatePet();
                }

                if (choice == 3)
                {
                    DeletePet();
                }
            }
        }

        private void ShowAllPets()
        {
            List<Pet> allPets = _petService.GetAllPets();

            foreach (Pet pet in allPets)
            {
                Console.WriteLine(pet.Id + " " + pet.Name +" " + pet.Color + " " + pet.Type + " " + pet.BirthDate + " " + pet.Price + " " + pet.SoldDate);
            }
        }

        private void DeletePet()
        {
            ShowAllPets();
            Console.WriteLine("Select a pet to delete, by typing the id and hit enter");
            
            var idString = Console.ReadLine();
            int idToDelete = 0;
            int id;

            if (int.TryParse(idString, out id))
            {
                idToDelete = id;
            }
            
            _petService.DeletePet(idToDelete);
            
            Console.WriteLine("The pet has been deleted");
        }
        private void CreatePet()
        {
            List<Pet> pets = _petService.GetAllPets();
            Pet pet = new Pet();
            
            Console.WriteLine(StringConstants.Id);
            var idString = Console.ReadLine();
            int id;

            if (int.TryParse(idString, out id))
            {
                pet.Id = id;
            }
            
            Console.WriteLine(StringConstants.Name);
            var name = Console.ReadLine();
            pet.Name = name;
            
            Console.WriteLine(StringConstants.Color);
            var color = Console.ReadLine();
            pet.Color = color;
            
            Console.WriteLine(StringConstants.Type);
            List<PetType> petTypes = _petTypeService.GetAllPetTypes();
            
            foreach (PetType petType in petTypes)
            {
                Console.WriteLine(petType.Id + ". " + petType.Name);
            }

            pet.Type = _petTypeService.GetPetType(GetPetTypeSelection());
            
            Console.WriteLine(pet.Type.Name);
            
            Console.WriteLine(StringConstants.Price);
            var priceString = Console.ReadLine();
            double price;

            if (double.TryParse(priceString, out price))
            {
                pet.Price = price;
            }
            
            Console.WriteLine(StringConstants.BirthDate);
            string birthDay = Console.ReadLine();
            var parsedBirthDay = DateTime.Parse(birthDay);

            pet.BirthDate = parsedBirthDay;
            
            Console.WriteLine(StringConstants.SoldDate);
            string soldDate = Console.ReadLine();
            var parsedSoldDate = DateTime.Parse(soldDate);

            pet.SoldDate = parsedSoldDate;
            
            pets.Add(pet);
            
            Console.WriteLine("You have added a new pet");
            Console.WriteLine(" Id: " + pet.Id + " Name: " + pet.Name + " Color: " + pet.Color + " Type: "
                              + pet.Type + " Price: " + pet.Price + " Birthdate: " + pet.BirthDate
                              + " Sold date: " + pet.SoldDate);
        }
        
        private void ShowWelcomeGreeting()
        {
            Console.WriteLine(StringConstants.Welcome);
            Console.WriteLine(StringConstants.SelectShowAllPets);
            Console.WriteLine(StringConstants.SelectCreatePet);
            Console.WriteLine(StringConstants.SelectExitApplication);
            Console.WriteLine(StringConstants.SelectDeletePet);
        }
        
        private int GetMainMenuSelection()
        {
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
        
        private int GetPetTypeSelection()
        {
            var selectionString = Console.ReadLine();
            int selection;
            if (int.TryParse(selectionString, out selection))
            {
                return selection;
            }
            return -1;
        }
    }
}