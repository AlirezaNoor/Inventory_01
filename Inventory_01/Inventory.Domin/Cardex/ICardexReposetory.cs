using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.Cardex
{
    public interface ICardexReposetory:IGenericReposetores<Cardexes,long>
    {
        void Create2(List<Cardexes> cardexes);
    }
}
