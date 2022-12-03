using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Olizia.Libraries.Infrascructure.Abstractions.Mappings;

public interface BaseMapping<Entity>
    where Entity : class
{
    public void CreateMapping(EntityTypeBuilder<Entity> entity);
}
