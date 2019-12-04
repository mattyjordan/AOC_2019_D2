﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2019_
{
    class AOC
    {
        static void Main(string[] args)
        {
            //Day1();
            Day2();
        
        }

        #region day1
        private static void Day1() 
        {
            List<int> listOfValues = intsToList();
            int Activity1Answer = D1Activity1(listOfValues);
            int Activity2Answer = D1Activity2(listOfValues);
        }
        private static List<int> intsToList()
        {
            List<int> myList = new List<int>() {
            146561


            return myList;
        }
        private static int D1Activity1(List<int> listOfValues)
        {
            

            int finalValue = 0;

            foreach (var item in listOfValues)
            {
                finalValue += DivideValueByThreeFlooredMiinus3(item);
            }

            return finalValue;

        }
        private static int D1Activity2(List<int> listOfValues)
        {

            int finalValue = 0;

            foreach (var item in listOfValues)
            {
                int workingValue = item;

                finalValue += workingValue = DivideValueByThreeFlooredMiinus3(item);
                
                while (workingValue > 0)
                {
                    workingValue = DivideValueByThreeFlooredMiinus3(workingValue);
                    if (workingValue > 0)
                    {
                        finalValue += workingValue;
                    }
                }
            }

            return finalValue;

        }
        private static int DivideValueByThreeFlooredMiinus3(int myInt)
        {
            myInt = myInt / 3;
            myInt = Convert.ToInt32(Math.Floor((decimal)myInt));
            myInt = myInt - 2;
            
            return myInt;
        }
        #endregion

        #region day2
        private static void Day2() 
        {
            int Answer1 = D2Activity1(12,1);
            int Answer2 = D2Activity2();
        }
                private static List<int> puzzleIntput()
        {
            List<int> returnList = new List<int>() {
            1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,1,9,19,1,19,5,23,2,6,23,27,1,6,27,31,2,31,9,35,1,35,6,39,1,10,39,43,2,9,43,47,1,5,47,51,2,51,6,55,1,5,55,59,2,13,59,63,1,63,5,67,2,67,13,71,1,71,9,75,1,75,6,79,2,79,6,83,1,83,5,87,2,87,9,91,2,9,91,95,1,5,95,99,2,99,13,103,1,103,5,107,1,2,107,111,1,111,5,0,99,2,14,0,0
            };
            return returnList;
        }
        private static int D2Activity1(int noun, int verb)
        {
            List<int> myList = puzzleIntput();
            myList[1] = noun;
            myList[2] = verb;


            for (int i = 0; i < myList.Count; i += 4)
            {

                if (myList[i] == 99)
                {
                    break;
                }
                if (myList[i] == 1)
                {
                    int firstValuePosition = i + 1;
                    int secondValuePostition = i + 2;
                    int outputValuePosition = i + 3;

                    int firstValue = myList[myList[firstValuePosition]];
                    int secondValue = myList[myList[secondValuePostition]];

                    int value = firstValue + secondValue;
                    myList[myList[outputValuePosition]] = value;


                }
                if (myList[i] == 2)
                {
                    int firstValuePosition = i + 1;
                    int secondValuePostition = i + 2;
                    int outputValuePosition = i + 3;

                    int firstValue = myList[myList[firstValuePosition]];
                    int secondValue = myList[myList[secondValuePostition]];

                    int value = firstValue * secondValue;
                    myList[myList[outputValuePosition]] = value;


                }
                else if (!(myList[i] == 2 || myList[i] == 1 || myList[i] == 99))
                {
                    Console.WriteLine("Error");
                }

            }

            return myList[0];
        }
        private static int D2Activity2()
        {
            //Expected answer 19690720 value in position 0
            int expectedAnswer = 19690720;
            int actualAnswer = 0;

            for (int noun = 0; noun < 99; noun++)
            {
                for (int verb = 0; verb < 99; verb++)
                {
                    List<int> puzzleInput = puzzleIntput();

                    int answer = D2Activity1(noun, verb);
                    if (answer == expectedAnswer)
                    {
                        Console.WriteLine($"noun: {noun} verb:{verb} Answer: {100*noun+verb}");
                        actualAnswer = 100 * noun + verb;
                        break;
                    }
                }
            }
            return actualAnswer;

        }
        #endregion


    }
}