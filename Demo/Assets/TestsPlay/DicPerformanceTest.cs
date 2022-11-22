using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class DicPerformanceTest
{

    private const int Num = 1000000;
    //private const int TestNum = 50;


    private Dictionary<int, int> valueDic = new Dictionary<int, int>(Num);

    private int[] keyArray = new int[Num];
    private int[] valueArray = new int[Num];

    private List<int> keyList = new List<int>(Num);
    private List<int> valueList = new List<int>(Num);


    public void SetupDic()
    {
        for (int i = 0; i < Num; i++)
        {
            valueDic.Add(i, i + 1);
        }
    }

    public void SetupArray()
    {
        for (int i = 0; i < Num; i++)
        {
            keyArray[i] = i;
            valueArray[i] = i + 1;
        }
    }

    public void SetupList()
    {
        for (int i = 0; i < Num; i++)
        {
            keyList.Add(i);
            valueList.Add(i + 1);
        }
    }


    // A Test behaves as an ordinary method
    //[PrebuildSetup(typeof(DicPerformanceTest))]
    [Test]
    public void TestDictionary()
    {
        SetupDic();
        int k, v;
        foreach (var item in valueDic)
        {
            k = item.Key;
            v = item.Value;
        }
    }

    //[PrebuildSetup(typeof(DicPerformanceTest))]
    [Test]
    public void TestArrayDic()
    {
        SetupArray();
        int k, v;
        for (int i = 0; i < keyArray.Length; i++)
        {
            k = keyArray[i];
            v = valueArray[i];
        }
    }

    //[PrebuildSetup(typeof(DicPerformanceTest))]
    [Test]
    public void TestListDic()
    {
        SetupList();
        int k, v;
        for (int i = 0; i < keyList.Count; i++)
        {
            k = keyList[i];
            v = valueList[i];
        }
    }

}
