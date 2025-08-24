int[] numbers1 = new int[] { 1, 2, 3, 4 };
int[] numbers2 = new int[] { 3, 4, 5, 6 };
var symmetricNumbers = numbers1.Except(numbers2).Union(numbers2.Except(numbers1));
Console.WriteLine("Distinct String values: " + string.Join(", ", symmetricNumbers));
#region Code Explanation
//var symmetricNumbers = numbers1.Except(numbers2); returns 1 , 2
//var symmetricNumbers = numbers2.Except(numbers1); returns 5 , 6
//var symmetricNumbers = numbers1.Except(numbers2).Union(numbers2.Except(numbers1)); now returns {1, 2, 5, 6}
/*Union:
The Union operation combines two sequences and removes duplicates.
It includes all elements from both sequences.
Symmetric Difference:
The symmetric difference only includes elements that are in one set or the other but not in both.
It excludes elements that are common in both sets.*/
#endregion
