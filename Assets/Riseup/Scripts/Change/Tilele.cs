using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class Tilele : MonoBehaviour
{

    #region Declare
  
    [SerializeField]
    Text txtLanguage;
  
    public SpriteRenderer player;
    public SpriteRenderer Ballon;
    public Toggle devo1Toggle;
    public Toggle devo2Toggle;
    public Toggle devo3Toggle;
    public Toggle devo4Toggle;
    public Toggle devo5Toggle;
    public Toggle devo6Toggle;
    public Toggle devo7Toggle;
    public Toggle devo8Toggle;
    public Toggle devo9Toggle;
    public static Tilele instance;
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
    void Start()
    {
        if (PlayerPrefs.HasKey("select11"))
        {
            if (PlayerPrefs.GetInt("select11") == 1)
            {
                devo1Toggle.isOn = true;
            }
            else
            {

                devo1Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select21"))
        {
            if (PlayerPrefs.GetInt("select21") == 1)
            {
                devo2Toggle.isOn = true;
            }
            else
            {

                devo2Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select31"))
        {
            if (PlayerPrefs.GetInt("select31") == 1)
            {
                devo3Toggle.isOn = true;
            }
            else
            {

                devo3Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select41"))
        {
            if (PlayerPrefs.GetInt("select41") == 1)
            {
                devo4Toggle.isOn = true;
            }
            else
            {

                devo4Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select51"))
        {
            if (PlayerPrefs.GetInt("select51") == 1)
            {
                devo5Toggle.isOn = true;
            }
            else
            {

                devo5Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select61"))
        {
            if (PlayerPrefs.GetInt("select61") == 1)
            {
                devo6Toggle.isOn = true;
            }
            else
            {

                devo6Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select71"))
        {
            if (PlayerPrefs.GetInt("select71") == 1)
            {
                devo7Toggle.isOn = true;
            }
            else
            {

                devo7Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select81"))
        {
            if (PlayerPrefs.GetInt("select81") == 1)
            {
                devo8Toggle.isOn = true;
            }
            else
            {

                devo8Toggle.isOn = false;
            }

        }
        if (PlayerPrefs.HasKey("select91"))
        {
            if (PlayerPrefs.GetInt("select91") == 1)
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
    void Update()
    {

    }
    #region Language
    void DisalbeButton(string name)
    {
        try
        {
 
            player.sprite = Applili.GetLocaleImage(LocaleType.ball);
            Ballon.sprite = Applili.GetLocaleImage(LocaleType.ball);
         
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

            PlayerPrefs.SetInt("select11", 1);
            Applili.SelectedLanguage = LanguageType.English;

            DisalbeButton("btEnglish");
        }
        else
        {
            PlayerPrefs.SetInt("select11", 0);

        }

    }
    public void SelectJapanese()
    {
        if (devo2Toggle.isOn == true)
        {

            PlayerPrefs.SetInt("select21", 1);
            Applili.SelectedLanguage = LanguageType.Japanese;
        DisalbeButton("btJapanese");

        }
        else
        {
            PlayerPrefs.SetInt("select21", 0);

        }
    }
    public void SelectChinese1()
    {
            if (devo3Toggle.isOn == true)
            {

                PlayerPrefs.SetInt("select31", 1);
                Applili.SelectedLanguage = LanguageType.Chinese1;
        DisalbeButton("btChinese");
        }
        else
        {
            PlayerPrefs.SetInt("select31", 0);

        }

    }
    public void SelectChinese2()
            {
                if (devo4Toggle.isOn == true)
                {

                    PlayerPrefs.SetInt("select41", 1);
                    Applili.SelectedLanguage = LanguageType.Chinese2;
        DisalbeButton("btChinese2");
        }
        else
        {
            PlayerPrefs.SetInt("select41", 0);

        }
    }
    public void SelectThai()
    {
                    if (devo5Toggle.isOn == true)
                    {

                        PlayerPrefs.SetInt("select51", 1);
                        Applili.SelectedLanguage = LanguageType.Thai;
        DisalbeButton("btThai");
        }
        else
        {
            PlayerPrefs.SetInt("select51", 0);

        }

    }
    public void Select1()
                    {
                        if (devo6Toggle.isOn == true)
                        {

                            PlayerPrefs.SetInt("select61", 1);
                            Applili.SelectedLanguage = LanguageType.select1;
        DisalbeButton("bt1");
        }
        else
        {
            PlayerPrefs.SetInt("select61", 0);

        }

    }
    public void Select2()
                        {
                            if (devo7Toggle.isOn == true)
                            {

                                PlayerPrefs.SetInt("select71", 1);
                                Applili.SelectedLanguage = LanguageType.select2;
        DisalbeButton("bt2");
        }
        else
        {
            PlayerPrefs.SetInt("select71", 0);

        }

    }
    public void Select3()
                            {
                                if (devo8Toggle.isOn == true)
                                {

                                    PlayerPrefs.SetInt("select81", 1);
                                    Applili.SelectedLanguage = LanguageType.select3;
        DisalbeButton("bt3");
        }
        else
        {
            PlayerPrefs.SetInt("select81", 0);

        }

    }
    public void Select4()
                                {
                                    if (devo9Toggle.isOn == true)
                                    {

                                        PlayerPrefs.SetInt("select91", 1);
                                        Applili.SelectedLanguage = LanguageType.select4;
        DisalbeButton("bt4");
        }
        else
        {
            PlayerPrefs.SetInt("select91", 0);

        }

    }
    #endregion
}
