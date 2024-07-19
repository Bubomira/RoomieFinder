namespace RoomieFinderAPI.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;
        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext _context)
        {
            try
            {
                await _next(_context);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                _context.Response.StatusCode = 500;
                _context.Response.WriteAsync(e.Message);
                throw;
            }
        }
    }
}
