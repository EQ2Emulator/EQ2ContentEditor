using Eq2ContentEditor.Core;
using Xunit;

namespace Eq2ContentEditor.Tests
{
    [Trait("Category", "Spells")]
    public class UtilitiesTests
    {
        
        {
            var sut = new Utilities();


            Assert.True(actual <= 100, "Spell Buff value cannot be greated than 100");
        }
    }
}
