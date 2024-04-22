using DAL.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ViewModels
{
    public class CreateUpdateVendorViewModel
    {
        public string? UserName { get; set; }
        public List<Healthprofessionaltype>? types { get; set; }
        public List<Region>? regions { get; set; }
        public string? BusinessName { get; set; }
        public int? Type { get; set; }
        public string? Fax { get; set; }
        public string? Code { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Code1 { get; set; }
        public string? Phone1 { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public int? State { get; set; }
        public string? Zip { get; set; }
        public int? Id { get; set; }
    }
}
