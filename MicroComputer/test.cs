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

        public const string format1 = "{0,4}";
        public const string format3 = "{0,4} {1,4} {2,4}";
        public const string format4 = "{0,4} {1,4} {2,4} {3,4}";
        public const string format5 = "{0,4} {1,4} {2,4} {3,4} {4,4}";
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
        public static void testJmp()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JMP();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JMP,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJc()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JC();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JC,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNC()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNC();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNC,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJCN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JCN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JCN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNCN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNCN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNCN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJCNN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JCNN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JCNN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNCNN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNCNN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNCNN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJCZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JCZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JCZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNCZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNCZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNCZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJCNZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JCNZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JCNZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNCNZ()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNCNZ();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNCNZ,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJZN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JZN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JZN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNZN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNZN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNZN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJZNN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JZNN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JZNN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
        public static void testJNZNN()
        {
            CPU.Globals._INSTR_PC_LOOKUP.Clear();

            CPU.Globals._INSTR_PC_LOOKUP.Add(9, 10);
            CPU.Globals._INSTR_PC_LOOKUP.Add(4, 10);

            for (int c = 0; c <= 1; c++)
            {
                for (int n = 0; n <= 1; n++)
                {
                    for (int z = 0; z <= 1; z++)
                    {
                        sbyte b = 9;
                        CPU.Instr currentInstr = new CPU.Instr_JNZNN();
                        currentInstr.data = "label";
                        CPU.Globals._PC = 2;
                        string cnz = c.ToString() + n.ToString() + z.ToString();
                        if (c == 0) CPU.Globals._CARRY = false;
                        else CPU.Globals._CARRY = true;
                        if (n == 0) CPU.Globals._NEGATIVE = false;
                        else CPU.Globals._NEGATIVE = true;
                        if (z == 0) CPU.Globals._ZERO = false;
                        else CPU.Globals._ZERO = true;

                        System.Console.Write(string.Format(format4, "Previous PC =", CPU.Globals._PC, "   CNZ= ", cnz));
                        currentInstr.operation(2, b);
                        System.Console.WriteLine(string.Format(format3, ";   After JNZNN,", "PC =", CPU.Globals._PC));
                    }
                }
            }

        }
    }

    /*
   0    +    0    =    0   C=    0
   0    +    1    =    1   C=    0
   0    +  127    =  127   C=    0
   0    + -128    = -128   C=    0
   0    + -127    = -127   C=    0
   0    +   -1    =   -1   C=    0
   1    +    0    =    1   C=    0
   1    +    1    =    2   C=    0
   1    +  127    = -128   C=    0
   1    + -128    = -127   C=    0
   1    + -127    = -126   C=    0
   1    +   -1    =    0   C=    1
 127    +    0    =  127   C=    0
 127    +    1    = -128   C=    0
 127    +  127    =   -2   C=    0
 127    + -128    =   -1   C=    0
 127    + -127    =    0   C=    1
 127    +   -1    =  126   C=    1
-128    +    0    = -128   C=    0
-128    +    1    = -127   C=    0
-128    +  127    =   -1   C=    0
-128    + -128    =    0   C=    1
-128    + -127    =    1   C=    1
-128    +   -1    =  127   C=    1
-127    +    0    = -127   C=    0
-127    +    1    = -126   C=    0
-127    +  127    =    0   C=    1
-127    + -128    =    1   C=    1
-127    + -127    =    2   C=    1
-127    +   -1    = -128   C=    1
  -1    +    0    =   -1   C=    0
  -1    +    1    =    0   C=    1
  -1    +  127    =  126   C=    1
  -1    + -128    =  127   C=    1
  -1    + -127    = -128   C=    1
  -1    +   -1    =   -2   C=    1
   0    +    0    +    0    =    0       C=    0
   0    +    1    +    0    =    1       C=    0
   0    +  127    +    0    =  127       C=    0
   0    + -128    +    0    = -128       C=    0
   0    + -127    +    0    = -127       C=    0
   0    +   -1    +    0    =   -1       C=    0
   1    +    0    +    0    =    1       C=    0
   1    +    1    +    0    =    2       C=    0
   1    +  127    +    0    = -128       C=    0
   1    + -128    +    0    = -127       C=    0
   1    + -127    +    0    = -126       C=    0
   1    +   -1    +    0    =    0       C=    1
 127    +    0    +    0    =  127       C=    0
 127    +    1    +    0    = -128       C=    0
 127    +  127    +    0    =   -2       C=    0
 127    + -128    +    0    =   -1       C=    0
 127    + -127    +    0    =    0       C=    1
 127    +   -1    +    0    =  126       C=    1
-128    +    0    +    0    = -128       C=    0
-128    +    1    +    0    = -127       C=    0
-128    +  127    +    0    =   -1       C=    0
-128    + -128    +    0    =    0       C=    1
-128    + -127    +    0    =    1       C=    1
-128    +   -1    +    0    =  127       C=    1
-127    +    0    +    0    = -127       C=    0
-127    +    1    +    0    = -126       C=    0
-127    +  127    +    0    =    0       C=    1
-127    + -128    +    0    =    1       C=    1
-127    + -127    +    0    =    2       C=    1
-127    +   -1    +    0    = -128       C=    1
  -1    +    0    +    0    =   -1       C=    0
  -1    +    1    +    0    =    0       C=    1
  -1    +  127    +    0    =  126       C=    1
  -1    + -128    +    0    =  127       C=    1
  -1    + -127    +    0    = -128       C=    1
  -1    +   -1    +    0    =   -2       C=    1
   0    +    0    +    1    =    1       C=    0
   0    +    1    +    1    =    2       C=    0
   0    +  127    +    1    = -128       C=    0
   0    + -128    +    1    = -127       C=    0
   0    + -127    +    1    = -126       C=    0
   0    +   -1    +    1    =    0       C=    1
   1    +    0    +    1    =    2       C=    0
   1    +    1    +    1    =    3       C=    0
   1    +  127    +    1    = -127       C=    0
   1    + -128    +    1    = -126       C=    0
   1    + -127    +    1    = -125       C=    0
   1    +   -1    +    1    =    1       C=    1
 127    +    0    +    1    = -128       C=    0
 127    +    1    +    1    = -127       C=    0
 127    +  127    +    1    =   -1       C=    0
 127    + -128    +    1    =    0       C=    1
 127    + -127    +    1    =    1       C=    1
 127    +   -1    +    1    =  127       C=    1
-128    +    0    +    1    = -127       C=    0
-128    +    1    +    1    = -126       C=    0
-128    +  127    +    1    =    0       C=    1
-128    + -128    +    1    =    1       C=    1
-128    + -127    +    1    =    2       C=    1
-128    +   -1    +    1    = -128       C=    1
-127    +    0    +    1    = -126       C=    0
-127    +    1    +    1    = -125       C=    0
-127    +  127    +    1    =    1       C=    1
-127    + -128    +    1    =    2       C=    1
-127    + -127    +    1    =    3       C=    1
-127    +   -1    +    1    = -127       C=    1
  -1    +    0    +    1    =    0       C=    1
  -1    +    1    +    1    =    1       C=    1
  -1    +  127    +    1    =  127       C=    1
  -1    + -128    +    1    = -128       C=    1
  -1    + -127    +    1    = -127       C=    1
  -1    +   -1    +    1    =   -1       C=    1
   0    -    0    =    0   C=    1
   0    -    1    =   -1   C=    1
   0    -  127    = -127   C=    1
   0    - -128    = -128   C=    1
   0    - -127    =  127   C=    1
   0    -   -1    =    1   C=    1
   1    -    0    =    1   C=    1
   1    -    1    =    0   C=    0
   1    -  127    = -126   C=    1
   1    - -128    = -127   C=    1
   1    - -127    = -128   C=    1
   1    -   -1    =    2   C=    1
 127    -    0    =  127   C=    1
 127    -    1    =  126   C=    0
 127    -  127    =    0   C=    0
 127    - -128    =   -1   C=    1
 127    - -127    =   -2   C=    1
 127    -   -1    = -128   C=    1
-128    -    0    = -128   C=    1
-128    -    1    =  127   C=    0
-128    -  127    =    1   C=    0
-128    - -128    =    0   C=    0
-128    - -127    =   -1   C=    1
-128    -   -1    = -127   C=    1
-127    -    0    = -127   C=    1
-127    -    1    = -128   C=    0
-127    -  127    =    2   C=    0
-127    - -128    =    1   C=    0
-127    - -127    =    0   C=    0
-127    -   -1    = -126   C=    1
  -1    -    0    =   -1   C=    1
  -1    -    1    =   -2   C=    0
  -1    -  127    = -128   C=    0
  -1    - -128    =  127   C=    0
  -1    - -127    =  126   C=    0
  -1    -   -1    =    0   C=    0
   0    -    0    -    0    =    0       C=    1
   0    -    1    -    0    =   -1       C=    1
   0    -  127    -    0    = -127       C=    1
   0    - -128    -    0    = -128       C=    1
   0    - -127    -    0    =  127       C=    1
   0    -   -1    -    0    =    1       C=    1
   1    -    0    -    0    =    1       C=    1
   1    -    1    -    0    =    0       C=    0
   1    -  127    -    0    = -126       C=    1
   1    - -128    -    0    = -127       C=    1
   1    - -127    -    0    = -128       C=    1
   1    -   -1    -    0    =    2       C=    1
 127    -    0    -    0    =  127       C=    1
 127    -    1    -    0    =  126       C=    0
 127    -  127    -    0    =    0       C=    0
 127    - -128    -    0    =   -1       C=    1
 127    - -127    -    0    =   -2       C=    1
 127    -   -1    -    0    = -128       C=    1
-128    -    0    -    0    = -128       C=    1
-128    -    1    -    0    =  127       C=    0
-128    -  127    -    0    =    1       C=    0
-128    - -128    -    0    =    0       C=    0
-128    - -127    -    0    =   -1       C=    1
-128    -   -1    -    0    = -127       C=    1
-127    -    0    -    0    = -127       C=    1
-127    -    1    -    0    = -128       C=    0
-127    -  127    -    0    =    2       C=    0
-127    - -128    -    0    =    1       C=    0
-127    - -127    -    0    =    0       C=    0
-127    -   -1    -    0    = -126       C=    1
  -1    -    0    -    0    =   -1       C=    1
  -1    -    1    -    0    =   -2       C=    0
  -1    -  127    -    0    = -128       C=    0
  -1    - -128    -    0    =  127       C=    0
  -1    - -127    -    0    =  126       C=    0
  -1    -   -1    -    0    =    0       C=    0
   0    -    0    -    1    =   -1       C=    1
   0    -    1    -    1    =   -2       C=    0
   0    -  127    -    1    = -128       C=    1
   0    - -128    -    1    =  127       C=    1
   0    - -127    -    1    =  126       C=    1
   0    -   -1    -    1    =    0       C=    1
   1    -    0    -    1    =    0       C=    1
   1    -    1    -    1    =   -1       C=    0
   1    -  127    -    1    = -127       C=    1
   1    - -128    -    1    = -128       C=    1
   1    - -127    -    1    =  127       C=    1
   1    -   -1    -    1    =    1       C=    1
 127    -    0    -    1    =  126       C=    1
 127    -    1    -    1    =  125       C=    0
 127    -  127    -    1    =   -1       C=    0
 127    - -128    -    1    =   -2       C=    0
 127    - -127    -    1    =   -3       C=    1
 127    -   -1    -    1    =  127       C=    1
-128    -    0    -    1    =  127       C=    1
-128    -    1    -    1    =  126       C=    0
-128    -  127    -    1    =    0       C=    0
-128    - -128    -    1    =   -1       C=    0
-128    - -127    -    1    =   -2       C=    0
-128    -   -1    -    1    = -128       C=    1
-127    -    1    -    1    =  127       C=    0
-127    -  127    -    1    =    1       C=    0
-127    - -128    -    1    =    0       C=    0
-127    - -127    -    1    =   -1       C=    0
-127    -   -1    -    1    = -127       C=    1
  -1    -    0    -    1    =   -2       C=    0
  -1    -    1    -    1    =   -3       C=    0
  -1    -  127    -    1    =  127       C=    0
  -1    - -128    -    1    =  126       C=    0
  -1    - -127    -    1    =  125       C=    0
  -1    -   -1    -    1    =   -1       C=    0
   0    +    1    =    1
   1    +    1    =    2
 127    +    1    = -128
-128    +    1    = -127
-127    +    1    = -126
  -1    +    1    =    0
   0    -    1    =   -1
   1    -    1    =    0
 127    -    1    =  126
-128    -    1    =  127
-127    -    1    = -128
  -1    -    1    =   -2

   0  AND    0    =    0
   0  AND    1    =    0
   0  AND  127    =    0
   0  AND -128    =    0
   0  AND -127    =    0
   0  AND   -1    =    0
   1  AND    0    =    0
   1  AND    1    =    1
   1  AND  127    =    1
   1  AND -128    =    0
   1  AND -127    =    1
   1  AND   -1    =    1
 127  AND    0    =    0
 127  AND    1    =    1
 127  AND  127    =  127
 127  AND -128    =    0
 127  AND -127    =    1
 127  AND   -1    =  127
-128  AND    0    =    0
-128  AND    1    =    0
-128  AND  127    =    0
-128  AND -128    = -128
-128  AND -127    = -128
-128  AND   -1    = -128
-127  AND    0    =    0
-127  AND    1    =    1
-127  AND  127    =    1
-127  AND -128    = -128
-127  AND -127    = -127
-127  AND   -1    = -127
  -1  AND    0    =    0
  -1  AND    1    =    1
  -1  AND  127    =  127
  -1  AND -128    = -128
  -1  AND -127    = -127
  -1  AND   -1    =   -1
   0   OR    0    =    0
   0   OR    1    =    1
   0   OR  127    =  127
   0   OR -128    = -128
   0   OR -127    = -127
   0   OR   -1    =   -1
   1   OR    0    =    1
   1   OR    1    =    1
   1   OR  127    =  127
   1   OR -128    = -127
   1   OR -127    = -127
   1   OR   -1    =   -1
 127   OR    0    =  127
 127   OR    1    =  127
 127   OR  127    =  127
 127   OR -128    =   -1
 127   OR -127    =   -1
 127   OR   -1    =   -1
-128   OR    0    = -128
-128   OR    1    = -127
-128   OR  127    =   -1
-128   OR -128    = -128
-128   OR -127    = -127
-128   OR   -1    =   -1
-127   OR    0    = -127
-127   OR    1    = -127
-127   OR  127    =   -1
-127   OR -128    = -127
-127   OR -127    = -127
-127   OR   -1    =   -1
  -1   OR    0    =   -1
  -1   OR    1    =   -1
  -1   OR  127    =   -1
  -1   OR -128    =   -1
  -1   OR -127    =   -1
  -1   OR   -1    =   -1
   0  XOR    0    =    0
   0  XOR    1    =    1
   0  XOR  127    =  127
   0  XOR -128    = -128
   0  XOR -127    = -127
   0  XOR   -1    =   -1
   1  XOR    0    =    1
   1  XOR    1    =    0
   1  XOR  127    =  126
   1  XOR -128    = -127
   1  XOR -127    = -128
   1  XOR   -1    =   -2
 127  XOR    0    =  127
 127  XOR    1    =  126
 127  XOR  127    =    0
 127  XOR -128    =   -1
 127  XOR -127    =   -2
 127  XOR   -1    = -128
-128  XOR    0    = -128
-128  XOR    1    = -127
-128  XOR  127    =   -1
-128  XOR -128    =    0
-128  XOR -127    =    1
-128  XOR   -1    =  127
-127  XOR    0    = -127
-127  XOR    1    = -128
-127  XOR  127    =   -2
-127  XOR -128    =    1
-127  XOR -127    =    0
-127  XOR   -1    =  126
  -1  XOR    0    =   -1
  -1  XOR    1    =   -2
  -1  XOR  127    = -128
  -1  XOR -128    =  127
  -1  XOR -127    =  126
  -1  XOR   -1    =    0
   0  INV   =    0
   1  INV   =   -1
 127  INV   = -127
-128  INV   = -128
-127  INV   =  127
  -1  INV   =    1
   0  CMP    0    =    0
   0  CMP    1    =   -1
   0  CMP  127    = -127
   0  CMP -128    = -128
   0  CMP -127    =  127
   1  CMP    0    =    1
   1  CMP    1    =    0
   1  CMP  127    = -126
   1  CMP -128    = -127
   1  CMP -127    = -128
   1  CMP   -1    =    2
 127  CMP    0    =  127
 127  CMP    1    =  126
 127  CMP  127    =    0
 127  CMP -128    =   -1
 127  CMP -127    =   -2
 127  CMP   -1    = -128
-128  CMP    0    = -128
-128  CMP    1    =  127
-128  CMP  127    =    1
-128  CMP -128    =    0
-128  CMP -127    =   -1
-128  CMP   -1    = -127
-127  CMP    0    = -127
-127  CMP    1    = -128
-127  CMP  127    =    2
-127  CMP -128    =    1
-127  CMP -127    =    0
-127  CMP   -1    = -126
  -1  CMP    0    =   -1
  -1  CMP    1    =   -2
  -1  CMP  127    = -128
  -1  CMP -128    =  127
  -1  CMP -127    =  126
  -1  CMP   -1    =    0
   0 CLRA    =    0
   1 CLRA    =    0
 127 CLRA    =    0
-128 CLRA    =    0
-127 CLRA    =    0
  -1 CLRA    =    0


Previous PC =    2    CNZ=   000;   After JMP, PC =    9
Previous PC =    2    CNZ=   001;   After JMP, PC =    9
Previous PC =    2    CNZ=   010;   After JMP, PC =    9
Previous PC =    2    CNZ=   011;   After JMP, PC =    9
Previous PC =    2    CNZ=   100;   After JMP, PC =    9
Previous PC =    2    CNZ=   101;   After JMP, PC =    9
Previous PC =    2    CNZ=   110;   After JMP, PC =    9
Previous PC =    2    CNZ=   111;   After JMP, PC =    9
Previous PC =    2    CNZ=   000;   After JC, PC =    4
Previous PC =    2    CNZ=   001;   After JC, PC =    4
Previous PC =    2    CNZ=   010;   After JC, PC =    4
Previous PC =    2    CNZ=   011;   After JC, PC =    4
Previous PC =    2    CNZ=   100;   After JC, PC =    9
Previous PC =    2    CNZ=   101;   After JC, PC =    9
Previous PC =    2    CNZ=   110;   After JC, PC =    9
Previous PC =    2    CNZ=   111;   After JC, PC =    9
Previous PC =    2    CNZ=   000;   After JNC, PC =    9
Previous PC =    2    CNZ=   001;   After JNC, PC =    9
Previous PC =    2    CNZ=   010;   After JNC, PC =    9
Previous PC =    2    CNZ=   011;   After JNC, PC =    9
Previous PC =    2    CNZ=   100;   After JNC, PC =    4
Previous PC =    2    CNZ=   101;   After JNC, PC =    4
Previous PC =    2    CNZ=   110;   After JNC, PC =    4
Previous PC =    2    CNZ=   111;   After JNC, PC =    4
Previous PC =    2    CNZ=   000;   After JN, PC =    4
Previous PC =    2    CNZ=   001;   After JN, PC =    4
Previous PC =    2    CNZ=   010;   After JN, PC =    9
Previous PC =    2    CNZ=   011;   After JN, PC =    9
Previous PC =    2    CNZ=   100;   After JN, PC =    4
Previous PC =    2    CNZ=   101;   After JN, PC =    4
Previous PC =    2    CNZ=   110;   After JN, PC =    9
Previous PC =    2    CNZ=   111;   After JN, PC =    9
Previous PC =    2    CNZ=   000;   After JNN, PC =    9
Previous PC =    2    CNZ=   001;   After JNN, PC =    9
Previous PC =    2    CNZ=   010;   After JNN, PC =    4
Previous PC =    2    CNZ=   011;   After JNN, PC =    4
Previous PC =    2    CNZ=   100;   After JNN, PC =    9
Previous PC =    2    CNZ=   101;   After JNN, PC =    9
Previous PC =    2    CNZ=   110;   After JNN, PC =    4
Previous PC =    2    CNZ=   111;   After JNN, PC =    4
Previous PC =    2    CNZ=   000;   After JZ, PC =    4
Previous PC =    2    CNZ=   001;   After JZ, PC =    9
Previous PC =    2    CNZ=   010;   After JZ, PC =    4
Previous PC =    2    CNZ=   011;   After JZ, PC =    9
Previous PC =    2    CNZ=   100;   After JZ, PC =    4
Previous PC =    2    CNZ=   101;   After JZ, PC =    9
Previous PC =    2    CNZ=   110;   After JZ, PC =    4
Previous PC =    2    CNZ=   111;   After JZ, PC =    9
Previous PC =    2    CNZ=   000;   After JNZ, PC =    9
Previous PC =    2    CNZ=   001;   After JNZ, PC =    4
Previous PC =    2    CNZ=   010;   After JNZ, PC =    9
Previous PC =    2    CNZ=   011;   After JNZ, PC =    4
Previous PC =    2    CNZ=   100;   After JNZ, PC =    9
Previous PC =    2    CNZ=   101;   After JNZ, PC =    4
Previous PC =    2    CNZ=   110;   After JNZ, PC =    9
Previous PC =    2    CNZ=   111;   After JNZ, PC =    4
Previous PC =    2    CNZ=   000;   After JCN, PC =    4
Previous PC =    2    CNZ=   001;   After JCN, PC =    4
Previous PC =    2    CNZ=   010;   After JCN, PC =    9
Previous PC =    2    CNZ=   011;   After JCN, PC =    9
Previous PC =    2    CNZ=   100;   After JCN, PC =    9
Previous PC =    2    CNZ=   101;   After JCN, PC =    9
Previous PC =    2    CNZ=   110;   After JCN, PC =    9
Previous PC =    2    CNZ=   111;   After JCN, PC =    9
Previous PC =    2    CNZ=   000;   After JNCN, PC =    9
Previous PC =    2    CNZ=   001;   After JNCN, PC =    9
Previous PC =    2    CNZ=   010;   After JNCN, PC =    9
Previous PC =    2    CNZ=   011;   After JNCN, PC =    9
Previous PC =    2    CNZ=   100;   After JNCN, PC =    4
Previous PC =    2    CNZ=   101;   After JNCN, PC =    4
Previous PC =    2    CNZ=   110;   After JNCN, PC =    9
Previous PC =    2    CNZ=   111;   After JNCN, PC =    9
Previous PC =    2    CNZ=   000;   After JCNN, PC =    9
Previous PC =    2    CNZ=   001;   After JCNN, PC =    9
Previous PC =    2    CNZ=   010;   After JCNN, PC =    4
Previous PC =    2    CNZ=   011;   After JCNN, PC =    4
Previous PC =    2    CNZ=   100;   After JCNN, PC =    9
Previous PC =    2    CNZ=   101;   After JCNN, PC =    9
Previous PC =    2    CNZ=   110;   After JCNN, PC =    9
Previous PC =    2    CNZ=   111;   After JCNN, PC =    9
Previous PC =    2    CNZ=   000;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   001;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   010;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   011;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   100;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   101;   After JNCNN, PC =    9
Previous PC =    2    CNZ=   110;   After JNCNN, PC =    4
Previous PC =    2    CNZ=   111;   After JNCNN, PC =    4
Previous PC =    2    CNZ=   000;   After JCZ, PC =    4
Previous PC =    2    CNZ=   001;   After JCZ, PC =    9
Previous PC =    2    CNZ=   010;   After JCZ, PC =    4
Previous PC =    2    CNZ=   011;   After JCZ, PC =    9
Previous PC =    2    CNZ=   100;   After JCZ, PC =    9
Previous PC =    2    CNZ=   101;   After JCZ, PC =    9
Previous PC =    2    CNZ=   110;   After JCZ, PC =    9
Previous PC =    2    CNZ=   111;   After JCZ, PC =    9
Previous PC =    2    CNZ=   000;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   001;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   010;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   011;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   100;   After JNCZ, PC =    4
Previous PC =    2    CNZ=   101;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   110;   After JNCZ, PC =    4
Previous PC =    2    CNZ=   111;   After JNCZ, PC =    9
Previous PC =    2    CNZ=   000;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   001;   After JCNZ, PC =    4
Previous PC =    2    CNZ=   010;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   011;   After JCNZ, PC =    4
Previous PC =    2    CNZ=   100;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   101;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   110;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   111;   After JCNZ, PC =    9
Previous PC =    2    CNZ=   000;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   001;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   010;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   011;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   100;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   101;   After JNCNZ, PC =    4
Previous PC =    2    CNZ=   110;   After JNCNZ, PC =    9
Previous PC =    2    CNZ=   111;   After JNCNZ, PC =    4
Previous PC =    2    CNZ=   000;   After JZN, PC =    4
Previous PC =    2    CNZ=   001;   After JZN, PC =    9
Previous PC =    2    CNZ=   010;   After JZN, PC =    9
Previous PC =    2    CNZ=   011;   After JZN, PC =    9
Previous PC =    2    CNZ=   100;   After JZN, PC =    4
Previous PC =    2    CNZ=   101;   After JZN, PC =    9
Previous PC =    2    CNZ=   110;   After JZN, PC =    9
Previous PC =    2    CNZ=   111;   After JZN, PC =    9
Previous PC =    2    CNZ=   000;   After JZNN, PC =    9
Previous PC =    2    CNZ=   001;   After JZNN, PC =    9
Previous PC =    2    CNZ=   010;   After JZNN, PC =    4
Previous PC =    2    CNZ=   011;   After JZNN, PC =    9
Previous PC =    2    CNZ=   100;   After JZNN, PC =    9
Previous PC =    2    CNZ=   101;   After JZNN, PC =    9
Previous PC =    2    CNZ=   110;   After JZNN, PC =    4
Previous PC =    2    CNZ=   111;   After JZNN, PC =    9
Previous PC =    2    CNZ=   000;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   001;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   010;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   011;   After JNZNN, PC =    4
Previous PC =    2    CNZ=   100;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   101;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   110;   After JNZNN, PC =    9
Previous PC =    2    CNZ=   111;   After JNZNN, PC =    4
 */



}










