using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AwesomeSauce
{
    interface IServer : IDisposable
    {
        IFeatureCollection Features { get; }
        Task StartAsync<TContext>(IHttpApplication<TContext> application,
            CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}
