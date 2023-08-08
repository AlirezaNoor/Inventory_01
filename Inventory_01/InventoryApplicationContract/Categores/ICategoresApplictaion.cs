using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApplicationContract.Categores
{
    public interface ICategoresApplictaion
    {
        void create(CreateCategores commnad);
        List<viewModel> showAll();
        void remove(long id);
        
        EditCategores edited (long id);
        void EditedRecordes(EditCategores command);
        List<viewModel> categoryseletor();

        viewModel caateoryseelected(long id);
    }
}
