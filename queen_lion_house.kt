// Chapter 1: Introduction

// 1. Define the basic concepts of Kotlin
fun main(args: Array<String>)
{
    println("Kotlin is a statically typed, general-purpose programming language developed by JetBrains. It is a cross-platform language that can run on the Java Virtual Machine (JVM) and can also be compiled to JavaScript source code or use the LLVM compiler infrastructure. It is the official language for Android development and is also used for web development and server-side programming. Kotlin is designed to provide improved safety, readability, and concise code.")
}

// 2. Describe the basic building blocks of Kotlin
object BuildingBlocks {
    //Data Classes
    data class Person(val name: String, val age: Int)

    //Classes and Inheritance
    open class Animal {
        open fun makeNoise() {
            println("Making a noise...")
        }
    }

    class Dog : Animal() {
        override fun makeNoise() {
            println("Woof!")
        }
    }

    //Functions
    fun add(a: Int, b: Int): Int {
        return a + b
    }

    //Control Flow
    val age = 20
    if (age >= 18) {
        println("You are an adult!")
    } else {
        println("You are not yet an adult!")
    }
}

// 3. Explain the features of the Kotlin language
object Features {
    //Null Safety
    fun parseInt(str: String): Int? {
        return str.toIntOrNull()
    }

    //Type Inference
    fun log(str: String) {
        println(str)
    }

    //Extension Functions
    fun String.hasSpaces(): Boolean {
        return find { it == ' ' } != null
    }

    //Lambdas
    val numbers = listOf(1, 2, 3, 4, 5)
    numbers.forEach{ println(it) }

    //Smart Casts
    fun typeCheck(obj: Any) {
        if (obj is String) {
            println("String of length ${obj.length}")
        }
    }
}

// 4. Describe the Kotlin Standard Library
object StandardLibrary {
    //Collections
    val numbers = mutableListOf(1, 2, 3)
    numbers.add(4)
    println(numbers)

    //Sequences
    val squares = numbers.asSequence().map { it * it }
    println(squares.toList())

    //Ranges
    for (i in 1..10) {
        print("$i ")
    }
    println()

    //Streams
    val evenNumbers = (1..10).asSequence().filter { it % 2 == 0 }
    println(evenNumbers.toList())
}