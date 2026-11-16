using System.Reflection;
using DId;

namespace DId.IntegrationTests;

/// <summary>
/// The merged document used to declare the same shape several times - JsonError through
/// JsonError4, plus TextScript3 and AudioScript3 - so the SDK shipped six duplicate public types.
/// generate.sh now collapses them before generating.
///
/// What this guards is narrow on purpose, because the change is narrower than it first looks: all
/// six were orphans, referenced by no `$ref` anywhere in the document, so no operation's wire
/// contract changed and a round-trip test of JsonError would prove nothing about the collapse.
/// JsonError itself was never touched. What can regress is the collapse silently stopping - a spec
/// refresh reintroducing the numbered copies, or the generate.sh step being dropped - and that is
/// what these assert.
/// </summary>
[TestClass]
public class CollapsedDuplicatesTests
{
    private static readonly string[] CollapsedNames =
    [
        "JsonError1", "JsonError2", "JsonError3", "JsonError4", "TextScript3", "AudioScript3",
    ];

    [TestMethod]
    public void TheDuplicateTypesAreNotInThePublicApi()
    {
        var assembly = typeof(DIdClient).Assembly;
        var present = CollapsedNames
            .Where(name => assembly.GetType($"DId.{name}", throwOnError: false) != null)
            .ToArray();

        Assert.AreEqual(
            0,
            present.Length,
            $"These duplicate types are back: {string.Join(", ", present)}. The document declares " +
            "them identically to their un-numbered siblings and generate.sh is meant to collapse " +
            "them; if a spec refresh reintroduced them, re-run generate.sh rather than deleting " +
            "the types by hand.");
    }

    [TestMethod]
    public void TheSurvivorsAreStillPublicAndStillDeserialize()
    {
        // The collapse keeps the un-numbered name, so losing one of these would mean it kept the
        // wrong member of a group.
        foreach (var name in new[] { "JsonError", "TextScript", "AudioScript" })
        {
            Assert.IsNotNull(
                typeof(DIdClient).Assembly.GetType($"DId.{name}", throwOnError: false),
                $"DId.{name} is gone; the collapse kept the wrong member.");
        }

        var error = JsonError.FromJson(
            """{"kind":"ValidationError","description":"bad input","internal":"trace-1"}""");

        Assert.IsNotNull(error);
        Assert.AreEqual("ValidationError", error.Kind);
        Assert.AreEqual("bad input", error.Description);
        Assert.AreEqual("trace-1", error.Internal);
        // `internal` is a C# keyword, so this property is the one most likely to be renamed by a
        // generator change; an empty extension-data bag is what proves all three bound by name.
        Assert.AreEqual(0, error.AdditionalProperties.Count);

        Assert.AreEqual("bad input", JsonError.FromJson(error.ToJson())?.Description);
    }
}
