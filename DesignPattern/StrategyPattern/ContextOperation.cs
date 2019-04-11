using DesignPattern.FactoryPatten;

namespace DesignPattern.StrategyPattern
{
    /// <summary>
    /// strategy 最大的不同于factory 就是 将factory实际上也封装了起来。
    /// 外部调用的时候，只需要暴露context一个类就可以。
    /// 而factory类却需要暴露2个类，super类即operation类，和factory类。
    /// 书中提到了，这还不是完美做法，因为没有屏蔽掉switch语句。如果有新的算法增加，还是要经常的修改这段switch语句，万一误改？？？
    /// 解决的方法是使用反射技术。
    /// </summary>
    public class ContextOperation
    {
        private Operation oper = null;
        public ContextOperation(string op) {
            
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
            
        }
        public ContextOperation(string op, int x, int y) : this ( op) {
               SetXY(x, y); 
        }
        public void SetXY(int x, int y) {
            if(oper!=null) {
                this.oper.NumberX = x;
                this.oper.NumberY = y;
            }
        }

        public int Calculate() {
            if(oper!=null){
                return oper.CalculateResult();
            } else {
                return 0;
            }
        }

    }
}