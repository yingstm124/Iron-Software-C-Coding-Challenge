namespace challenge;

public class Phone
{
    private Dictionary<char, char[]> characterList = new Dictionary<char, char[]>()
        {
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
        char[] specialCharacter = [' ', '*', '#'];

        int start = 0;
        int end = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0)
                continue;

            if (input[i] == input[end])
            {
                end = i;
            }
            else
            {
                if (!specialCharacter.Contains(input[end]))
                {
                    var _allCharacter = characterList[input[end]];
                    translateText += _allCharacter[(end - start) % _allCharacter.Length];
                }
                if (input[i] == '*')
                {
                    translateText = translateText.Remove(translateText.Length - 1);
                }
                start = i;
                end = i;
            }
        }

        return translateText;
    }
};
