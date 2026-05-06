using Test.Core.ContributorAggregate;

namespace Test.UseCases.Contributors;
public record ContributorDto(ContributorId Id, ContributorName Name, PhoneNumber PhoneNumber);
