namespace NET.CORE.MVC.Middleware
{
    public class RequestEditingMiddleware
    {
        private RequestDelegate requestDelegate;
        public RequestEditingMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }


        //Request response HttpContext üzerinden  erişilir
        public async Task Invoke(HttpContext context)
        {
            //middlewarede client server  arasindakı işlem
            if (context.Request.Path.ToString() == "/ayhan")
                  context.Response.WriteAsync("Hoşgeldin ayhan");
            else
                  requestDelegate.Invoke(context);
        }
    }
}
