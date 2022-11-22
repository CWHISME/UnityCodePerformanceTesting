using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// 传递结构体参数时可以视情况通过 ref 或 in 减少数据拷贝消耗
/// </summary>
public class RefValuePerformanceTest
{

    private int TestNum = 10000000;

    struct TestData
    {
        public int A;
        public int B;
    }

    public void TestDirectWrite()
    {
        TestData data = new TestData();
        data.A = 2;
        data.B = 1;
    }

    [Test]
    public void TestNormal()
    {
        TestData data = new TestData() { A = 12345 };
        for (int i = 0; i < TestNum; i++)
        {
            data.B = i;
            Calc(data);
        }
    }

    [Test]
    public void TestRef()
    {
        TestData data = new TestData() { A = 12345 };
        for (int i = 0; i < TestNum; i++)
        {
            data.B = i;
            CalcWithRef(ref data);
        }
    }

    [Test]
    public void TestIn()
    {
        TestData data = new TestData() { A = 12345 };
        for (int i = 0; i < TestNum; i++)
        {
            data.B = i;
            CalcWithIn(data);
        }
    }

    private int Calc(TestData data)
    {
        return data.A + data.B;
    }

    private int CalcWithRef(ref TestData data)
    {
        return data.A + data.B;
    }

    private int CalcWithIn(in TestData data)
    {
        return data.A + data.B;
    }

    [Test]
    public void TestDoubleNormal()
    {
        for (int i = 0; i < TestNum; i++)
        {
            Calc(i, i);
        }
    }

    [Test]
    public void TestDoubleIn()
    {
        for (int i = 0; i < TestNum; i++)
        {
            CalcWithIn(i, i);
        }
    }


    private double Calc(double a, double b)
    {
        return a * b;
    }

    private double CalcWithIn(in double a, in double b)
    {
        return a * b;
    }
}
