//given a query string s and a set of all possible query strings, return all strings in the set that have s as a prefix.
//For example, given the query string de and the set of strings [dog, deer, deal], return [deer, deal].
//Asked by Twitter

string s = "de";
string[] arrayStrings = {"dog","deer","deal"};
CheckTheString(s,arrayStrings);

void CheckTheString(string s, string[] arrayStrings)
{
    List<string> output = new List<string>();
    foreach(var str in arrayStrings)
    {
        if (str.StartsWith(s))
            output.Add(str);
    }

    Console.WriteLine(string.Join(",",output));
}