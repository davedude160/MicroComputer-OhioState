using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroComputer
{
    class test
    {
        public static sbyte[] testData =
        {
            0,
            1,
            127,
            -128,
            -127,
            -1
        };

        public const string format3 = "{0,4} {1,4} {2,4}";
        public const string format2 = "{0,4} {1,4}";
        public const string format1 = "{0,4}";
        public const string format4 = "{0,4} {1,4} {2,4} {3,4}";
        public const string format5 = "{0,4} {1,4} {2,4} {3,4} {4,4}";
        public const string format6 = "{0,4} {1,4} {2,4} {3,4} {4,4} {5,4}";
        public const string format7 = "{0,4} {1,4} {2,4} {3,4} {4,4} {5,4} {6,4}";
        public const string format9 = "{0,4} {1,4} {2,4} {3,4} {4,4} {5,4} {6,4} {7,8} {8,4}";

        public static void testAdd()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {
                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_ADD();
                    currentInstr.isImmediate = true;

                    currentInstr.operation(a, b);
                    int carry;
                    if (CPU.Globals._CARRY)
                        carry = 1;
                    else carry = 0;

                    System.Console.WriteLine(string.Format(format7, a, "+", b, "=", CPU.Globals._AC, "C=", carry));

                }

            }


        }
        public static void testAddc()
        {
            for (int c = 0; c <= 1; c++)
            {
                for (int ai = 0; ai < testData.Length; ai++)
                {
                    for (int bi = 0; bi < testData.Length; bi++)
                    {
                        sbyte a = testData[ai];
                        sbyte b = testData[bi];
                        CPU.Instr currentInstr = new CPU.Instr_ADDC();
                        currentInstr.isImmediate = true;
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;

                        currentInstr.operation(a, b);
                        int carry;
                        if (CPU.Globals._CARRY)
                            carry = 1;
                        else carry = 0;

                        System.Console.WriteLine(string.Format(format9, a, "+", b, "+", c, "=", CPU.Globals._AC, "C=", carry));


                    }

                }
            }

        }
        public static void testSub()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {
                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_SUB();
                    currentInstr.isImmediate = true;

                    currentInstr.operation(a, b);
                    int carry;
                    if (CPU.Globals._CARRY)
                        carry = 1;
                    else carry = 0;
                    System.Console.WriteLine(string.Format(format7, a, "-", b, "=", CPU.Globals._AC, "C=", carry));

                }

            }
        }
        public static void testSubc()
        {
            for (int c = 0; c <= 1; c++)
            {
                for (int ai = 0; ai < testData.Length; ai++)
                {
                    for (int bi = 0; bi < testData.Length; bi++)
                    {
                        sbyte a = testData[ai];
                        sbyte b = testData[bi];
                        CPU.Instr currentInstr = new CPU.Instr_SUBC();
                        currentInstr.isImmediate = true;
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;

                        currentInstr.operation(a, b);
                        int carry;
                        if (CPU.Globals._CARRY)
                            carry = 1;
                        else carry = 0;
                        System.Console.WriteLine(string.Format(format9, a, "-", b, "-", c, "=", CPU.Globals._AC, "C=", carry));

                    }

                }
            }
        }
        public static void testInc()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                sbyte a = testData[ai];
                sbyte b = 0;
                CPU.Instr currentInstr = new CPU.Instr_INC();
                currentInstr.isImmediate = true;

                currentInstr.operation(a, b);
                System.Console.WriteLine(String.Format(format5, a, "+", "1", "=", CPU.Globals._AC));



            }
        }
        public static void testDec()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                sbyte a = testData[ai];
                sbyte b = 0;
                CPU.Instr currentInstr = new CPU.Instr_DEC();
                currentInstr.isImmediate = true;

                currentInstr.operation(a, b);
                System.Console.WriteLine(String.Format(format5, a, "-", "1", "=", CPU.Globals._AC));



            }
        }
        public static void testOr()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {
                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_OR();
                    currentInstr.isImmediate = true;

                    currentInstr.operation(a, b);
                    System.Console.WriteLine(string.Format(format5, a, "OR", b, "=", CPU.Globals._AC));

                }

            }
        }
        public static void testXOr()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {
                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_XOR();
                    currentInstr.isImmediate = true;

                    currentInstr.operation(a, b);
                    System.Console.WriteLine(string.Format(format5, a, "XOR", b, "=", CPU.Globals._AC));

                }

            }
        }
        public static void testAnd()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {
                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_AND();
                    currentInstr.isImmediate = true;

                    currentInstr.operation(a, b);
                    System.Console.WriteLine(string.Format(format5, a, "AND", b, "=", CPU.Globals._AC));

                }

            }
        }
        public static void testInv()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {

                sbyte a = testData[ai];
                sbyte b = 0;
                CPU.Instr currentInstr = new CPU.Instr_INV();
                currentInstr.isImmediate = true;

                CPU.Globals._AC = a;
                currentInstr.operation(a, b);
                System.Console.WriteLine(string.Format(format3, a, " INV   =", CPU.Globals._AC));

            }
        }


        public static void testCmp()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                for (int bi = 0; bi < testData.Length; bi++)
                {

                    sbyte a = testData[ai];
                    sbyte b = testData[bi];
                    CPU.Instr currentInstr = new CPU.Instr_CMP();
                    currentInstr.isImmediate = true;


                    currentInstr.operation(a, b);

                    System.Console.WriteLine(string.Format(format5, a, "CMP", b, "=", CPU.Globals._AC));
                }

            }
        }
        public static void testClra()
        {
            for (int ai = 0; ai < testData.Length; ai++)
            {
                sbyte a = testData[ai];
                sbyte b = 0;
                CPU.Instr currentInstr = new CPU.Instr_CLRA();
                currentInstr.isImmediate = true;
                CPU.Globals._AC = a;

                System.Console.Write(string.Format(format1, CPU.Globals._AC));
                currentInstr.operation(a, b);
                System.Console.WriteLine(string.Format(format3, " CLRA", "=", CPU.Globals._AC));



            }
        }











    }
}
