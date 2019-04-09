namespace DesignPattern.FactoryPatten
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string op ) {
            Operation oper = null;
            switch (op.ToLower() )
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-" :
                oper = new OperationSub();
                    break;
                case "/" :
                oper = new OperationDiv();
                    break;
                case "*" :
                oper = new OperationMul();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
}