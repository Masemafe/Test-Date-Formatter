namespace Library.Tests;

public class Tests
{
    [TestMethod]
    public void ChangeFormat_ValidDate_ShouldReturnFormattedDate()
    {
        string inputDate = "10/11/1997";

        string expectedOutput = "1997-11-10";

        string result = DateFormatter.ChangeFormat(inputDate);

        Assert.AreEqual(expectedOutput, result);
    }

    [TestMethod]
    public void ChangeFormat_InvalidDate_ShouldReturnErrorMessage()
    {
        string inputDate = "InvalidDate";

        string result = DateFormatter.ChangeFormat(inputDate);

        Assert.AreEqual("Error en la fecha, por favor intente otra vez", result);
    }

    [TestMethod]
    public void ChangeFormat_NoDateSpecified_ShouldReturnErrorMessage()
    {
        string inputDate = "";

        string result = DateFormatter.ChangeFormat(inputDate);

        Assert.AreEqual("No se ha especificado una fecha, por intente otra vez", result);
    }
}