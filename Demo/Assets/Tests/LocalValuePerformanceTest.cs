using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// Ƶ��ʹ�õı��������ڷ�������Ǿֲ�
/// </summary>
public class LocalValuePerformanceTest
{

    private int TestNum = 10000000;

    struct TestData
    {
        public int A;
        public int B;
    }

    //��Ч������
    [Test]
    public void TestLower()
    {
        //��ʼ����������
        List<TestData> list = SetUp();

        //���ܲ���
        for (int i = 0; i < TestNum; i++)
        {
            Calc(list[i].A, list[i].A);
        }
    }

    //ʹ��ʱ��ʱ���滺��
    [Test]
    public void TestLocalTmp()
    {
        //��ʼ����������
        List<TestData> list = SetUp();

        //���ܲ���
        for (int i = 0; i < TestNum; i++)
        {
            TestData tmp = list[i];
            Calc(tmp.A, tmp.B);
        }
    }

    //�������⻺��
    [Test]
    public void TestTmp()
    {
        //��ʼ����������
        List<TestData> list = SetUp();

        //���ܲ���
        TestData tmp;
        for (int i = 0; i < TestNum; i++)
        {
            tmp = list[i];
            Calc(tmp.A, tmp.B);
        }
    }

    private List<TestData> SetUp()
    {
        List<TestData> list = new List<TestData>(TestNum);
        for (int i = 0; i < TestNum; i++)
        {
            list.Add(new TestData() { A = i, B = i });
        }
        return list;
    }

    private int Calc(int a, int b)
    {
        return a * b;
    }
}
