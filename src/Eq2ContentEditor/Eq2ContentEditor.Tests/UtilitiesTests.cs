using Eq2ContentEditor.Core;
using Xunit;

namespace Eq2ContentEditor.Tests
{
    [Trait("Category", "Spells")]
    public class UtilitiesTests
    {
        [Theory(DisplayName = "Spell Buff Cannot be Greater Than 100")]
        [InlineData(100,5)]
        [InlineData(1, 8)]
        [InlineData(1, -8)]
        public void SpellBuff_CannotBeGreaterThan100(int lvl, int multiplier)
        {
            var sut = new Utilities();

            var actual = sut.CalcSpellBuffValue(lvl, multiplier);

            Assert.True(actual <= 100, "Spell Buff value cannot be greated than 100");
        }
    }
}
