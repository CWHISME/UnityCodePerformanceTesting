using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// 频繁使用的变量定义在方法外而非局部
/// </summary>
public class LocalValuePerformanceTest
{

    private int TestNum = 10000000;

    struct TestData
    {
        public int A;
        public int B;
    }

    //低效率做法
    [Test]
    public void TestLower()
    {
        //初始化测试数据
        List<TestData> list = SetUp();

        //性能测试
        for (int i = 0; i < TestNum; i++)
        {
            Calc(list[i].A, list[i].A);
        }
    }

    //使用时临时缓存缓存
    [Test]
    public void TestLocalTmp()
    {
        //初始化测试数据
        List<TestData> list = SetUp();

        //性能测试
        for (int i = 0; i < TestNum; i++)
        {
            TestData tmp = list[i];
            Calc(tmp.A, tmp.B);
        }
    }

    //方法块外缓存
    [Test]
    public void TestTmp()
    {
        //初始化测试数据
        List<TestData> list = SetUp();

        //性能测试
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
