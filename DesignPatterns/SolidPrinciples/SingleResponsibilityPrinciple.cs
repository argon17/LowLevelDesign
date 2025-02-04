namespace DesignPatterns.SolidPrinciples;

/// <summary>
/// Single Responsibility Principle
/// </summary>

public abstract class Marker;

public class InvoiceBad(Marker marker, int quantity)
{
    private Marker _marker = marker;
    private int _quantity = quantity;

    public int CalculateTotal() => throw new NotImplementedException();
    public void PrintInvoice() => throw new NotImplementedException();
    public void SaveToDb() => throw new NotImplementedException();
}

// The InvoiceBad class violates the Single Responsibility Principle, because it has multiple responsibilities: calculating the total, printing the invoice, and saving the invoice to the database.
// The refactored code below separates these responsibilities into different classes:

public class InvoiceGood(Marker marker, int quantity)
{
    private Marker _marker = marker;
    private int _quantity = quantity;

    public int CalculateTotal() => throw new NotImplementedException();
}

public class InvoicePrinter(InvoiceGood invoice)
{
    private InvoiceGood _invoice = invoice;

    public void PrintInvoice() => throw new NotImplementedException();
}

public class InvoiceDbSaver(InvoiceGood invoice)
{
    private InvoiceGood _invoice = invoice;

    public void SaveToDb() => throw new NotImplementedException();
}