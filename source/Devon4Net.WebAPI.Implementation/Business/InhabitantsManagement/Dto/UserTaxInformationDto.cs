using System.Collections.Generic;

namespace Devon4Net.WebAPI.Implementation.Business.InhabitantsManagement.Dto
{
    public class UserTaxInformationDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<UserTaxesDto> Taxes { get; set; }
    }
}