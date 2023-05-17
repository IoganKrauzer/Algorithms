string text = "Есть такая легенда - о птице, что поёт лишь один раз за всю жизнь, но зато прекраснее всех на свете..."
+ "Однажды она покидает свое гнездо и летит искать куст терновника и не успокоится, пока не найдёт..."
+ "Среди колючих ветвей запевает она песню и бросается грудью на самый длинный, самый острый шип. И, возвышаясь над несказанной мукой,"
+ "так поет, умирая, что этой ликующей песне позавидовали бы и жаворонок, и соловей...";





string newText = CharChange(text, ' ', '|');

 Console.WriteLine(newText);

string CharChange(string tex, char oldCh, char newCh)
{
    int len = text.Length;
    string result = String.Empty;
    for (int i = 0; i < len; i++)
    {
        if (text[i] == oldCh) result = result + newCh;
        else result = result + text[i];
    }
    return result;
}

