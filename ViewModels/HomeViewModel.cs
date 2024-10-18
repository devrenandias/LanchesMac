using LanchesMac.Models;

namespace LanchesMac.ViewModels
{
    public class HomeViewModel
    {
        //Definindo a logica da View
        public IEnumerable<Lanche> LanchesPreferidos { get; set; }
    }
}
