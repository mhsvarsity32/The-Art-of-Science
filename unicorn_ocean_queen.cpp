#include <iostream>
#include <string>
#include <vector>

using namespace std;

//Enumerate the four key elements of art
enum Art_Elements {LINE, COLOR, SHAPE, TEXTURE };

//Function prototypes for loop through the four elements
void Line_Art();
void Color_Art();
void Shape_Art();
void Texture_Art();

//Main function
int main()
{
	vector <Art_Elements> elements;
	
	//Adding the elements to the vector 
	elements.push_back(LINE);
	elements.push_back(COLOR);
	elements.push_back(SHAPE);
	elements.push_back(TEXTURE);
	
	//Loop through the vector elements
	for (Art_Elements element : elements)
	{
		if (element == LINE)
		{
			Line_Art();
		}
		
		else if (element == COLOR)
		{
			Color_Art();
		}
		
		else if (element == SHAPE)
		{
			Shape_Art();
		}
		
		else if (element == TEXTURE)
		{
			Texture_Art();
		}
		
		else 
		{
			cout << "This element does not exist. Please enter a valid element." << endl;
			
		}
	}
	
	return 0;
}

// Line Art Function
void Line_Art()
{
	cout << " Drawing a Straight Line: " << endl;
	cout << "Using a ruler and a pencil, draw a straight line on the paper. " << endl;
	cout << "Ensure that the line is symmetrical and the pencil is held firmly to prevent any errors. " << endl; 
	cout << endl;

}

// Color Art Function 
void Color_Art()
{
	cout << "Mixing Colors: " << endl; 
	cout << "Combine two primary colors on a palette to create a new shade of color. " << endl;
	cout << "Use a brush to mix the colors on a sheet of paper. The ratio of the two colors can be adjusted to create various shades. " << endl;
	cout << endl;
}

// Shape Art Function 
void Shape_Art()
{
	cout << "Drawing Geometric Shapes: " << endl; 
	cout << "Draw various geometric shapes, such as triangles, circles, and rectangles, on a sheet of paper using a ruler and a pencil. " << endl;
	cout << "Ensure that the shapes are symmetrical and of equal size and try to create an interesting pattern using the shapes. " << endl;
	cout << endl;
}

// Texture Art Function 
void Texture_Art()
{
	cout << "Creating Textures: " << endl; 
	cout << "Using a variety of tools such as a paintbrush, sponge, and crayon, create interesting textures by adding layers of color or scratching the paper. " << endl;
	cout << "Experiment with different tools and techniques to create unique textures. " << endl;
	cout << endl;
}