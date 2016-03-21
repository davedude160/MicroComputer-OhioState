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
}