//https://en.wikibooks.org/wiki/The_Art_of_Computer_Programming

//This code is an example of how to implement a sorting algorithm using Javascript.

//First, set up a function called 'sort' that takes an array of numbers as an argument and returns the array with the numbers sorted.

//This function uses the 'selection sort' algorithm to sort the numbers in the array.

function sort(arr) {
  var minIdx, temp,
      len = arr.length;
  for(var i = 0; i < len; i++) {
    minIdx = i;
    for(var j = i+1; j<len; j++) {
       if(arr[j]<arr[minIdx]){
          minIdx = j;
       }
    }
    temp = arr[i];
    arr[i] = arr[minIdx];
    arr[minIdx] = temp;
}
  return arr;
}

//Next, set up a function that takes a number 'n' as an argument and returns an array containing the first 'n' perfect squares.

//This function uses the 'divide and conquer' algorithm to generate the perfect squares.

function perfectSquares(n) {
  if (n === 0) {
    return [];
  }
  if (n === 1) {
    return [1];
  }
  if (n > 1) {
    var maxSquare = Math.floor(Math.sqrt(n));
    var squares = perfectSquares(maxSquare);
    return [maxSquare * maxSquare].concat(squares.map(function (sq) {
      return sq + maxSquare * maxSquare;
    }));
  }
}

//Next, write a function called 'genFibonacci' that takes a number 'n' as an argument and returns an array containing the first 'n' Fibonacci numbers.

//This function uses the 'recursion' algorithm to generate the Fibonacci numbers.

function genFibonacci(n) {
  if (n === 0) {
    return [0];
  }
  if (n === 1) {
    return [0, 1];
  }
  else {
    var fib = genFibonacci(n-1);
    fib.push(fib[fib.length-1] + fib[fib.length-2]);
    return fib;
  }
}

//Finally, set up a function called 'binarySearch' that takes an array of numbers, a target number, and the min and max indices to search as arguments and returns the index of the target number if it's in the array, or -1 if it's not.

//This function uses the 'binary search' algorithm to search for the target number.

function binarySearch(arr, num, min, max) {
  if (min > max) {
    return -1;
  }
  var mid = Math.floor((min + max) / 2);
  if (arr[mid] === num) {
    return mid;
  }
  else if (arr[mid] < num) {
    return binarySearch(arr, num, mid + 1, max);
  }
  else {
    return binarySearch(arr, num, min, mid - 1);
  }
}