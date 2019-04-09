namespace DesignPattern.FactoryPatten
{
    public class OperationAdd : Operation
    {
        public override int CalculateResult() {
            return this.NumberX + this.NumberY;
        }
    }
}