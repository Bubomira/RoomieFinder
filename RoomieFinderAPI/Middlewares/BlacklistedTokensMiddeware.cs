using RoomieFinderCore.Contracts.AuthContracts;

namespace RoomieFinderAPI.Middlewares
{
    public class BlacklistedTokensMiddeware
    {
        private readonly RequestDelegate _next;

        public BlacklistedTokensMiddeware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext _context)
        {
            var token = _context.Request.Headers.Authorization.ToString();
            var jwtContract = _context.RequestServices.GetService<IJWTSContract>();

            if (token != null && jwtContract != null)
            {
                if (await jwtContract.CheckIfTokenIsBlacklisted(token))
                {
                    _context.Response.StatusCode = 401;
                    return;
                }
            }

            await _next(_context);
        }
    }
}
