using MoneyExtensionMalosti;

namespace MoneyExtension.Test;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal value = 297.98M;
        var cents = value.ToCents();
        Assert.AreEqual(29798, cents);
    }
}