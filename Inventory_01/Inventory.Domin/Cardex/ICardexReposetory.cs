using Invetory01.Infrastructure.GnericReposetory;

namespace Inventory.Domin.Cardex
{
    public interface ICardexReposetory:IGenericReposetores<Cardexes,long>
    {
        void Create(List<Cardexes> cardexes);
    }
}
