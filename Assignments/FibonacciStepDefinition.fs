module FibonacciStepDefinition

open TickSpec
open NUnit.Framework
open FsUnit

let mutable resultSet:int list = [] 
let mutable fibonnaciNumber:int = -1

let rec fibonnaci x = 
  //todo: implement
  -1000

let fibonnaciSequence x = 
  //todo: implement
  []

let [<Given>] ``Given a fibonacci sequence calculator`` ()= 
    ()
      
let [<When>] ``When I ask for the first (.*) numbers in the sequence`` (n:int) =  
    resultSet <- fibonnaciSequence n
   
let [<When>] ``When I ask for the Fibonacci number of (.*)`` (n:int) =  
    fibonnaciNumber <- fibonnaci n

let [<Then>] ``the fib result set length should be (.*)`` (len:int) =  
    Assert.AreEqual(len,resultSet.Length)

let [<Then>] ``the fib set should contain (.*)`` (expected:int) =  
    let doesExist=resultSet|> List.exists (fun x-> x= expected)
    Assert.IsTrue(doesExist, "Could not find it")

