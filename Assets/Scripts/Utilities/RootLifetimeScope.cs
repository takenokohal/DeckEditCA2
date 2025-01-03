using Databases;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Utilities
{
    public class RootLifetimeScope : LifetimeScope
    {
        [SerializeField] private CardDatabase cardDatabase;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterInstance(cardDatabase);
        }
    }
}