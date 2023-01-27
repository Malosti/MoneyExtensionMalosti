using MoneyExtensionMalosti;

namespace MoneyExtension.Test;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 297.98M;
        var cents = valor.ToCents();
        Assert.AreEqual(29798, cents);
    }
}