module FibonacciStepDefinition

open TickSpec
open NUnit.Framework
open FsUnit

let mutable resultSet:int list = [] 
let mutable fibonnaciNumber:int = -1

let rec fibonnaci x = 
    //todo: implement
        if x = 1 then 1
        elif x = 2 then 1
        else fibonnaci (x-1) + fibonnaci (x-2) 

let fibonnaciSequence x = 
  //todo: implement
  []

let [<Given>] ``a fibonacci sequence calculator`` ()= 
    ()
      
let [<When>] ``I ask for the first (.*) numbers in the sequence`` (n:int) =  
    resultSet <- fibonnaciSequence n
   
let [<When>] ``I ask for the Fibonacci number of (.*)`` (n:int) =  
    fibonnaciNumber <- fibonnaci n

let [<Then>] ``the fib result should be (.*)`` (expected:int) =  
    Assert.AreEqual(expected, fibonnaciNumber)

let [<Then>] ``the fib set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> List.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")

