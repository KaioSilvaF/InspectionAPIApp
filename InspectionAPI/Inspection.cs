using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Inspection
    {
        public int Id { get; set; }
        [StringLength(20)]
        public string Status{ get; set; } = string.Empty;

        [StringLength(200)]
        public String Comments { get; set; } = string.Empty;

        public int InspectionTypeId { get; set; }

        // ? mark means it can be null
        public InspectionType? InspectionType { get; set; }

    }
}
