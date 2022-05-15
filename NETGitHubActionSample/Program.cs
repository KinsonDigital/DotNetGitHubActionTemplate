using System;
using System.Linq;
using System.Threading.Tasks;

using IHost host = Host.CreateDefaultBuilder(args).Build();

static TService Get<TService>(IHost host)
    where TService : notnull =>
    host.Services.GetRequiredService<TService>();

#pragma warning disable CS1998 Async function without await expression
static async Task RunActionAsync(ActionInputs inputs, IHost host)
{
    // https://docs.github.com/actions/reference/workflow-commands-for-github-actions#setting-an-output-parameter
    Console.WriteLine("This is a sample GitHub action in .NET!!");
    Console.WriteLine($"::set-output message=message::{inputs.Message}");

#if DEBUG
    Console.ReadLine();
#endif

    Environment.Exit(0); // Exist with no failure
}
#pragma warning restore CS1998

var parser = Default.ParseArguments<ActionInputs>(() => new(), args);
parser.WithNotParsed(
    errors =>
    {
        // Display any issues with parsing the command line options
        Get<ILoggerFactory>(host)
            .CreateLogger("NETGitHubActionSample.Program")
            .LogError(
                string.Join(Environment.NewLine, errors.Select(error => error.ToString())));
        
        Environment.Exit(2);
    });

// If the command line values were successfully parsed, continue running
await parser.WithParsedAsync(options => RunActionAsync(options, host));
await host.RunAsync();
