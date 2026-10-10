namespace CanHazFunny;

public class Jester
{
    private IJokeService JokeService { get; }
    private IJokeWrite JokeWrite { get; }

    public Jester(IJokeService jokeService, IJokeWrite jokeWrite)
    {
        ArgumentNullException.ThrowIfNull(jokeService);
        ArgumentNullException.ThrowIfNull(jokeWrite);

        JokeService = jokeService;
        JokeWrite = jokeWrite;
    }

    public void TellJoke()
    {
        var joke = "Chuck Norris";
        while (joke.Contains("Chuck Norris"))
        {
            joke = JokeService.GetJoke();
        }
        JokeWrite.WriteJoke(joke);
    }
}