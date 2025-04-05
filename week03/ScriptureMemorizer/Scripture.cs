// Scripture: Keeps track of both the reference and the text of the scripture. Can hide words and get the rendered display of the text.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
    }

    private void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return _reference.GetDisplayText();
    }

    private bool IsCompletelyHidden()
    {

    }
}