# Array Practice - README

This practice involves working with arrays and lists in C#. Below are the steps and explanations for the task implementation.

## Task Description
The program performs the following steps:

1. **Define an Array:** Define an array that can hold 10 integers.
2. **Populate the Array:** Use a `for` loop to populate the array with values and display its elements using a `foreach` loop.
3. **Add a New Value:** Add a new value provided by the user as the 11th element.
4. **Sort and Display:** Sort the array in descending order and display the sorted elements.

---

## Step-by-Step Implementation

### Step 1: Define an Array
The program initializes a fixed-size array capable of storing 10 integers:
```csharp
int[] array = new int[10];
```

### Step 2: Populate and Display the Array
A `for` loop is used to fill the array with sequential values (0 to 9), and a `foreach` loop is used to display these values:
```csharp
for (int i = 0; i < array.Length; i++)
{
    array[i] = i;
}

foreach (var item in array)
{
    Console.WriteLine(item);
}
```

### Step 3: Add a New Value
The program prompts the user for a new value. Since arrays have a fixed size, the array is converted into a `List<int>` to allow dynamic resizing:
```csharp
if (int.TryParse(Console.ReadLine(), out int newNumber))
{
    List<int> numberList = new List<int>(array);
    numberList.Add(newNumber);
}
```

### Step 4: Sort and Display the List
The list is sorted in ascending order using `Sort()` and then reversed using `Reverse()` to display the elements in descending order:
```csharp
numberList.Sort();
numberList.Reverse();

foreach (var item in numberList)
{
    Console.WriteLine(item);
}
```

---

## Example Run

### Input:
```
Current array elements:
0
1
2
3
4
5
6
7
8
9
Add a new value to the array: 15
```

### Output:
```
Sorted array in descending order:
15
9
8
7
6
5
4
3
2
1
0
```

---

## Notes
- **Validation:** The program validates user input using `int.TryParse` to ensure a valid integer is entered.
- **Dynamic Sizing:** Conversion to a `List<int>` allows adding elements beyond the initial fixed size of the array.
- **Sorting:** The combination of `Sort` and `Reverse` ensures the list is displayed in descending order.

---

Feel free to run the code and explore its functionality!

