import java.util.*;

public class TheArtOfScience {
	
	public static void main(String[] args) {
		
		// Declare variables
		int number;
		String word;
		double number2;

		// Create a Scanner object
		Scanner input = new Scanner(System.in);

		// Prompt the user to enter a number
		System.out.print("Enter a number: ");
		number = input.nextInt();

		// Prompt the user to enter a word
		System.out.print("Enter a word: ");
		word = input.next();

		// Prompt the user to enter a number
		System.out.print("Enter a number: ");
		number2 = input.nextDouble();

		// Close the Scanner
		input.close();

		// Print the results
		System.out.println("You entered: " + number + " " + word + " " + number2);

		// Calculate the result of the equation
		double result = (number + number2) * number;

		// Print the result
		System.out.println("The result of the equation is: " + result);

		// Create a while loop
		int i = 0;
		while (i < 5) {
			// Print the current value of the loop counter
			System.out.println("The current value of i is: " + i);
			i++;
		}

		// Create an array
		String[] names = {"John", "Bob", "James", "Mary"};
		
		// Print the contents of the array
		for (String name : names) {
			System.out.println(name);
		}
		
		// Create an ArrayList
		ArrayList<String> strings = new ArrayList<String>();
		
		// Add items to the ArrayList
		strings.add("One");
		strings.add("Two");
		strings.add("Three");
		
		// Print the contents of the ArrayList
		for (String string : strings) {
			System.out.println(string);
		}
		
		// Define a function
		public static int addNumbers(int x, int y) {
			return x + y;
		}
		
		// Call the function
		int result2 = addNumbers(2, 5);
		System.out.println("The result of the function is: " + result2);
		
		// Instantiate a class
		MyClass myClass = new MyClass();
		
		// Call the class function
		myClass.printMessage();
		
		// Define an enumeration
		public enum Numbers {
			ONE, TWO, THREE;
		}
		
		// Print out the enum values
		System.out.println("The possible values for Numbers are: "
				+ Arrays.toString(Numbers.values()));
		
		// Instantiate a thread
		Thread thread = new Thread(new MyRunnable());
		
		// Start the thread
		thread.start();
		
		// Wait for the thread to finish
		try {
			thread.join();
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		
		// Create a hash map
		HashMap<String, Integer> dictionary = new HashMap<String, Integer>();
		
		// Add items to the hash map
		dictionary.put("One", 1);
		dictionary.put("Two", 2);
		dictionary.put("Three", 3);
		
		// Print the contents of the hash map
		for (String key : dictionary.keySet()) {
			System.out.println(key + ": " + dictionary.get(key));
		}
		
		// Read from a file
		BufferedReader reader;
		try {
			reader = new BufferedReader(new FileReader("test.txt"));
			String line = reader.readLine();
			while (line != null) {
				System.out.println(line);
				line = reader.readLine();
			}
			reader.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		// Write to a file
		try {
			PrintWriter writer = new PrintWriter(new FileWriter("test2.txt"));
			writer.println("This is a test.");
			writer.close();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
		// Create a generic class
		public class MyGenericClass<T> {
			T value;
			
			public void setValue(T value) {
				this.value = value;
			}
			
			public T getValue() {
				return value;
			}
		}
		
		// Instantiate the generic class
		MyGenericClass<Integer> genericClass = new MyGenericClass<>();
		
		// Set the value of the generic class
		genericClass.setValue(5);
		
		// Get the value of the generic class
		int value = genericClass.getValue();
		System.out.println("The value of the generic class is: " + value);

		// Create a try-catch block
		try {
			int x = 5 / 0;
			System.out.println(x);
		} catch (ArithmeticException e) {
			System.out.println("Arithmetic exception: " + e.getMessage());
		}

		// Iterate through a list
		List<String> list = new ArrayList<String>();
		list.add("One");
		list.add("Two");
		list.add("Three");
		
		for (String s : list) {
			System.out.println(s);
		}
		
		// Create an anonymous inner class
		Runnable r = new Runnable(){
			public void run(){
				System.out.println("This is from the anonymous inner class");
			}
		};
		
		// Start the anonymous inner class
		Thread t = new Thread(r);
		t.start();
	}
}

// Define a class
class MyClass {
	public void printMessage() {
		System.out.println("This is a message from MyClass");
	}
}

// Define a runnable class
class MyRunnable implements Runnable {
	public void run() {
		System.out.println("This is from a runnable thread");
	}
}