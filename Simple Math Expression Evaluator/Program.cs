using System.Linq.Expressions;
while (true)
{
    Console.Write("Enter your Expression (e.g. 3 + 4) or type 'exit' to quit: ");
    string expression = Console.ReadLine();

    if (expression.ToLower() == "exit")
        break;

    try
    {
        int whitespaceIndex1 = expression.IndexOf(' ');
        int whitespaceIndex2 = expression.LastIndexOf(' ');

        int firstOperand = Convert.ToInt32(expression.Substring(0, whitespaceIndex1).Trim());
        int secOperand = Convert.ToInt32(expression.Substring(whitespaceIndex2 + 1).Trim());
        string operandIndex = expression.Substring(whitespaceIndex1 + 1, 1).Trim();

        switch (operandIndex)
        {
            case "+":
                Console.WriteLine($"{expression} = {firstOperand + secOperand}");
                break;
            case "-":
                Console.WriteLine($"{expression} = {firstOperand - secOperand}");
                break;
            case "*":
                Console.WriteLine($"{expression} = {firstOperand * secOperand}");
                break;
            case "/":
                if (secOperand == 0)
                    Console.WriteLine("Cannot divide by zero.");
                else
                    Console.WriteLine($"{expression} = {firstOperand / secOperand}");
                break;
            case "%":
                Console.WriteLine($"{expression} = {firstOperand % secOperand}");
                break;
            default:
                Console.WriteLine("Unknown operator.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Invalid expression. " + ex.Message);
    }
}
