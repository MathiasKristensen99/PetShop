using System;
using System.Collections.Generic;
using EASV.PetShop.Core.IServices;
using EASV.PetShop.Domain.Models;

namespace EASV.PetShop.UI
{
    internal class Menu
    {
        private IPetService _petService;

        public Menu(IPetService petService)
        {
            _petService = petService;
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

        private void CreatePet()
        {
            Pet pet = new Pet();
            
        }
        
        private void ShowWelcomeGreeting()
        {
            Console.WriteLine(StringConstants.Welcome);
            Console.WriteLine(StringConstants.SelectShowAllPets);
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
    }
}