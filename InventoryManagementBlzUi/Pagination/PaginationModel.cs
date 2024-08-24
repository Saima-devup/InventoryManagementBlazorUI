namespace InventoryManagementBlzUi.Pagination
{
    public class PaginationModel
    {
        public int TotalItems { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int PreviousPage { get; set; }
        public List<Page> Pages { get; set; }
        public int PageStartIndex { get; set; }
        public int PageEndIndex { get; set; }

    }

    public class Page
    {
        public int PageNumber { get; set; }
        public bool Active { get; set; }
        public bool Disabled { get; set; }
        public PaginationButtons PageType { get; set; }
    }

}
