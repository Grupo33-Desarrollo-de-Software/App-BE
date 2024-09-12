using Xunit;

namespace Notify.EntityFrameworkCore;

[CollectionDefinition(NotifyTestConsts.CollectionDefinitionName)]
public class NotifyEntityFrameworkCoreCollection : ICollectionFixture<NotifyEntityFrameworkCoreFixture>
{

}
