using NUnit.Framework;
using Pencil_Durability;

namespace Tests
{
    public class PencilDurabilityTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenThePencilIsPassedTextThenThePaperReflectsTheText()
        {
            var text = "test text";
            var pencil = new Pencil();
            pencil.Write(text);

            Assert.AreEqual(text, pencil.Paper);
        }

        [Test]
        public void WhenThePencilIsPassedTextTwiceThenThePaperShouldAppendTheText()
        {
            var text = "test text";
            var text2 = " testing some more.";
            var pencil = new Pencil();
            pencil.Write(text);
            pencil.Write(text2);

            Assert.AreEqual(text + text2, pencil.Paper);
        }
    }
}