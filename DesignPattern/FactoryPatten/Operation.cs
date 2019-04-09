namespace DesignPattern.FactoryPatten
{
    public class Operation
    {
        public int NumberX { get;set;}
        public int NumberY { get;set; }

        public virtual int CalculateResult(){
            return 0;
        }
    }
}