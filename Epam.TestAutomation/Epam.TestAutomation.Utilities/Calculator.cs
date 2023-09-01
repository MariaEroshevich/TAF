namespace Epam.TestAutomation.Utilities
{
    public class Calculator
    {
        private readonly Queue<double> _operands = new();

        public double Result => _operands.Peek();

        public void EnterOperand(double operand)
        {
            _operands.Enqueue(operand);
        }

        public void Sum()
        {
            _operands.Enqueue(_operands.Dequeue() + _operands.Dequeue());
        }

        public void Diff()
        {
            _operands.Enqueue(_operands.Dequeue() - _operands.Dequeue());
        }

        public void Mult()
        {
            _operands.Enqueue(_operands.Dequeue() * _operands.Dequeue());
        }

        public void Div()
        {
            _operands.Enqueue(_operands.Dequeue() / _operands.Dequeue());
        }
    }
}
