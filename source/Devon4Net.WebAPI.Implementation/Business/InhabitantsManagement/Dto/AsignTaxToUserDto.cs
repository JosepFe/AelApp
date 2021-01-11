namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto
{
    public class AsignTaxToUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TaxName { get; set; }
        public int TaxYear { get; set; }
        public double BaseAmount { get; set; }
        public string Reference { get; set; }
    }
}