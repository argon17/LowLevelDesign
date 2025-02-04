namespace DesignPatterns.SolidPrinciples;

/// <summary>
/// Open for extension, closed for modification
/// </summary>
public class InvoiceDbSaverBad(InvoiceGood invoice)
{
    private InvoiceGood _invoice = invoice;

    public void SaveToDb() => throw new NotImplementedException();
}

// The InvoiceDbSaverBad class violates the Open/Closed Principle, because it is not open for extension.
// If you want to save the invoice to a different type of database, you would have to modify the InvoiceDbSaverBad class.

// The refactored code below uses the Open/Closed Principle by creating an interface called IInvoiceSaver
// that can be implemented by different classes to save the invoice to different types of databases:

public interface IInvoiceSaver
{
    void Save();
}

public class InvoiceDbSaverGood(InvoiceGood invoice) : IInvoiceSaver
{
    private InvoiceGood _invoice = invoice;

    public void Save() => throw new NotImplementedException();
}

public class InvoiceXmlSaver(InvoiceGood invoice) : IInvoiceSaver
{
    private InvoiceGood _invoice = invoice;

    public void Save() => throw new NotImplementedException();
}