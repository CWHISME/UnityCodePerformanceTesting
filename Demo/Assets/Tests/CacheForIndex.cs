using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CacheForIndex
{

    private const int TestNum = 1000000;

    [Test]
    public void TestNoCahche()
    {
        int[] array = new int[TestNum];
        for (int i = 0; i < array.Length; i++)
        {

        }
    }


    [Test]
    public void TestCahche()
    {
        int[] array = new int[TestNum];
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {

        }
    }
}
