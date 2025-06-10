using CSCore.Codecs.AIFF;

namespace CSCore.Test.Streams
{
    [TestClass]
    public class AiffDecoderTests : GenericSourceTests
    {
        protected override IWaveSource GetSource()
        {
            return new AiffReader(new MemoryStream(/*Resources.aiff_50s_sine*/));
        }
    }
}
