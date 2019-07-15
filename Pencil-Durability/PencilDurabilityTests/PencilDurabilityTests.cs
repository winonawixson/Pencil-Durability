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
        public void WhenThePaperHasTextAndThePencilIsPassedMoreTextThenTheNewTextIsAppended()
        {
            var originalText = "She sells sea shells";
            var newText = " down by the sea shore";
            var pencil = new Pencil();
            pencil.Paper = originalText;
            pencil.Write(newText);

            Assert.AreEqual(originalText + newText, pencil.Paper);
        }

        [Test]
        public void WhenThePencilIsCreatedWithAPointDurabilityThenItHasThatPointDurability()
        {
            var pencil = new Pencil(10);
            Assert.AreEqual(10, pencil.PointDurability);
        }

        [Test]
        public void WhenThePencilWritesLowercaseLetterThenThePointDurabilityDegradesByOne()
        {
            var pencil = new Pencil(4);
            pencil.Write("a");

            Assert.AreEqual(3, pencil.PointDurability);
        }
    }
}