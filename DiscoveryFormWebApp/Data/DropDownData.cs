using Microsoft.AspNetCore.Mvc.Rendering;

namespace DiscoveryFormWebApp.Data
{
    public class DropDownData
    {
        List<SelectListItem> YesNoOption = new List<SelectListItem>
        {
            new SelectListItem { Text = "Yes", Value = "Yes" },
            new SelectListItem { Text = "No", Value = "No" }
        };

        List<SelectListItem> VisibilityStatusOption = new List<SelectListItem>
        {
            new SelectListItem { Text = "Public", Value = "Yes" },
            new SelectListItem { Text = "Private", Value = "No" },
            new SelectListItem { Text = "Shared With IT", Value = "Shared With IT" },
            new SelectListItem { Text = "Shared With Accounting", Value = "Shared With Accounting" },
            new SelectListItem { Text = "Shared With Human Resources", Value = "Shared With Human Resources" },

        };

        List<SelectListItem> ApprovalStatusOptions = new List<SelectListItem>
        {
            new SelectListItem { Text = "Approved", Value = "Approved" },
            new SelectListItem { Text = "Under review by Administration", Value = "Under review by Administration" }
        };
    }
}
