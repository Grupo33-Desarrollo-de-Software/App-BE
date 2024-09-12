using Notify.Samples;
using Xunit;

namespace Notify.EntityFrameworkCore.Domains;

[Collection(NotifyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NotifyEntityFrameworkCoreTestModule>
{

}
