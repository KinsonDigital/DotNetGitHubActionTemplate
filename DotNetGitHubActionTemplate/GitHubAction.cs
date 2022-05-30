// <copyright file="GitHubAction.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

using DotNetGitHubActionTemplate.Services;

namespace DotNetGitHubActionTemplate;

/// <inheritdoc/>
public class GitHubAction : IGitHubAction
{
    private readonly IGitHubConsoleService gitHubConsoleService;
    private readonly IActionOutputService actionOutputService;

    /// <summary>
    /// Initializes a new instance of the <see cref="GitHubAction"/> class.
    /// </summary>
    /// <param name="gitHubConsoleService">Writes to the console.</param>
    /// <param name="actionOutputService">Sets the output data of the action.</param>
    public GitHubAction(
        IGitHubConsoleService gitHubConsoleService,
        IActionOutputService actionOutputService)
    {
        this.gitHubConsoleService = gitHubConsoleService;
        this.actionOutputService = actionOutputService;
    }

    /// <inheritdoc/>
    public async Task Run(ActionInputs inputs, Action onCompleted, Action<Exception> onError)
    {
        ShowWelcomeMessage();

        try
        {
        }
        catch (Exception e)
        {
            onError(e);
        }

        onCompleted();
    }

    /// <summary>
    /// Shows a welcome message with additional information.
    /// </summary>
    private void ShowWelcomeMessage()
    {
        this.gitHubConsoleService.WriteLine("Welcome!!");
        this.gitHubConsoleService.BlankLine();
    }
}
