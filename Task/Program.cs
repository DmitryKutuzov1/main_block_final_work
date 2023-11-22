string[] array = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", 
                    "computer science", "Russia", "Denmark", "Kazan" };
int count = 0;
for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3) count++;
}

string[] result = new string[count];
for (int i = 0; i < array.Length; i++) {
    if (array[i].Length <= 3) {
        result[count - 1] = array[i];
        count--;
    }
}

Console.Write($"{String.Join(", ", result)}");
