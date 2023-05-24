using Share.Base;

namespace Share.DTO
{
    public class AddressDto :DtoBase
    {
        public int? CountryId { get; set; }

        public string? FristName { get; set; }

        public string? LastName { get; set; }

        public string? Company { get; set; }

        public string? Address1 { get; set; }

        public string? House { get; set; }

        public string? City { get; set; }

        public string? Postcode { get; set; }

        public int? PhoneId { get; set; }

        //public virtual Country? Country { get; set; }

        //public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
    }
}
