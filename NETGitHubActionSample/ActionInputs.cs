namespace NETGitHubActionSample;

public class ActionInputs
{
    public ActionInputs()
    {
    }

    [Option('m', "message",
        Required = true,
        HelpText = "The message to print.")]
    public string Message { get; set; } = null!;
}
