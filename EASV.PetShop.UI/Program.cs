﻿using System;
using System.Collections.Generic;
using EASV.PetShop.Core.IServices;
using EASV.PetShop.DataAccess;
using EASV.PetShop.Domain.IRepositories;
using EASV.PetShop.Domain.Models;
using EASV.PetShop.Domain.Services;

namespace EASV.PetShop.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IPetRepository repo = new PetRepository();
            IPetTypeRepository petTypeRepository = new PetTypeRepository();
            IPetService service = new PetService(repo);
            IPetTypeService petTypeService = new PetTypeService(petTypeRepository);
            
            Menu menu = new Menu(service, petTypeService);
            menu.Start();
        }
    }
}