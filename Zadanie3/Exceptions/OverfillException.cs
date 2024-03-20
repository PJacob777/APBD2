namespace Zadanie3.Exceptions;

public class OverfillException: Exception
{
    public OverfillException() : base("Przeładowanie")
    {
    }
}