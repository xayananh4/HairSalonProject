using System.Collections.Generic;

namespace HairSalon.Models
{
    public class Stylist
    {
        public int StylistId { get; set; }
        public string Detail { get; set; }
        public List<Client> Clients { get; set; }
    }
}