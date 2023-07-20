import java.util.Scanner;  //Imports Scanner class

public class TheArtOfScience {
	public static void main(String[] args) {
		
		Scanner scanner = new Scanner(System.in); // Create a Scanner object
		
		// Variables to store user input
		String title;
		int year;
		String author;
		int numberOfPages;
		
		// Prompt user to enter book title
		System.out.println("Please enter the title of the book:");
		title = scanner.nextLine();
		
		// Prompt user to enter year published
		System.out.println("Please enter the year the book was published:");
		year = scanner.nextInt();
		
		// Prompt user to enter author
		System.out.println("Please enter the author of the book:");
		author = scanner.nextLine();
		
		// Prompt user to enter number of pages
		System.out.println("Please enter the number of pages in the book:");
		numberOfPages = scanner.nextInt();
		
		// Create a Book object 
		Book artOfScience = new Book(title, year, author, numberOfPages); 
		
		// Print book information 
		System.out.println("Book information:");
		System.out.println(artOfScience);
		
		// Close the Scanner object
		scanner.close();
		
	}
	
	// Create private inner Book class
	private static class Book {
		
		// Book Properties
		private String title;
		private int year;
		private String author;
		private int numberOfPages;
		
		// Constructor
		public Book(String title, int year, String author, int numberOfPages){
			this.title = title;
			this.year = year;
			this.author = author;
			this.numberOfPages = numberOfPages;
		}
		
		// Getter methods
		public String getTitle() {
			return this.title;
		}
		
		public int getYear() {
			return this.year;
		}
		
		public String getAuthor() {
			return this.author;
		}
		
		public int getNumberOfPages() {
			return this.numberOfPages;
		}
		
		// toString method
		@Override
		public String toString() {
			return "Title: " + this.title + "; Year: " + this.year 
					+ "; Author: " + this.author + "; Number of Pages: " + this.numberOfPages + ".";
			
		}
		
	}
}