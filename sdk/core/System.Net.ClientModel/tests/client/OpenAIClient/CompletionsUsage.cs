// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace OpenAI;

/// <summary>
/// Representation of the token counts processed for a completions request.
/// Counts consider all tokens across prompts, choices, choice alternates, best_of generations, and
/// other consumers.
/// </summary>
public partial class CompletionsUsage
{
    /// <summary> Initializes a new instance of CompletionsUsage. </summary>
    /// <param name="completionTokens"> The number of tokens generated across all completions emissions. </param>
    /// <param name="promptTokens"> The number of tokens in the provided prompts for the completions request. </param>
    /// <param name="totalTokens"> The total number of tokens processed for the completions request and response. </param>
    internal CompletionsUsage(int completionTokens, int promptTokens, int totalTokens)
    {
        CompletionTokens = completionTokens;
        PromptTokens = promptTokens;
        TotalTokens = totalTokens;
    }

    /// <summary> The number of tokens generated across all completions emissions. </summary>
    public int CompletionTokens { get; }
    /// <summary> The number of tokens in the provided prompts for the completions request. </summary>
    public int PromptTokens { get; }
    /// <summary> The total number of tokens processed for the completions request and response. </summary>
    public int TotalTokens { get; }
}

