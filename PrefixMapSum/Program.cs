//asked by google

//Implement a PrefixMapSum class with the following methods:
  //  insert(key: str, value: int): Set a given key's value in the map. If the key already exists, overwrite the value.
  //  sum(prefix: str): Return the sum of all values of keys that begin with a given prefix.

//For example, you should be able to run the following code:
//mapsum.insert("columnar", 3)
//assert mapsum.sum("col") == 3

//mapsum.insert("column", 2)
//assert mapsum.sum("col") == 5
var dicitionaryList = new List<KeyValuePair<string,int>>(){
new KeyValuePair<string, int>("ciao",5),
new KeyValuePair<string, int>("love",2),
new KeyValuePair<string, int>("misera",8),
new KeyValuePair<string, int>("pollo",4),
};

insert("ciao",11,dicitionaryList);
sum("c",dicitionaryList);

void insert(string key,int value,List<KeyValuePair<string,int>> dictionaryList){
    for(var c = 0; c< dictionaryList.Count;c++){
       if(dictionaryList[c].Key.Equals(key)){
          var newKeyValueItem = new KeyValuePair<string, int>(key,value);
          dictionaryList.Add(newKeyValueItem);

          dictionaryList.Remove(dictionaryList[c]);           
         }
    }
}

void sum(string prefix,List<KeyValuePair<string,int>> dictionaryList){
  var sum = 0;
  foreach(var item in dicitionaryList){
    if(item.Key.StartsWith(prefix))
      sum += item.Value;
  }

  Console.WriteLine($"La somma dei valori dei dizionari che iniziano con {prefix} è: {sum}");
}