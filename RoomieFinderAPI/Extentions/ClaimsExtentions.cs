namespace System.Security.Claims
{
    public static class ClaimsExtentions
    {
        public static string? Id(this ClaimsPrincipal user) =>
            user.FindFirstValue(ClaimTypes.NameIdentifier);

    }
}
