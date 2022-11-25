using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ArrayTest
{

    private const int ArrayCount = 100;
    private const int TestNum = 1000;

    [Test]
    public void MultiDimensionalArrayTest()
    {
        //初始化
        int[,] array = new int[ArrayCount, ArrayCount];
        for (int i = 0; i < ArrayCount; i++)
        {
            for (int j = 0; j < ArrayCount; j++)
            {
                array[i, j] = -1;
            }
        }

        //遍历
        int num;
        for (int n = 0; n < TestNum; n++)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                for (int j = 0; j < ArrayCount; j++)
                {
                    num = array[i, j];
                }
            }
        }
    }


    [Test]
    public void JaggedArraytTest()
    {
        //初始化
        int[][] array = new int[ArrayCount][];
        for (int i = 0; i < ArrayCount; i++)
        {
            array[i] = new int[ArrayCount];
            for (int j = 0; j < ArrayCount; j++)
            {
                array[i][j] = -1;
            }
        }

        //遍历
        int num;
        for (int n = 0; n < TestNum; n++)
        {
            for (int i = 0; i < ArrayCount; i++)
            {
                for (int j = 0; j < ArrayCount; j++)
                {
                    num = array[i][j];
                }
            }
        }
    }
}
