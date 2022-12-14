using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.AspNetCore.Http.Features;

namespace AwesomeSauce
{
    public class AwesomeHttpContext : HttpContext
    {
        private readonly IFeatureCollection features;
        private readonly HttpRequest request;
        private readonly HttpResponse response;

        public AwesomeHttpContext(IFeatureCollection features, string path)
        {
            this.Features = features;
            this.Request = new FileHttpRequest(this, path); 
            this.Response = new FileHttpResponse(this, path); 
        }

        public override IFeatureCollection Features { get; }
        public override HttpRequest Request { get; }
        public override HttpResponse Response { get; }

        public override ConnectionInfo Connection => throw new NotImplementedException();
        public override WebSocketManager WebSockets => throw new NotImplementedException();
        public override AuthenticationManager Authentication => throw new NotImplementedException();
        public override ClaimsPrincipal User { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IDictionary<object, object> Items { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override IServiceProvider RequestServices { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override CancellationToken RequestAborted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string TraceIdentifier { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ISession Session { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Abort()
        {
            throw new NotImplementedException();
        }
    }
}