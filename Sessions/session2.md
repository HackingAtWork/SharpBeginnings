Topics Covered
==============
+ What is a list
+ What can a list contain
+ What are the list operation
  + List.head
  + List.map
  + List.filter
+ What is a pipe
+ What is a list comprehension
+ What is a list range
+ What is a yield

Exercises
=========
1]
  let numberlist = [1..40]
  let squares = numberlist |> List.map (fun x -> x*x)

  Rewrite the 'squares' function above to not use the pipe operator

2]
  let multiplied = List.map (fun x -> x * 3) [1...50]

  Rewrite the 'multiplied' function above to use the pipe operator

3]

+ Declare a list of strings
+ Declare a list of integers
+ Declare a list of longs

4]
 Write a list comprehension to return all the odd numbers

5]

Enable 'SimpleCollectionFeature' in your homework project and run the assignment tests

