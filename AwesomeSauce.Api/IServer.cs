using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeSauce
{
    interface IServer : IDisposable
    {
        IFeatureCollection Features { get; }
        Task StartAsync<TContext>(IHttpApplication<TCOntext> application,
            CancellationToken cancellationToken);
        Task StopAsync(CancellationToken cancellationToken);
    }
}
