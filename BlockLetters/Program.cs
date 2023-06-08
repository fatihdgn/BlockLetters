var text = string.Join(' ', Enumerable.Repeat("Fatih", 5)); 

text = text.ToUpperInvariant();

var letters = text.Select(c => LetterProvider.Provide(c)).ToArray();

for (int y = 0; y < LetterProvider.LetterLength; y++)
{
    for (int l = 0; l < letters.Length; l++)
    {
        for(int x = 0; x < LetterProvider.LetterWidth; x++)
        {
            Console.Write(letters[l][y,x]);
        }
    }
    Console.WriteLine();

}

class LetterProvider
{
    public const int LetterLength = 7;
    public const int LetterWidth = 5;

    static readonly Dictionary<char, char[,]> Letters = new Dictionary<char, char[,]>
        {
            {
                ' ',
                new char[LetterLength,LetterWidth] {
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                    { ' ', ' ', ' ', ' ', ' ' },
                }
            },
            {
                'F',
                new char[LetterLength,LetterWidth] {
                    { 'F', 'F', 'F', 'F', 'F' },
                    { 'F', ' ', ' ', ' ', ' ' },
                    { 'F', ' ', ' ', ' ', ' ' },
                    { 'F', 'F', 'F', ' ', ' ' },
                    { 'F', ' ', ' ', ' ', ' ' },
                    { 'F', ' ', ' ', ' ', ' ' },
                    { 'F', ' ', ' ', ' ', ' ' },
                }
            },
            {
                'A',
                new char[LetterLength,LetterWidth] {
                    { ' ', ' ', 'A', ' ', ' ' },
                    { ' ', 'A', ' ', 'A', ' ' },
                    { 'A', ' ', ' ', ' ', 'A' },
                    { 'A', 'A', 'A', 'A', 'A' },
                    { 'A', ' ', ' ', ' ', 'A' },
                    { 'A', ' ', ' ', ' ', 'A' },
                    { 'A', ' ', ' ', ' ', 'A' },
                }
            },
            {
                'T',
                new char[LetterLength,LetterWidth] {
                    { 'T', 'T', 'T', 'T', 'T' },
                    { ' ', ' ', 'T', ' ', ' ' },
                    { ' ', ' ', 'T', ' ', ' ' },
                    { ' ', ' ', 'T', ' ', ' ' },
                    { ' ', ' ', 'T', ' ', ' ' },
                    { ' ', ' ', 'T', ' ', ' ' },
                    { ' ', ' ', 'T', ' ', ' ' },
                }
            },
            {
                'I',
                new char[LetterLength, LetterWidth] {
                    { ' ', 'I', 'I', 'I', ' ' },
                    { ' ', ' ', 'I', ' ', ' ' },
                    { ' ', ' ', 'I', ' ', ' ' },
                    { ' ', ' ', 'I', ' ', ' ' },
                    { ' ', ' ', 'I', ' ', ' ' },
                    { ' ', ' ', 'I', ' ', ' ' },
                    { ' ', 'I', 'I', 'I', ' ' },
                }
            },
            {
                'H',
                new char[LetterLength,LetterWidth] {
                    { 'H', ' ', ' ', ' ', 'H' },
                    { 'H', ' ', ' ', ' ', 'H' },
                    { 'H', ' ', ' ', ' ', 'H' },
                    { 'H', 'H', 'H', 'H', 'H' },
                    { 'H', ' ', ' ', ' ', 'H' },
                    { 'H', ' ', ' ', ' ', 'H' },
                    { 'H', ' ', ' ', ' ', 'H' },
                }
            }
        };
    public static char[,] Provide(char c)
    {
        return Letters[char.ToUpperInvariant(c)];
    }
}