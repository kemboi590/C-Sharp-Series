# C# Series

Welcome to the C# Beginner Code repository! This repository contains simple and illustrative examples of fundamental concepts in C# programming. It is designed to help beginners understand the basics of C# through practical examples.

## Table of Contents

- [Hello World](#hello-world)
- [Namespaces](#namespaces)
- [Keywords in C#](#keywords-in-c)
- [Classes and Objects](#classes-and-objects)
- [Variables](#variables)
- [C-Sharp Type System](#C-Sharp-Type-System)

## Hello World

This demonstrates the basic syntax for printing "Hello World" to the console. It introduces the `Console.WriteLine()` method used to output text.

## Namespaces

This shows how to use namespaces to organize code. It includes classes grouped into different namespaces to avoid naming conflicts and illustrate their usage.

## Keywords in C#

This introduces various C# keywords and their usage, such as `class`, `public`, `private`, `static`, `void`, `int`, `return`, `new`, `if`, `else`, and more.

## Classes and Objects

This demonstrates the concepts of classes and objects in C#. It includes defining a class with properties and methods and creating objects of that class.

## Variables

This illustrates different types of variables in C#, such as `int`, `string`, `double`, `bool`, and `char`. It covers how to declare, initialize, and use variables in calculations.

## C-Sharp Type System

C# has two categories of type.

### 1. Value Types
- Only contain its data
- Examples include: 
    - int
    - float
    - doule
    - decimal
    - bool
    - char


### 2. Referrence Types
- Stores reference to there data objects.
- Examples include:
    - class
    - intefaces
    - arrays
    - strings
    - tuples
    - records
    - dynamic


### 3. Generics and Interfaces


**Explanation**:

- **IPaymentProcessor Interface**:  
  This defines two methods, `ProcessPayment` and `GetPaymentStatus`, that any class implementing this interface must provide. It abstracts the functionality of different payment processors.

- **CreditCardPayment and PayPalPayment Classes**:  
  These classes implement the `IPaymentProcessor` interface, providing their own versions of how a payment is processed and how the payment status is retrieved.



| **Feature**             | **Interface**                                                            | **Generics**                                                          |
|-------------------------|--------------------------------------------------------------------------|-----------------------------------------------------------------------|
| **Purpose**              | Define a contract that a class must follow.                              | Define reusable types, methods, or classes with placeholders for types.|
| **Type Constraint**      | No specific type constraint; any class/struct can implement an interface.| Can be constrained to specific types (e.g., `where T : class`).        |
| **Implementation**       | Interfaces do not contain any implementation; classes must implement them.| Generics provide actual code and logic, but work with any type.        |
| **Polymorphism**         | Used to achieve polymorphism (treat different classes uniformly).         | Enables writing flexible, type-safe code that can work with multiple types. |
| **Multiple Use**         | A class can implement multiple interfaces.                               | A class or method can only use one generic definition at a time.       |
| **Example Use Cases**    | Enforce common behavior across different types of classes.               | Create reusable data structures (e.g., lists, dictionaries) or methods.|
| **Code Reuse**           | Achieves code reuse by defining shared behavior for unrelated classes.   | Achieves code reuse by allowing logic to be applied to various data types. |
