namespace NET.CORE.MVC.Middleware
{
    public class ResponseEditingMiddleware
    {
        private RequestDelegate requestDelegate;
        public ResponseEditingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }


        //Request response HttpContext üzerinden  erişilir
        public async Task Invoke(HttpContext context)
            {

            await requestDelegate.Invoke(context);
            if (context.Response.StatusCode == StatusCodes.Status404NotFound)
              await  context.Response.WriteAsync("Sayfa bulunamadı");
        }
    }
}
