namespace InvoiceVarianceChecker.Api.Dtos
{
    public class ErrorResponse
    {
        public required ErrorDetail Error { get; set; }
    }

    public class ErrorDetail
    {
        public required string Code { get; set; }
        public required string Message { get; set; }
    }
}