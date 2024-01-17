using UnityEngine;

public class Frage
{
    //Instanzvariable deklarieren
    [SerializeField] private string frageText;
    private Antwort[] antworten;

    //Konstruktor
    public Frage()
    {
        Debug.Log("Erstelle Frage");
    }

    public void SetFrageText(string fragetxt)
    {
        frageText = fragetxt;
    }

    public string GetFrageText()
    {
        return frageText;
    }

    public void SetAntworten(Antwort[] antworten)
    {
        this.antworten = antworten;
    }

    public void PrintAllAntworten()
    {
        foreach (Antwort aw in antworten)
        {
            Debug.Log(aw.GetAntwortText());
        }
    }

    public Antwort[] ShuffleAntworten()
    {
        int i = Random.Range(0,antworten.Length);
        int[] order = new int[3];

        //erstes Element im Array
        order[0] = i;

        i = Random.Range(0, antworten.Length);
        //zweites Element im Array
        do
        {
            i = Random.Range(0, antworten.Length);
        } while (order[0] == i);

        order[1] = i;

        //drittes Element im Array
        i = Random.Range(0, antworten.Length);
        do
        {
            i = Random.Range(0, antworten.Length);
        } while (order[0] == i || order[1] == i);

        order[2] = i;

        Antwort[] tmpAntworten = new Antwort[3];
        System.Array.Copy(antworten, tmpAntworten, 3);

        for (int j = 0; j < antworten.Length; j++)
        {
            antworten[j] = tmpAntworten[order[j]];
            Debug.Log(antworten[j]);
        }

        //Ausgabe
        foreach (int index in order)
        {
            Debug.Log("order" + index);
        }

        return antworten;
    }
}


