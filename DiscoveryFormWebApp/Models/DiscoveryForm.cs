using System;
using System.Collections.Generic;

namespace DiscoveryFormWebApp.Models
{
    public partial class DiscoveryForm
    {
        public int UniqueDiscoveryFormId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public string? VisibilityStatus { get; set; }
        public string? ApprovalStatus { get; set; }
        public string? Notes { get; set; }
        public string? CurrentFlag { get; set; }
        public DateTime? InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
