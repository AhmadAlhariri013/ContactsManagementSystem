namespace Shared.Models
{
    public class ContactSortModel
    {
        public string SortBy { get; set; } // Field to sort by (e.g., "FirstName", "LastName")
        public bool Descending { get; set; } // Sort order (ascending or descending)
    }
}
