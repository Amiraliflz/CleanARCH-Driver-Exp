using Test.Core.ContributorAggregate;
using Vogen;

namespace Test.Infrastructure.Data.Config;

[EfCoreConverter<ContributorId>]
[EfCoreConverter<ContributorName>]
internal partial class VogenEfCoreConverters;
