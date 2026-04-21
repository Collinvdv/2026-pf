namespace theory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}





// Prev exam 2
// Read in the file sentences.txt (check the quiz-instructions) and determine whether or not a given sentence (number) is an isogram. An isogram uses every letter from the alphabet only 1 time, not more. If it is an isogram, your output should be "It is an isogram". If it is not an isogram, your output should be "NOT an isogram" and underneath it you output the letter(s) that appear more than 1 time in the given sentence in alphabetical order.

 

// INPUT
// string --> question name
// int --> line number


// OUTPUT
// string --> "It is an isogram" or "NOT an isogram"
// depending on isogram or not:
// string --> letters that are used more than once in alphabetical order

 

// EXAMPLES
// input
// A1
// 7

// output
// NOT an isogram
// aeiu

// explanation
// Sentence 7 is: Go, lazy fat vixen; be shrewd, jump quick.
// The letters that are shown are used more than once.

 

// input
// A1
// 20

// output
// It is an isogram

// explanation
// Sentence 20 is: Put back my English word!
// Every letter in this sentence is only used once.

 

// input
// A1
// 32

// output
// NOT an isogram
// afgilorstw

// explanation
// Sentence 32 is: Six big devils from Japan quickly forgot how to waltz.
// The letters that are shown are used more than once.