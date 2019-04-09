namespace DesignPattern.FactoryPatten
{
    public class OperationDiv: Operation
    {
        public override int CalculateResult() {
            if(this.NumberY == 0)
            {
                throw new System.Exception("Divisor cannot be zero");
            }
            return this.NumberX / this.NumberY;
        }
    }
}