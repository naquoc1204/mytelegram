﻿namespace MyTelegram.MessengerServer.Abp;

public static class MyTelegramMessengerServerAbpExtensions
{
    public static void UseMyTelegramMessengerServer(this IServiceCollection services,
        Action<IEventFlowOptions>? configure = null)
    {
        services.AddTransient<IMongoDbIndexesCreator, MongoDbIndexesCreator>();
        services.AddEventFlow(options =>
            {
                options.AddDefaults(typeof(MyTelegramMessengerServerExtensions).Assembly);
                options.AddDefaults(typeof(EventFlowExtensions).Assembly);
                options.Configure(c => { c.IsAsynchronousSubscribersEnabled = true; });
                
                options.UseMongoDbEventStore();
                options.UseMongoDbSnapshotStore();

                options.AddMessengerMongoDbReadModel();
                options.AddMongoDbQueryHandlers();
                options.AddPushUpdatesMongoDbReadModel();

                options.UseSystemTextJson(jsonSerializerOptions =>
                {
                    jsonSerializerOptions.AddSingleValueObjects(
                        new SystemTextJsonSingleValueObjectConverter<CacheKey>());
                });
                configure?.Invoke(options);
                //options.UseSpanJson();
            })
            .AddMyTelegramCoreServices()
            .AddMyTelegramHandlerServices()
            .AddMyTelegramMessengerServices()
            .AddMyTelegramIdGeneratorServices()
            .AddMyEventFlow()
            .AddMyTelegramAbpServices()
            ;
    }

    private static void AddMyTelegramAbpServices(this IServiceCollection services)
    {
        services.AddTransient<IMediaHelper, AbpMediaHelper>();
        services.AddSingleton<IEventBus, AbpEventBus>();
        services.AddSingleton(typeof(ICacheManager<>), typeof(AbpCacheManager<>));
    }

    private static IServiceCollection AddMyTelegramIdGeneratorServices(this IServiceCollection services)
    {
        services.AddSingleton<IHiLoHighValueGenerator, HiLoHighValueGenerator>();
        
        return services;
    }
}
