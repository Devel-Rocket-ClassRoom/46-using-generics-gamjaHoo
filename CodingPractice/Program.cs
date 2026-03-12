using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//1
{
    Stack stack = new Stack();
    stack.Push(200);
    stack.Push(100);
    Console.WriteLine($"값1: {(int)stack.Pop()}, 값2: {(int)stack.Pop()}");
}

//2
{
    Stack<int> stack = new Stack<int>();
    stack.Push(200);
    stack.Push(100);
    Console.WriteLine($"값1: {stack.Pop()}, 값2: {stack.Pop()}");
}

////3
//Cup<string> stringCup = new Cup<string>();
//Cup<int> intCup = new Cup<int>();
//stringCup.Value = "커피";
//intCup.Value = 500;

//Console.WriteLine($"음료: {stringCup.Value}\n용량: {intCup.Value}ml");
//class Cup<T>
//{
//    public T Value { get; set; }
//}


////4
//Pair<string, int> pair1 = new Pair<string, int>();
//Pair<int, double> pair2 = new Pair<int, double>();

//pair1.First = "용사";
//pair1.Second = 100;
//pair2.First = 1;
//pair2.Second = 95.5;
//Console.WriteLine($"이름: {pair1.First} HP: {pair2.First}");
//Console.WriteLine($"순위: {pair2.First}, 점수: {pair2.Second}");
//class Pair<TFirst, TSecond>
//{
//    public TFirst First { get; set; }
//    public TSecond Second { get; set; }
//}

////5
//int x = 10, y = 20;
//string first = "사과", second = "바나나";
//Console.WriteLine($"교환 전: x={x}, y={y}");
//Swap(ref x, ref y);
//Console.WriteLine($"교환 후: x={x}, y={y}");
//Console.WriteLine($"교환 전: first={first}, second={second}");
//Swap(ref first,ref second);
//Console.WriteLine($"교환 후: first={first}, second={second}");
//void Swap<T>(ref T first, ref T second)
//{
//    T temp = first;
//    first = second;
//    second = temp;
//}

////6
//NumberContainer<int> i = new NumberContainer<int>();
//i.Value = 100;
//NumberContainer<float> f = new NumberContainer<float>();
//f.Value = 3.14F;
//Console.WriteLine($"정수값: {i.Value}\n실수값: {f.Value}");
//class NumberContainer<T> where T : struct
//{
//    public T Value;
//}

////7
//var monster = CreateInstance<Monster>();
//monster.Name = "슬라임";
//monster.Health = 50;

//Console.WriteLine($"생성된 몬스터: {monster.Name}, HP: {monster.Health}");
//T CreateInstance<T>() where T : new()
//{
//    return new T(); 
//}
//class Monster
//{
//    public string Name { get; set; }
//    public int Health { get; set; }
//}

////8
//T GetMax<T>(T a, T b) where T : IComparable<T>
//{
//    return a.CompareTo(b) > 0 ? a : b;
//}

//int maxInt = GetMax(10, 25);
//Console.WriteLine($"더 큰 정수: {maxInt}");

//string maxString = GetMax("apple", "banana");
//Console.WriteLine($"사전순 뒤: {maxString}");

////9
//int defaultInt = GetDefaultValue<int>();
//bool defaultBool = GetDefaultValue<bool>();
//string defaultString = GetDefaultValue<string>();
//Console.WriteLine($"int 기본값: {defaultInt}\nbool 기본값: {defaultBool}\nstring 기본값: {defaultString}");
//T GetDefaultValue<T>  ()
//{
//    return default(T); 
//}

////10
//List<string> names = new List<string>();
//names.Add("철수");
//names.Add("영희");
//names.Add("민수");
//Console.WriteLine("이름 목록:");
//foreach(string name in names)
//{
//    Console.WriteLine($"  - {name}"); 
//}
//Dictionary<string, int> people = new Dictionary<string, int>();
//people["철수"] = 95;
//people["영희"] = 88;
//people["민수"] = 92;
//Console.WriteLine("점수:");
//foreach(var pair in people)
//{
//    Console.WriteLine($"  {pair.Key}: {pair.Value}점"); 
//}


////11
//SpecialContainer<string> specialContainer = new SpecialContainer<string>();
//specialContainer.Item = "특별한 아이템";
//specialContainer.description = "레어 등급";

//IntContainer intContainer = new IntContainer();
//intContainer.Item = 50;

//Console.WriteLine($"{specialContainer.Item} ({specialContainer.description})");
//Console.WriteLine($"값: {intContainer.Item}, 두 배: {intContainer.Double()}");

//class Container<T>
//{
//    public T Item {  get; set; }
//}

//class SpecialContainer<T> : Container<T>
//{
//    public string description { get; set; }
//}

//class IntContainer : Container<int>
//{
//    public int Double() => Item * 2; 
//}

//12
// 각 타입별로 독립적인 Count를 가짐
Counter<int>.Count++;
Counter<int>.Count++;
Counter<string>.Count++;

Console.WriteLine($"Counter<int>.Count: {Counter<int>.Count}");
Console.WriteLine($"Counter<string>.Count: {Counter<string>.Count}");

public class Counter<T>
{
    public static int Count = 0;
}