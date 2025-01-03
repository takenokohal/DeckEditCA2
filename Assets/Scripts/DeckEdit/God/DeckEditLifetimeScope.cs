using DeckEdit.Domain.Core;
using DeckEdit.Domain.UseCases;
using DeckEdit.Infrastructure;
using DeckEdit.UIs.Binder;
using VContainer;
using VContainer.Unity;

namespace DeckEdit.God
{
    public class DeckEditLifetimeScope: LifetimeScope
    {
        protected override void Configure(IContainerBuilder builder)
        {
            //Domain
            builder.Register<Deck>(Lifetime.Singleton);
            builder.Register<CardPool>(Lifetime.Singleton);
            
            //UseCase
            builder.Register<CardPoolReset>(Lifetime.Singleton);
            
            //UI
            builder.RegisterComponentInHierarchy<DeckCardButtonBinder>();
            builder.RegisterComponentInHierarchy<CardPoolButtonBinder>();
            
            //Infra
            builder.Register<DatabaseCardListLoader>(Lifetime.Singleton).AsImplementedInterfaces();
            
            //God
            builder.RegisterEntryPoint<StartUp>();
        }
    }
}