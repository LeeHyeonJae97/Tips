using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Example1
public class Test
{
    public void LogOrder(Number number)
    {
        Debug.Log(number.ToOrder());
    }
}

public enum Number
{
    One,
    Two,
    Three,
    None = -1,
}

public enum Order
{
    First,
    Second,
    Third,
    None = -1,
}

public static class FromExtension
{
    public static Order ToOrder(this Number number)
    {
        switch (number)
        {
            case Number.One:
                return Order.First;

            case Number.Two:
                return Order.Second;

            case Number.Three:
                return Order.Third;
        }
        return Order.None;
    }
}
#endregion

#region Example2
public class UI
{
    public enum Type { A, B, C, None = -1, }

    Type _type;

    public void UpdateData(UIData uiData)
    {
        _type = ToType(uiData.type);
    }

    Type ToType(UIData.Type type)
    {
        switch (type)
        {
            case UIData.Type.A:
                return Type.A;

            case UIData.Type.B:
                return Type.B;

            case UIData.Type.C:
            case UIData.Type.D:
                return Type.C;
        }
        return Type.None;
    }
}

public class UIData
{
    public enum Type { D, C, B, A, None = -1, }

    public Type type;
}
#endregion

#region Example3
public class ExamResult
{
    public int score;
    public int grade;

    public ExamResult(int score)
    {
        this.score = score;
        this.grade = ToGrade(score);
    }

    int ToGrade(int score)
    {
        if (score < 50)
        {
            return 4;
        }
        else if (50 <= score && score < 70)
        {
            return 3;
        }
        else if (70 <= score && score < 90)
        {
            return 2;
        }
        else if (90 <= score && score <= 100)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }
}
#endregion

#region Example4
public class Man
{
    public int age;
    public int health;
    public int smartness;
    public int sympathy;
}

public class Worker
{
    public int age;
    public int health;
    public int smartness;

    public Worker(Man man)
    {
        age = man.age;
        health = man.health;
        smartness = man.smartness;
    }
}

public class Husband
{
    public int age;
    public int health;
    public int sympathy;

    public Husband(Man man)
    {
        age = man.age;
        health = man.health;
        sympathy = man.sympathy;
    }
}
#endregion