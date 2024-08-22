using Microsoft.Extensions.WebEncoders.Testing;

namespace Conexao.API.Middleware
{
	public class RequestMiddleware
	{
		private readonly RequestDelegate _next;
		public RequestMiddleware(RequestDelegate next)
		{
			_next = next;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			Console.WriteLine("Entrando na validação do Header");

			var headers = context.Request.Headers;

			if (!headers.ContainsKey("Ambev"))
			{
				context.Response.StatusCode = 400;
				return;
			}

			await _next(context);
			Console.WriteLine("Saindo na validação do Header");
		}
	}
}
