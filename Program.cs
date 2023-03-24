/**       
 *--------------------------------------------------------------------
 * 	   File name: Lab 7
 * 	Project name: Lab 7 work
 *--------------------------------------------------------------------
 * Author’s name and email:	Hayden Swearengin				
 *          Course-Section: CSCI 1250
 *           Creation Date:	3/21/2023 		
 * -------------------------------------------------------------------
 */

Console.WriteLine(sheepCount(2));

Console.WriteLine(wordCut("Some String"));

Console.WriteLine(isPerfectSquare(15));
Console.WriteLine(isPerfectSquare(16));

string[] words = {"This ", "is ", "a ", "sentence "};
Console.WriteLine(sentencifyWord(words));

int[] nums = {5,8,6,3,10};
Console.WriteLine(numberOrder(nums));

int[] nums2 = {1,2,3,4,5};
Console.WriteLine(numberOrder(nums2));




//Sheep Count
static string sheepCount(int sheepNum)
{
    int count = 1;
    string display = "";
    if(sheepNum > 0)
    {
        while(sheepNum >= count)
        {
            display += $"{count} sheep...";
            count++;
        }
        return display;
    }
    else
    {
        return display;
    }
}

//String to Array of Letters
static char[] wordCut(string wordSplit)
{
    char[] arrayLetter = {};
    char character = '0';
    for(int i = 0; i < wordSplit.Length; i++)
    {
        character = wordSplit[i];
        arrayLetter.Append(character);
    }
    return arrayLetter;

}

//Perfect Square test
static bool isPerfectSquare(double n)
{
    n = Math.Sqrt(n);
    n = n % 1;
    if(n == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


//Sentencify
static string sentencifyWord(string[]words)
{
    string sentence = "";
    for(int i = 0; i < words.Length; i++)
    {
        if(i == 0)
        {
            sentence += words[i];
        }
        else
        {
            sentence += "" + words[i];
        }
    }
    return sentence;
}

//X's and O's
static bool XAndO(string word)
{
    int x = 0;
    int o = 0;
    word = word.ToUpper();
    char letter = '\0';
    for(int i = 0; i < word.Length;i++)
    {
        letter = word[i];
        if(letter == 'O')
        {
            o += 1;
        }
        else if(letter == 'X')
        {
            x += 1;
        }
    }
    if(x == o)
    {
        return true;
    }
    else if (x + o == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Numbers in order

static bool numberOrder(int[] nums)
{
    for(int i = 0; i < nums.Length - 1;i++)
    {
        if(nums[i] > nums[i + 1])
        {
            return false;
        }
    }
    return true;
}