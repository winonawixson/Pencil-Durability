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
    }
}