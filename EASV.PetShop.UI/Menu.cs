using EASV.PetShop.Core.IServices;

namespace EASV.PetShop.UI
{
    internal class Menu
    {
        private IPetService _petService;

        public Menu(IPetService service)
        {
            _petService = service;
        }
    }
}