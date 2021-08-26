using System;
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
            IPetService service = new PetService(repo);
            
            Menu menu = new Menu(service);
            menu.Start();
        }
    }
}