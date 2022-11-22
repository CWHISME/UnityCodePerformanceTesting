using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

/// <summary>
/// ≤‚ ‘ StringBuilder   Append ∫Õ Insert
/// </summary>
public class StringBuilderTest
{

    private const int TestNum = 100000;


    [Test]
    public void TestAppend()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.Append(1);
        }
        Debug.Log("TestAppend Capacity" + builder.Capacity);
    }

    [Test]
    public void TestInsertStart()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.Insert(0, 1);
        }
        Debug.Log("TestInsertStart Capacity" + builder.Capacity);
    }

    [Test]
    public void TestInsertMiddle()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.Insert(builder.Length / 2, 1);
        }
        Debug.Log("TestInsertMiddle Capacity" + builder.Capacity);
    }

    [Test]
    public void TestInsertEnd()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.Insert(builder.Length, 1);
        }
        Debug.Log("TestInsertEnd Capacity" + builder.Capacity);
    }

    [Test]
    public void TestAppendNormalParams()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.Append("X");
            builder.Append(1);
            builder.Append("Y");
        }
        Debug.Log("TestAppendNormalParams Capacity£∫" + builder.Capacity);
    }

    [Test]
    public void TestAppendFormatParams()
    {
        StringBuilder builder = new StringBuilder(1);
        for (int i = 0; i < TestNum; i++)
        {
            builder.AppendFormat("X{0}Y", 1);
        }
        Debug.Log("TestAppend Capacity£∫" + builder.Capacity);
    }
}
