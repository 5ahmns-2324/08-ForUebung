using UnityEngine;

public class Manager : MonoBehaviour
{
    //zum Testen
    string frage1Text = "Frage1";
    string frage2Text = "Frage2";
    string frage3Text = "Frage3";

    //Deklaration des Array vom Datentyp Frage
    private Frage[] meineFragen;

    // Start is called before the first frame update
    void Start()
    {
        int[] array1 = new int[3] { 1, 2, 3 };
        int[] arraytmp = new int[3];
        int[] arrayCopy = new int[3];

        arraytmp = array1;
        System.Array.Copy(array1, arrayCopy, 3);

        arraytmp[2] = 99;

        Debug.Log("array 1: " + array1[2]);
        Debug.Log("array tmp " + arraytmp[2]);
        Debug.Log("array copy: " + arrayCopy[2]);

        Frage frage0 = new Frage();
        frage0.SetFrageText("Ist das Wetter schön?");
        Antwort f0a1 = new Antwort();
        f0a1.SetAntwortText("ja");
        f0a1.SetAntwortCorrect(true);

        //Testen
        //Frage 1 und Antworten Setup
        Frage frage1 = new Frage();
        frage1.SetFrageText(frage1Text);

        Antwort a1 = new Antwort();
        a1.SetAntwortText("f1a1");
        Antwort a2 = new Antwort();
        a2.SetAntwortText("f1a2");
        Antwort a3 = new Antwort();
        a3.SetAntwortText("f1a3");

        Antwort[] antwortenF1 = new Antwort[3] { a1, a2, a3 };
        frage1.SetAntworten(antwortenF1);
        frage1.PrintAllAntworten();
        frage1.ShuffleAntworten();

        //Frage 2
        Frage frage2 = new Frage();
        frage2.SetFrageText(frage2Text);

        Antwort[] antwortenF2 = new Antwort[3];
        //Antwortobjekte generieren und in Array speichern
        for (int i = 0; i < antwortenF2.Length; i++)
        {
            antwortenF2[i] = new Antwort();
        }

        antwortenF2[0].SetAntwortText("f2a1");
        antwortenF2[1].SetAntwortText("f2a2");
        antwortenF2[2].SetAntwortText("f2a3");
        frage2.SetAntworten(antwortenF2);
        frage2.PrintAllAntworten();
        frage2.ShuffleAntworten();

        Frage frage3 = new Frage();
        frage3.SetFrageText(frage3Text);

        meineFragen = new Frage[3] { frage1, frage2, frage3 };

        Debug.Log("++++++++++++++++++++++++++++++++++");

        for (int i = 0; i < meineFragen.Length; i++)
        {
            Debug.Log("meineFragen[" + i + "] ist" + meineFragen[i].GetFrageText());
        }

        //Durchlaufen eines bestehenden Array
        foreach (Frage mf in meineFragen)
        {
            mf.GetFrageText();
        }
    }
}
