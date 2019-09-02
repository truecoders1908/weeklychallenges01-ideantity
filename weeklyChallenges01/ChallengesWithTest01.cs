using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;

namespace ChallengesWithTests01
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public double Subtract(double minuend, double subtrahend)
        {
            double sub = minuend - subtrahend;
            return sub;
            throw new NotImplementedException();
        }

        public int Add(int number1, int number2)
        {
            int sum = number1 + number2;
            return sum;
            throw new NotImplementedException();
        }

        public int GetSmallestNumber(int number1, int number2)
        {
           int tinyboi = Math.Min(number1,number2);
           return tinyboi;
           throw new NotImplementedException();
        }

        public long Multiply(long factor1, long factor2)
        {
            long twoply = factor1 * factor2;
            return twoply;
            throw new NotImplementedException();
        }

        public string GetGreeting(string personName) //Changed nameOfPerson to personName
        {
            string greet = "Hello!";
            string greetings = "Hello, " + personName + "!";
            if (string.IsNullOrEmpty(personName))
            {
                return greet;
            }
            else
            {
                return greetings;
            }
            throw new NotImplementedException();
        }

        public string GetHey()
        {
            string hey = "HEY!";
            return hey;
            throw new NotImplementedException();
        }
    }
}