using System.ComponentModel.DataAnnotations;

namespace HelpPlatform.Models
{
    public class DonationRequest
    {
        [Key]
        public int Id { get; set; }
        public string Resource { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public DonationRequest(string resource = "", string description = "")
        {
            Resource = resource;
            Description = description;
            Status = "Aguardando";
        }
    }
}
