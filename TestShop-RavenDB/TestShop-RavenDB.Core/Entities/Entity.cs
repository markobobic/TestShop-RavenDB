using System;

namespace TestShop_RavenDB.Core.Entities
{
    public abstract class Entity
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();

    }
}
