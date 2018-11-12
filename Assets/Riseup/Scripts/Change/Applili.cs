using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Applili : MonoBehaviour
{
    static Applili appli;


    public static string GetLocaleText(LocaleType key)
    {
        var localee = appli.localeData.Find((obj) => obj.key == key);
        if (localee.key != LocaleType.None)
        {
            if (Applili.SelectedLanguage == LanguageType.Thai)
            {
                try
                {
                    return ThaiFontAdjuster.Adjust(localee.localContents.Find((obj) => obj.languageType == SelectedLanguage).text);
                }
                catch (Exception e)
                {
                    Debug.Log(e.Message);
                    return "error !";
                }
            }
            else
            {
                return localee.localContents.Find((obj) => obj.languageType == SelectedLanguage).text;
            }

        }
        else
        {
            Debug.LogError("cant find locale");
            return "";
        }
    }

    public static LanguageType SelectedLanguage
    {
        get
        {
            return appli.selectedLanguage;
        }
        set
        {
            appli.selectedLanguage = value;
        }
    }

    public static Sprite GetLocaleImage(LocaleType key)
    {
        var locale = appli.localeData.Find((obj) => obj.key == key);
        if (locale.key != LocaleType.None)
        {
            return locale.localContents.Find((obj) => obj.languageType == SelectedLanguage).image;
        }
        else
        {
            Debug.LogError("cant find locale");
            return null;
        }
    }

    [SerializeField]
    LanguageType selectedLanguage = LanguageType.Japanese;

    [SerializeField]
    List<LocaleData> localeData = new List<LocaleData>();

    void Awake()
    {
        appli = this;
    }
}
public enum LanguageType
{
    Japanese,
    English,
    Chinese1,
    Chinese2,
    Thai,
    select1,
    select2,
    select3, select4

}

public enum LocaleType
{
    None,
    TermLimitedYokai,//1
    MiddleEnding1,//2
    ball,
    ball1,
    ball2
}

[Serializable]
public struct LocaleData
{
    public LocaleType key;
    public List<Local> localContents;
}

[Serializable]
public struct Local
{
    public LanguageType languageType;
    [Multiline]
    public string text;
    public Sprite image;

}



