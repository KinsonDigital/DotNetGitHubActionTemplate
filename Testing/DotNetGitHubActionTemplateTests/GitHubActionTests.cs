// <copyright file="GitHubActionTests.cs" company="KinsonDigital">
// Copyright (c) KinsonDigital. All rights reserved.
// </copyright>

using DotNetGitHubActionTemplate;
using DotNetGitHubActionTemplate.Services;
using Moq;

// TODO: Rename this namespace
namespace DotNetGitHubActionTemplateTests;

public class GitHubActionTests
{
    private readonly Mock<IGitHubConsoleService> mockConsoleService;
    private readonly Mock<IActionOutputService> mockActionOutputService;

    /// <summary>
    /// Initializes a new instance of the <see cref="GitHubActionTests"/> class.
    /// </summary>
    public GitHubActionTests()
    {
        this.mockConsoleService = new Mock<IGitHubConsoleService>();
        this.mockActionOutputService = new Mock<IActionOutputService>();
    }

    #region Method Tests
    #endregion

    /// <summary>
    /// Creates a new instance of <see cref="ActionInputs"/> for the purpose of testing.
    /// </summary>
    /// <returns>The instance to test.</returns>
    private static ActionInputs CreateInputs() => new ()
    {
        Message = "test-owner",
    };

    /// <summary>
    /// Creates a new instance of <see cref="GitHubAction"/> for the purpose of testing.
    /// </summary>
    /// <returns>The instance to test.</returns>
    private GitHubAction CreateAction()
        => new (this.mockConsoleService.Object, this.mockActionOutputService.Object);
}
