using Test.Core.ContributorAggregate;

namespace Test.UseCases.Contributors.Delete;

public record DeleteContributorCommand(ContributorId ContributorId) : ICommand<Result>;
