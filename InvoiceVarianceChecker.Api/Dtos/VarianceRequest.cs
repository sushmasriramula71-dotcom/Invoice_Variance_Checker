using System.ComponentModel.DataAnnotations;
namespace InvoiceVarianceChecker.Api.Dtos
{
    public class VarianceRequest
    {
        [Range(0.01, double.MaxValue, ErrorMessage = "PO amount must be greater than zero.")]
        public decimal PoAmount { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Invoice amount must be greater than zero.")]
        public decimal InvoiceAmount { get; set; }
    }
}