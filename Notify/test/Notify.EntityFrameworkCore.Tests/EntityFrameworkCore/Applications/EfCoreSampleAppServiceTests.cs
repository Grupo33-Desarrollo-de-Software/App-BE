using Notify.Samples;
using Xunit;

namespace Notify.EntityFrameworkCore.Applications;

[Collection(NotifyTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NotifyEntityFrameworkCoreTestModule>
{

}
