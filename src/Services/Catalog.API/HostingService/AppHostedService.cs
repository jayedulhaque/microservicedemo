﻿using Catalog.API.Context;

namespace Catalog.API.HostingService
{
    public class AppHostedService : IHostedService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            CatalogDbContextSeed.seed();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
