using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ValueChecker
{

    [Test]
    public void Test()
    {
        Debug.Log("�������ͣ�" + Marshal.SizeOf<Data>());
        Data data = new Data();
        data.x = "�������ʹ�����";
        Debug.Log("�������ʹ����ݣ�" + Marshal.SizeOf<Data>(data));
        Debug.Log("sbyte��" + Marshal.SizeOf<sbyte>());
        Debug.Log("byte��" + Marshal.SizeOf<byte>());
        Debug.Log("char��" + Marshal.SizeOf<char>());
        Debug.Log("short��" + Marshal.SizeOf<short>());
        Debug.Log("int��" + Marshal.SizeOf<int>());
        Debug.Log("float��" + Marshal.SizeOf<float>());
        Debug.Log("long��" + Marshal.SizeOf<long>());
        Debug.Log("double��" + Marshal.SizeOf<double>());
        Debug.Log("decimal��" + Marshal.SizeOf<decimal>());
    }

    struct Data
    {
        public string x;
    }
}
