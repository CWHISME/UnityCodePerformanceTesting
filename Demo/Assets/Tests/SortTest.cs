using System.Collections;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class SortTest
{

    private int[] _arrayData = new int[] { 1, 2, 3, 4, 5, 0, 6, 7, 8, 9, 10 };

    private const int TestNum = 100000;

    [Test]
    public void BubbleSort()
    {
        for (int N = 0; N < TestNum; N++)
        {
            for (int i = 1; i < _arrayData.Length; i++)
            {
                for (int j = 0; j < _arrayData.Length; j++)
                {
                    if (_arrayData[i] > _arrayData[j])
                    {
                        int tmp = _arrayData[j];
                        _arrayData[j] = _arrayData[i];
                        _arrayData[i] = tmp;
                    }
                }
            }
        }

        Debug.Log(string.Join(",", _arrayData));
    }

    [Test]
    public void InsertionSort()
    {
        for (int N = 0; N < TestNum; N++)
        {
            for (int i = 1; i < _arrayData.Length; i++)
            {
                int tmp = _arrayData[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (tmp > _arrayData[j])
                    {
                        _arrayData[j + 1] = _arrayData[j];
                        //_arrayData[i + 1] = _arrayData[j];
                        _arrayData[j] = tmp;
                    }
                }
            }
        }

        Debug.Log(string.Join(",", _arrayData));
    }


    [Test]
    public void GuideShellSort()
    {
        int gap = 1;
        int len = 3;

        while (gap < _arrayData.Length)
        {
            gap = gap * len + 1;
        }

        for (int N = 0; N < TestNum; N++)
        {
            while (gap > 0)
            {
                for (int i = gap; i < _arrayData.Length; i++)
                {
                    int tmp = _arrayData[i];
                    for (int j = i - gap; j >= 0; j -= gap)
                    {
                        if (tmp < _arrayData[j])
                        {
                            _arrayData[j + gap] = _arrayData[j];
                            _arrayData[j] = tmp;
                        }
                    }
                }
                gap /= len;
            }
        }


        Debug.Log(string.Join(",", _arrayData));
    }

    [Test]
    public void ShellSort()
    {
        int gap = _arrayData.Length / 2;

        for (int N = 0; N < TestNum; N++)
        {
            while (gap > 0)
            {
                for (int i = gap; i < _arrayData.Length; i++)
                {
                    int tmp = _arrayData[i];
                    for (int j = i - gap; j >= 0; j -= gap)
                    {
                        if (tmp < _arrayData[j])
                        {
                            _arrayData[j + gap] = _arrayData[j];
                            _arrayData[j] = tmp;
                        }
                    }
                }
                gap /= 2;
            }
        }

        Debug.Log(string.Join(",", _arrayData));
    }

}
