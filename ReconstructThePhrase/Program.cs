//Given a dictionary of words and a string made up of those words (no spaces), return the original sentence in a list. 
//If there is more than one possible reconstruction, return any of them. If there is no possible reconstruction, then return null.
//Given the set of words 'bed', 'bath', 'bedbath', 'and', 'beyond', and the string "bedbathandbeyond", return either ['bed', 'bath', 'and', 'beyond] 
//or ['bedbath', 'and', 'beyond'].
//Asked by Microsoft

string[] words = {"bed","bath","bedbath","and","beyond"};
string phrase = "ganggang";
ReconstructThePhrase(words,phrase); 

void ReconstructThePhrase(string[] words,string phrase){
    List<string> output = new List<string>();

    foreach(string word in words){
        if(phrase.Contains(word)){
            phrase = phrase.Replace(word,"");
            output.Add(word);
            continue;
        }
    }

    if(output.Count == 0)
    {
        Console.WriteLine("NULL");
        return;
    }

    foreach(string word in output){
        Console.WriteLine(word);
    }

}
