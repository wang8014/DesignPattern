using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using DesignPattern.FactoryPatten;
using DesignPattern.StrategyPattern;


namespace DesignPattern.Controllers
{
    [Route("api/[controller]")]
    public class PatternController : Controller
    {
        [HttpPost("[action]")]
        public FactoryReturnClass FactoryCalculate([FromBody]JsonFactoryParameter param) {
            FactoryReturnClass rtn = new FactoryReturnClass();
            Operation oper = OperationFactory.CreateOperation(param.oper);
            if(oper!=null){
                oper.NumberX = param.NumberX;
                oper.NumberY = param.NumberY;
                try{
                    rtn.Message = "Calculated successfully by factoryPattern!";
                    rtn.result = oper.CalculateResult(); 
                    rtn.ReturnValue = 0;
                } 
                catch (Exception ex){
                    rtn.Message = "error:"+ex.Message;
                    rtn.ReturnValue = 100;
                }
                finally
                {
                    
                }
            } else {
                rtn.Message = "Operator is invalid.";
                rtn.ReturnValue = 101;
            }
            
            return rtn;

        }

        [HttpPost("[action]")]
        public StrategyReturnClass StrategyCalculate([FromBody]JsonStrategyParameter param) {
            StrategyReturnClass rtn = new StrategyReturnClass();
            ContextOperation context = new ContextOperation(param.oper,param.NumberX,param.NumberY);
            try{
                    rtn.Message = "Calculated successfully by strategyPattern!";
                    rtn.result = context.Calculate(); 
                    rtn.ReturnValue = 0;
            } 
            catch (Exception ex){
                rtn.Message = "error:"+ex.Message;
                rtn.ReturnValue = 100;
            }
            finally
            {
                
            }
            
            return rtn;

        }
    }
}