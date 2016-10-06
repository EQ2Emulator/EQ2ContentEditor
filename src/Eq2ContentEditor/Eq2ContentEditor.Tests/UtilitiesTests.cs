using Eq2ContentEditor.Core;
using Xunit;

namespace Eq2ContentEditor.Tests
{
    public class UtilitiesTests
    {
        
        [Fact]
        public void SpellBuff_CannotBeGreaterThan100()
        {
            var sut = new Utilities();

            var actual = sut.CalcSpellBuffValue(100, 5);

            Assert.True(actual <= 100, "Spell Buff value cannot be greated than 100");
        }
    }
}
