
public class SimpleParser
{
    private readonly string _expression;

    public SimpleParser(string expression)
    {
        _expression = expression.Replace(" ", ""); // Usuwamy spacje
    }

    public int Parse()
    {
        if (string.IsNullOrEmpty(_expression))
            return 0;

        char[] operators = { '+', '-', '*', '/' };
        int operatorCount = _expression.Count(c => operators.Contains(c));

        if (operatorCount != 1)
        {
            return 0;
        }

        int operatorIndex = -1;

        foreach (char op in operators)
        {
            operatorIndex = _expression.IndexOf(op);
            if (operatorIndex != -1)
                break; 
        }

        if (operatorIndex == -1)
        {
            return 0;
        }

        string leftStr = _expression.Substring(0, operatorIndex);
        string rightStr = _expression.Substring(operatorIndex + 1);

        int left = int.Parse(leftStr);
        int right = int.Parse(rightStr);
        char opChar = _expression[operatorIndex];

        switch (opChar)
        {
            case '+':
                return left + right;
            case '-':
                return left - right;
            case '*':
                return left * right;
            case '/':
                return left / right;
            default:
                return 0;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wyrażenie do obliczenia (np. '2+3'):");
        string input = Console.ReadLine();

        try
        {
            SimpleParser parser = new SimpleParser(input);
            int result = parser.Parse();
            Console.WriteLine($"Wynik: {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd: {ex.Message}");
        }
    }
}
