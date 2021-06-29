# Stack
--> Stack is a special type of collection that stores elements in LIFO style (Last In First Out).

# Types of Stack
--> Generic Type
--> Non-Generic Type

#Stack Properties and Methods

Property:
--> Count--> Returns the total count of elements in the Stack.

Method:
--> Push(item)	Inserts an item at the top of the stack.
--> Peek()	Returns the top item from the stack.
--> Pop()	Removes and returns items from the top of the stack.
--> Contains(item)	Checks whether an item exists in the stack or not.
--> Clear()	Removes all items from the stack.

#Generic Type
--> You can create an object of the Stack<T> by specifying a type parameter for the type of elements it can store.
--> It comes under System.Collection.Generic namespace.
--> Stack<T> can contain elements of the specified type. It provides compile-time type checking and doesn't perform boxing-unboxing because it is generic.
--> Faster than generic type.
--> Elements can be added using the Push() method. Cannot use collection-initializer syntax.
--> Elements can be retrieved using the Pop() and the Peek() methods. It does not support an indexer

#Non Generic Type
--> You can create an object of the Stack by specifying object type.
--> It comes under System.Collection namespace.
--> Stack can contain elements of any types. It provides run-time type checking and perform boxing-unboxing because it is non-generic.
--> Slower than generic type.
--> Elements can be added using the Push() method. Cannot use collection-initializer syntax.
--> Elements can be retrieved using the Pop() and the Peek() methods. It does not support an indexer.

