namespace DesignPatterns.Core.Command.CalculatorCommand.Receiver
{
    public class CalculatorService
    {
        public int CurrentValue;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': CurrentValue += operand; break;
                case '-': CurrentValue -= operand; break;
                case '*': CurrentValue *= operand; break;
                case '/': CurrentValue /= operand; break;
            }
        }
    }
}
