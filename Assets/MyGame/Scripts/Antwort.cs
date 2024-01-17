public class Antwort
{
    string antwortText;
    bool valid;

    //Konstruktor
    public Antwort()
    {

    }

    //Parameter wird Instanzvariable zugewiesen
    public void SetAntwortText(string antwortText)
    {
        this.antwortText = antwortText;
    }

    public string GetAntwortText()
    {
        return antwortText;
    }

    public bool IsCorrect()
    {
        return valid;
    }

    public void SetAntwortCorrect(bool valid)
    {
        this.valid = valid;
    }
}
