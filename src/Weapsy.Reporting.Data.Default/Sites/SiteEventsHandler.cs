﻿using System;
using System.Threading.Tasks;
using Weapsy.Core.Caching;
using Weapsy.Core.Domain;
using Weapsy.Domain.Model.Sites.Events;

namespace Weapsy.Reporting.Data.Default.Sites
{
    public class SiteEventsHandler : 
        IEventHandler<SiteCreated>,
        IEventHandler<SiteDetailsUpdated>
    {
        private readonly ICacheManager _cacheManager;

        public SiteEventsHandler(ICacheManager cacheManager)
        {
            _cacheManager = cacheManager;
        }

        public async Task Handle(SiteCreated @event)
        {
            await ClearCache(@event.AggregateRootId);
        }

        public async Task Handle(SiteDetailsUpdated @event)
        {
            await ClearCache(@event.AggregateRootId);
        }

        private Task ClearCache(Guid siteId)
        {
            return Task.Run(() => _cacheManager.Remove(string.Format(CacheKeys.SiteInfoCacheKey, siteId)));
        }
    }
}
