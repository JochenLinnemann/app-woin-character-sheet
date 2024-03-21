using System.Collections.Immutable;

namespace WoinRules2;

/// <summary>
///     Interface IHasPrerequisites
/// </summary>
public interface IHasPrerequisites
{
    /// <summary>
    ///     Gets the prerequisites.
    /// </summary>
    /// <value>The prerequisites.</value>
    ImmutableArray<Prerequisite> Prerequisites { get; }
}