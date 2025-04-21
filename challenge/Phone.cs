namespace challenge;

public class Phone
{
    private Dictionary<char, char[]> characterList = new Dictionary<char, char[]>()
        {
            {'0', [ ' ' ]},
            {'1', [ '&', '\'', '(']},
            {'2', [ 'A', 'B', 'C' ]},
            {'3', [ 'D', 'E', 'F' ]},
            {'4', [ 'G', 'H', 'I' ]},
            {'5', [ 'J', 'K', 'L' ]},
            {'6', [ 'M', 'N', 'O' ]},
            {'7', [ 'P', 'Q', 'R', 'S']},
            {'8', [ 'T', 'U', 'V']},
            {'9', [ 'W', 'X', 'Y', 'Z']},
            };

    public string OldPhonePad(string input)
    {
        // process
        string translateText = "";

        int start = 0;
        int end = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
                continue;

            if (input[end] == '#')
                break;

            if (input[i] == input[end])
            {
                end = i;
            }
            else
            {
                if (Char.IsDigit(input[end]))
                {
                    translateText += translateChar(input[end], end - start);
                }
                if (input[i] == '*' && translateText != "")
                {
                    translateText = translateText.Remove(translateText.Length - 1);
                }
                start = i;
                end = i;
            }
        }

        if (Char.IsDigit(input[end]))
        {
            translateText += translateChar(input[end], end - start);
        }

        return translateText;
    }

    private char translateChar(char character, int repeatAmount)
    {
        var _allCharacter = characterList[character];
        return _allCharacter[(repeatAmount) % _allCharacter.Length];
    }
};
