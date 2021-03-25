using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Localization : MonoBehaviour
{
    public static int currentLanguage = 1;
    private Dictionary<string, string[]> _fields;
    private static Dictionary<string, string[]> Fields;

    private void Awake()
    {
        Fields = new Dictionary<string, string[]>();
        
        //Keys
        Fields.Add("restart", new []{"Restart", "Рестарт"});
        Fields.Add("tutorial0", new []{
            "Move unit using W, A, S, D keys",
            "Перемещайте юнита используя клавиши W, A, S, D"});
        Fields.Add("tutorial1", new []{
            "Press Space to switch control to the next unit,",
            "Нажмите Пробел, чтобы переключить управление на" +
            "следующего юнита. Однако перемещение предыдущих" +
            "будет зависать от него, т.е. они будут перемещаться" +
            "вместе с ним"});
    }

    public static string Translate(string text)
    {
        string[] elements = text.Split(new[] {'|'});
        for (int i = 0; i < elements.Length; i++)
        {
            if (!NumberHelper.Even(i))
            {
                if (Fields.ContainsKey(elements[i]))
                {
                    elements[i] = Fields[elements[i]][currentLanguage];
                }
            }
        }

        string returned = "";
        foreach (var element in elements)
        {
            returned += element;
        }

        return returned;
    }
}
