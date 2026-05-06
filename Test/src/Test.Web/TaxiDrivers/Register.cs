



using System.Formats.Tar;
using System.Net;

namespace Test.Web.TaxiDrivers
{
    public class Register(IRegisterTaxiDriverService service) : EndPoint<RegisterTaxiDriverRequest,
    Results<Created<RegisterTaxiDriverResponse>, ValidationProblem, ProblemHttpResult>>
    {
        private readonly IRegisterTaxiDriverService _service = service;
        public override void Configure()
        {
            Post(RegisterTaxiDriverRequest.Route);
            AllowAnonymous();
            Tags("TaxiDrivers");
        }

        public override async Task<Results<Created<RegisterTaxiDriverResponse>, ValidationProblem, ProblemHttpResult>> HandleAsync(RegisterTaxiDriverRequest request, CancellationToken cancellationToken = default)
        {
            var command = new RegiserTaxiDriverCommand(
                request.FirstName,
                request.LastName,
                request.Email,
                request.PhoneNumber,
                request.LicenseNumber,
                request.IssuingCountry,
                request.LicenseExpiryDate
            );
            var result = await _service.ExecuteAsync(command, cancellationToken);
            return result.ToCreateResult(id => $"/TaxiDrivers{id}",
            id => new RegisterTaxiDriverResponse(id));
        }
        public class RegisterTaxiDriverRequest
        {
            public const string Route = "TaxiDrivers/register";
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            [EmailAddress]
            public string Email { get; set; }
            [Required]
            [Phone]
            public string PhoneNumber { get; set; }
            [Required]
            public string LicenseNumber { get; set; }
            [Required]
            public string IssuingCountry { get; set; }
            [Required]
            public DateTime LicenseExpiryDate { get; set; }
        }

        public class RegisterTaxiDriverValidator : Validator<RegisterTaxiDriverRequest>
        {
            public RegisterTaxiDriverValidator()
            {
                RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.");
                RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required.");
                RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage("A valid email is required.");
                RuleFor(x => x.PhoneNumber).NotEmpty().PhoneNumber().WithMessage("A valid phone number is required.");
                RuleFor(x => x.LicenseNumber).NotEmpty().WithMessage("License number is required.");
                RuleFor(x => x.IssuingCountry).NotEmpty().WithMessage("Issuing country is required.");
                RuleFor(x => x.LicenseExpiryDate).GreaterThan(DateTime.UtcNow).WithMessage("License expiry date must be in the future.");
            }
        }

    }
}