using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class Title : MonoBehaviour {

    #region Declare
    [SerializeField]
    List<Button> lstButton;
    [SerializeField]
    Text  txtLanguage;  
    public SpriteRenderer ball;
    public SpriteRenderer Hander; 
    public static Title instance;

    public Toggle devo1Toggle;
    public Toggle devo2Toggle;
    public Toggle devo3Toggle;
    public Toggle devo4Toggle;
    public Toggle devo5Toggle;
    public Toggle devo6Toggle;
    public Toggle devo7Toggle;
    public Toggle devo8Toggle;
    public Toggle devo9Toggle;
    
    #endregion

    #region Init
    void OnEnable()
    {
        switch (Application.systemLanguage.ToString())
        {
            case "Japanese":
                SelectJapanese();
                break;
            case "ChineseTraditional":
                SelectChinese1();
                break;
            case "ChineseSimplified":
                SelectChinese2();
                break;
            case "Thai":
                SelectThai();
                break;
            default:
                SelectEnglish();
                break;
        }
       // txtLanguage.text = Appli.GetLocaleText(LocaleTyp.TermLimitedYokai); //key value language
    }
    #endregion

        // Use this for initialization
        void Start() {
        if (PlayerPrefs.HasKey("select1"))
        {
            if (PlayerPrefs.GetInt("select1") == 1)
            {
                devo1Toggle.isOn = true;
            }
            else
            {

                devo1Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select2"))
        {
            if (PlayerPrefs.GetInt("select2") == 1)
            {
                devo2Toggle.isOn = true;
            }
            else
            {

                devo2Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select3"))
        {
            if (PlayerPrefs.GetInt("select3") == 1)
            {
                devo3Toggle.isOn = true;
            }
            else
            {

                devo3Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select4"))
        {
            if (PlayerPrefs.GetInt("select4") == 1)
            {
                devo4Toggle.isOn = true;
            }
            else
            {

                devo4Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select5"))
        {
            if (PlayerPrefs.GetInt("select5") == 1)
            {
                devo5Toggle.isOn = true;
            }
            else
            {

                devo5Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select6"))
        {
            if (PlayerPrefs.GetInt("select6") == 1)
            {
                devo6Toggle.isOn = true;
            }
            else
            {

                devo6Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select7"))
        {
            if (PlayerPrefs.GetInt("select7") == 1)
            {
                devo7Toggle.isOn = true;
            }
            else
            {

                devo7Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select8"))
        {
            if (PlayerPrefs.GetInt("select8") == 1)
            {
                devo8Toggle.isOn = true;
            }
            else
            {

                devo8Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select9"))
        {
            if (PlayerPrefs.GetInt("select9") == 1)
            {
                devo9Toggle.isOn = true;
            }
            else
            {

                devo9Toggle.isOn = false;
            }

        }
    }

    // Update is called once per frame
    void Update() {

    }
    #region Language
    void DisalbeButton(string name)
    {
        try
        {
            List<Button> lstTemp = lstButton.FindAll(x => x.name != name);
            Button bt = lstButton.Find(x => x.name == name);         
            ball.sprite = Appli.GetLocaleImage(LocaleTyp.TermLimitedYokai);
            Hander.sprite = Appli.GetLocaleImage(LocaleTyp.TermLimitedYokai);
         
        }
        catch (System.Exception e)
        {

            Debug.Log(e.Message);
        }
    }
    

    public void SelectEnglish()
    {
        if (devo1Toggle.isOn == true)
        {

            PlayerPrefs.SetInt("select1", 1);
            Appli.SelectedLanguage = LanguageTyp.English;
     
        DisalbeButton("btEnglish");
        }
        else
        {
            PlayerPrefs.SetInt("select1", 0);

        }

    }   
    public void SelectJapanese()
    {
        if (devo2Toggle.isOn == true)
        {

            PlayerPrefs.SetInt("select2", 1);
            Appli.SelectedLanguage = LanguageTyp.Japanese;
            DisalbeButton("btJapanese");
        }
        else
        {
            PlayerPrefs.SetInt("select2", 0);

        }

    }
    public void SelectChinese1()
    {
        if (devo3Toggle.isOn == true)
        {

            PlayerPrefs.SetInt("select3", 1);

            Appli.SelectedLanguage = LanguageTyp.Chinese1;
            DisalbeButton("btChinese");
        }
        else
        {
            PlayerPrefs.SetInt("select3", 0);

        }

    }
    public void SelectChinese2()
    {
            if (devo4Toggle.isOn == true)
            {

                PlayerPrefs.SetInt("select4", 1);
                Appli.SelectedLanguage = LanguageTyp.Chinese2;
            DisalbeButton("btChinese2");
        }
        else
        {
            PlayerPrefs.SetInt("select4", 0);

        }
    }
    public void SelectThai()
            {
                if (devo5Toggle.isOn == true)
                {

                    PlayerPrefs.SetInt("select5", 1);
                    Appli.SelectedLanguage = LanguageTyp.Thai;
        DisalbeButton("btThai");
        }
        else
        {
            PlayerPrefs.SetInt("select5", 0);

        }

    }
    public void Select1()
    {
                    if (devo6Toggle.isOn == true)
                    {

                        PlayerPrefs.SetInt("select6", 1);
                        Appli.SelectedLanguage = LanguageTyp.select1;
        DisalbeButton("bt1");
        }
        else
        {
            PlayerPrefs.SetInt("select6", 0);

        }

    }
    public void Select2()
     {
        if (devo7Toggle.isOn == true)
     {
         PlayerPrefs.SetInt("select7", 1);
           Appli.SelectedLanguage = LanguageTyp.select2;
        DisalbeButton("bt2");
        }
        else
        {
            PlayerPrefs.SetInt("select7", 0);

        }

    }
    public void Select3()
       {
     if (devo8Toggle.isOn == true)
       {

     PlayerPrefs.SetInt("select8", 1);
     Appli.SelectedLanguage = LanguageTyp.select3;
    DisalbeButton("bt3");

        }
        else
        {
            PlayerPrefs.SetInt("select8", 0);

        }
    }
    public void Select4()
     {
          if (devo9Toggle.isOn == true)
           {

              PlayerPrefs.SetInt("select99", 1);
             Appli.SelectedLanguage = LanguageTyp.select4;
             DisalbeButton("bt4");
        }
        else
        {
            PlayerPrefs.SetInt("select9", 0);

        }

    }
    #endregion
}
