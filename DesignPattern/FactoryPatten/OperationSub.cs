namespace DesignPattern.FactoryPatten
{
    public class OperationSub : Operation
    {
        public override int CalculateResult() {
            return this.NumberX - this.NumberY;
        }
        
    }
}