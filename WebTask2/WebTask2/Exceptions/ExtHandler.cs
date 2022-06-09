using Microsoft.AspNetCore.Builder;

namespace WebTask2.Exceptions
{
    public static class ExtHandler
    {
        public static IApplicationBuilder ExtHandlerMethod(this IApplicationBuilder builder) {
            return builder.UseMiddleware<MiddleWareExceptionHandler>();
        }

    }
}
