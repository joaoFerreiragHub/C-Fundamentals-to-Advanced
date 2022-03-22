using Microsoft.AspNetCore.Mvc.Rendering;

namespace InAndOut.Models.ViewModels
{
    public class ExpenseVM
    {
        public Expenses Expense { get; set; }
        public IEnumerable<SelectListItem> TypeDropDown { get; set; }
    }
}
