using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RE_Matching_FSA_Project
{
    class RegularExpression
    {
        private Hashtable register;
        private string[] operators = { "^", "+", "[", "]", "$", "*", "." };
        public string[] operants = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

        public RegularExpression()
        {
            register = new Hashtable();
            register.Add("^",0);
            register.Add("+", 0);
            register.Add("[]", 0);
            register.Add("$", 0);
            register.Add("*", 0);
            register.Add(".", 0);
        }

        public void updateRegister(string inputs)
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                switch (inputs.Substring(i,1))
                {
                    case "^":
                        register["^"] = 1;
                        break;
                    case "+":
                        register["+"] = 1;
                        break;
                    case "[":
                        register["[]"] = 1;
                        break;
                    case "$":
                        register["$"] = 1;
                        break;
                    case "*":
                        register["*"] = 1;
                        break;
                    case ".":
                        register["."] = 1;
                        break;
                    default:
                        break;
                }
            }
        }

        public Boolean registerQuery(string p_operator)
        {
            if ((int)register[p_operator] == 1)
            {
                return true;
            }
            else
                return false;
        }

        public Boolean isOperator(string input)
        {
            for (int i = 0; i < operators.Length; i++)
            {
                if (input.Equals(operators[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public Boolean isOperant(string input)
        {
            for (int i = 0; i < operants.Length; i++)
            {
                if (input.Equals(operants[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public string[] splitInput(string s)
        {
            string[] splitedInput = new string[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                splitedInput[i] = s.Substring(i, 1);
            }
            return splitedInput;
        }

        public int numOfOperator(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (isOperator(input.Substring(i,1)))
                {
                    count++;
                }
            }
            return count;
        }

        public int numOfOperant(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (isOperant(input.Substring(i, 1)))
                {
                    count++;
                }
            }
            return count;
        }

        public int stateCount(string input)
        {
            int operantCount = numOfOperant(input),squareBrakeCount = 0;
            Boolean squareBrakeCont = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i,1) == "[")
                {
                    squareBrakeCont = true;
                }
                if (input.Substring(i, 1) == "]")
                {
                    squareBrakeCont = false;
                }
                if (squareBrakeCont == true && input.Substring(i, 1) != "[")
                {
                    squareBrakeCount++;
                }
            }
            //return (int)register["[]"] == 1 ? (operantCount - squareBrakeCount) + 2 : (operantCount - squareBrakeCount) + 1;
            return operantCount - squareBrakeCount + 2;
        }
    }
}
