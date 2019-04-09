namespace DesignPattern.FactoryPatten
{
    public class OperationMul: Operation
    {
        public override int CalculateResult() {
            return this.NumberX * this.NumberY;
        }
    }
}