using Microsoft.VisualStudio.TestTools.UnitTesting;
using FriskTale.AbpGuidGen;
namespace FriskTale.AbpGuidGen.Test;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestStringId()
    {
        SequentialGuidGenerator.Create(SequentialGuidType.SequentialAsString);

    }

    [TestMethod]
    public void TestEndId()
    {
        SequentialGuidGenerator.Create(SequentialGuidType.SequentialAtEnd);
    }

    [TestMethod]
    public void TestBinaryId()
    {
        SequentialGuidGenerator.Create(SequentialGuidType.SequentialAsBinary);
    }
}