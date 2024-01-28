namespace MiniDevTo.Features.Author.SignUp;

internal sealed class Endpoint : Endpoint<Request, Response, Mapper>
{
    public override void Configure()
    {
        Post("/author/signup");
        AllowAnonymous();
    }

    public override async Task HandleAsync(Request r, CancellationToken c)
    {
        await SendAsync(new Response($"hello {r.FirstName} {r.LastName}! your request has been received!"), cancellation: c);
    }
}