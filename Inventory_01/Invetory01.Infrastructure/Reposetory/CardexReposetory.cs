using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.GnericReposetory;
using Inventory.Domin.Cardex;
using Invetory01.Infrastructure.Db_Context;
using Microsoft.EntityFrameworkCore;

namespace Invetory01.Infrastructure.Reposetory
{
    public class CardexReposetory:GenericReposetores<Cardexes,long>,ICardexReposetory
    {
private readonly MyContext _myContext;

public CardexReposetory( MyContext myContext) : base(myContext)
{
    _myContext = myContext;
}

public void Create(List<Cardexes> cardexes)
{
 _myContext.cardex.AddRange(cardexes);
}
    }
}
