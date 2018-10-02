using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mind.Repositories
{
    public interface ICookieRepository
    {
        void Add(string key, string value, ResponseCookies options);
    }

    public class CookieRepository : ICookieRepository
    {
        private readonly HttpResponse context;

        public CookieRepository(IHttpContextAccessor context)
        {
            this.context = context.HttpContext.Response;
        }

        public void Add(string key, string value, ResponseCookies options)
        {

        }
    }
}
