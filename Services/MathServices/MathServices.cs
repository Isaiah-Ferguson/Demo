using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.Services.MathServices
{
    public class MathServices : IMathServices
    {
        public string MathTime(string num1){

            int num2 = 0;
            bool isTrue = int.TryParse(num1, out num2);

            if(isTrue == true){
                return $"{num2} is a number good job";
            }else{
                return "That was not a number";
            }

        }
    }
}